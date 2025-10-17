using System;
using System.Drawing;

using Vintasoft.Imaging.Dicom.Mpr;
using Vintasoft.Imaging.Dicom.Mpr.UI;
using Vintasoft.Imaging.Dicom.Mpr.UI.VisualTools;
using Vintasoft.Imaging;

namespace DicomMprViewerDemo
{
    /// <summary>
    /// Stores and manages appearance settings for <see cref="MprImageTool"/>.
    /// </summary>
    public class MprImageToolAppearanceSettings
    {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MprImageToolAppearanceSettings"/> class.
        /// </summary>
        public MprImageToolAppearanceSettings()
        {
            _sagittalSliceAppearance.SliceColor = Color.LightBlue;
            _coronalSliceAppearance.SliceColor = Color.Coral;
            _axialSliceAppearance.SliceColor = Color.Yellow;
            _curvilinearSliceAppearance.SliceColor = Color.Blue;
            _perpendicularMultiSliceAppearance.SliceColor = Color.Magenta;
            _perpendicularMultiSliceAppearance.FocusedSliceColor = Color.Aqua;
        }

        #endregion



        #region Properties

        #region VisualizationPerformanceSettings

        int _fillDataThreadCount = Environment.ProcessorCount;
        /// <summary>
        /// Gets or sets the maximum count of threads, which can be used for filling MPR data.
        /// </summary>
        public int FillDataThreadCount
        {
            get
            {
                return _fillDataThreadCount;
            }
            set
            {
                _fillDataThreadCount = value;
            }
        }

        int _renderingThreadCount = Environment.ProcessorCount;
        /// <summary>
        /// Gets or sets the maximum count of threads, which can be used for rendering slices.
        /// </summary>
        public int RenderingThreadCount
        {
            get
            {
                return _renderingThreadCount;
            }
            set
            {
                _renderingThreadCount = value;
            }
        }

        int _maxFps = 0;
        /// <summary>
        /// Gets or sets the maximum FPS value, in frames per second (FPS).
        /// </summary>
        public int MaxFps
        {
            get
            {
                return _maxFps;
            }
            set
            {
                _maxFps = value;
            }
        }

        int _adaptiveRenderingQualityStepCount = 3;
        /// <summary>
        /// Gets or sets the adaptive rendering quality step count.
        /// </summary>
        public int AdaptiveRenderingQualityStepCount
        {
            get
            {
                return _adaptiveRenderingQualityStepCount;
            }
            set
            {
                _adaptiveRenderingQualityStepCount = value;
            }
        }

        int _complexityThreshold = 200;
        /// <summary>
        /// Gets or sets the complexity threshold value.
        /// </summary>
        public int ComplexityThreshold
        {
            get
            {
                return _complexityThreshold;
            }
            set
            {
                _complexityThreshold = value;
            }
        }

        #endregion


        #region SliceSettings

        VisualMprSliceAppearanceSettings _sagittalSliceAppearance = new VisualMprSliceAppearanceSettings();
        /// <summary>
        /// Gets or sets the sagittal slice appearance settings.
        /// </summary>
        public VisualMprSliceAppearanceSettings SagittalSliceAppearance
        {
            get
            {
                return _sagittalSliceAppearance;
            }
            set
            {
                _sagittalSliceAppearance = value;
            }
        }

        VisualMprSliceAppearanceSettings _coronalSliceAppearance = new VisualMprSliceAppearanceSettings();
        /// <summary>
        /// Gets or sets the coronal slice appearance settings.
        /// </summary>
        public VisualMprSliceAppearanceSettings CoronalSliceAppearance
        {
            get
            {
                return _coronalSliceAppearance;
            }
            set
            {
                _coronalSliceAppearance = value;
            }
        }

        VisualMprSliceAppearanceSettings _axialSliceAppearance = new VisualMprSliceAppearanceSettings();
        /// <summary>
        /// Gets or sets the axial slice appearance settings.
        /// </summary>
        public VisualMprSliceAppearanceSettings AxialSliceAppearance
        {
            get
            {
                return _axialSliceAppearance;
            }
            set
            {
                _axialSliceAppearance = value;
            }
        }

