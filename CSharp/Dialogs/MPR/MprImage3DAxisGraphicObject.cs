using System.Drawing;

using Vintasoft.Imaging.Dicom.Mpr.UI.VisualTools;
using Vintasoft.Imaging.UI;
using Vintasoft.Imaging.UI.VisualTools.GraphicObjects;

namespace Vintasoft.Imaging.Dicom.Mpr.UI
{
    /// <summary>
    /// Displays 3D axis of MPR image.
    /// </summary>
    public class MprImage3DAxisGraphicObject : GraphicObject
    {

        #region Fields

        /// <summary>
        /// The MPR visualization controller.
        /// </summary>
        MprVisualizationController _visualizationController;

        #endregion


        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MprImage3DAxisGraphicObject"/> class.
        /// </summary>
        /// <param name="visualizationController">The MPR visualization controller.</param>
        public MprImage3DAxisGraphicObject(MprVisualizationController visualizationController)
            : base()
        {
            _visualizationController = visualizationController;
        }

        #endregion


        #region Methods

        /// <summary>
        /// Draws the object on specified <see cref="T:System.Drawing.Graphics" /> in the object space.
        /// </summary>
        /// <param name="viewer">An image viewer.</param>
        /// <param name="g">A graphics where the object must be drawn.</param>
        /// <remarks>
        /// This method draws object after the <see cref="P:Vintasoft.Imaging.UI.VisualTools.GraphicObjects.GraphicObject.PointTransform" /> is applied to
        /// the Graphics, specified by <i>g</i> parameter.<br /><br />
        /// By default this method does not do anything.
        /// </remarks>
        public override void DrawInObjectSpace(ImageViewer viewer, Graphics g)
        {
            DicomMprTool dicomMprTool = _visualizationController.GetDicomMprToolAssociatedWithImageViewer(viewer);
            if (dicomMprTool == null)
                return;

            MprImage mprImage = dicomMprTool.MprImageTool.MprImage;

            // get 3D axis projections on slice (2D space, mm)
            MprSlice focusedSlice = dicomMprTool.MprImageTool.FocusedSlice;
            PointF p0 = VintasoftDrawingConverter.Convert(focusedSlice.GetPointProjectionOnSlice(new VintasoftPoint3D(0, 0, 0)));
            PointF pX00 = VintasoftDrawingConverter.Convert(focusedSlice.GetPointProjectionOnSlice(new VintasoftPoint3D(mprImage.XLength, 0, 0)));
            PointF pXY0 = VintasoftDrawingConverter.Convert(focusedSlice.GetPointProjectionOnSlice(new VintasoftPoint3D(mprImage.XLength, mprImage.YLength, 0)));
            PointF p0Y0 = VintasoftDrawingConverter.Convert(focusedSlice.GetPointProjectionOnSlice(new VintasoftPoint3D(0, mprImage.YLength, 0)));
            PointF p0YZ = VintasoftDrawingConverter.Convert(focusedSlice.GetPointProjectionOnSlice(new VintasoftPoint3D(0, mprImage.YLength, mprImage.ZLength)));
            PointF p00Z = VintasoftDrawingConverter.Convert(focusedSlice.GetPointProjectionOnSlice(new VintasoftPoint3D(0, 0, mprImage.ZLength)));
            PointF pX0Z = VintasoftDrawingConverter.Convert(focusedSlice.GetPointProjectionOnSlice(new VintasoftPoint3D(mprImage.XLength, 0, mprImage.ZLength)));

            // transform points from slice 2D space to image viewer space
            PointFTransform transformFormSliceToViewer = dicomMprTool.MprImageTool.FocusedSliceView.GetPointTransform(viewer, viewer.Image);
            p0 = transformFormSliceToViewer.TransformPoint(p0);
            pX00 = transformFormSliceToViewer.TransformPoint(pX00);
            pXY0 = transformFormSliceToViewer.TransformPoint(pXY0);
            p0Y0 = transformFormSliceToViewer.TransformPoint(p0Y0);
            p0YZ = transformFormSliceToViewer.TransformPoint(p0YZ);
            p00Z = transformFormSliceToViewer.TransformPoint(p00Z);
            pX0Z = transformFormSliceToViewer.TransformPoint(pX0Z);

            // draw axis
            g.DrawLine(Pens.Gray, pX00, pX0Z);
            g.DrawLine(Pens.Gray, pX00, pXY0);
            g.DrawLine(Pens.Gray, p0Y0, pXY0);
            g.DrawLine(Pens.Gray, p0Y0, p0YZ);
            g.DrawLine(Pens.Gray, p00Z, p0YZ);
            g.DrawLine(Pens.Gray, p00Z, pX0Z);

            g.DrawLine(Pens.Lime, p0, pX00);
            g.DrawLine(Pens.Red, p0, p0Y0);
            g.DrawLine(Pens.Blue, p0, p00Z);

        }

        /// <summary>
        /// Creates a new <see cref="T:MprImage3DAxisGraphicObject" /> that is a copy of the current instance.
        /// </summary>
        /// <returns>
        /// A new <see cref="T:MprImage3DAxisGraphicObject" /> that is a copy of this instance.
        /// </returns>
        public override object Clone()
        {
            return new MprImage3DAxisGraphicObject(_visualizationController);
        }

        /// <summary>
        /// Returns a bounding box of object, in object space.
        /// </summary>
        /// <returns>
        /// Bounding box of object, in object space.
        /// </returns>
        public override RectangleF GetBoundingBox()
        {
            return RectangleF.Empty;
        }

        /// <summary>
        /// Returns a drawing rectangle of object, in object space.
        /// </summary>
        /// <param name="viewer">An image viewer.</param>
        /// <returns>
        /// Drawing rectangle of object, in object space.
        /// </returns>
        public override RectangleF GetDrawingBox(ImageViewer viewer)
        {
            return new RectangleF(0, 0, viewer.Width, viewer.Height);
        }

        /// <summary>
        /// Determines that point belongs the object.
        /// </summary>
        /// <param name="x">X coordinate of point in object space.</param>
        /// <param name="y">Y coordinate of point in object space.</param>
        /// <returns>
        /// <b>true</b> if point belongs the object;
        /// otherwise, <b>false</b>.
        /// </returns>
        public override bool IsPointOnObject(float x, float y)
        {
            return false;
        }

        #endregion

    }
}
