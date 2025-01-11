namespace QR_Code_Desktop_App.UI_Panels
{
    public partial class QRColorOptions : UserControl
    {
        public event EventHandler ColorUpdated;

        public QRColorOptions()
        {
            InitializeComponent();

            // Set default colors
            SelectedForegroundColor = Color.FromArgb(255, 0, 0, 0); // Black, fully opaque
            SelectedBackgroundColor = Color.FromArgb(0, 255, 255, 255); // Transparent

            // Set button initial colors
            foregroundColorButton.BackColor = SelectedForegroundColor;
            backgroundColorButton.BackColor = Color.Transparent;

            // Attach click events
            foregroundColorButton.Click += ForegroundColorButton_Click;
            backgroundColorButton.Click += BackgroundColorButton_Click;

            // Attach opacity track bar events
            foregroundOpacityTrackBar.Minimum = 51; // 20% opacity
            foregroundOpacityTrackBar.Value = 255; // Fully opaque
            backgroundOpacityTrackBar.Value = 0;  // Fully transparent
            foregroundOpacityTrackBar.Scroll += ForegroundOpacityChanged;
            backgroundOpacityTrackBar.Scroll += BackgroundOpacityChanged;

            // Trigger updates to QR preview
            ColorUpdated += (sender, e) => TriggerQRPreviewUpdate();
        }

        public Color SelectedForegroundColor { get; set; } // Allow setting externally
        public Color SelectedBackgroundColor { get; set; } // Allow setting externally

        private void ForegroundColorButton_Click(object sender, EventArgs e)
        {
            using (var colorDialog = new ColorDialog())
            {
                colorDialog.Color = Color.FromArgb(255, SelectedForegroundColor.R, SelectedForegroundColor.G, SelectedForegroundColor.B);
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    SelectedForegroundColor = Color.FromArgb(foregroundOpacityTrackBar.Value, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
                    foregroundColorButton.BackColor = SelectedForegroundColor;
                    ColorUpdated?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        private void BackgroundColorButton_Click(object sender, EventArgs e)
        {
            using (var colorDialog = new ColorDialog())
            {
                colorDialog.Color = Color.FromArgb(255, SelectedBackgroundColor.R, SelectedBackgroundColor.G, SelectedBackgroundColor.B);
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    SelectedBackgroundColor = Color.FromArgb(backgroundOpacityTrackBar.Value, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
                    backgroundColorButton.BackColor = SelectedBackgroundColor;
                    ColorUpdated?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        private void ForegroundOpacityChanged(object sender, EventArgs e)
        {
            SelectedForegroundColor = Color.FromArgb(foregroundOpacityTrackBar.Value, SelectedForegroundColor.R, SelectedForegroundColor.G, SelectedForegroundColor.B);
            foregroundColorButton.BackColor = SelectedForegroundColor;
            ColorUpdated?.Invoke(this, EventArgs.Empty);
        }

        private void BackgroundOpacityChanged(object sender, EventArgs e)
        {
            SelectedBackgroundColor = Color.FromArgb(backgroundOpacityTrackBar.Value, SelectedBackgroundColor.R, SelectedBackgroundColor.G, SelectedBackgroundColor.B);
            backgroundColorButton.BackColor = SelectedBackgroundColor;
            ColorUpdated?.Invoke(this, EventArgs.Empty);
        }

        private void TriggerQRPreviewUpdate()
        {
            // Implement logic to notify the parent component or main window to refresh the QR preview
            Console.WriteLine("QR Preview Updated with Foreground: {0}, Background: {1}", SelectedForegroundColor, SelectedBackgroundColor);
            // Add any additional logic to integrate with the main preview component
        }
    }
}