        VisualMprSliceAppearanceSettings _curvilinearSliceAppearance = new VisualMprSliceAppearanceSettings();
        /// <summary>
        /// Gets or sets the curvilinear slice appearance settings.
        /// </summary>
        public VisualMprSliceAppearanceSettings CurvilinearSliceAppearance
        {
            get
            {
                return _curvilinearSliceAppearance;
            }
            set
            {
                _curvilinearSliceAppearance = value;
            }
        }

        VisualMprSliceAppearanceSettings _perpendicularMultiSliceAppearance = new VisualMprSliceAppearanceSettings();
        /// <summary>
        /// Gets or sets the appearance settings of perpendicular multi slice.
        /// </summary>
        public VisualMprSliceAppearanceSettings PerpendicularMultiSliceAppearance
        {
            get
            {
                return _perpendicularMultiSliceAppearance;
            }
            set
            {
                _perpendicularMultiSliceAppearance = value;
            }
        }

        #endregion


        #region MprImageToolSettings

        Color _focusedImageViewerColorMark = Color.Green;
        /// <summary>
        /// Gets or sets the focused image viewer color mark.
        /// </summary>
        public Color FocusedImageViewerColorMark
        {
            get
            {
                return _focusedImageViewerColorMark;
            }
            set
            {
                _focusedImageViewerColorMark = value;
            }
        }

        double _focusedImageViewerMarkSize = 0.4;
        /// <summary>
        /// Gets or sets the focused image viewer mark size.
        /// </summary>
        public double FocusedImageViewerMarkSize
        {
            get
            {
                return _focusedImageViewerMarkSize;
            }
            set
            {
                _focusedImageViewerMarkSize = value;
            }
        }

        bool _isColorMarkVisible = true;
        /// <summary>
        /// Gets or sets a value which indicates whether the color mark is visible.
        /// </summary>
        public bool IsColorMarkVisible
        {
            get
            {
                return _isColorMarkVisible;
            }
            set
            {
                _isColorMarkVisible = value;
            }
        }

        Size _colorMarkSize = new Size(20, 20);
        /// <summary>
        /// Gets or sets the color mark size.
        /// </summary>
        public Size ColorMarkSize
        {
            get
            {
                return _colorMarkSize;
            }
            set
            {
                _colorMarkSize = value;
            }
        }

        AnchorType _colorMarkAnchor = AnchorType.Top | AnchorType.Right;
        /// <summary>
        /// Gets or sets the color mark anchor.
        /// </summary>
        public AnchorType ColorMarkAnchor
        {
            get
            {
                return _colorMarkAnchor;
            }
            set
            {
                _colorMarkAnchor = value;
            }
        }

        #endregion

        #endregion



        #region Methods

        /// <summary>
        /// Copies the appearance to the specified manager.
        /// </summary>
        /// <param name="manager">The manager.</param>
        public void CopyTo(MprImageToolAppearanceSettings manager)
        {
            manager.FillDataThreadCount = FillDataThreadCount;
            manager.RenderingThreadCount = RenderingThreadCount;
            manager.MaxFps = MaxFps;
            manager.AdaptiveRenderingQualityStepCount = AdaptiveRenderingQualityStepCount;
            manager.ComplexityThreshold = ComplexityThreshold;

            SagittalSliceAppearance.CopyTo(manager.SagittalSliceAppearance);
            CoronalSliceAppearance.CopyTo(manager.CoronalSliceAppearance);
            AxialSliceAppearance.CopyTo(manager.AxialSliceAppearance);
            CurvilinearSliceAppearance.CopyTo(manager.CurvilinearSliceAppearance);
            PerpendicularMultiSliceAppearance.CopyTo(manager.PerpendicularMultiSliceAppearance);

            manager.FocusedImageViewerColorMark = FocusedImageViewerColorMark;
            manager.FocusedImageViewerMarkSize = FocusedImageViewerMarkSize;
            manager.IsColorMarkVisible = IsColorMarkVisible;
            manager.ColorMarkSize = ColorMarkSize;
            manager.ColorMarkAnchor = ColorMarkAnchor;
        }

