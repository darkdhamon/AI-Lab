namespace QR_Code_Desktop_App
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
            this.contactCardGroup = new System.Windows.Forms.GroupBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.orgTextBox = new System.Windows.Forms.TextBox();
            this.eventGroup = new System.Windows.Forms.GroupBox();
            this.eventNameTextBox = new System.Windows.Forms.TextBox();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.socialMediaGroup = new System.Windows.Forms.GroupBox();
            this.socialMediaPlatformComboBox = new System.Windows.Forms.ComboBox();
            this.socialMediaHandleTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.qrCodePreview)).BeginInit();
            this.contactCardGroup.SuspendLayout();
            this.eventGroup.SuspendLayout();
            this.socialMediaGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(20, 20);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(400, 23);
            this.inputTextBox.TabIndex = 0;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(20, 500);
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
            this.qrTypeComboBox.Location = new System.Drawing.Point(20, 60);
            this.qrTypeComboBox.Name = "qrTypeComboBox";
            this.qrTypeComboBox.Size = new System.Drawing.Size(200, 23);
            this.qrTypeComboBox.TabIndex = 2;
            this.qrTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.QrTypeComboBox_SelectedIndexChanged);
            // 
            // qrCodePreview
            // 
            this.qrCodePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qrCodePreview.Location = new System.Drawing.Point(250, 500);
            this.qrCodePreview.Name = "qrCodePreview";
            this.qrCodePreview.Size = new System.Drawing.Size(300, 300);
            this.qrCodePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.qrCodePreview.TabIndex = 3;
            this.qrCodePreview.TabStop = false;
            // 
            // logoPathTextBox
            // 
            this.logoPathTextBox.Location = new System.Drawing.Point(20, 100);
            this.logoPathTextBox.Name = "logoPathTextBox";
            this.logoPathTextBox.Size = new System.Drawing.Size(300, 23);
            this.logoPathTextBox.TabIndex = 4;
            this.logoPathTextBox.PlaceholderText = "Optional: Path to logo image";
            // 
            // browseLogoButton
            // 
            this.browseLogoButton.Location = new System.Drawing.Point(330, 100);
            this.browseLogoButton.Name = "browseLogoButton";
            this.browseLogoButton.Size = new System.Drawing.Size(75, 23);
            this.browseLogoButton.TabIndex = 5;
            this.browseLogoButton.Text = "Browse";
            this.browseLogoButton.UseVisualStyleBackColor = true;
            this.browseLogoButton.Click += new System.EventHandler(this.BrowseLogoButton_Click);
            // 
            // contactCardGroup
            // 
            this.contactCardGroup.Controls.Add(this.firstNameTextBox);
            this.contactCardGroup.Controls.Add(this.lastNameTextBox);
            this.contactCardGroup.Controls.Add(this.phoneTextBox);
            this.contactCardGroup.Controls.Add(this.emailTextBox);
            this.contactCardGroup.Controls.Add(this.orgTextBox);
            this.contactCardGroup.Location = new System.Drawing.Point(20, 140);
            this.contactCardGroup.Name = "contactCardGroup";
            this.contactCardGroup.Size = new System.Drawing.Size(400, 150);
            this.contactCardGroup.TabIndex = 6;
            this.contactCardGroup.TabStop = false;
            this.contactCardGroup.Text = "Contact Card";
            this.contactCardGroup.Visible = false;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(10, 20);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.PlaceholderText = "First Name";
            this.firstNameTextBox.Size = new System.Drawing.Size(180, 23);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(200, 20);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.PlaceholderText = "Last Name";
            this.lastNameTextBox.Size = new System.Drawing.Size(180, 23);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(10, 50);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.PlaceholderText = "Phone";
            this.phoneTextBox.Size = new System.Drawing.Size(180, 23);
            this.phoneTextBox.TabIndex = 2;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(200, 50);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PlaceholderText = "Email";
            this.emailTextBox.Size = new System.Drawing.Size(180, 23);
            this.emailTextBox.TabIndex = 3;
            // 
            // orgTextBox
            // 
            this.orgTextBox.Location = new System.Drawing.Point(10, 80);
            this.orgTextBox.Name = "orgTextBox";
            this.orgTextBox.PlaceholderText = "Organization";
            this.orgTextBox.Size = new System.Drawing.Size(370, 23);
            this.orgTextBox.TabIndex = 4;
            // 
            // eventGroup
            // 
            this.eventGroup.Controls.Add(this.eventNameTextBox);
            this.eventGroup.Controls.Add(this.startTimePicker);
            this.eventGroup.Controls.Add(this.endTimePicker);
            this.eventGroup.Controls.Add(this.locationTextBox);
            this.eventGroup.Controls.Add(this.descriptionTextBox);
            this.eventGroup.Location = new System.Drawing.Point(20, 140);
            this.eventGroup.Name = "eventGroup";
            this.eventGroup.Size = new System.Drawing.Size(400, 200);
            this.eventGroup.TabIndex = 7;
            this.eventGroup.TabStop = false;
            this.eventGroup.Text = "Event";
            this.eventGroup.Visible = false;
            // 
            // eventNameTextBox
            // 
            this.eventNameTextBox.Location = new System.Drawing.Point(10, 20);
            this.eventNameTextBox.Name = "eventNameTextBox";
            this.eventNameTextBox.PlaceholderText = "Event Name";
            this.eventNameTextBox.Size = new System.Drawing.Size(370, 23);
            this.eventNameTextBox.TabIndex = 0;
            // 
            // startTimePicker
            // 
            this.startTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimePicker.Location = new System.Drawing.Point(10, 50);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.Size = new System.Drawing.Size(180, 23);
            this.startTimePicker.TabIndex = 1;
            // 
            // endTimePicker
            // 
            this.endTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimePicker.Location = new System.Drawing.Point(200, 50);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.Size = new System.Drawing.Size(180, 23);
            this.endTimePicker.TabIndex = 2;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(10, 80);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.PlaceholderText = "Location";
            this.locationTextBox.Size = new System.Drawing.Size(370, 23);
            this.locationTextBox.TabIndex = 3;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(10, 110);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.PlaceholderText = "Description";
            this.descriptionTextBox.Size = new System.Drawing.Size(370, 60);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // socialMediaGroup
            // 
            this.socialMediaGroup.Controls.Add(this.socialMediaPlatformComboBox);
            this.socialMediaGroup.Controls.Add(this.socialMediaHandleTextBox);
            this.socialMediaGroup.Location = new System.Drawing.Point(20, 140);
            this.socialMediaGroup.Name = "socialMediaGroup";
            this.socialMediaGroup.Size = new System.Drawing.Size(400, 100);
            this.socialMediaGroup.TabIndex = 8;
            this.socialMediaGroup.TabStop = false;
            this.socialMediaGroup.Text = "Social Media";
            this.socialMediaGroup.Visible = false;
            // 
            // socialMediaPlatformComboBox
            // 
            this.socialMediaPlatformComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.socialMediaPlatformComboBox.FormattingEnabled = true;
            this.socialMediaPlatformComboBox.Items.AddRange(new object[] {
            "Facebook",
            "Twitter",
            "Instagram",
            "LinkedIn"});
            this.socialMediaPlatformComboBox.Location = new System.Drawing.Point(10, 20);
            this.socialMediaPlatformComboBox.Name = "socialMediaPlatformComboBox";
            this.socialMediaPlatformComboBox.Size = new System.Drawing.Size(180, 23);
            this.socialMediaPlatformComboBox.TabIndex = 0;
            // 
            // socialMediaHandleTextBox
            // 
            this.socialMediaHandleTextBox.Location = new System.Drawing.Point(10, 50);
            this.socialMediaHandleTextBox.Name = "socialMediaHandleTextBox";
            this.socialMediaHandleTextBox.PlaceholderText = "Handle/Username";
            this.socialMediaHandleTextBox.Size = new System.Drawing.Size(370, 23);
            this.socialMediaHandleTextBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 850);
            this.Controls.Add(this.socialMediaGroup);
            this.Controls.Add(this.eventGroup);
            this.Controls.Add(this.contactCardGroup);
            this.Controls.Add(this.browseLogoButton);
            this.Controls.Add(this.logoPathTextBox);
            this.Controls.Add(this.qrCodePreview);
            this.Controls.Add(this.qrTypeComboBox);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.inputTextBox);
            this.Name = "Form1";
            this.Text = "QR Code Generator";
            ((System.ComponentModel.ISupportInitialize)(this.qrCodePreview)).EndInit();
            this.contactCardGroup.ResumeLayout(false);
            this.contactCardGroup.PerformLayout();
            this.eventGroup.ResumeLayout(false);
            this.eventGroup.PerformLayout();
            this.socialMediaGroup.ResumeLayout(false);
            this.socialMediaGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.ComboBox qrTypeComboBox;
        private System.Windows.Forms.PictureBox qrCodePreview;
        private System.Windows.Forms.TextBox logoPathTextBox;
        private System.Windows.Forms.Button browseLogoButton;

        // Contact Card Fields
        private System.Windows.Forms.GroupBox contactCardGroup;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox orgTextBox;

        // Event Fields
        private System.Windows.Forms.GroupBox eventGroup;
        private System.Windows.Forms.TextBox eventNameTextBox;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;

        // Social Media Fields
        private System.Windows.Forms.GroupBox socialMediaGroup;
        private System.Windows.Forms.ComboBox socialMediaPlatformComboBox;
        private System.Windows.Forms.TextBox socialMediaHandleTextBox;

        private void QrTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hide all groups initially
            contactCardGroup.Visible = false;
            eventGroup.Visible = false;
            socialMediaGroup.Visible = false;

            switch (qrTypeComboBox.SelectedItem?.ToString())
            {
                case "Contact Card":
                    contactCardGroup.Visible = true;
                    break;
                case "Event":
                    eventGroup.Visible = true;
                    break;
                case "Social Media":
                    socialMediaGroup.Visible = true;
                    break;
            }
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            string inputText = inputTextBox.Text;
            string qrType = qrTypeComboBox.SelectedItem?.ToString();
            string logoPath = logoPathTextBox.Text;

            if (string.IsNullOrWhiteSpace(inputText))
            {
                MessageBox.Show("Please enter valid input text.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tempFilePath = Path.Combine(Path.GetTempPath(), "GeneratedQRCode.png");

            bool success = false;

            var qrCodeTool = new QRCodeGeneratorLib.QRCodeGeneratorTool(); // Instantiate your QRCode generator tool

            switch (qrType)
            {
                case "Text":
                    success = qrCodeTool.GenerateQRCode(inputText, tempFilePath, logoFilePath: logoPath);
                    break;
                case "Hyperlink":
                    success = qrCodeTool.GenerateHyperlinkQRCode(inputText, tempFilePath, logoFilePath: logoPath);
                    break;
                case "Contact Card":
                    success = qrCodeTool.GenerateContactCardQRCode(
                        firstNameTextBox.Text,
                        lastNameTextBox.Text,
                        orgTextBox.Text,
                        phoneTextBox.Text,
                        emailTextBox.Text,
                        tempFilePath,
                        logoFilePath: logoPath);
                    break;
                case "Event":
                    success = qrCodeTool.GenerateEventQRCode(
                        eventNameTextBox.Text,
                        startTimePicker.Value,
                        endTimePicker.Value,
                        locationTextBox.Text,
                        descriptionTextBox.Text,
                        tempFilePath,
                        logoFilePath: logoPath);
                    break;
                case "Social Media":
                    success = qrCodeTool.GenerateSocialMediaQRCode(
                        (QRCodeGeneratorLib.SocialMediaPlatform)socialMediaPlatformComboBox.SelectedItem,
                        socialMediaHandleTextBox.Text,
                        tempFilePath,
                        logoFilePath: logoPath);
                    break;
                default:
                    MessageBox.Show("Please select a valid QR code type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            if (success)
            {
                qrCodePreview.Image?.Dispose();
                qrCodePreview.Image = Image.FromFile(tempFilePath);
                MessageBox.Show("QR Code generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to generate QR Code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BrowseLogoButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    logoPathTextBox.Text = openFileDialog.FileName;
                }
            }
        }

        #endregion
    }
}
