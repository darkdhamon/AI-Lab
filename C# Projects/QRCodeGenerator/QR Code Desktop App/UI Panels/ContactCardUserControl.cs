using System;
using System.Windows.Forms;

namespace QR_Code_Desktop_App.UI_Panels
{
    public partial class ContactCardUserControl : UserControl
    {
        public ContactCardUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Retrieves the contact card data as a formatted string.
        /// </summary>
        /// <returns>A string representing the contact card data.</returns>
        public string GetContactCardData()
        {
            return $"First Name: {qrFirstNameInput.Text}\nLast Name: {qrLastNameInput.Text}\n" +
                   $"Organization: {qrOrganizationInput.Text}\nPhone: {qrPhoneInput.Text}\nEmail: {qrEmailInput.Text}";
        }
    }
}
