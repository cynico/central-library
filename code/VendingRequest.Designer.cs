
namespace CentralLibrary
{
    partial class VendingRequest
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
            this.branchlabel = new System.Windows.Forms.Label();
            this.confirmationPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.newRequestValidation = new System.Windows.Forms.Label();
            this.addRequestButton = new System.Windows.Forms.Button();
            this.vendorlabel = new System.Windows.Forms.Label();
            this.addlabel = new System.Windows.Forms.Label();
            this.vendorcombobox = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.toppanel = new System.Windows.Forms.Panel();
            this.branchcombobox = new System.Windows.Forms.ComboBox();
            this.confirmationpanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.addBookButton = new System.Windows.Forms.Button();
            this.removeBookButton = new System.Windows.Forms.Button();
            this.addRemovePanel = new System.Windows.Forms.Panel();
            this.booklistpanel = new System.Windows.Forms.Panel();
            this.toppanel.SuspendLayout();
            this.confirmationpanel.SuspendLayout();
            this.addRemovePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // branchlabel
            // 
            this.branchlabel.AutoSize = true;
            this.branchlabel.BackColor = System.Drawing.Color.White;
            this.branchlabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.branchlabel.Location = new System.Drawing.Point(380, 85);
            this.branchlabel.Name = "branchlabel";
            this.branchlabel.Size = new System.Drawing.Size(76, 22);
            this.branchlabel.TabIndex = 88;
            this.branchlabel.Text = "Branch";
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
            this.confirmationPassword.Size = new System.Drawing.Size(361, 31);
            this.confirmationPassword.TabIndex = 77;
            this.confirmationPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            // newRequestValidation
            // 
            this.newRequestValidation.AutoSize = true;
            this.newRequestValidation.BackColor = System.Drawing.Color.White;
            this.newRequestValidation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.newRequestValidation.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.newRequestValidation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.newRequestValidation.Location = new System.Drawing.Point(14, 56);
            this.newRequestValidation.Name = "newRequestValidation";
            this.newRequestValidation.Size = new System.Drawing.Size(216, 17);
            this.newRequestValidation.TabIndex = 84;
            this.newRequestValidation.Text = " Please Enter A Valid Email Address.";
            this.newRequestValidation.Visible = false;
            // 
            // addRequestButton
            // 
            this.addRequestButton.AccessibleDescription = "";
            this.addRequestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.addRequestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRequestButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRequestButton.ForeColor = System.Drawing.Color.White;
            this.addRequestButton.Location = new System.Drawing.Point(17, 125);
            this.addRequestButton.Name = "addRequestButton";
            this.addRequestButton.Size = new System.Drawing.Size(213, 40);
            this.addRequestButton.TabIndex = 78;
            this.addRequestButton.Text = "Add";
            this.addRequestButton.UseVisualStyleBackColor = false;
            this.addRequestButton.Click += new System.EventHandler(this.addRequestButton_Click);
            // 
            // vendorlabel
            // 
            this.vendorlabel.AutoSize = true;
            this.vendorlabel.BackColor = System.Drawing.Color.White;
            this.vendorlabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.vendorlabel.Location = new System.Drawing.Point(16, 85);
            this.vendorlabel.Name = "vendorlabel";
            this.vendorlabel.Size = new System.Drawing.Size(80, 22);
            this.vendorlabel.TabIndex = 80;
            this.vendorlabel.Text = "Vendor";
            // 
            // addlabel
            // 
            this.addlabel.AutoSize = true;
            this.addlabel.BackColor = System.Drawing.Color.White;
            this.addlabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.addlabel.Location = new System.Drawing.Point(11, 13);
            this.addlabel.Name = "addlabel";
            this.addlabel.Size = new System.Drawing.Size(240, 33);
            this.addlabel.TabIndex = 79;
            this.addlabel.Text = "Vending Request";
            // 
            // vendorcombobox
            // 
            this.vendorcombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vendorcombobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vendorcombobox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorcombobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.vendorcombobox.FormattingEnabled = true;
            this.vendorcombobox.Location = new System.Drawing.Point(15, 122);
            this.vendorcombobox.Name = "vendorcombobox";
            this.vendorcombobox.Size = new System.Drawing.Size(299, 29);
            this.vendorcombobox.TabIndex = 89;
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
            this.comboBox2.TabIndex = 90;
            // 
            // toppanel
            // 
            this.toppanel.Controls.Add(this.branchcombobox);
            this.toppanel.Controls.Add(this.branchlabel);
            this.toppanel.Controls.Add(this.addlabel);
            this.toppanel.Controls.Add(this.vendorlabel);
            this.toppanel.Controls.Add(this.vendorcombobox);
            this.toppanel.Controls.Add(this.newRequestValidation);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(640, 178);
            this.toppanel.TabIndex = 91;
            this.toppanel.Paint += new System.Windows.Forms.PaintEventHandler(this.toppanel_Paint);
            // 
            // branchcombobox
            // 
            this.branchcombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.branchcombobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.branchcombobox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchcombobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.branchcombobox.FormattingEnabled = true;
            this.branchcombobox.Location = new System.Drawing.Point(384, 122);
            this.branchcombobox.Name = "branchcombobox";
            this.branchcombobox.Size = new System.Drawing.Size(178, 29);
            this.branchcombobox.TabIndex = 90;
            // 
            // confirmationpanel
            // 
            this.confirmationpanel.Controls.Add(this.button1);
            this.confirmationpanel.Controls.Add(this.label1);
            this.confirmationpanel.Controls.Add(this.addRequestButton);
            this.confirmationpanel.Controls.Add(this.confirmationPassword);
            this.confirmationpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.confirmationpanel.Location = new System.Drawing.Point(0, 593);
            this.confirmationpanel.Name = "confirmationpanel";
            this.confirmationpanel.Size = new System.Drawing.Size(640, 199);
            this.confirmationpanel.TabIndex = 92;
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "";
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(413, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 40);
            this.button1.TabIndex = 86;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addBookButton
            // 
            this.addBookButton.AccessibleDescription = "";
            this.addBookButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.addBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBookButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBookButton.ForeColor = System.Drawing.Color.White;
            this.addBookButton.Location = new System.Drawing.Point(483, 17);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(136, 40);
            this.addBookButton.TabIndex = 79;
            this.addBookButton.Text = "Add Book";
            this.addBookButton.UseVisualStyleBackColor = false;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // removeBookButton
            // 
            this.removeBookButton.AccessibleDescription = "";
            this.removeBookButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.removeBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBookButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBookButton.ForeColor = System.Drawing.Color.White;
            this.removeBookButton.Location = new System.Drawing.Point(20, 17);
            this.removeBookButton.Name = "removeBookButton";
            this.removeBookButton.Size = new System.Drawing.Size(136, 40);
            this.removeBookButton.TabIndex = 81;
            this.removeBookButton.Text = "Remove Book";
            this.removeBookButton.UseVisualStyleBackColor = false;
            this.removeBookButton.Click += new System.EventHandler(this.removeBookButton_Click);
            // 
            // addRemovePanel
            // 
            this.addRemovePanel.BackColor = System.Drawing.Color.White;
            this.addRemovePanel.Controls.Add(this.removeBookButton);
            this.addRemovePanel.Controls.Add(this.addBookButton);
            this.addRemovePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addRemovePanel.Location = new System.Drawing.Point(0, 518);
            this.addRemovePanel.Name = "addRemovePanel";
            this.addRemovePanel.Size = new System.Drawing.Size(640, 75);
            this.addRemovePanel.TabIndex = 94;
            // 
            // booklistpanel
            // 
            this.booklistpanel.AutoScroll = true;
            this.booklistpanel.AutoSize = true;
            this.booklistpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.booklistpanel.Location = new System.Drawing.Point(0, 178);
            this.booklistpanel.Name = "booklistpanel";
            this.booklistpanel.Size = new System.Drawing.Size(640, 340);
            this.booklistpanel.TabIndex = 95;
            // 
            // VendingRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 792);
            this.Controls.Add(this.booklistpanel);
            this.Controls.Add(this.addRemovePanel);
            this.Controls.Add(this.confirmationpanel);
            this.Controls.Add(this.toppanel);
            this.Controls.Add(this.comboBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VendingRequest";
            this.Text = "vendingrequest";
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            this.confirmationpanel.ResumeLayout(false);
            this.confirmationpanel.PerformLayout();
            this.addRemovePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label branchlabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox confirmationPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label newRequestValidation;
        private System.Windows.Forms.Button addRequestButton;
        private System.Windows.Forms.Label vendorlabel;
        private System.Windows.Forms.Label addlabel;
        private System.Windows.Forms.ComboBox vendorcombobox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Panel confirmationpanel;
        private System.Windows.Forms.ComboBox branchcombobox;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.Button removeBookButton;
        private System.Windows.Forms.Panel addRemovePanel;
        private System.Windows.Forms.Panel booklistpanel;
        private System.Windows.Forms.Button button1;
    }
}