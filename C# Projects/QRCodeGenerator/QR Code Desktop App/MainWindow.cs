namespace QR_Code_Desktop_App
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            // Event Handlers
            qrCodeTypeSelector.SelectedIndexChanged += QrCodeTypeSelector_SelectedIndexChanged;
            qrTextUserControl.TextUpdated += UpdateQRCode; // Subscribe to TextUpdated
            contactCardUserControl.ContactCardUpdated += UpdateQRCode;
            qrHyperlinkUserControl.HyperlinkUpdated += UpdateQRCode;

            // Subscribe to ColorUpdated event from QRColorOptions
            qrColorOptions.ColorUpdated += UpdateQRCode;

            // Subscribe to LogoUploaded event
            logoUploadUserControl.LogoUploaded += UpdateQRCode;

            // Subscribe to MenuBar events
            menuBarUserControl.SavePNGClicked += MenuBar_SavePNG;
            menuBarUserControl.SavePNGAsClicked += MenuBar_SavePNGAs;
            menuBarUserControl.SaveDataClicked += MenuBar_SaveData;
            menuBarUserControl.OpenClicked += MenuBar_Open;

            // Attach UpdateQRCode to all relevant input fields
            AttachUpdateListeners();
        }

        // Attach listeners to inputs to trigger QR code regeneration
        private void AttachUpdateListeners()
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.TextChanged += UpdateQRCode;
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndexChanged += UpdateQRCode;
                }
            }
        }

        // Conversion helper for colors
        private SkiaSharp.SKColor ConvertToSkiaColor(Color color)
        {
            return new SkiaSharp.SKColor(color.R, color.G, color.B, color.A);
        }

        // MenuBar Event Handlers
        private void MenuBar_SavePNG(object sender, EventArgs e)
        {
            try
            {
                if (previewPanel.QRCodeImage == null)
                {
                    MessageBox.Show("No QR Code to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var saveFileDialog = new SaveFileDialog
                {
                    Filter = "PNG Image|*.png",
                    Title = "Save QR Code as PNG"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    previewPanel.QRCodeImage.Save(saveFileDialog.FileName);
                    MessageBox.Show("QR Code saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving QR Code: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenuBar_SavePNGAs(object sender, EventArgs e)
        {
            MenuBar_SavePNG(sender, e); // Reuse same logic for Save As for now
        }

        private void MenuBar_SaveData(object sender, EventArgs e)
        {
            try
            {
                var data = new
                {
                    QRCodeType = qrCodeTypeSelector.SelectedItem?.ToString(),
                    QRCodeContent = previewPanel.QRCodeContent,
                    ForegroundColor = qrColorOptions.SelectedForegroundColor.ToArgb(),
                    BackgroundColor = qrColorOptions.SelectedBackgroundColor.ToArgb()
                };

                var saveFileDialog = new SaveFileDialog
                {
                    Filter = "JSON File|*.json",
                    Title = "Save QR Code Data"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var jsonData = System.Text.Json.JsonSerializer.Serialize(data);
                    File.WriteAllText(saveFileDialog.FileName, jsonData);
                    MessageBox.Show("QR Code data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving QR Code data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenuBar_Open(object sender, EventArgs e)
        {
            try
            {
                var openFileDialog = new OpenFileDialog
                {
                    Filter = "JSON File|*.json",
                    Title = "Open QR Code Data"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var jsonData = File.ReadAllText(openFileDialog.FileName);
                    var data = System.Text.Json.JsonSerializer.Deserialize<dynamic>(jsonData);

                    qrCodeTypeSelector.SelectedItem = data["QRCodeType"];
                    previewPanel.QRCodeContent = data["QRCodeContent"];
                    qrColorOptions.SelectedForegroundColor = Color.FromArgb((int)data["ForegroundColor"]);
                    qrColorOptions.SelectedBackgroundColor = Color.FromArgb((int)data["BackgroundColor"]);

                    UpdateQRCode(sender, e);

                    MessageBox.Show("QR Code data loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading QR Code data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Listener: Update QR Code when input changes
        private void UpdateQRCode(object sender, EventArgs e)
        {
            // Logic to regenerate and update the QR code preview pane.
            try
            {
                // Determine the type of QR Code
                string qrCodeType = qrCodeTypeSelector.SelectedItem?.ToString();

                // Placeholder for the QR code content
                string qrContent = string.Empty;

                switch (qrCodeType)
                {
                    case "Text":
                        qrContent = qrTextUserControl.GetText(); // Assuming GetText() fetches the user input
                        break;
                    case "Hyperlink":
                        qrContent = qrHyperlinkUserControl.GetHyperlink();
                        break;
                    case "Contact Card":
                        qrContent = contactCardUserControl.GetContactCardData(); // Assuming GetContactCardData() compiles contact card info
                        break;
                    // Add additional cases for other QR code types
                    default:
                        Console.WriteLine("Invalid QR Code type selected.");
                        return;
                }

                // Get colors from QRColorOptions
                var foregroundColor = ConvertToSkiaColor(qrColorOptions.SelectedForegroundColor);
                var backgroundColor = ConvertToSkiaColor(qrColorOptions.SelectedBackgroundColor);

                // Use QRCodeGeneratorTool from the user's library
                var qrGenerator = new QRCodeGeneratorLib.QRCodeGeneratorTool();
                var tempFilePath = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}_GeneratedQRCode.png");

                bool success = qrGenerator.GenerateQRCode(qrContent, tempFilePath, 20, foregroundColor, backgroundColor,logoFilePath: logoUploadUserControl.LogoFilePath);

                if (success)
                {
                    var qrCodeImage = Image.FromFile(tempFilePath);

                    // Update the preview pane
                    previewPanel.UpdatePreview(qrCodeImage, qrContent); // Assuming UpdatePreview() handles both image and text preview

                    Console.WriteLine("QR Code successfully updated.");
                }
                else
                {
                    Console.WriteLine("Failed to generate QR Code.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error generating QR Code: {ex.Message}");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QrCodeTypeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ignore placeholder value
            if (qrCodeTypeSelector.SelectedIndex == 0)
            {
                HideQrCodeTypeGroupBoxes();
                Console.WriteLine("Placeholder selected. No action performed.");
                return;
            }

            // Hide all QR code type-specific group boxes initially
            HideQrCodeTypeGroupBoxes();

            // Show the relevant group box based on selected type
            string selectedType = qrCodeTypeSelector.SelectedItem?.ToString();
            switch (selectedType)
            {
                case "Text":
                    qrTextUserControl.Visible = true;
                    break;
                case "Hyperlink":
                    qrHyperlinkUserControl.Visible = true;
                    break;
                case "Contact Card":
                    contactCardUserControl.Visible = true;
                    break;
                case "Event":
                    // Implement logic for Event group box if added
                    break;
                case "Social Media":
                    // Implement logic for Social Media group box if added
                    break;
                default:
                    Console.WriteLine("No matching group box for the selected QR Code type.");
                    break;
            }

            // Trigger QR code regeneration
            UpdateQRCode(sender, e);
        }

        /// <summary>
        /// 
        /// </summary>
        private void HideQrCodeTypeGroupBoxes()
        {
            qrTextUserControl.Visible = false;
            qrHyperlinkUserControl.Visible = false;
            contactCardUserControl.Visible = false;
            // Add logic for other group boxes if applicable

        }

    }
}