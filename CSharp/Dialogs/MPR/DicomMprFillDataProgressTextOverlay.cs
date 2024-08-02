using System;
using System.Drawing;

using Vintasoft.Imaging;
using Vintasoft.Imaging.Dicom.Mpr;
using Vintasoft.Imaging.Dicom.Mpr.UI.VisualTools;
using Vintasoft.Imaging.UI;
using Vintasoft.Imaging.UI.VisualTools;

namespace DicomMprViewerDemo
{
    /// <summary>
    /// Represents a text object, which shows fill data progress of MPR image.
    /// </summary>
    public class DicomMprFillDataProgressTextOverlay : DicomMprToolTextOverlay
    {

        #region Constructor

        /// <summary>
        /// Initializes a new instance of <see cref="DicomMprFillDataProgressTextOverlay"/>.
        /// </summary>
        public DicomMprFillDataProgressTextOverlay()
            : base(AnchorType.Top | AnchorType.Left)
        {
            TextColor = Color.Lime;
        }

        #endregion



        #region Properties

        string _progressTemplate = "Loading data {0}%...";
        /// <summary>
        /// Gets or sets the progress string template. 
        /// </summary>
        public string ProgressTemplate
        {
            get
            {
                return _progressTemplate;
            }
            set
            {
                _progressTemplate = value;
            }
        }

        MprImage _mprImage = null;
        /// <summary>
        /// Gets or sets the MPR image.
        /// </summary>
        private MprImage MprImage
        {
            get
            {
                return _mprImage;
            }
            set
            {
                // unsubscribe from the MPR image fill data events
                if (_mprImage != null)
                {
                    _mprImage.FillDataProgress -= MprImage_FillDataProgress;
                    _mprImage.FillDataFinished -= MprImage_FillDataFinished;
                }

                _mprImage = value;

                // subscribe to the MPR image fill data events
                if (_mprImage != null)
                {
                    _mprImage.FillDataProgress += new EventHandler<ProgressEventArgs>(MprImage_FillDataProgress);
                    _mprImage.FillDataFinished += new EventHandler<EventArgs>(MprImage_FillDataFinished);
                }
            }
        }

        #endregion



        #region Methods

        #region PUBLIC

        /// <summary>
        /// Acivates this instance on the specified viewer.
        /// </summary>
        /// <param name="viewer">The viewer.</param>
        public override void Activate(Vintasoft.Imaging.UI.ImageViewer viewer)
        {
            base.Activate(viewer);
            if (Tool != null && Tool.MprImageTool != null)
                MprImage = Tool.MprImageTool.MprImage;
        }

        /// <summary>
        /// Deactivates this instance.
        /// </summary>
        public override void Deactivate()
        {
            MprImage = null;
            base.Deactivate();
        }

        /// <summary>
        /// Creates a new <see cref="DicomMprFillDataProgressTextOverlay"/> that is a copy of the current instance. 
        /// </summary>
        /// <returns>
        /// A new <see cref="DicomMprFillDataProgressTextOverlay"/> that is a copy of the current instance.
        /// </returns>
        public override object Clone()
        {
            DicomMprFillDataProgressTextOverlay textOverlay = new DicomMprFillDataProgressTextOverlay();
            CopyTo(textOverlay);
            return textOverlay;
        }

        /// <summary>
        /// Copies the state of the current object to the target object.
        /// </summary>
        /// <param name="target">Object to copy the state of the current object to.</param>
        /// <exception cref="ArgumentNullException">Thrown if <i>source</i> is <b>null</b>.</exception>
        public override void CopyTo(TextOverlay target)
        {
            if (target == null)
                throw new ArgumentNullException();

            DicomMprFillDataProgressTextOverlay typedTarget = (DicomMprFillDataProgressTextOverlay)target;
            typedTarget.ProgressTemplate = ProgressTemplate;

            base.CopyTo(target);
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return "MPR Fill Data Progress";
        }

        /// <summary>
        /// Updates the text of the text object.
        /// </summary>
        public override void UpdateText()
        {
            SetText(string.Empty);
        }

        #endregion


        #region PRIVATE

        /// <summary>
        /// Handles the FillDataProgress event of the MprImage.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="ProgressEventArgs"/> instance containing the event data.</param>
        private void MprImage_FillDataProgress(object sender, ProgressEventArgs e)
        {
            SetText(string.Format(ProgressTemplate, e.Progress));
        }

        /// <summary>
        /// Handles the FillDataFinished event of the MprImage.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MprImage_FillDataFinished(object sender, EventArgs e)
        {
            SetText(string.Empty);
        }

        #endregion

        #endregion

    }
}
