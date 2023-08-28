using System;
using System.Windows.Forms;

using Vintasoft.Imaging;
using Vintasoft.Imaging.Codecs.Encoders;

using DemosCommonCode.Imaging.Codecs;


namespace DemosCommonCode.Imaging
{
    /// <summary>
    /// Allows to show a file save dialog and save an image to a file.
    /// </summary>
    public class SaveImageFileForm
    {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveImageFileForm"/> class.
        /// </summary>
        public SaveImageFileForm()
        {
        }

        #endregion



        #region Methods

        /// <summary>
        /// Shows a file save dialog and saves the specified image to the selected file.
        /// </summary>
        /// <param name="image">The image, which must be saved.</param>
        /// <param name="encoderFactory">The encoder factory.</param>
        /// <returns>The dialog result.</returns>
        public static DialogResult SaveImageToFile(
            VintasoftImage image,
            ImagingEncoderFactory encoderFactory)
        {
            if (image == null)
                return DialogResult.OK;

            // create the save file dialog
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // set save file dialog filters
                CodecsFileFilters.SetSaveFileDialogFilter(saveFileDialog, false, false);
                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    return DialogResult.Cancel;

                EncoderBase encoder = null;
                // if encoder is created
                if (encoderFactory.GetEncoder(saveFileDialog.FileName, out encoder))
                {
                    try
                    {
                        // save images
                        image.Save(saveFileDialog.FileName, encoder);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return DialogResult.OK;
                }
                return DialogResult.Cancel;
            }
        }

        /// <summary>
        /// Shows a file save dialog and saves the specified images to the selected file.
        /// </summary>
        /// <param name="images">The images, which must be saved.</param>
        /// <param name="encoderFactory">The encoder factory.</param>
        /// <returns>The dialog result.</returns>
        public static DialogResult SaveImagesToFile(
            ImageCollection images,
            ImagingEncoderFactory encoderFactory)
        {
            if (images.Count == 0)
                return DialogResult.OK;
            if (images.Count == 1)
                return SaveImageToFile(images[0], encoderFactory);

            // create the save file dialog
            using (SaveFileDialog saveFileDlg = new SaveFileDialog())
            {
                // set save file dialog filters
                CodecsFileFilters.SetSaveFileDialogFilter(saveFileDlg, true, false);
                if (saveFileDlg.ShowDialog() != DialogResult.OK)
                    return DialogResult.Cancel;

                MultipageEncoderBase encoder = null;
                // if encoder is created
                if (encoderFactory.GetMultipageEncoder(saveFileDlg.FileName, out encoder))
                {
                    try
                    {
                        // save images
                        images.SaveSync(saveFileDlg.FileName, encoder);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return DialogResult.OK;
                }
                return DialogResult.Cancel;
            }
        }

        #endregion

    }
}
