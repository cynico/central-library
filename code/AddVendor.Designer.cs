
namespace CentralLibrary
{
    partial class AddVendor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.confirmationPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.newVendorValidation = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.newVendorEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.newVendorName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.addlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newVendorAddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.newVendorPhone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.newbranchComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(3, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(642, 2);
            this.label3.TabIndex = 86;
            // 
            // confirmationPassword
            // 
            this.confirmationPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.confirmationPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.confirmationPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.confirmationPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirmationPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.confirmationPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.confirmationPassword.HintForeColor = System.Drawing.Color.Gray;
            this.confirmationPassword.HintText = "Password";
            this.confirmationPassword.isPassword = true;
            this.confirmationPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.confirmationPassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.confirmationPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.confirmationPassword.LineThickness = 3;
            this.confirmationPassword.Location = new System.Drawing.Point(30, 561);
            this.confirmationPassword.Margin = new System.Windows.Forms.Padding(4);
            this.confirmationPassword.MaxLength = 32767;
            this.confirmationPassword.Name = "confirmationPassword";
            this.confirmationPassword.Size = new System.Drawing.Size(341, 31);
            this.confirmationPassword.TabIndex = 6;
            this.confirmationPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.label1.Location = new System.Drawing.Point(25, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 22);
            this.label1.TabIndex = 85;
            this.label1.Text = "Enter your password for confirmation";
            // 
            // newVendorValidation
            // 
            this.newVendorValidation.AutoSize = true;
            this.newVendorValidation.BackColor = System.Drawing.Color.White;
            this.newVendorValidation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.newVendorValidation.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.newVendorValidation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.newVendorValidation.Location = new System.Drawing.Point(26, 67);
            this.newVendorValidation.Name = "newVendorValidation";
            this.newVendorValidation.Size = new System.Drawing.Size(216, 17);
            this.newVendorValidation.TabIndex = 84;
            this.newVendorValidation.Text = " Please Enter A Valid Email Address.";
            this.newVendorValidation.Visible = false;
            // 
            // addButton
            // 
            this.addButton.AccessibleDescription = "";
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(27, 740);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(215, 40);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // newVendorEmail
            // 
            this.newVendorEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.newVendorEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.newVendorEmail.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.newVendorEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newVendorEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.newVendorEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newVendorEmail.HintForeColor = System.Drawing.Color.Gray;
            this.newVendorEmail.HintText = "Email";
            this.newVendorEmail.isPassword = false;
            this.newVendorEmail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.newVendorEmail.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.newVendorEmail.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.newVendorEmail.LineThickness = 3;
            this.newVendorEmail.Location = new System.Drawing.Point(27, 210);
            this.newVendorEmail.Margin = new System.Windows.Forms.Padding(4);
            this.newVendorEmail.MaxLength = 32767;
            this.newVendorEmail.Name = "newVendorEmail";
            this.newVendorEmail.Size = new System.Drawing.Size(477, 31);
            this.newVendorEmail.TabIndex = 2;
            this.newVendorEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.label6.Location = new System.Drawing.Point(26, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 22);
            this.label6.TabIndex = 81;
            this.label6.Text = "Email";
            // 
            // newVendorName
            // 
            this.newVendorName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.newVendorName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.newVendorName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.newVendorName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newVendorName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.newVendorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newVendorName.HintForeColor = System.Drawing.Color.Gray;
            this.newVendorName.HintText = "Vendor Name";
            this.newVendorName.isPassword = false;
            this.newVendorName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.newVendorName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.newVendorName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.newVendorName.LineThickness = 3;
            this.newVendorName.Location = new System.Drawing.Point(27, 132);
            this.newVendorName.Margin = new System.Windows.Forms.Padding(4);
            this.newVendorName.MaxLength = 32767;
            this.newVendorName.Name = "newVendorName";
            this.newVendorName.Size = new System.Drawing.Size(477, 31);
            this.newVendorName.TabIndex = 1;
            this.newVendorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.label4.Location = new System.Drawing.Point(25, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 22);
            this.label4.TabIndex = 80;
            this.label4.Text = "Name";
            // 
            // addlabel
            // 
            this.addlabel.AutoSize = true;
            this.addlabel.BackColor = System.Drawing.Color.White;
            this.addlabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.addlabel.Location = new System.Drawing.Point(23, 25);
            this.addlabel.Name = "addlabel";
            this.addlabel.Size = new System.Drawing.Size(279, 33);
            this.addlabel.TabIndex = 79;
            this.addlabel.Text = "Add A New Vendor ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.label2.Location = new System.Drawing.Point(26, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 89;
            this.label2.Text = "Address";
            // 
            // newVendorAddress
            // 
            this.newVendorAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.newVendorAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.newVendorAddress.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.newVendorAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newVendorAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.newVendorAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newVendorAddress.HintForeColor = System.Drawing.Color.Gray;
            this.newVendorAddress.HintText = "Adress";
            this.newVendorAddress.isPassword = false;
            this.newVendorAddress.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.newVendorAddress.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.newVendorAddress.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.newVendorAddress.LineThickness = 3;
            this.newVendorAddress.Location = new System.Drawing.Point(27, 294);
            this.newVendorAddress.Margin = new System.Windows.Forms.Padding(4);
            this.newVendorAddress.MaxLength = 32767;
            this.newVendorAddress.Name = "newVendorAddress";
            this.newVendorAddress.Size = new System.Drawing.Size(477, 31);
            this.newVendorAddress.TabIndex = 3;
            this.newVendorAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CloseButton
            // 
            this.CloseButton.AccessibleDescription = "";
            this.CloseButton.BackColor = System.Drawing.Color.DimGray;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(403, 740);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(215, 40);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.label5.Location = new System.Drawing.Point(26, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 22);
            this.label5.TabIndex = 93;
            this.label5.Text = "Phone Number";
            // 
            // newVendorPhone
            // 
            this.newVendorPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.newVendorPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.newVendorPhone.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.newVendorPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newVendorPhone.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.newVendorPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newVendorPhone.HintForeColor = System.Drawing.Color.Gray;
            this.newVendorPhone.HintText = "+201234567890";
            this.newVendorPhone.isPassword = false;
            this.newVendorPhone.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.newVendorPhone.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.newVendorPhone.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.newVendorPhone.LineThickness = 3;
            this.newVendorPhone.Location = new System.Drawing.Point(27, 385);
            this.newVendorPhone.Margin = new System.Windows.Forms.Padding(4);
            this.newVendorPhone.MaxLength = 32767;
            this.newVendorPhone.Name = "newVendorPhone";
            this.newVendorPhone.Size = new System.Drawing.Size(244, 31);
            this.newVendorPhone.TabIndex = 4;
            this.newVendorPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.label11.Location = new System.Drawing.Point(332, 344);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 22);
            this.label11.TabIndex = 88;
            this.label11.Text = "Initial Contract";
            // 
            // newbranchComboBox
            // 
            this.newbranchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newbranchComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newbranchComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newbranchComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.newbranchComboBox.FormattingEnabled = true;
            this.newbranchComboBox.Location = new System.Drawing.Point(336, 385);
            this.newbranchComboBox.Name = "newbranchComboBox";
            this.newbranchComboBox.Size = new System.Drawing.Size(168, 29);
            this.newbranchComboBox.TabIndex = 5;
            // 
            // AddVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 792);
            this.Controls.Add(this.newVendorPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.newbranchComboBox);
            this.Controls.Add(this.newVendorAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.confirmationPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newVendorValidation);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.newVendorEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.newVendorName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddVendor";
            this.Text = "addVendor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox confirmationPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label newVendorValidation;
        private System.Windows.Forms.Button addButton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox newVendorEmail;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox newVendorName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label addlabel;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox newVendorAddress;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox newVendorPhone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox newbranchComboBox;
    }
}