
namespace CentralLibrary
{
    partial class CreateBusinessMeeting
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
            this.booklistpanel = new System.Windows.Forms.Panel();
            this.adminsListBox = new System.Windows.Forms.CheckedListBox();
            this.confirmationpanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.createMeetingButton = new System.Windows.Forms.Button();
            this.confirmationPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.createmeetinglabel = new System.Windows.Forms.Label();
            this.vendorlabel = new System.Windows.Forms.Label();
            this.createmeetingvalidation = new System.Windows.Forms.Label();
            this.toppanel = new System.Windows.Forms.Panel();
            this.description_textbox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.titletextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.timepicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.datepicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.branchComboBox = new System.Windows.Forms.ComboBox();
            this.booklistpanel.SuspendLayout();
            this.confirmationpanel.SuspendLayout();
            this.toppanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // booklistpanel
            // 
            this.booklistpanel.AutoScroll = true;
            this.booklistpanel.AutoSize = true;
            this.booklistpanel.Controls.Add(this.adminsListBox);
            this.booklistpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.booklistpanel.Location = new System.Drawing.Point(0, 395);
            this.booklistpanel.Name = "booklistpanel";
            this.booklistpanel.Size = new System.Drawing.Size(640, 198);
            this.booklistpanel.TabIndex = 100;
            // 
            // adminsListBox
            // 
            this.adminsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminsListBox.FormattingEnabled = true;
            this.adminsListBox.Location = new System.Drawing.Point(0, 0);
            this.adminsListBox.Name = "adminsListBox";
            this.adminsListBox.Size = new System.Drawing.Size(640, 198);
            this.adminsListBox.TabIndex = 5;
            // 
            // confirmationpanel
            // 
            this.confirmationpanel.Controls.Add(this.CloseButton);
            this.confirmationpanel.Controls.Add(this.label1);
            this.confirmationpanel.Controls.Add(this.createMeetingButton);
            this.confirmationpanel.Controls.Add(this.confirmationPassword);
            this.confirmationpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.confirmationpanel.Location = new System.Drawing.Point(0, 593);
            this.confirmationpanel.Name = "confirmationpanel";
            this.confirmationpanel.Size = new System.Drawing.Size(640, 199);
            this.confirmationpanel.TabIndex = 98;
            // 
            // CloseButton
            // 
            this.CloseButton.AccessibleDescription = "";
            this.CloseButton.BackColor = System.Drawing.Color.DimGray;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(415, 125);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(213, 40);
            this.CloseButton.TabIndex = 86;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 22);
            this.label1.TabIndex = 85;
            this.label1.Text = "Enter your password for confirmation";
            // 
            // createMeetingButton
            // 
            this.createMeetingButton.AccessibleDescription = "";
            this.createMeetingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.createMeetingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMeetingButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createMeetingButton.ForeColor = System.Drawing.Color.White;
            this.createMeetingButton.Location = new System.Drawing.Point(17, 125);
            this.createMeetingButton.Name = "createMeetingButton";
            this.createMeetingButton.Size = new System.Drawing.Size(213, 40);
            this.createMeetingButton.TabIndex = 7;
            this.createMeetingButton.Text = "Create";
            this.createMeetingButton.UseVisualStyleBackColor = false;
            this.createMeetingButton.Click += new System.EventHandler(this.createMeetingButton_Click);
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
            this.confirmationPassword.Location = new System.Drawing.Point(15, 69);
            this.confirmationPassword.Margin = new System.Windows.Forms.Padding(4);
            this.confirmationPassword.MaxLength = 32767;
            this.confirmationPassword.Name = "confirmationPassword";
            this.confirmationPassword.Size = new System.Drawing.Size(341, 31);
            this.confirmationPassword.TabIndex = 6;
            this.confirmationPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.comboBox2.Location = new System.Drawing.Point(281, 677);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(233, 29);
            this.comboBox2.TabIndex = 96;
            // 
            // createmeetinglabel
            // 
            this.createmeetinglabel.AutoSize = true;
            this.createmeetinglabel.BackColor = System.Drawing.Color.White;
            this.createmeetinglabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createmeetinglabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.createmeetinglabel.Location = new System.Drawing.Point(11, 13);
            this.createmeetinglabel.Name = "createmeetinglabel";
            this.createmeetinglabel.Size = new System.Drawing.Size(358, 33);
            this.createmeetinglabel.TabIndex = 79;
            this.createmeetinglabel.Text = "Creating Business Meeting";
            // 
            // vendorlabel
            // 
            this.vendorlabel.AutoSize = true;
            this.vendorlabel.BackColor = System.Drawing.Color.White;
            this.vendorlabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.vendorlabel.Location = new System.Drawing.Point(16, 85);
            this.vendorlabel.Name = "vendorlabel";
            this.vendorlabel.Size = new System.Drawing.Size(56, 22);
            this.vendorlabel.TabIndex = 80;
            this.vendorlabel.Text = "Date";
            // 
            // createmeetingvalidation
            // 
            this.createmeetingvalidation.AutoSize = true;
            this.createmeetingvalidation.BackColor = System.Drawing.Color.White;
            this.createmeetingvalidation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.createmeetingvalidation.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.createmeetingvalidation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.createmeetingvalidation.Location = new System.Drawing.Point(14, 56);
            this.createmeetingvalidation.Name = "createmeetingvalidation";
            this.createmeetingvalidation.Size = new System.Drawing.Size(216, 17);
            this.createmeetingvalidation.TabIndex = 84;
            this.createmeetingvalidation.Text = " Please Enter A Valid Email Address.";
            this.createmeetingvalidation.Visible = false;
            // 
            // toppanel
            // 
            this.toppanel.Controls.Add(this.branchComboBox);
            this.toppanel.Controls.Add(this.label5);
            this.toppanel.Controls.Add(this.description_textbox);
            this.toppanel.Controls.Add(this.label4);
            this.toppanel.Controls.Add(this.titletextbox);
            this.toppanel.Controls.Add(this.label3);
            this.toppanel.Controls.Add(this.timepicker);
            this.toppanel.Controls.Add(this.label2);
            this.toppanel.Controls.Add(this.datepicker);
            this.toppanel.Controls.Add(this.createmeetinglabel);
            this.toppanel.Controls.Add(this.vendorlabel);
            this.toppanel.Controls.Add(this.createmeetingvalidation);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(640, 395);
            this.toppanel.TabIndex = 97;
            // 
            // description_textbox
            // 
            this.description_textbox.Location = new System.Drawing.Point(16, 291);
            this.description_textbox.Name = "description_textbox";
            this.description_textbox.Size = new System.Drawing.Size(261, 98);
            this.description_textbox.TabIndex = 4;
            this.description_textbox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.label4.Location = new System.Drawing.Point(16, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 22);
            this.label4.TabIndex = 90;
            this.label4.Text = "Description";
            // 
            // titletextbox
            // 
            this.titletextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.titletextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.titletextbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.titletextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.titletextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.titletextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.titletextbox.HintForeColor = System.Drawing.Color.Gray;
            this.titletextbox.HintText = "Title Of The Meeting";
            this.titletextbox.isPassword = false;
            this.titletextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.titletextbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.titletextbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.titletextbox.LineThickness = 3;
            this.titletextbox.Location = new System.Drawing.Point(20, 197);
            this.titletextbox.Margin = new System.Windows.Forms.Padding(4);
            this.titletextbox.MaxLength = 32767;
            this.titletextbox.Name = "titletextbox";
            this.titletextbox.Size = new System.Drawing.Size(257, 31);
            this.titletextbox.TabIndex = 3;
            this.titletextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.label3.Location = new System.Drawing.Point(16, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 22);
            this.label3.TabIndex = 88;
            this.label3.Text = "Title";
            // 
            // timepicker
            // 
            this.timepicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timepicker.Location = new System.Drawing.Point(334, 121);
            this.timepicker.Name = "timepicker";
            this.timepicker.Size = new System.Drawing.Size(268, 20);
            this.timepicker.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.label2.Location = new System.Drawing.Point(330, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 22);
            this.label2.TabIndex = 86;
            this.label2.Text = "Time";
            // 
            // datepicker
            // 
            this.datepicker.Location = new System.Drawing.Point(20, 121);
            this.datepicker.Name = "datepicker";
            this.datepicker.Size = new System.Drawing.Size(210, 20);
            this.datepicker.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.label5.Location = new System.Drawing.Point(330, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 22);
            this.label5.TabIndex = 91;
            this.label5.Text = "Branch";
            // 
            // branchComboBox
            // 
            this.branchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.branchComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.branchComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.branchComboBox.FormattingEnabled = true;
            this.branchComboBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.branchComboBox.Location = new System.Drawing.Point(334, 199);
            this.branchComboBox.Name = "branchComboBox";
            this.branchComboBox.Size = new System.Drawing.Size(268, 29);
            this.branchComboBox.TabIndex = 93;
            // 
            // createbusinessmeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 792);
            this.Controls.Add(this.booklistpanel);
            this.Controls.Add(this.confirmationpanel);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.toppanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "createbusinessmeeting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "createbusinessmeeting";
            this.booklistpanel.ResumeLayout(false);
            this.confirmationpanel.ResumeLayout(false);
            this.confirmationpanel.PerformLayout();
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel booklistpanel;
        private System.Windows.Forms.Panel confirmationpanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createMeetingButton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox confirmationPassword;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label createmeetinglabel;
        private System.Windows.Forms.Label vendorlabel;
        private System.Windows.Forms.Label createmeetingvalidation;
        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.DateTimePicker datepicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker timepicker;
        private System.Windows.Forms.CheckedListBox adminsListBox;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox titletextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox description_textbox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox branchComboBox;
    }
}