namespace QR_Code_Desktop_App
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            // Event Handlers
            qrCodeTypeSelector.SelectedIndexChanged += QrCodeTypeSelector_SelectedIndexChanged;

            // Attach UpdateQRCode to all relevant input fields
            AttachUpdateListeners();
        }

        // Attach listeners to inputs to trigger QR code regeneration
        private void AttachUpdateListeners()
        {
            foreach (Control control in Controls)
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
            // TODO: Logic to regenerate and update the QR code preview pane.
            Console.WriteLine("QR Code inputs updated. Regenerating QR Code...");
        }

        // Listener: Handle QR Code Type selection change
        private void QrCodeTypeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hide all QR code type-specific group boxes initially
            HideQRCodeTypeGroupBoxes();

            // Show the relevant group box based on selected type
            string selectedType = qrCodeTypeSelector.SelectedItem?.ToString();
            switch (selectedType)
            {
                case "Text":
                    qrTextGroupBox.Visible = true;
                    break;
                case "Hyperlink":
                    qrHyperlinkGroupBox.Visible = true;
                    break;
                case "Contact Card":
                    contactCardGroupBox.Visible = true;
                    break;
                case "Event":
                    //eventGroupBox.Visible = true;
                    break;
                case "Social Media":
                    //socialMediaGroupBox.Visible = true;
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
            qrTextGroupBox.Visible = false;
            qrHyperlinkGroupBox.Visible = false;
            contactCardGroupBox.Visible = false;
            //eventGroupBox.Visible = false;
            //socialMediaGroupBox.Visible = false;
        }        
    }
}
