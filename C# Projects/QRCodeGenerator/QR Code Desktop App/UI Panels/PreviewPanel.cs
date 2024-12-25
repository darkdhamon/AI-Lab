using System;
using System.Drawing;
using System.Windows.Forms;

namespace QR_Code_Desktop_App.UI_Panels
{
    public partial class PreviewPanel : UserControl
    {
        public PreviewPanel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Updates the preview panel with the QR code image and its corresponding text.
        /// </summary>
        /// <param name="qrImage">The QR code image to display.</param>
        /// <param name="qrText">The text value of the QR code.</param>
        public void UpdatePreview(Image qrImage, string qrText)
        {
            if (qrCodePictureBox.Image != null)
            {
                qrCodePictureBox.Image.Dispose();
            }

            qrCodePictureBox.Image = qrImage;
            qrCodeTextBox.Text = qrText;
        }
    }
}
