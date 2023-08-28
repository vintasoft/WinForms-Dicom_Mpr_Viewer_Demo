using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

using Vintasoft.Imaging;
using Vintasoft.Imaging.Codecs.ImageFiles.Dicom;
using Vintasoft.Imaging.Dicom.Mpr;
using Vintasoft.Imaging.Dicom.Mpr.UI;

using DemosCommonCode;


namespace DicomMprViewerDemo
{
    /// <summary>
    /// Manages source data of the MPR image.
    /// </summary>
    public sealed class MprSourceDataController
    {

        #region Fields

        /// <summary>
        /// The source DICOM files.
        /// </summary>
        IEnumerable<DicomFile> _dicomFiles = null;

        /// <summary>
        /// The MPR source data.
        /// </summary>
        MprDicomImagePlanarSlice[] _mprSourceData = null;

        /// <summary>
        /// Dictionary: DICOM frame => MPR source data.
        /// </summary>
        Dictionary<DicomFrame, MprDicomImagePlanarSlice[]> _frameToMprSourceData =
            new Dictionary<DicomFrame, MprDicomImagePlanarSlice[]>();

        /// <summary>
        /// The data, which are loaded, in MPR image.
        /// </summary>
        MprDicomImagePlanarSlice[] _currentMprSourceData = null;

        /// <summary>
        /// Indicates whether data filling process of the MPR image must be canceled.
        /// </summary>
        bool _areMprImageFillDataCanceled = false;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MprSourceDataController"/> class.
        /// </summary>
        public MprSourceDataController()
        {
            // create the MPR image 
            _mprImage = new MprImage();
            _mprImage.SliceIntervalMaxDelta = 0.05;
            _mprImage.FillDataProgress += new EventHandler<ProgressEventArgs>(MprImage_FillDataProgress);
            _mprImage.FillDataError += new EventHandler<ExceptionEventArgs>(MprImage_FillDataError);
        }

        #endregion



        #region Properties

        MprImage _mprImage;
        /// <summary>
        /// Gets the MPR image.
        /// </summary>
        public MprImage MprImage
        {
            get
            {
                return _mprImage;
            }
        }

        #endregion



        #region Methods

        #region PUBLIC

        /// <summary>
        /// Specifies the source data of MPR image.
        /// </summary>
        /// <param name="dicomFiles">The dicom files.</param>
        public void SetSourceMprData(IEnumerable<DicomFile> dicomFiles)
        {
            ClearSourceMprData();

            _dicomFiles = dicomFiles;
        }

        /// <summary>
        /// Clears the source data of MPR image.
        /// </summary>
        public void ClearSourceMprData()
        {
            // break fill MPR image
            CancelFillMprData();

            // if source data is specified
            if (_mprSourceData != null)
            {
                // dispose all slices
                foreach (MprDicomImagePlanarSlice slice in _mprSourceData)
                    slice.Dispose();

                _mprSourceData = null;
                _frameToMprSourceData.Clear();
            }

            // if MPR image is initialized
            if (_currentMprSourceData != null)
            {
                // clear MPR image
                _mprImage.Clear(true);
                _currentMprSourceData = null;
            }
        }

        /// <summary>
        /// Selects the MPR image source data, which are related to the specified DICOM frame.
        /// </summary>
        /// <param name="frame">The DICOM frame.</param>
        /// <param name="beginDataFilling">Indicates whether the MPR image must be filled.</param>
        /// <returns>
        /// <b>true</b> if the source data is selected; otherwise, <b>false</b>.
        /// </returns>
        public bool SetMprData(DicomFrame frame, bool beginDataFilling)
        {
            // if source data is not specified
            if (_dicomFiles == null)
                return false;

            try
            {
                // get source data of specified DICOM frame
                MprDicomImagePlanarSlice[] mprImageData = GetSlicesOfFrame(frame);

                // if MPR image must be reinitialized
                if (mprImageData != _currentMprSourceData)
                {
                    _mprImage.Clear(false);
                    _currentMprSourceData = null;
                }

                // if MPR image is not initialized
                if (!_mprImage.IsInitialized)
                {
                    // save current source data of MPR image
                    _currentMprSourceData = mprImageData;

                    // initialize MPR image 
                    _mprImage.Initialize(_currentMprSourceData);

                    // if slice is not regular interval correction
                    if (_mprImage.IsSlicesIntervalCorrected)
                    {
                        DemosTools.ShowWarningMessage("MPR Image Initialization",
                            "The slice interval is NOT regular - the distortion in presentation and measurements may be present.");
                    }
                }

                // if data of MPR image must be filled
                if (beginDataFilling && !_mprImage.IsDataFilled && !_mprImage.IsDataFilling)
                {
                    _areMprImageFillDataCanceled = false;
                    // fill MPR image data from slices asynchronly
                    _mprImage.FillDataAsync();
                }

                return true;
            }
            catch (Exception ex)
            {
                // show error message
                DemosTools.ShowErrorMessage(ex);
                return false;
            }
        }

