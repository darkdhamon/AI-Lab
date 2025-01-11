namespace QR_Code_Desktop_App.UI_Panels
{
    public partial class QRHyperlinkUserControl : UserControl
    {
        public event EventHandler HyperlinkUpdated;

        public QRHyperlinkUserControl()
        {
            InitializeComponent();

            // Attach TextChanged event to notify listeners
            hyperlinkInput.TextChanged += (sender, e) => HyperlinkUpdated?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Retrieves the hyperlink entered in the input field.
        /// </summary>
        /// <returns>The user-entered hyperlink.</returns>
        public string GetHyperlink()
        {
            var url = hyperlinkInput.Text.Trim();
            if (ValidateHyperlink())
                return hyperlinkInput.Text.Trim();
            else return string.Empty;
        }

        /// <summary>
        /// Validates the hyperlink input.
        /// </summary>
        public bool ValidateHyperlink()
        {
            string url = hyperlinkInput.Text.Trim();
            if (Uri.TryCreate(url, UriKind.Absolute, out var uriResult) &&
                (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps))
            {
                hyperlinkInput.BackColor = SystemColors.Window; // Valid input
                return true;
            }
            else
            {
                hyperlinkInput.BackColor = Color.LightCoral; // Invalid input
                return false;
            }
        }
    }
}
