namespace QR_Code_Desktop_App.UI_Panels
{
    partial class ContactCardUserControl
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
            tableLayoutPanel = new TableLayoutPanel();
            qrFirstNameInput = new TextBox();
            qrLastNameInput = new TextBox();
            qrOrganizationInput = new TextBox();
            qrPhoneInput = new TextBox();
            qrEmailInput = new TextBox();
            groupBox = new GroupBox();
            tableLayoutPanel.SuspendLayout();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Controls.Add(qrFirstNameInput, 0, 0);
            tableLayoutPanel.Controls.Add(qrLastNameInput, 1, 0);
            tableLayoutPanel.Controls.Add(qrOrganizationInput, 0, 1);
            tableLayoutPanel.Controls.Add(qrPhoneInput, 0, 2);
            tableLayoutPanel.Controls.Add(qrEmailInput, 1, 2);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(3, 19);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel.Size = new Size(244, 86);
            tableLayoutPanel.TabIndex = 0;
            // 
            // qrFirstNameInput
            // 
            qrFirstNameInput.Dock = DockStyle.Fill;
            qrFirstNameInput.Location = new Point(3, 3);
            qrFirstNameInput.Name = "qrFirstNameInput";
            qrFirstNameInput.PlaceholderText = "First Name";
            qrFirstNameInput.Size = new Size(116, 23);
            qrFirstNameInput.TabIndex = 0;
            // 
            // qrLastNameInput
            // 
            qrLastNameInput.Dock = DockStyle.Fill;
            qrLastNameInput.Location = new Point(125, 3);
            qrLastNameInput.Name = "qrLastNameInput";
            qrLastNameInput.PlaceholderText = "Last Name";
            qrLastNameInput.Size = new Size(116, 23);
            qrLastNameInput.TabIndex = 1;
            // 
            // qrOrganizationInput
            // 
            tableLayoutPanel.SetColumnSpan(qrOrganizationInput, 2);
            qrOrganizationInput.Dock = DockStyle.Fill;
            qrOrganizationInput.Location = new Point(3, 33);
            qrOrganizationInput.Name = "qrOrganizationInput";
            qrOrganizationInput.PlaceholderText = "Organization";
            qrOrganizationInput.Size = new Size(238, 23);
            qrOrganizationInput.TabIndex = 2;
            // 
            // qrPhoneInput
            // 
            qrPhoneInput.Dock = DockStyle.Fill;
            qrPhoneInput.Location = new Point(3, 63);
            qrPhoneInput.Name = "qrPhoneInput";
            qrPhoneInput.PlaceholderText = "Phone Number";
            qrPhoneInput.Size = new Size(116, 23);
            qrPhoneInput.TabIndex = 3;
            // 
            // qrEmailInput
            // 
            qrEmailInput.Dock = DockStyle.Fill;
            qrEmailInput.Location = new Point(125, 63);
            qrEmailInput.Name = "qrEmailInput";
            qrEmailInput.PlaceholderText = "Email";
            qrEmailInput.Size = new Size(116, 23);
            qrEmailInput.TabIndex = 4;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(tableLayoutPanel);
            groupBox.Dock = DockStyle.Fill;
            groupBox.Location = new Point(0, 0);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(250, 108);
            groupBox.TabIndex = 1;
            groupBox.TabStop = false;
            groupBox.Text = "Contact Card QR Code";
            // 
            // ContactCardUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox);
            Name = "ContactCardUserControl";
            Size = new Size(250, 108);
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            groupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TextBox qrFirstNameInput;
        private System.Windows.Forms.TextBox qrLastNameInput;
        private System.Windows.Forms.TextBox qrOrganizationInput;
        private System.Windows.Forms.TextBox qrPhoneInput;
        private System.Windows.Forms.TextBox qrEmailInput;
        private System.Windows.Forms.GroupBox groupBox;
    }
}