        /// <summary>
        /// Sets the appearance to the planar slices.
        /// </summary>
        /// <param name="sagittalSliceVisualizer">The sagittal slice visualizer.</param>
        /// <param name="coronalSliceVisualizer">The coronal slice visualizer.</param>
        /// <param name="axialSliceVisualizer">The axial slice visualizer.</param>
        public void SetSliceSettings(
            MprSliceVisualizer sagittalSliceVisualizer,
            MprSliceVisualizer coronalSliceVisualizer,
            MprSliceVisualizer axialSliceVisualizer)
        {
            SagittalSliceAppearance.SetSettings(sagittalSliceVisualizer);
            CoronalSliceAppearance.SetSettings(coronalSliceVisualizer);
            AxialSliceAppearance.SetSettings(axialSliceVisualizer);
        }

        /// <summary>
        /// Sets the appearance to the planar slices.
        /// </summary>
        /// <param name="sliceType">The slice type.</param>
        /// <param name="sliceVisualizer">The slice visualizer.</param>
        /// <exception cref="NotSupportedException">
        /// Thrown if <i>sliceType</i> is not supported.
        /// </exception>
        public void SetSliceSettings(
            SliceType sliceType,
            MprSliceVisualizer sliceVisualizer)
        {
            switch (sliceType)
            {
                case SliceType.Sagittal:
                    SagittalSliceAppearance.SetSettings(sliceVisualizer);
                    break;

                case SliceType.Coronal:
                    CoronalSliceAppearance.SetSettings(sliceVisualizer);
                    break;

                case SliceType.Axial:
                    AxialSliceAppearance.SetSettings(sliceVisualizer);
                    break;

                case SliceType.Curvilinear:
                    CurvilinearSliceAppearance.SetSettings(sliceVisualizer);
                    break;

                case SliceType.Multi:
                    PerpendicularMultiSliceAppearance.SetSettings(sliceVisualizer);
                    break;

                default:
                    throw new NotSupportedException();
            }
        }

        /// <summary>
        /// Sets the appearance to the curvilinear slice.
        /// </summary>
        /// <param name="curvilinearSliceVisualizer">The curvilinear slice visualizer.</param>
        public void SetCurvilinearSliceSettings(
            MprSliceVisualizer curvilinearSliceVisualizer)
        {
            CurvilinearSliceAppearance.SetSettings(curvilinearSliceVisualizer);
        }

        /// <summary>
        /// Sets the appearance for the perpendicular multi slice.
        /// </summary>
        /// <param name="perpendicularMultiSliceVisualizer">The perpendicular multi slice visualizer.</param>
        public void SetPerpendicularMultiSliceSettings(
            MprSliceVisualizer perpendicularMultiSliceVisualizer)
        {
            PerpendicularMultiSliceAppearance.SetSettings(perpendicularMultiSliceVisualizer);
        }

        /// <summary>
        /// Sets the appearance to the MPR tool.
        /// </summary>
        /// <param name="mprTool">The MPR tool.</param>
        public void SetMprToolSettings(MprImageTool mprTool)
        {
            mprTool.FocusedImageViewerColorMark = FocusedImageViewerColorMark;
            mprTool.FocusedImageViewerMarkSize = FocusedImageViewerMarkSize;
            mprTool.IsFocusedSliceColorMarkVisible = IsColorMarkVisible;
            mprTool.FocusedSliceColorMarkSize = ColorMarkSize;
            mprTool.FocusedSliceColorMarkAnchor = ColorMarkAnchor;
        }

        /// <summary>
        /// Sets settings to the MPR image.
        /// </summary>
        /// <param name="mprImage">The MPR image.</param>
        public void SetMprImageSettings(MprImage mprImage)
        {
            mprImage.FillDataThreadCount = FillDataThreadCount;
            mprImage.RenderingThreadCount = RenderingThreadCount;
        }

        /// <summary>
        /// Sets settings to the MPR visualization controller.
        /// </summary>
        /// <param name="controller">The MPR visualization controller.</param>
        public void SetMprVisualizationControllerSettings(MprVisualizationController controller)
        {
            controller.MaxFps = MaxFps;
            controller.AdaptiveRenderingQualityStepCount = AdaptiveRenderingQualityStepCount;
            controller.AdaptiveRenderingQualityComplexityThreshold = ComplexityThreshold;
        }

        #endregion

    }
}
