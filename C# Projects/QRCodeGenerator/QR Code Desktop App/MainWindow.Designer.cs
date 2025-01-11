using QR_Code_Desktop_App.UI_Panels;

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
        /// <param name="disposing">true if managed resources should be disposed; otherwise.</param>
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
            menuBarUserControl = new MenuBarUserControl();
            splitContainer1 = new SplitContainer();
            tabControl1 = new TabControl();
            qrCodeContentTab = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            qrTextUserControl = new QRTextUserControl();
            qrHyperlinkUserControl = new QRHyperlinkUserControl();
            contactCardUserControl = new ContactCardUserControl();
            qrCodeTypeSelector = new ComboBox();
            generalOptionsTab = new TabPage();
            previewPanel = new PreviewPanel();
            qrColorOptions = new QRColorOptions();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabControl1.SuspendLayout();
            qrCodeContentTab.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuBarUserControl
            // 
            menuBarUserControl.Dock = DockStyle.Top;
            menuBarUserControl.Location = new Point(0, 0);
            menuBarUserControl.Name = "menuBarUserControl";
            menuBarUserControl.Size = new Size(800, 24);
            menuBarUserControl.TabIndex = 0;
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
            splitContainer1.Panel2.Controls.Add(previewPanel);
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
            flowLayoutPanel1.Controls.Add(qrTextUserControl);
            flowLayoutPanel1.Controls.Add(qrHyperlinkUserControl);
            flowLayoutPanel1.Controls.Add(contactCardUserControl);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(2, 25);
            flowLayoutPanel1.Margin = new Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(254, 321);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // qrTextUserControl
            // 
            qrTextUserControl.Location = new Point(3, 3);
            qrTextUserControl.Name = "qrTextUserControl";
            qrTextUserControl.Size = new Size(250, 100);
            qrTextUserControl.TabIndex = 0;
            qrTextUserControl.Visible = false;
            // 
            // qrHyperlinkUserControl
            // 
            qrHyperlinkUserControl.Location = new Point(3, 109);
            qrHyperlinkUserControl.Name = "qrHyperlinkUserControl";
            qrHyperlinkUserControl.Size = new Size(250, 100);
            qrHyperlinkUserControl.TabIndex = 1;
            qrHyperlinkUserControl.Visible = false;
            // 
            // contactCardUserControl
            // 
            contactCardUserControl.Location = new Point(3, 215);
            contactCardUserControl.Name = "contactCardUserControl";
            contactCardUserControl.Size = new Size(250, 108);
            contactCardUserControl.TabIndex = 2;
            contactCardUserControl.Visible = false;
            // 
            // qrCodeTypeSelector
            // 
            qrCodeTypeSelector.Dock = DockStyle.Top;
            qrCodeTypeSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            qrCodeTypeSelector.FormattingEnabled = true;
            qrCodeTypeSelector.Items.AddRange(new object[] { "Select QR Code Type", "Text", "Hyperlink", "Contact Card", "Event", "Social Media" });
            qrCodeTypeSelector.Location = new Point(2, 2);
            qrCodeTypeSelector.Margin = new Padding(2);
            qrCodeTypeSelector.Name = "qrCodeTypeSelector";
            qrCodeTypeSelector.Size = new Size(254, 23);
            qrCodeTypeSelector.TabIndex = 0;
            qrCodeTypeSelector.SelectedIndex = 0; // Set the default selection
            // 
            // generalOptionsTab
            // 
            generalOptionsTab.Controls.Add(qrColorOptions);
            generalOptionsTab.Location = new Point(4, 24);
            generalOptionsTab.Margin = new Padding(2);
            generalOptionsTab.Name = "generalOptionsTab";
            generalOptionsTab.Padding = new Padding(2);
            generalOptionsTab.Size = new Size(258, 348);
            generalOptionsTab.TabIndex = 0;
            generalOptionsTab.Text = "General Options";
            generalOptionsTab.UseVisualStyleBackColor = true;
            //
            // qrColorOptions
            //
            qrColorOptions.Dock = DockStyle.Top;

            // 
            // previewPanel
            // 
            previewPanel.Dock = DockStyle.Fill;
            previewPanel.Location = new Point(0, 0);
            previewPanel.Name = "previewPanel";
            previewPanel.Size = new Size(531, 376);
            previewPanel.TabIndex = 0;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 400);
            Controls.Add(splitContainer1);
            Controls.Add(menuBarUserControl);
            Name = "MainWindow";
            Text = "QR Code Generator";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            qrCodeContentTab.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MenuBarUserControl menuBarUserControl;
        private SplitContainer splitContainer1;
        private TabControl tabControl1;
        private TabPage generalOptionsTab;
        private TabPage qrCodeContentTab;
        private ComboBox qrCodeTypeSelector;
        private FlowLayoutPanel flowLayoutPanel1;
        private PreviewPanel previewPanel;
        private QRTextUserControl qrTextUserControl;
        private QRHyperlinkUserControl qrHyperlinkUserControl;
        private ContactCardUserControl contactCardUserControl;
        private QRColorOptions qrColorOptions;
    }
}
