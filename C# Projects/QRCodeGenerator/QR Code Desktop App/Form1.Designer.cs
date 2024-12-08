﻿namespace QR_Code_Desktop_App
{
    partial class Form1
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.qrTypeComboBox = new System.Windows.Forms.ComboBox();
            this.qrCodePreview = new System.Windows.Forms.PictureBox();
            this.logoPathTextBox = new System.Windows.Forms.TextBox();
            this.browseLogoButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qrCodePreview)).BeginInit();
            this.SuspendLayout();

            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(20, 100);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(400, 23);
            this.inputTextBox.TabIndex = 0;

            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(20, 300);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(200, 23);
            this.generateButton.TabIndex = 1;
            this.generateButton.Text = "Generate QR Code";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.GenerateButton_Click);

            // 
            // qrTypeComboBox
            // 
            this.qrTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.qrTypeComboBox.FormattingEnabled = true;
            this.qrTypeComboBox.Items.AddRange(new object[] {
            "Text",
            "Hyperlink",
            "Contact Card",
            "Event",
            "Social Media"});
            this.qrTypeComboBox.Location = new System.Drawing.Point(20, 20);
            this.qrTypeComboBox.Name = "qrTypeComboBox";
            this.qrTypeComboBox.Size = new System.Drawing.Size(200, 23);
            this.qrTypeComboBox.TabIndex = 2;
            this.qrTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.QrTypeComboBox_SelectedIndexChanged);

            // 
            // qrCodePreview
            // 
            this.qrCodePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qrCodePreview.Location = new System.Drawing.Point(450, 20);
            this.qrCodePreview.Name = "qrCodePreview";
            this.qrCodePreview.Size = new System.Drawing.Size(300, 300);
            this.qrCodePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.qrCodePreview.TabIndex = 3;
            this.qrCodePreview.TabStop = false;

            // 
            // logoPathTextBox
            // 
            this.logoPathTextBox.Location = new System.Drawing.Point(20, 60);
            this.logoPathTextBox.Name = "logoPathTextBox";
            this.logoPathTextBox.Size = new System.Drawing.Size(300, 23);
            this.logoPathTextBox.TabIndex = 4;
            this.logoPathTextBox.PlaceholderText = "Optional: Path to logo image";

            // 
            // browseLogoButton
            // 
            this.browseLogoButton.Location = new System.Drawing.Point(330, 60);
            this.browseLogoButton.Name = "browseLogoButton";
            this.browseLogoButton.Size = new System.Drawing.Size(75, 23);
            this.browseLogoButton.TabIndex = 5;
            this.browseLogoButton.Text = "Browse";
            this.browseLogoButton.UseVisualStyleBackColor = true;
            this.browseLogoButton.Click += new System.EventHandler(this.BrowseLogoButton_Click);

            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(450, 330);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(200, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save QR Code";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.qrCodePreview);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.qrTypeComboBox);
            this.Controls.Add(this.logoPathTextBox);
            this.Controls.Add(this.browseLogoButton);
            this.Controls.Add(this.inputTextBox);
            this.Name = "Form1";
            this.Text = "QR Code Generator";
            ((System.ComponentModel.ISupportInitialize)(this.qrCodePreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.ComboBox qrTypeComboBox;
        private System.Windows.Forms.PictureBox qrCodePreview;
        private System.Windows.Forms.TextBox logoPathTextBox;
        private System.Windows.Forms.Button browseLogoButton;
        private System.Windows.Forms.Button saveButton;

        private void BrowseLogoButton_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new System.Windows.Forms.OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp;*.gif";
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    logoPathTextBox.Text = openFileDialog.FileName;
                }
            }
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string input = inputTextBox.Text;
                string logoPath = logoPathTextBox.Text;
                string qrType = qrTypeComboBox.SelectedItem?.ToString();

                if (string.IsNullOrWhiteSpace(input))
                {
                    System.Windows.Forms.MessageBox.Show("Please provide the required input.", "Error");
                    return;
                }

                var qrGenerator = new QRCodeGeneratorLib.QRCodeGeneratorTool();
                string tempFilePath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "GeneratedQRCode.png");
                bool success = false;

                switch (qrType)
                {
                    case "Text":
                        success = qrGenerator.GenerateQRCode(input, tempFilePath, logoFilePath: logoPath);
                        break;
                    case "Hyperlink":
                        success = qrGenerator.GenerateHyperlinkQRCode(input, tempFilePath, logoFilePath: logoPath);
                        break;
                    case "Contact Card":
                        // Add Contact Card handling logic here when additional fields are implemented.
                        break;
                    case "Event":
                        // Add Event handling logic here when additional fields are implemented.
                        break;
                    case "Social Media":
                        // Add Social Media handling logic here when additional fields are implemented.
                        break;
                    default:
                        System.Windows.Forms.MessageBox.Show("Unsupported QR code type.", "Error");
                        return;
                }

                if (success)
                {
                    qrCodePreview.Image?.Dispose();
                    qrCodePreview.Image = System.Drawing.Image.FromFile(tempFilePath);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Failed to generate QR Code.", "Error");
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (qrCodePreview.Image == null)
            {
                System.Windows.Forms.MessageBox.Show("No QR Code to save.", "Error");
                return;
            }

            using (var saveFileDialog = new System.Windows.Forms.SaveFileDialog())
            {
                saveFileDialog.Filter = "PNG Image|*.png";
                if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    qrCodePreview.Image.Save(saveFileDialog.FileName);
                    System.Windows.Forms.MessageBox.Show("QR Code saved successfully.", "Success");
                }
            }
        }

        private void QrTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Placeholder logic for handling type selection.
            System.Windows.Forms.MessageBox.Show("QR Code type changed.", "Info");
        }

        #endregion
    }
}