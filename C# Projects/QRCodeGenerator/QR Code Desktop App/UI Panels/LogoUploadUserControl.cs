using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SkiaSharp;

namespace QR_Code_Desktop_App.UI_Panels
{
    public partial class LogoUploadUserControl : UserControl
    {
        public event EventHandler LogoUploaded;

        public LogoUploadUserControl()
        {
            InitializeComponent();
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.png;*.webp";
                openFileDialog.Title = "Select a Logo Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Load the image using SkiaSharp
                        using (var stream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                        using (var skBitmap = SKBitmap.Decode(stream))
                        {
                            if (skBitmap == null)
                            {
                                throw new FormatException("Failed to decode image.");
                            }

                            using (var skImage = SKImage.FromBitmap(skBitmap))
                            using (var data = skImage.Encode(SKEncodedImageFormat.Png, 100))
                            using (var ms = new MemoryStream(data.ToArray()))
                            {
                                logoPictureBox.Image = Image.FromStream(ms);
                            }
                        }

                        LogoFilePath = openFileDialog.FileName;
                        LogoUploaded?.Invoke(this, EventArgs.Empty);
                    }
                    catch (OutOfMemoryException)
                    {
                        MessageBox.Show("The selected file is not a valid image or is corrupted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public string LogoFilePath { get; private set; }
    }
}
