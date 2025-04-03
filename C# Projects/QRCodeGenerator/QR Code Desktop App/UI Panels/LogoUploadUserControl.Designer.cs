namespace QR_Code_Desktop_App.UI_Panels
{
    partial class LogoUploadUserControl
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.GroupBox logoGroupBox;

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
            this.uploadButton = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.logoGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.logoGroupBox.SuspendLayout();
            this.SuspendLayout();

            // uploadButton
            this.uploadButton.Location = new System.Drawing.Point(10, 20);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(100, 30);
            this.uploadButton.TabIndex = 0;
            this.uploadButton.Text = "Upload Logo";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);

            // logoPictureBox
            this.logoPictureBox.Location = new System.Drawing.Point(10, 60);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(200, 200);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 1;
            this.logoPictureBox.TabStop = false;

            // logoGroupBox
            this.logoGroupBox.Controls.Add(this.uploadButton);
            this.logoGroupBox.Controls.Add(this.logoPictureBox);
            this.logoGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoGroupBox.Location = new System.Drawing.Point(0, 0);
            this.logoGroupBox.Name = "logoGroupBox";
            this.logoGroupBox.Size = new System.Drawing.Size(220, 270);
            this.logoGroupBox.TabIndex = 2;
            this.logoGroupBox.TabStop = false;
            this.logoGroupBox.Text = "Logo Upload";

            // LogoUploadUserControl
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.logoGroupBox);
            this.Name = "LogoUploadUserControl";
            this.Size = new System.Drawing.Size(220, 270);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.logoGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