        #endregion


        #region PRIVATE

        /// <summary>
        /// Returns the slices of specified DICOM frame.
        /// </summary>
        /// <param name="frame">The DICOM frame.</param>
        /// <returns>
        /// The slices of DICOM frame.
        /// </returns>
        private MprDicomImagePlanarSlice[] GetSlicesOfFrame(DicomFrame frame)
        {
            // load source data of MPR image
            LoadMprSourceData();

            // result array
            MprDicomImagePlanarSlice[] result = null;

            // if source data for DICOM frame is specified
            if (_frameToMprSourceData.TryGetValue(frame, out result))
                return result;

            return _mprSourceData;
        }

        /// <summary>
        /// Loads the source data of MPR image.
        /// </summary>
        private void LoadMprSourceData()
        {
            // if source data is not loaded
            if (_mprSourceData == null)
            {
                List<MprDicomImagePlanarSlice> sourceSlices = new List<MprDicomImagePlanarSlice>();
                // for each DICOM file
                foreach (DicomFile dicomFile in _dicomFiles)
                {
                    // create MPR slices from DICOM file and add the slices to the slice list
                    sourceSlices.AddRange(MprVisualizationController.CreateMprDicomImagePlanarSlice(dicomFile));
                }
                _mprSourceData = sourceSlices.ToArray();

                // save created slices
                MprDicomImagePlanarSlice[][] splitSourceDataArray =
                    MprDicomImagePlanarSlice.ExtractMprSourceData(_mprSourceData);

                // clear dictionary
                _frameToMprSourceData.Clear();

                // if slices is determined
                if (splitSourceDataArray.Length != 0)
                {
                    // fill dictionary
                    foreach (MprDicomImagePlanarSlice[] splitSourceData in splitSourceDataArray)
                    {
                        foreach (MprDicomImagePlanarSlice sourceData in splitSourceData)
                            _frameToMprSourceData.Add(sourceData.DicomFrame, splitSourceData);
                    }

                    // if not all frames were added to the dictionary
                    if (_frameToMprSourceData.Count != _mprSourceData.Length)
                    {
                        foreach (MprDicomImagePlanarSlice slice in _mprSourceData)
                        {
                            if (!_frameToMprSourceData.ContainsKey(slice.DicomFrame))
                                _frameToMprSourceData.Add(slice.DicomFrame, splitSourceDataArray[0]);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Cancels MPR image filling.
        /// </summary>
        private void CancelFillMprData()
        {
            // if MPR image data is filling
            if (_mprImage.IsDataFilling)
            {
                // break data filling
                _areMprImageFillDataCanceled = true;

                while (_mprImage.IsDataFilling)
                    Thread.Sleep(1);
            }
        }

        /// <summary> 
        /// Handles the FillDataProgress event of the MprImage.
        /// </summary>
        private void MprImage_FillDataProgress(object sender, ProgressEventArgs e)
        {
            if (_areMprImageFillDataCanceled && e.CanCancel)
                e.Cancel = true;
        }

        /// <summary>
        /// Shows MPR image filling error.
        /// </summary>
        private void MprImage_FillDataError(object sender, ExceptionEventArgs e)
        {
            DemosTools.ShowErrorMessage("MPR data filling error", e.Exception);
        }

        #endregion

        #endregion

    }
}
