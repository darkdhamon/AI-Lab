namespace QR_Code_Desktop_App.UI_Panels
{
    public partial class QRTextUserControl : UserControl
    {
        public event EventHandler TextUpdated;

        public QRTextUserControl()
        {
            InitializeComponent();

            // Attach TextChanged event to notify listeners
            qrTextInput.TextChanged += (sender, e) => TextUpdated?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Retrieves the text entered in the QR text input field.
        /// </summary>
        /// <returns>The user-entered text.</returns>
        public string GetText()
        {
            return qrTextInput.Text;
        }
    }
}
