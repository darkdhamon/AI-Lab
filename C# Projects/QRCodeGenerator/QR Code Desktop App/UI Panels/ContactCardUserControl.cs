using System.Text.RegularExpressions;

namespace QR_Code_Desktop_App.UI_Panels
{
    public partial class ContactCardUserControl : UserControl
    {
        public event EventHandler ContactCardUpdated;

        public ContactCardUserControl()
        {
            InitializeComponent();

            // Attach TextChanged events to notify listeners
            qrFirstNameInput.TextChanged += NotifyUpdate;
            qrLastNameInput.TextChanged += NotifyUpdate;
            qrOrganizationInput.TextChanged += NotifyUpdate;
            qrPhoneInput.TextChanged += NotifyUpdate;
            qrEmailInput.TextChanged += NotifyUpdate;
        }

        private void NotifyUpdate(object sender, EventArgs e)
        {
            ContactCardUpdated?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Retrieves the contact card data as a formatted string, validating fields.
        /// </summary>
        /// <returns>A string representing the contact card data.</returns>
        public string GetContactCardData()
        {
            string firstName = ValidateTextField(qrFirstNameInput);
            string lastName = ValidateTextField(qrLastNameInput);
            string organization = ValidateTextField(qrOrganizationInput);
            string phone = ValidatePhoneField(qrPhoneInput);
            string email = ValidateEmailField(qrEmailInput);

            return $"BEGIN:VCARD\nVERSION:3.0\n" +
                   $"{(string.IsNullOrWhiteSpace(firstName + lastName) ? string.Empty : $"FN:{firstName} {lastName}\n")}" +
                   $"{(string.IsNullOrWhiteSpace(organization) ? string.Empty : $"ORG:{organization}\n")}" +
                   $"{(string.IsNullOrWhiteSpace(phone) ? string.Empty : $"TEL:{phone}\n")}" +
                   $"{(string.IsNullOrWhiteSpace(email) ? string.Empty : $"EMAIL:{email}\n")}" +
                   "END:VCARD";
        }

        /// <summary>
        /// Validates a text input field.
        /// </summary>
        private string ValidateTextField(TextBox textBox)
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.BackColor = SystemColors.Window; // Reset to default color
                return textBox.Text.Trim();
            }
            textBox.BackColor = Color.LightCoral; // Indicate an error
            return string.Empty;
        }

        /// <summary>
        /// Validates a phone input field.
        /// </summary>
        private string ValidatePhoneField(TextBox textBox)
        {
            string phonePattern = @"^\+?\d{0,2}[-.\s]?\(?\d{3}\)?[-.\s]?\d{3}[-.\s]?\d{4}$"; // Enhanced phone regex
            if (Regex.IsMatch(textBox.Text, phonePattern))
            {
                textBox.BackColor = SystemColors.Window; // Reset to default color
                return textBox.Text.Trim();
            }
            textBox.BackColor = Color.LightCoral; // Indicate an error
            return string.Empty;
        }

        /// <summary>
        /// Validates an email input field.
        /// </summary>
        private string ValidateEmailField(TextBox textBox)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // Basic email regex
            if (Regex.IsMatch(textBox.Text, emailPattern))
            {
                textBox.BackColor = SystemColors.Window; // Reset to default color
                return textBox.Text.Trim();
            }
            textBox.BackColor = Color.LightCoral; // Indicate an error
            return string.Empty;
        }
    }
}
