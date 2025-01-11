namespace QR_Code_Desktop_App.UI_Panels
{
    partial class QRHyperlinkUserControl
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

        #region Component Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            hyperlinkGroupBox = new GroupBox();
            hyperlinkInput = new TextBox();
            hyperlinkGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // hyperlinkGroupBox
            // 
            hyperlinkGroupBox.AutoSize = true;
            hyperlinkGroupBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            hyperlinkGroupBox.Controls.Add(hyperlinkInput);
            hyperlinkGroupBox.Dock = DockStyle.Fill;
            hyperlinkGroupBox.Location = new Point(0, 0);
            hyperlinkGroupBox.Name = "hyperlinkGroupBox";
            hyperlinkGroupBox.Size = new Size(300, 100);
            hyperlinkGroupBox.TabIndex = 0;
            hyperlinkGroupBox.TabStop = false;
            hyperlinkGroupBox.Text = "Hyperlink QR Code";
            // 
            // hyperlinkInput
            // 
            hyperlinkInput.Dock = DockStyle.Fill;
            hyperlinkInput.Location = new Point(3, 19);
            hyperlinkInput.Name = "hyperlinkInput";
            hyperlinkInput.PlaceholderText = "Enter URL";
            hyperlinkInput.Size = new Size(294, 23);
            hyperlinkInput.TabIndex = 0;
            // 
            // QRHyperlinkUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(hyperlinkGroupBox);
            Name = "QRHyperlinkUserControl";
            Size = new Size(300, 100);
            hyperlinkGroupBox.ResumeLayout(false);
            hyperlinkGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox hyperlinkGroupBox;
        private System.Windows.Forms.TextBox hyperlinkInput;
    }
}
