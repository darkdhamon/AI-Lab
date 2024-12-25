using System;
using System.Windows.Forms;

namespace QR_Code_Desktop_App.UI_Panels
{
    public partial class QRTextUserControl : UserControl
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
            qrTextGroupBox = new GroupBox();
            qrTextInput = new TextBox();
            qrTextGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // qrTextGroupBox
            // 
            qrTextGroupBox.Controls.Add(qrTextInput);
            qrTextGroupBox.Dock = DockStyle.Fill;
            qrTextGroupBox.Location = new Point(0, 0);
            qrTextGroupBox.Name = "qrTextGroupBox";
            qrTextGroupBox.Size = new Size(300, 100);
            qrTextGroupBox.TabIndex = 0;
            qrTextGroupBox.TabStop = false;
            qrTextGroupBox.Text = "Text-Based QR Code";
            // 
            // qrTextInput
            // 
            qrTextInput.Dock = DockStyle.Fill;
            qrTextInput.Location = new Point(3, 19);
            qrTextInput.Multiline = true;
            qrTextInput.Name = "qrTextInput";
            qrTextInput.PlaceholderText = "Any text you want";
            qrTextInput.Size = new Size(294, 78);
            qrTextInput.TabIndex = 0;
            // 
            // QRTextUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(qrTextGroupBox);
            Name = "QRTextUserControl";
            Size = new Size(300, 100);
            qrTextGroupBox.ResumeLayout(false);
            qrTextGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox qrTextGroupBox;
        private System.Windows.Forms.TextBox qrTextInput;
    }
}
