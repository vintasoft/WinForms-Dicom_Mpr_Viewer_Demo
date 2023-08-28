using Vintasoft.Imaging;
using Vintasoft.Imaging.Annotation.Measurements;


namespace DicomMprViewerDemo
{
    /// <summary>
    /// Contains collection of helper-algorithms for  <see cref="ImageMeasureTool"/>.
    /// </summary>
    public static class DicomMeasureToolUtils
    {

        /// <summary>
        /// Returns a measuring text template.
        /// </summary>
        /// <param name="measurementAnnotation">A measurement annotation data.</param>
        /// <returns>Measuring text template.</returns>
        public static string GetMeasuringTextTemplate(MeasurementAnnotationData measurementAnnotation)
        {            
            string unitOfMeasureString = GetUnitOfMeasureString(measurementAnnotation.MeasuringAnnotation.UnitsOfMeasure);

            // if measurement annotation measures angle
            if (measurementAnnotation.MeasuringAnnotation is AngleMeasuringData)
            {
                return string.Format("Angle = {1}°\nReflex angle = {2}°\nLength = {3} {0} ",
                    unitOfMeasureString, "{Angle:f2}", "{ReflexAngle:f2}", "{Length:f2}");
            }

            // if measurement annotation measures line
            if (measurementAnnotation.MeasuringAnnotation is LinearMeasuringData)
            {
                return "{Length:f2} " + unitOfMeasureString;
            }

            // if measurement annotation measures ellipse
            if (measurementAnnotation.MeasuringAnnotation is EllipseMeasuringData)
            {
                return string.Format("S = {1} {0}^2\nDx = {2} {0}, Dy = {3} {0}",
                    unitOfMeasureString, "{Square:f2}", "{DiameterX:f2}", "{DiameterY:f2}");
            }

            return measurementAnnotation.MeasuringTextTemplate;
        }

        /// <summary>
        /// Returns a unit of measure string presentation.
        /// </summary>
        /// <param name="unitOfMeasure">A unit of measure.</param>
        /// <returns>Unit of measure string presentation</returns>
        private static string GetUnitOfMeasureString(UnitOfMeasure unitOfMeasure)
        {
            switch (unitOfMeasure)
            {
                case UnitOfMeasure.Millimeters:
                    return "mm";

                case UnitOfMeasure.Centimeters:
                    return "cm";

                case UnitOfMeasure.Inches:
                    return "inch";

                case UnitOfMeasure.DeviceIndependentPixels:
                    return "dip";

                case UnitOfMeasure.Pixels:
                    return "px";

                case UnitOfMeasure.Points:
                    return "point";

                case UnitOfMeasure.Twips:
                    return "twip";

                case UnitOfMeasure.Emu:
                    return "emu";
            }

            return unitOfMeasure.ToString();
        }

    }
}
