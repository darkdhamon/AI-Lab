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
                        qrContent = qrHyperlinkInput.Text;
                        break;
                    case "Contact Card":
                        qrContent = contactCardUserControl.GetContactCardData(); // Assuming GetContactCardData() compiles contact card info
                        break;
                    // Add additional cases for other QR code types
                    default:
                        Console.WriteLine("Invalid QR Code type selected.");
                        return;
                }

                // Use QR code generator library (e.g., QRCoder) to create QR code
                var qrGenerator = new QRCoder.QRCodeGenerator();
                var qrCodeData = qrGenerator.CreateQrCode(qrContent, QRCoder.QRCodeGenerator.ECCLevel.Q);
                var qrCode = new QRCoder.QRCode(qrCodeData);
                var qrCodeImage = qrCode.GetGraphic(20);

                // Update the preview pane
                previewPanel.UpdatePreview(qrCodeImage, qrContent); // Assuming UpdatePreview() handles both image and text preview

                Console.WriteLine("QR Code successfully updated.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error generating QR Code: {ex.Message}");
            }
        }

        // Listener: Handle QR Code Type selection change
        private void QrCodeTypeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ignore placeholder value
            if (qrCodeTypeSelector.SelectedIndex == 0)
            {
                HideQRCodeTypeGroupBoxes();
                Console.WriteLine("Placeholder selected. No action performed.");
                return;
            }

            // Hide all QR code type-specific group boxes initially
            HideQRCodeTypeGroupBoxes();

            // Show the relevant group box based on selected type
            string selectedType = qrCodeTypeSelector.SelectedItem?.ToString();
            switch (selectedType)
            {
                case "Text":
                    qrTextUserControl.Visible = true;
                    break;
                case "Hyperlink":
                    qrHyperlinkGroupBox.Visible = true;
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

        // Helper: Hide all QR code type-specific group boxes
        private void HideQRCodeTypeGroupBoxes()
        {
            qrTextUserControl.Visible = false;
            qrHyperlinkGroupBox.Visible = false;
            contactCardUserControl.Visible = false;
            // Add logic for other group boxes if applicable
        }
    }
}
