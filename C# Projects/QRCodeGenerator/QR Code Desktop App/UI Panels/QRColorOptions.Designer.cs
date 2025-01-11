namespace QR_Code_Desktop_App.UI_Panels
{
    partial class QRColorOptions
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
            this.colorOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.foregroundOpacityTrackBar = new System.Windows.Forms.TrackBar();
            this.backgroundOpacityTrackBar = new System.Windows.Forms.TrackBar();
            this.foregroundOpacityLabel = new System.Windows.Forms.Label();
            this.backgroundOpacityLabel = new System.Windows.Forms.Label();
            this.foregroundColorButton = new System.Windows.Forms.Button();
            this.backgroundColorButton = new System.Windows.Forms.Button();
            this.foregroundColorLabel = new System.Windows.Forms.Label();
            this.backgroundColorLabel = new System.Windows.Forms.Label();
            this.colorOptionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foregroundOpacityTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundOpacityTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // colorOptionsGroupBox
            // 
            this.colorOptionsGroupBox.Controls.Add(this.foregroundOpacityTrackBar);
            this.colorOptionsGroupBox.Controls.Add(this.backgroundOpacityTrackBar);
            this.colorOptionsGroupBox.Controls.Add(this.foregroundOpacityLabel);
            this.colorOptionsGroupBox.Controls.Add(this.backgroundOpacityLabel);
            this.colorOptionsGroupBox.Controls.Add(this.foregroundColorButton);
            this.colorOptionsGroupBox.Controls.Add(this.backgroundColorButton);
            this.colorOptionsGroupBox.Controls.Add(this.foregroundColorLabel);
            this.colorOptionsGroupBox.Controls.Add(this.backgroundColorLabel);
            this.colorOptionsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorOptionsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.colorOptionsGroupBox.Name = "colorOptionsGroupBox";
            this.colorOptionsGroupBox.Size = new System.Drawing.Size(300, 200);
            this.colorOptionsGroupBox.TabIndex = 0;
            this.colorOptionsGroupBox.TabStop = false;
            this.colorOptionsGroupBox.Text = "QR Code Colors";
            // 
            // foregroundOpacityTrackBar
            // 
            this.foregroundOpacityTrackBar.Location = new System.Drawing.Point(150, 60);
            this.foregroundOpacityTrackBar.Maximum = 255;
            this.foregroundOpacityTrackBar.Name = "foregroundOpacityTrackBar";
            this.foregroundOpacityTrackBar.Size = new System.Drawing.Size(120, 45);
            this.foregroundOpacityTrackBar.TabIndex = 4;
            this.foregroundOpacityTrackBar.Value = 255;
            // 
            // backgroundOpacityTrackBar
            // 
            this.backgroundOpacityTrackBar.Location = new System.Drawing.Point(150, 145);
            this.backgroundOpacityTrackBar.Maximum = 255;
            this.backgroundOpacityTrackBar.Name = "backgroundOpacityTrackBar";
            this.backgroundOpacityTrackBar.Size = new System.Drawing.Size(120, 45);
            this.backgroundOpacityTrackBar.TabIndex = 5;
            this.backgroundOpacityTrackBar.Value = 0;
            // 
            // foregroundOpacityLabel
            // 
            this.foregroundOpacityLabel.AutoSize = true;
            this.foregroundOpacityLabel.Location = new System.Drawing.Point(10, 65);
            this.foregroundOpacityLabel.Name = "foregroundOpacityLabel";
            this.foregroundOpacityLabel.Size = new System.Drawing.Size(113, 15);
            this.foregroundOpacityLabel.TabIndex = 6;
            this.foregroundOpacityLabel.Text = "Foreground Opacity:";
            // 
            // backgroundOpacityLabel
            // 
            this.backgroundOpacityLabel.AutoSize = true;
            this.backgroundOpacityLabel.Location = new System.Drawing.Point(10, 150);
            this.backgroundOpacityLabel.Name = "backgroundOpacityLabel";
            this.backgroundOpacityLabel.Size = new System.Drawing.Size(113, 15);
            this.backgroundOpacityLabel.TabIndex = 7;
            this.backgroundOpacityLabel.Text = "Background Opacity:";
            // 
            // foregroundColorButton
            // 
            this.foregroundColorButton.Location = new System.Drawing.Point(150, 22);
            this.foregroundColorButton.Name = "foregroundColorButton";
            this.foregroundColorButton.Size = new System.Drawing.Size(120, 23);
            this.foregroundColorButton.TabIndex = 0;
            this.foregroundColorButton.Text = "Select Color";
            this.foregroundColorButton.UseVisualStyleBackColor = true;
            // 
            // backgroundColorButton
            // 
            this.backgroundColorButton.Location = new System.Drawing.Point(150, 105);
            this.backgroundColorButton.Name = "backgroundColorButton";
            this.backgroundColorButton.Size = new System.Drawing.Size(120, 23);
            this.backgroundColorButton.TabIndex = 1;
            this.backgroundColorButton.Text = "Select Color";
            this.backgroundColorButton.BackColor = System.Drawing.Color.Transparent;
            this.backgroundColorButton.UseVisualStyleBackColor = true;
            // 
            // foregroundColorLabel
            // 
            this.foregroundColorLabel.AutoSize = true;
            this.foregroundColorLabel.Location = new System.Drawing.Point(10, 27);
            this.foregroundColorLabel.Name = "foregroundColorLabel";
            this.foregroundColorLabel.Size = new System.Drawing.Size(106, 15);
            this.foregroundColorLabel.TabIndex = 2;
            this.foregroundColorLabel.Text = "Foreground Color:";
            // 
            // backgroundColorLabel
            // 
            this.backgroundColorLabel.AutoSize = true;
            this.backgroundColorLabel.Location = new System.Drawing.Point(10, 110);
            this.backgroundColorLabel.Name = "backgroundColorLabel";
            this.backgroundColorLabel.Size = new System.Drawing.Size(106, 15);
            this.backgroundColorLabel.TabIndex = 3;
            this.backgroundColorLabel.Text = "Background Color:";
            // 
            // QRColorOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.colorOptionsGroupBox);
            this.Name = "QRColorOptions";
            this.Size = new System.Drawing.Size(300, 200);
            this.colorOptionsGroupBox.ResumeLayout(false);
            this.colorOptionsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foregroundOpacityTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundOpacityTrackBar)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox colorOptionsGroupBox;
        private System.Windows.Forms.Button foregroundColorButton;
        private System.Windows.Forms.Button backgroundColorButton;
        private System.Windows.Forms.Label foregroundColorLabel;
        private System.Windows.Forms.Label backgroundColorLabel;
        private System.Windows.Forms.TrackBar foregroundOpacityTrackBar;
        private System.Windows.Forms.TrackBar backgroundOpacityTrackBar;
        private System.Windows.Forms.Label foregroundOpacityLabel;
        private System.Windows.Forms.Label backgroundOpacityLabel;
    }
}
