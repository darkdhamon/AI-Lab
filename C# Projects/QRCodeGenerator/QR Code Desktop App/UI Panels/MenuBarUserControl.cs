namespace QR_Code_Desktop_App.UI_Panels
{
    public partial class MenuBarUserControl : UserControl
    {
        public event EventHandler SavePNGClicked;
        public event EventHandler SavePNGAsClicked;
        public event EventHandler SaveDataClicked;
        public event EventHandler OpenClicked; // Added for Open button

        public MenuBarUserControl()
        {
            InitializeComponent();

            // Attach event handlers
            savePNGToolStripMenuItem.Click += SavePNGToolStripMenuItem_Click;
            savePNGAsToolStripMenuItem.Click += SavePNGAsToolStripMenuItem_Click;
            saveDataToolStripMenuItem.Click += SaveDataToolStripMenuItem_Click;
            openToolStripMenuItem.Click += OpenToolStripMenuItem_Click; // Attach Open button handler
        }

        private void SavePNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SavePNGClicked?.Invoke(this, EventArgs.Empty);
        }

        private void SavePNGAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SavePNGAsClicked?.Invoke(this, EventArgs.Empty);
        }

        private void SaveDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDataClicked?.Invoke(this, EventArgs.Empty);
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenClicked?.Invoke(this, EventArgs.Empty); // Raise the OpenClicked event
        }
    }
}
