namespace QR_Code_Desktop_App
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            savePNGToolStripMenuItem = new ToolStripMenuItem();
            savePNGAsToolStripMenuItem = new ToolStripMenuItem();
            saveDataToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            tabControl1 = new TabControl();
            generalOptionsTab = new TabPage();
            qrCodeContentTab = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            qrTextGroupBox = new GroupBox();
            qrTextInput = new TextBox();
            qrHyperlinkGroupBox = new GroupBox();
            qrHyperlinkInput = new TextBox();
            contactCardGroupBox = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            qrPhoneInput = new TextBox();
            qrOrganizationInput = new TextBox();
            qrLastNameInput = new TextBox();
            qrFirstNameInput = new TextBox();
            qrEmailInput = new TextBox();
            qrCodeTypeSelector = new ComboBox();
            previewSplitContainer = new SplitContainer();
            qrCodePictureBox = new PictureBox();
            qrCodeTextBox = new TextBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabControl1.SuspendLayout();
            qrCodeContentTab.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            qrTextGroupBox.SuspendLayout();
            qrHyperlinkGroupBox.SuspendLayout();
            contactCardGroupBox.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)previewSplitContainer).BeginInit();
            previewSplitContainer.Panel1.SuspendLayout();
            previewSplitContainer.Panel2.SuspendLayout();
            previewSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)qrCodePictureBox).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, saveAsToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 22);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { savePNGToolStripMenuItem, savePNGAsToolStripMenuItem, saveDataToolStripMenuItem });
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(103, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // savePNGToolStripMenuItem
            // 
            savePNGToolStripMenuItem.Name = "savePNGToolStripMenuItem";
            savePNGToolStripMenuItem.Size = new Size(148, 22);
            savePNGToolStripMenuItem.Text = "Save PNG";
            // 
            // savePNGAsToolStripMenuItem
            // 
            savePNGAsToolStripMenuItem.Name = "savePNGAsToolStripMenuItem";
            savePNGAsToolStripMenuItem.Size = new Size(148, 22);
            savePNGAsToolStripMenuItem.Text = "Save PNG as...";
            // 
            // saveDataToolStripMenuItem
            // 
            saveDataToolStripMenuItem.Name = "saveDataToolStripMenuItem";
            saveDataToolStripMenuItem.Size = new Size(148, 22);
            saveDataToolStripMenuItem.Text = "Save Data";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(103, 22);
            saveAsToolStripMenuItem.Text = "Open";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 24);
            splitContainer1.Margin = new Padding(2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(previewSplitContainer);
            splitContainer1.Size = new Size(800, 376);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.SplitterWidth = 3;
            splitContainer1.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(qrCodeContentTab);
            tabControl1.Controls.Add(generalOptionsTab);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(266, 376);
            tabControl1.TabIndex = 0;
            // 
            // generalOptionsTab
            // 
            generalOptionsTab.Location = new Point(4, 24);
            generalOptionsTab.Margin = new Padding(2);
            generalOptionsTab.Name = "generalOptionsTab";
            generalOptionsTab.Padding = new Padding(2);
            generalOptionsTab.Size = new Size(258, 348);
            generalOptionsTab.TabIndex = 0;
            generalOptionsTab.Text = "General Options";
            generalOptionsTab.UseVisualStyleBackColor = true;
            // 
            // qrCodeContentTab
            // 
            qrCodeContentTab.Controls.Add(flowLayoutPanel1);
            qrCodeContentTab.Controls.Add(qrCodeTypeSelector);
            qrCodeContentTab.Location = new Point(4, 24);
            qrCodeContentTab.Margin = new Padding(2);
            qrCodeContentTab.Name = "qrCodeContentTab";
            qrCodeContentTab.Padding = new Padding(2);
            qrCodeContentTab.Size = new Size(258, 348);
            qrCodeContentTab.TabIndex = 1;
            qrCodeContentTab.Text = "QR Code Content";
            qrCodeContentTab.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(qrTextGroupBox);
            flowLayoutPanel1.Controls.Add(qrHyperlinkGroupBox);
            flowLayoutPanel1.Controls.Add(contactCardGroupBox);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(2, 25);
            flowLayoutPanel1.Margin = new Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(254, 321);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // qrTextGroupBox
            // 
            qrTextGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            qrTextGroupBox.Controls.Add(qrTextInput);
            qrTextGroupBox.Location = new Point(2, 2);
            qrTextGroupBox.Margin = new Padding(2);
            qrTextGroupBox.Name = "qrTextGroupBox";
            qrTextGroupBox.Padding = new Padding(2);
            qrTextGroupBox.Size = new Size(253, 60);
            qrTextGroupBox.TabIndex = 0;
            qrTextGroupBox.TabStop = false;
            qrTextGroupBox.Text = " Text-Based Qr Code";
            qrTextGroupBox.Visible = false;
            // 
            // qrTextInput
            // 
            qrTextInput.Dock = DockStyle.Fill;
            qrTextInput.Location = new Point(2, 18);
            qrTextInput.Margin = new Padding(2);
            qrTextInput.Multiline = true;
            qrTextInput.Name = "qrTextInput";
            qrTextInput.PlaceholderText = "Any text you want";
            qrTextInput.Size = new Size(249, 40);
            qrTextInput.TabIndex = 0;
            // 
            // qrHyperlinkGroupBox
            // 
            qrHyperlinkGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            qrHyperlinkGroupBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            qrHyperlinkGroupBox.Controls.Add(qrHyperlinkInput);
            qrHyperlinkGroupBox.Location = new Point(2, 66);
            qrHyperlinkGroupBox.Margin = new Padding(2);
            qrHyperlinkGroupBox.Name = "qrHyperlinkGroupBox";
            qrHyperlinkGroupBox.Padding = new Padding(2);
            qrHyperlinkGroupBox.Size = new Size(253, 38);
            qrHyperlinkGroupBox.TabIndex = 1;
            qrHyperlinkGroupBox.TabStop = false;
            qrHyperlinkGroupBox.Text = "Hyperlink Qr Code";
            qrHyperlinkGroupBox.Visible = false;
            // 
            // qrHyperlinkInput
            // 
            qrHyperlinkInput.Dock = DockStyle.Fill;
            qrHyperlinkInput.Location = new Point(2, 18);
            qrHyperlinkInput.Margin = new Padding(2);
            qrHyperlinkInput.Name = "qrHyperlinkInput";
            qrHyperlinkInput.PlaceholderText = "URL";
            qrHyperlinkInput.Size = new Size(249, 23);
            qrHyperlinkInput.TabIndex = 0;
            // 
            // contactCardGroupBox
            // 
            contactCardGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            contactCardGroupBox.Controls.Add(tableLayoutPanel2);
            contactCardGroupBox.Location = new Point(2, 108);
            contactCardGroupBox.Margin = new Padding(2);
            contactCardGroupBox.Name = "contactCardGroupBox";
            contactCardGroupBox.Padding = new Padding(2);
            contactCardGroupBox.Size = new Size(253, 109);
            contactCardGroupBox.TabIndex = 2;
            contactCardGroupBox.TabStop = false;
            contactCardGroupBox.Text = "Contact Card QR Code";
            contactCardGroupBox.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(qrPhoneInput, 0, 2);
            tableLayoutPanel2.Controls.Add(qrOrganizationInput, 0, 1);
            tableLayoutPanel2.Controls.Add(qrLastNameInput, 1, 0);
            tableLayoutPanel2.Controls.Add(qrFirstNameInput, 0, 0);
            tableLayoutPanel2.Controls.Add(qrEmailInput, 1, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(2, 18);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(249, 89);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // qrPhoneInput
            // 
            qrPhoneInput.Location = new Point(2, 56);
            qrPhoneInput.Margin = new Padding(2);
            qrPhoneInput.Name = "qrPhoneInput";
            qrPhoneInput.PlaceholderText = "Phone Number";
            qrPhoneInput.Size = new Size(120, 23);
            qrPhoneInput.TabIndex = 3;
            // 
            // qrOrganizationInput
            // 
            tableLayoutPanel2.SetColumnSpan(qrOrganizationInput, 2);
            qrOrganizationInput.Location = new Point(2, 29);
            qrOrganizationInput.Margin = new Padding(2);
            qrOrganizationInput.Name = "qrOrganizationInput";
            qrOrganizationInput.PlaceholderText = "Organization";
            qrOrganizationInput.Size = new Size(245, 23);
            qrOrganizationInput.TabIndex = 2;
            // 
            // qrLastNameInput
            // 
            qrLastNameInput.Dock = DockStyle.Fill;
            qrLastNameInput.Location = new Point(126, 2);
            qrLastNameInput.Margin = new Padding(2);
            qrLastNameInput.Name = "qrLastNameInput";
            qrLastNameInput.PlaceholderText = "Last Name";
            qrLastNameInput.Size = new Size(121, 23);
            qrLastNameInput.TabIndex = 1;
            // 
            // qrFirstNameInput
            // 
            qrFirstNameInput.Dock = DockStyle.Fill;
            qrFirstNameInput.Location = new Point(2, 2);
            qrFirstNameInput.Margin = new Padding(2);
            qrFirstNameInput.Name = "qrFirstNameInput";
            qrFirstNameInput.PlaceholderText = "First Name";
            qrFirstNameInput.Size = new Size(120, 23);
            qrFirstNameInput.TabIndex = 0;
            // 
            // qrEmailInput
            // 
            qrEmailInput.Location = new Point(126, 56);
            qrEmailInput.Margin = new Padding(2);
            qrEmailInput.Name = "qrEmailInput";
            qrEmailInput.PlaceholderText = "Email";
            qrEmailInput.Size = new Size(121, 23);
            qrEmailInput.TabIndex = 4;
            // 
            // qrCodeTypeSelector
            // 
            qrCodeTypeSelector.Dock = DockStyle.Top;
            qrCodeTypeSelector.FormattingEnabled = true;
            qrCodeTypeSelector.Items.AddRange(new object[] { "Text", "Hyperlink", "Contact Card", "Event", "Social Media" });
            qrCodeTypeSelector.Location = new Point(2, 2);
            qrCodeTypeSelector.Margin = new Padding(2);
            qrCodeTypeSelector.Name = "qrCodeTypeSelector";
            qrCodeTypeSelector.Size = new Size(254, 23);
            qrCodeTypeSelector.TabIndex = 0;
            qrCodeTypeSelector.Tag = "";
            // 
            // previewSplitContainer
            // 
            previewSplitContainer.Dock = DockStyle.Fill;
            previewSplitContainer.Location = new Point(0, 0);
            previewSplitContainer.Margin = new Padding(2);
            previewSplitContainer.Name = "previewSplitContainer";
            previewSplitContainer.Orientation = Orientation.Horizontal;
            // 
            // previewSplitContainer.Panel1
            // 
            previewSplitContainer.Panel1.Controls.Add(qrCodePictureBox);
            // 
            // previewSplitContainer.Panel2
            // 
            previewSplitContainer.Panel2.Controls.Add(qrCodeTextBox);
            previewSplitContainer.Size = new Size(531, 376);
            previewSplitContainer.SplitterDistance = 266;
            previewSplitContainer.SplitterWidth = 2;
            previewSplitContainer.TabIndex = 0;
            // 
            // qrCodePictureBox
            // 
            qrCodePictureBox.Dock = DockStyle.Fill;
            qrCodePictureBox.Location = new Point(0, 0);
            qrCodePictureBox.Margin = new Padding(2);
            qrCodePictureBox.Name = "qrCodePictureBox";
            qrCodePictureBox.Size = new Size(531, 266);
            qrCodePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            qrCodePictureBox.TabIndex = 0;
            qrCodePictureBox.TabStop = false;
            // 
            // qrCodeTextBox
            // 
            qrCodeTextBox.Dock = DockStyle.Fill;
            qrCodeTextBox.Location = new Point(0, 0);
            qrCodeTextBox.Margin = new Padding(2);
            qrCodeTextBox.Multiline = true;
            qrCodeTextBox.Name = "qrCodeTextBox";
            qrCodeTextBox.ReadOnly = true;
            qrCodeTextBox.ScrollBars = ScrollBars.Vertical;
            qrCodeTextBox.Size = new Size(531, 108);
            qrCodeTextBox.TabIndex = 0;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 400);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainWindow";
            Text = "QR Code Generator";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            qrCodeContentTab.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            qrTextGroupBox.ResumeLayout(false);
            qrTextGroupBox.PerformLayout();
            qrHyperlinkGroupBox.ResumeLayout(false);
            qrHyperlinkGroupBox.PerformLayout();
            contactCardGroupBox.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            previewSplitContainer.Panel1.ResumeLayout(false);
            previewSplitContainer.Panel2.ResumeLayout(false);
            previewSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)previewSplitContainer).EndInit();
            previewSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)qrCodePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem savePNGToolStripMenuItem;
        private ToolStripMenuItem savePNGAsToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem saveDataToolStripMenuItem;
        private SplitContainer splitContainer1;
        private TabControl tabControl1;
        private TabPage generalOptionsTab;
        private TabPage qrCodeContentTab;
        private ComboBox qrCodeTypeSelector;
        private SplitContainer previewSplitContainer;
        private PictureBox qrCodePictureBox;
        private TextBox qrCodeTextBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox qrTextGroupBox;
        private GroupBox qrHyperlinkGroupBox;
        private GroupBox contactCardGroupBox;
        private TextBox qrTextInput;
        private TextBox qrHyperlinkInput;
        private TextBox qrFirstNameInput;
        private TextBox qrLastNameInput;
        private TextBox qrOrganizationInput;
        private TextBox qrPhoneInput;
        private TextBox qrEmailInput;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
