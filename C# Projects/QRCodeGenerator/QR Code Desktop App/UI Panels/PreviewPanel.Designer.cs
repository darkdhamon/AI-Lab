namespace QR_Code_Desktop_App.UI_Panels
{
    partial class PreviewPanel
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
            previewSplitContainer = new SplitContainer();
            qrCodePictureBox = new PictureBox();
            qrCodeTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)previewSplitContainer).BeginInit();
            previewSplitContainer.Panel1.SuspendLayout();
            previewSplitContainer.Panel2.SuspendLayout();
            previewSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)qrCodePictureBox).BeginInit();
            SuspendLayout();
            // 
            // previewSplitContainer
            // 
            previewSplitContainer.Dock = DockStyle.Fill;
            previewSplitContainer.Location = new Point(0, 0);
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
            previewSplitContainer.Size = new Size(400, 400);
            previewSplitContainer.SplitterDistance = 300;
            previewSplitContainer.TabIndex = 0;
            // 
            // qrCodePictureBox
            // 
            qrCodePictureBox.Dock = DockStyle.Fill;
            qrCodePictureBox.Location = new Point(0, 0);
            qrCodePictureBox.Name = "qrCodePictureBox";
            qrCodePictureBox.Size = new Size(400, 300);
            qrCodePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            qrCodePictureBox.TabIndex = 0;
            qrCodePictureBox.TabStop = false;
            // 
            // qrCodeTextBox
            // 
            qrCodeTextBox.Dock = DockStyle.Fill;
            qrCodeTextBox.Location = new Point(0, 0);
            qrCodeTextBox.Multiline = true;
            qrCodeTextBox.Name = "qrCodeTextBox";
            qrCodeTextBox.ReadOnly = true;
            qrCodeTextBox.ScrollBars = ScrollBars.Vertical;
            qrCodeTextBox.Size = new Size(400, 96);
            qrCodeTextBox.TabIndex = 0;

            // 
            // PreviewPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(previewSplitContainer);
            Name = "PreviewPanel";
            Size = new Size(400, 400);
            previewSplitContainer.Panel1.ResumeLayout(false);
            previewSplitContainer.Panel2.ResumeLayout(false);
            previewSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)previewSplitContainer).EndInit();
            previewSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)qrCodePictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer previewSplitContainer;
        private System.Windows.Forms.PictureBox qrCodePictureBox;
        private System.Windows.Forms.TextBox qrCodeTextBox;
    }
}
