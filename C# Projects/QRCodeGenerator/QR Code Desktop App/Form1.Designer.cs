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
            this.saveButton = new System.Windows.Forms.Button();
            this.socialMediaGroup = new System.Windows.Forms.GroupBox();
            this.socialMediaPlatformComboBox = new System.Windows.Forms.ComboBox();
            this.socialMediaHandleTextBox = new System.Windows.Forms.TextBox();
            this.contactCardGroup = new System.Windows.Forms.GroupBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.organizationTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();

            ((System.ComponentModel.ISupportInitialize)(this.qrCodePreview)).BeginInit();
            this.socialMediaGroup.SuspendLayout();
            this.contactCardGroup.SuspendLayout();
            this.SuspendLayout();

            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(20, 100);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(400, 23);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.TextChanged += new System.EventHandler(this.GenerateButton_Click);

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
            this.logoPathTextBox.TextChanged += new System.EventHandler(this.GenerateButton_Click);

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
            // socialMediaGroup
            // 
            this.socialMediaGroup.Controls.Add(this.socialMediaPlatformComboBox);
            this.socialMediaGroup.Controls.Add(this.socialMediaHandleTextBox);
            this.socialMediaGroup.Location = new System.Drawing.Point(20, 140);
            this.socialMediaGroup.Name = "socialMediaGroup";
            this.socialMediaGroup.Size = new System.Drawing.Size(400, 100);
            this.socialMediaGroup.TabIndex = 7;
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
            "Instagram"});
            this.socialMediaPlatformComboBox.Location = new System.Drawing.Point(20, 20);
            this.socialMediaPlatformComboBox.Name = "socialMediaPlatformComboBox";
            this.socialMediaPlatformComboBox.Size = new System.Drawing.Size(200, 23);
            this.socialMediaPlatformComboBox.TabIndex = 0;
            this.socialMediaPlatformComboBox.SelectedIndexChanged += new System.EventHandler(this.GenerateButton_Click);

            // 
            // socialMediaHandleTextBox
            // 
            this.socialMediaHandleTextBox.Location = new System.Drawing.Point(20, 60);
            this.socialMediaHandleTextBox.Name = "socialMediaHandleTextBox";
            this.socialMediaHandleTextBox.Size = new System.Drawing.Size(200, 23);
            this.socialMediaHandleTextBox.TabIndex = 1;
            this.socialMediaHandleTextBox.PlaceholderText = "Handle/URL";
            this.socialMediaHandleTextBox.TextChanged += new System.EventHandler(this.GenerateButton_Click);

            // 
            // contactCardGroup
            // 
            this.contactCardGroup.Controls.Add(this.firstNameTextBox);
            this.contactCardGroup.Controls.Add(this.lastNameTextBox);
            this.contactCardGroup.Controls.Add(this.emailTextBox);
            this.contactCardGroup.Controls.Add(this.organizationTextBox);
            this.contactCardGroup.Controls.Add(this.phoneTextBox);
            this.contactCardGroup.Location = new System.Drawing.Point(20, 140);
            this.contactCardGroup.Name = "contactCardGroup";
            this.contactCardGroup.Size = new System.Drawing.Size(400, 180);
            this.contactCardGroup.TabIndex = 8;
            this.contactCardGroup.TabStop = false;
            this.contactCardGroup.Text = "Contact Card";
            this.contactCardGroup.Visible = false;

            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(20, 20);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(200, 23);
            this.firstNameTextBox.TabIndex = 0;
            this.firstNameTextBox.PlaceholderText = "First Name";
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.GenerateButton_Click);

            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(20, 60);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(200, 23);
            this.lastNameTextBox.TabIndex = 1;
            this.lastNameTextBox.PlaceholderText = "Last Name";
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.GenerateButton_Click);

            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(20, 100);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 23);
            this.emailTextBox.TabIndex = 2;
            this.emailTextBox.PlaceholderText = "Email";
            this.emailTextBox.TextChanged += new System.EventHandler(this.GenerateButton_Click);

            // 
            // organizationTextBox
            // 
            this.organizationTextBox.Location = new System.Drawing.Point(20, 140);
            this.organizationTextBox.Name = "organizationTextBox";
            this.organizationTextBox.Size = new System.Drawing.Size(200, 23);
            this.organizationTextBox.TabIndex = 3;
            this.organizationTextBox.PlaceholderText = "Organization";
            this.organizationTextBox.TextChanged += new System.EventHandler(this.GenerateButton_Click);

            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(20, 160);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(200, 23);
            this.phoneTextBox.TabIndex = 4;
            this.phoneTextBox.PlaceholderText = "Phone";
            this.phoneTextBox.TextChanged += new System.EventHandler(this.GenerateButton_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.contactCardGroup);
            this.Controls.Add(this.socialMediaGroup);
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
            this.socialMediaGroup.ResumeLayout(false);
            this.socialMediaGroup.PerformLayout();
            this.contactCardGroup.ResumeLayout(false);
            this.contactCardGroup.PerformLayout();
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
        private System.Windows.Forms.GroupBox socialMediaGroup;
        private System.Windows.Forms.ComboBox socialMediaPlatformComboBox;
        private System.Windows.Forms.TextBox socialMediaHandleTextBox;
        private System.Windows.Forms.GroupBox contactCardGroup;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox organizationTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;

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
            GenerateQRCode();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (qrCodePreview.Image == null)
            {
                Console.WriteLine("No QR Code to save.");
                return;
            }

            using (var saveFileDialog = new System.Windows.Forms.SaveFileDialog())
            {
                saveFileDialog.Filter = "PNG Image|*.png";
                if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    qrCodePreview.Image.Save(saveFileDialog.FileName);
                    Console.WriteLine("QR Code saved successfully.");
                }
            }
        }

        private void QrTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideAllInputGroups();

            switch (qrTypeComboBox.SelectedItem?.ToString())
            {
                case "Social Media":
                    socialMediaGroup.Visible = true;
                    break;
                case "Contact Card":
                    contactCardGroup.Visible = true;
                    break;
                default:
                    inputTextBox.Visible = true;
                    break;
            }

            GenerateQRCode();
        }

        private void HideAllInputGroups()
        {
            inputTextBox.Visible = false;
            socialMediaGroup.Visible = false;
            contactCardGroup.Visible = false;
        }

        private void GenerateQRCode()
        {
            try
            {
                string qrType = qrTypeComboBox.SelectedItem?.ToString();
                string input = inputTextBox.Text;
                string logoPath = logoPathTextBox.Text;
                string tempFilePath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), $"{Guid.NewGuid()}_GeneratedQRCode.png");

                var qrGenerator = new QRCodeGeneratorLib.QRCodeGeneratorTool();
                bool success = false;

                switch (qrType)
                {
                    case "Social Media":
                        if (Enum.TryParse(socialMediaPlatformComboBox.SelectedItem?.ToString(), out QRCodeGeneratorLib.SocialMediaPlatform platform))
                        {
                            string handle = socialMediaHandleTextBox.Text;
                            success = qrGenerator.GenerateSocialMediaQRCode(platform, handle, tempFilePath, logoFilePath: logoPath);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Social Media Platform.");
                        }
                        break;
                    case "Contact Card":
                        string firstName = firstNameTextBox.Text;
                        string lastName = lastNameTextBox.Text;
                        string email = emailTextBox.Text;
                        string organization = organizationTextBox.Text;
                        string phone = phoneTextBox.Text;
                        success = qrGenerator.GenerateContactCardQRCode(firstName, lastName, organization, phone, email, tempFilePath, logoFilePath: logoPath);
                        break;
                    default:
                        success = qrGenerator.GenerateQRCode(input, tempFilePath, logoFilePath: logoPath);
                        break;
                }

                if (success)
                {
                    if (qrCodePreview.Image != null)
                    {
                        qrCodePreview.Image.Dispose();
                        qrCodePreview.Image = null;
                    }

                    qrCodePreview.Image = System.Drawing.Image.FromFile(tempFilePath);
                    Console.WriteLine("QR Code generated successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to generate QR Code.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        #endregion
    }
}