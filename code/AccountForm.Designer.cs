
namespace CentralLibrary
{
    partial class AccountForm
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
            this.label17 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.accountpass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.accountrepass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.accountcurrpass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.accountsavechanges = new System.Windows.Forms.Button();
            this.accountvalidation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteAccount = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.label17.Location = new System.Drawing.Point(12, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(236, 33);
            this.label17.TabIndex = 41;
            this.label17.Text = "Account Settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.label4.Location = new System.Drawing.Point(14, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 22);
            this.label4.TabIndex = 45;
            this.label4.Text = "Change Password";
            // 
            // accountpass
            // 
            this.accountpass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.accountpass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.accountpass.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.accountpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.accountpass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.accountpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.accountpass.HintForeColor = System.Drawing.Color.Gray;
            this.accountpass.HintText = "12345678";
            this.accountpass.isPassword = true;
            this.accountpass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.accountpass.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.accountpass.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.accountpass.LineThickness = 3;
            this.accountpass.Location = new System.Drawing.Point(13, 168);
            this.accountpass.Margin = new System.Windows.Forms.Padding(4);
            this.accountpass.MaxLength = 32767;
            this.accountpass.Name = "accountpass";
            this.accountpass.Size = new System.Drawing.Size(230, 31);
            this.accountpass.TabIndex = 46;
            this.accountpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // accountrepass
            // 
            this.accountrepass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.accountrepass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.accountrepass.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.accountrepass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.accountrepass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.accountrepass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.accountrepass.HintForeColor = System.Drawing.Color.Gray;
            this.accountrepass.HintText = "12345678";
            this.accountrepass.isPassword = true;
            this.accountrepass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.accountrepass.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.accountrepass.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.accountrepass.LineThickness = 3;
            this.accountrepass.Location = new System.Drawing.Point(273, 168);
            this.accountrepass.Margin = new System.Windows.Forms.Padding(4);
            this.accountrepass.MaxLength = 32767;
            this.accountrepass.Name = "accountrepass";
            this.accountrepass.Size = new System.Drawing.Size(230, 31);
            this.accountrepass.TabIndex = 47;
            this.accountrepass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // accountcurrpass
            // 
            this.accountcurrpass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.accountcurrpass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.accountcurrpass.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.accountcurrpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.accountcurrpass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.accountcurrpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.accountcurrpass.HintForeColor = System.Drawing.Color.Gray;
            this.accountcurrpass.HintText = "12345678";
            this.accountcurrpass.isPassword = true;
            this.accountcurrpass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.accountcurrpass.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.accountcurrpass.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.accountcurrpass.LineThickness = 3;
            this.accountcurrpass.Location = new System.Drawing.Point(18, 245);
            this.accountcurrpass.Margin = new System.Windows.Forms.Padding(4);
            this.accountcurrpass.MaxLength = 32767;
            this.accountcurrpass.Name = "accountcurrpass";
            this.accountcurrpass.Size = new System.Drawing.Size(485, 31);
            this.accountcurrpass.TabIndex = 48;
            this.accountcurrpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // accountsavechanges
            // 
            this.accountsavechanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.accountsavechanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountsavechanges.ForeColor = System.Drawing.Color.White;
            this.accountsavechanges.Location = new System.Drawing.Point(18, 307);
            this.accountsavechanges.Name = "accountsavechanges";
            this.accountsavechanges.Size = new System.Drawing.Size(161, 33);
            this.accountsavechanges.TabIndex = 49;
            this.accountsavechanges.Text = "Save Changes";
            this.accountsavechanges.UseVisualStyleBackColor = false;
            this.accountsavechanges.Click += new System.EventHandler(this.accountsavechanges_Click);
            // 
            // accountvalidation
            // 
            this.accountvalidation.AutoSize = true;
            this.accountvalidation.BackColor = System.Drawing.Color.White;
            this.accountvalidation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.accountvalidation.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.accountvalidation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.accountvalidation.Location = new System.Drawing.Point(15, 63);
            this.accountvalidation.Name = "accountvalidation";
            this.accountvalidation.Size = new System.Drawing.Size(190, 17);
            this.accountvalidation.TabIndex = 50;
            this.accountvalidation.Text = "Password should not be empty.";
            this.accountvalidation.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.label1.Location = new System.Drawing.Point(14, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 21);
            this.label1.TabIndex = 51;
            this.label1.Text = "Current Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.label2.Location = new System.Drawing.Point(9, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 52;
            this.label2.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.label3.Location = new System.Drawing.Point(269, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 21);
            this.label3.TabIndex = 53;
            this.label3.Text = "Re-enter new password";
            // 
            // deleteAccount
            // 
            this.deleteAccount.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.deleteAccount.AutoSize = true;
            this.deleteAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAccount.LinkColor = System.Drawing.Color.DimGray;
            this.deleteAccount.Location = new System.Drawing.Point(14, 751);
            this.deleteAccount.Name = "deleteAccount";
            this.deleteAccount.Size = new System.Drawing.Size(260, 21);
            this.deleteAccount.TabIndex = 54;
            this.deleteAccount.TabStop = true;
            this.deleteAccount.Text = "Resign and delete your account";
            this.deleteAccount.Visible = false;
            this.deleteAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.deleteAccount_LinkClicked);
            // 
            // owneraccountform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 792);
            this.Controls.Add(this.deleteAccount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accountvalidation);
            this.Controls.Add(this.accountsavechanges);
            this.Controls.Add(this.accountcurrpass);
            this.Controls.Add(this.accountrepass);
            this.Controls.Add(this.accountpass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label17);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "owneraccountform";
            this.Text = "owneraccountform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox accountpass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox accountrepass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox accountcurrpass;
        private System.Windows.Forms.Button accountsavechanges;
        private System.Windows.Forms.Label accountvalidation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel deleteAccount;
    }
}