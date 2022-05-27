
namespace CentralLibrary
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.changepicture = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.profileemail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.doblabel = new System.Windows.Forms.Label();
            this.dobDatePicker = new System.Windows.Forms.DateTimePicker();
            this.genderlabel = new System.Windows.Forms.Label();
            this.profileGenderCombo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.profilepasswordtextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.savechanges = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.validationLabel = new System.Windows.Forms.Label();
            this.profilelastname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.profilefirstname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.vendorName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.vendorAddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.vendorphoneNumber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // changepicture
            // 
            this.changepicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.changepicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changepicture.ForeColor = System.Drawing.Color.White;
            this.changepicture.Location = new System.Drawing.Point(36, 221);
            this.changepicture.Name = "changepicture";
            this.changepicture.Size = new System.Drawing.Size(114, 33);
            this.changepicture.TabIndex = 6;
            this.changepicture.Text = "Upload Picture";
            this.changepicture.UseVisualStyleBackColor = false;
            this.changepicture.Click += new System.EventHandler(this.changepicture_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.label15.Location = new System.Drawing.Point(187, 170);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 22);
            this.label15.TabIndex = 28;
            this.label15.Text = "Email";
            // 
            // profileemail
            // 
            this.profileemail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.profileemail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.profileemail.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.profileemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.profileemail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.profileemail.ForeColor = System.Drawing.Color.Black;
            this.profileemail.HintForeColor = System.Drawing.Color.Gray;
            this.profileemail.HintText = "Email";
            this.profileemail.isPassword = false;
            this.profileemail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.profileemail.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.profileemail.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.profileemail.LineThickness = 3;
            this.profileemail.Location = new System.Drawing.Point(191, 196);
            this.profileemail.Margin = new System.Windows.Forms.Padding(4);
            this.profileemail.MaxLength = 32767;
            this.profileemail.Name = "profileemail";
            this.profileemail.Size = new System.Drawing.Size(297, 31);
            this.profileemail.TabIndex = 3;
            this.profileemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // doblabel
            // 
            this.doblabel.AutoSize = true;
            this.doblabel.BackColor = System.Drawing.Color.White;
            this.doblabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doblabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.doblabel.Location = new System.Drawing.Point(187, 330);
            this.doblabel.Name = "doblabel";
            this.doblabel.Size = new System.Drawing.Size(52, 22);
            this.doblabel.TabIndex = 33;
            this.doblabel.Text = "DOB";
            // 
            // dobDatePicker
            // 
            this.dobDatePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.dobDatePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.dobDatePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.dobDatePicker.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.dobDatePicker.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobDatePicker.Location = new System.Drawing.Point(191, 355);
            this.dobDatePicker.Name = "dobDatePicker";
            this.dobDatePicker.Size = new System.Drawing.Size(297, 21);
            this.dobDatePicker.TabIndex = 5;
            // 
            // genderlabel
            // 
            this.genderlabel.AutoSize = true;
            this.genderlabel.BackColor = System.Drawing.Color.White;
            this.genderlabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.genderlabel.Location = new System.Drawing.Point(187, 256);
            this.genderlabel.Name = "genderlabel";
            this.genderlabel.Size = new System.Drawing.Size(82, 22);
            this.genderlabel.TabIndex = 35;
            this.genderlabel.Text = "Gender";
            // 
            // profileGenderCombo
            // 
            this.profileGenderCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.profileGenderCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileGenderCombo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileGenderCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.profileGenderCombo.FormattingEnabled = true;
            this.profileGenderCombo.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.profileGenderCombo.Location = new System.Drawing.Point(191, 281);
            this.profileGenderCombo.Name = "profileGenderCombo";
            this.profileGenderCombo.Size = new System.Drawing.Size(121, 29);
            this.profileGenderCombo.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.label7.Location = new System.Drawing.Point(187, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 22);
            this.label7.TabIndex = 37;
            this.label7.Text = "Current Password";
            // 
            // profilepasswordtextbox
            // 
            this.profilepasswordtextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.profilepasswordtextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.profilepasswordtextbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.profilepasswordtextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.profilepasswordtextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.profilepasswordtextbox.ForeColor = System.Drawing.Color.Black;
            this.profilepasswordtextbox.HintForeColor = System.Drawing.Color.Gray;
            this.profilepasswordtextbox.HintText = "Password";
            this.profilepasswordtextbox.isPassword = true;
            this.profilepasswordtextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.profilepasswordtextbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.profilepasswordtextbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.profilepasswordtextbox.LineThickness = 3;
            this.profilepasswordtextbox.Location = new System.Drawing.Point(191, 442);
            this.profilepasswordtextbox.Margin = new System.Windows.Forms.Padding(4);
            this.profilepasswordtextbox.MaxLength = 32767;
            this.profilepasswordtextbox.Name = "profilepasswordtextbox";
            this.profilepasswordtextbox.Size = new System.Drawing.Size(297, 31);
            this.profilepasswordtextbox.TabIndex = 7;
            this.profilepasswordtextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // savechanges
            // 
            this.savechanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.savechanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savechanges.ForeColor = System.Drawing.Color.White;
            this.savechanges.Location = new System.Drawing.Point(191, 499);
            this.savechanges.Name = "savechanges";
            this.savechanges.Size = new System.Drawing.Size(297, 33);
            this.savechanges.TabIndex = 8;
            this.savechanges.Text = "Save Changes";
            this.savechanges.UseVisualStyleBackColor = false;
            this.savechanges.Click += new System.EventHandler(this.savechanges_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.label17.Location = new System.Drawing.Point(39, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(151, 33);
            this.label17.TabIndex = 40;
            this.label17.Text = "Edit Profile";
            // 
            // validationLabel
            // 
            this.validationLabel.AutoSize = true;
            this.validationLabel.BackColor = System.Drawing.Color.White;
            this.validationLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.validationLabel.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.validationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.validationLabel.Location = new System.Drawing.Point(42, 54);
            this.validationLabel.Name = "validationLabel";
            this.validationLabel.Size = new System.Drawing.Size(216, 17);
            this.validationLabel.TabIndex = 43;
            this.validationLabel.Text = " Please Enter A Valid Email Address.";
            this.validationLabel.Visible = false;
            // 
            // profilelastname
            // 
            this.profilelastname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.profilelastname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.profilelastname.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.profilelastname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.profilelastname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.profilelastname.ForeColor = System.Drawing.Color.Black;
            this.profilelastname.HintForeColor = System.Drawing.Color.Gray;
            this.profilelastname.HintText = "Last Name";
            this.profilelastname.isPassword = false;
            this.profilelastname.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.profilelastname.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.profilelastname.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.profilelastname.LineThickness = 3;
            this.profilelastname.Location = new System.Drawing.Point(390, 114);
            this.profilelastname.Margin = new System.Windows.Forms.Padding(4);
            this.profilelastname.MaxLength = 32767;
            this.profilelastname.Name = "profilelastname";
            this.profilelastname.Size = new System.Drawing.Size(161, 31);
            this.profilelastname.TabIndex = 2;
            this.profilelastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // profilefirstname
            // 
            this.profilefirstname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.profilefirstname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.profilefirstname.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.profilefirstname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.profilefirstname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.profilefirstname.ForeColor = System.Drawing.Color.Black;
            this.profilefirstname.HintForeColor = System.Drawing.Color.Gray;
            this.profilefirstname.HintText = "First Name";
            this.profilefirstname.isPassword = false;
            this.profilefirstname.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.profilefirstname.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.profilefirstname.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.profilefirstname.LineThickness = 3;
            this.profilefirstname.Location = new System.Drawing.Point(191, 114);
            this.profilefirstname.Margin = new System.Windows.Forms.Padding(4);
            this.profilefirstname.MaxLength = 32767;
            this.profilefirstname.Name = "profilefirstname";
            this.profilefirstname.Size = new System.Drawing.Size(161, 31);
            this.profilefirstname.TabIndex = 1;
            this.profilefirstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.label4.Location = new System.Drawing.Point(187, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 22);
            this.label4.TabIndex = 44;
            this.label4.Text = "User name";
            // 
            // vendorName
            // 
            this.vendorName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.vendorName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.vendorName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.vendorName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.vendorName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.vendorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vendorName.HintForeColor = System.Drawing.Color.Gray;
            this.vendorName.HintText = "Email";
            this.vendorName.isPassword = false;
            this.vendorName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.vendorName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.vendorName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.vendorName.LineThickness = 3;
            this.vendorName.Location = new System.Drawing.Point(191, 114);
            this.vendorName.Margin = new System.Windows.Forms.Padding(4);
            this.vendorName.MaxLength = 32767;
            this.vendorName.Name = "vendorName";
            this.vendorName.Size = new System.Drawing.Size(297, 31);
            this.vendorName.TabIndex = 45;
            this.vendorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.vendorName.Visible = false;
            // 
            // vendorAddress
            // 
            this.vendorAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.vendorAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.vendorAddress.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.vendorAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.vendorAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.vendorAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vendorAddress.HintForeColor = System.Drawing.Color.Gray;
            this.vendorAddress.HintText = "Email";
            this.vendorAddress.isPassword = false;
            this.vendorAddress.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.vendorAddress.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.vendorAddress.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.vendorAddress.LineThickness = 3;
            this.vendorAddress.Location = new System.Drawing.Point(191, 282);
            this.vendorAddress.Margin = new System.Windows.Forms.Padding(4);
            this.vendorAddress.MaxLength = 32767;
            this.vendorAddress.Name = "vendorAddress";
            this.vendorAddress.Size = new System.Drawing.Size(297, 31);
            this.vendorAddress.TabIndex = 46;
            this.vendorAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.vendorAddress.Visible = false;
            // 
            // vendorphoneNumber
            // 
            this.vendorphoneNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.vendorphoneNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.vendorphoneNumber.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.vendorphoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.vendorphoneNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.vendorphoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vendorphoneNumber.HintForeColor = System.Drawing.Color.Gray;
            this.vendorphoneNumber.HintText = "Email";
            this.vendorphoneNumber.isPassword = false;
            this.vendorphoneNumber.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.vendorphoneNumber.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.vendorphoneNumber.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.vendorphoneNumber.LineThickness = 3;
            this.vendorphoneNumber.Location = new System.Drawing.Point(191, 356);
            this.vendorphoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.vendorphoneNumber.MaxLength = 32767;
            this.vendorphoneNumber.Name = "vendorphoneNumber";
            this.vendorphoneNumber.Size = new System.Drawing.Size(297, 31);
            this.vendorphoneNumber.TabIndex = 47;
            this.vendorphoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.vendorphoneNumber.Visible = false;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 792);
            this.Controls.Add(this.vendorphoneNumber);
            this.Controls.Add(this.vendorAddress);
            this.Controls.Add(this.vendorName);
            this.Controls.Add(this.profilelastname);
            this.Controls.Add(this.profilefirstname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.validationLabel);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.savechanges);
            this.Controls.Add(this.profilepasswordtextbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.profileGenderCombo);
            this.Controls.Add(this.genderlabel);
            this.Controls.Add(this.dobDatePicker);
            this.Controls.Add(this.doblabel);
            this.Controls.Add(this.profileemail);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.changepicture);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfileForm";
            this.Text = "profileForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button changepicture;
        private System.Windows.Forms.Label label15;
        private Bunifu.Framework.UI.BunifuMaterialTextbox profileemail;
        private System.Windows.Forms.Label doblabel;
        private System.Windows.Forms.DateTimePicker dobDatePicker;
        private System.Windows.Forms.Label genderlabel;
        private System.Windows.Forms.ComboBox profileGenderCombo;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox profilepasswordtextbox;
        private System.Windows.Forms.Button savechanges;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label validationLabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox profilelastname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox profilefirstname;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox vendorName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox vendorAddress;
        private Bunifu.Framework.UI.BunifuMaterialTextbox vendorphoneNumber;
    }
}