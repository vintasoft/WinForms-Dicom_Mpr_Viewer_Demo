namespace DicomMprViewerDemo
{
    /// <summary>
    /// Specifies available types of slices.
    /// </summary>
    public enum SliceType
    {
        /// <summary>
        /// The sagittal slice type.
        /// </summary>
        Sagittal = 0,

        /// <summary>
        /// The coronal slice type.
        /// </summary>
        Coronal = 1,

        /// <summary>
        /// The axial slice type.
        /// </summary>
        Axial = 2,

        /// <summary>
        /// The curvilinear slice type.
        /// </summary>
        Curvilinear = 3
    }
}
