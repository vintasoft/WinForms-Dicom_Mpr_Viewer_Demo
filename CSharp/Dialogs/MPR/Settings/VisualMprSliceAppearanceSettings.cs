using System.Drawing;
using System.Drawing.Drawing2D;

using Vintasoft.Imaging.Dicom.Mpr;
using Vintasoft.Imaging.Dicom.Mpr.UI;

namespace DicomMprViewerDemo
{
    /// <summary>
    /// Stores and manages the appearance settings for <see cref="VisualMprSlice"/>.
    /// </summary>
    public class VisualMprSliceAppearanceSettings
    {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualMprSliceAppearanceSettings"/> class.
        /// </summary>
        public VisualMprSliceAppearanceSettings()
        {
        }

        #endregion



        #region Properties

        Color _sliceColor = Color.Gray;
        /// <summary>
        /// Gets or sets a slice color.
        /// </summary>
        public Color SliceColor
        {
            get
            {
                return _sliceColor;
            }
            set
            {
                _sliceColor = value;
            }
        }

        float _sliceLineWidth = 2;
        /// <summary>
        /// Gets or sets a slice line width.
        /// </summary>
        public float SliceLineWidth
        {
            get
            {
                return _sliceLineWidth;
            }
            set
            {
                _sliceLineWidth = value;
            }
        }

        float _markerPointDiameter = 4;
        /// <summary>
        /// Gets or sets a marker point diameter.
        /// </summary>
        public float MarkerPointDiameter
        {
            get
            {
                return _markerPointDiameter;
            }
            set
            {
                _markerPointDiameter = value;
            }
        }

        float _thickness = 0f;
        /// <summary>
        /// Gets or sets a slice thickness.
        /// </summary>
        public float Thickness
        {
            get
            {
                return _thickness;
            }
            set
            {
                _thickness = value;
            }
        }

        MprSliceRenderingMode _renderingMode = MprSliceRenderingMode.MPR;
        /// <summary>
        /// Gets or sets the MPR image slice rendering mode.
        /// </summary>
        public MprSliceRenderingMode RenderingMode
        {
            get
            {
                return _renderingMode;
            }
            set
            {
                _renderingMode = value;
            }
        }

        double _curveTension = 1;
        /// <summary>
        /// Gets or sets the curve tension for curvilinear slice.
        /// </summary>
        public double CurveTension
        {
            get
            {
                return _curveTension;
            }
            set
            {
                _curveTension = value;
            }
        }

        #endregion



        #region Methods

        /// <summary>
        /// Copies the appearance to the specified manager.
        /// </summary>
        /// <param name="manager">The slice appearance manager.</param>
        public void CopyTo(VisualMprSliceAppearanceSettings manager)
        {
            manager.SliceColor = SliceColor;
            manager.SliceLineWidth = SliceLineWidth;
            manager.MarkerPointDiameter = MarkerPointDiameter;
            manager.Thickness = Thickness;
            manager.RenderingMode = RenderingMode;
            manager.CurveTension = CurveTension;
        }

        /// <summary>
        /// Sets the appearance to the specified slice.
        /// </summary>
        /// <param name="sliceVisualizer">The MPR slice visualizer.</param>
        public void SetSettings(MprSliceVisualizer sliceVisualizer)
        {
            Pen slicePen = new Pen(SliceColor, SliceLineWidth);
            Pen previousPen = sliceVisualizer.SlicePen;
            sliceVisualizer.SlicePen = slicePen;
            previousPen.Dispose();

            sliceVisualizer.MarkerPointDiameter = MarkerPointDiameter;
            sliceVisualizer.Slice.Thickness = Thickness;
            sliceVisualizer.Slice.RenderingMode = RenderingMode;
            
            MprCurvilinearSlice slice = sliceVisualizer.Slice as MprCurvilinearSlice;
            if (slice != null)
            {
                SolidBrush sliceBrush = new SolidBrush(Color.FromArgb(SliceColor.A / 3, SliceColor));
                Brush previousBrush = sliceVisualizer.SliceThicknessBrush;
                sliceVisualizer.SliceThicknessBrush = sliceBrush;
                if (previousBrush != null)
                    previousBrush.Dispose();

                slice.CurveTension = CurveTension;
            }
            else
            {
                Pen thicknessPen = new Pen(SliceColor, SliceLineWidth * 0.75f);
                thicknessPen.DashStyle = DashStyle.Custom;
                thicknessPen.DashPattern = new float[] { 3, 3 };

                previousPen = sliceVisualizer.SliceThicknessPen;
                sliceVisualizer.SliceThicknessPen = thicknessPen;
                if (previousPen != null)
                    previousPen.Dispose();
            }
        }

        #endregion

    }
}
