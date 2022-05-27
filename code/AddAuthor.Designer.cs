
namespace CentralLibrary
{
    partial class AddAuthor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAuthor));
            this.CloseButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.confirmationPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.validationLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.authorNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.addlabel = new System.Windows.Forms.Label();
            this.changepicture = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.AccessibleDescription = "";
            this.CloseButton.BackColor = System.Drawing.Color.DimGray;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(403, 734);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(215, 40);
            this.CloseButton.TabIndex = 130;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(-1, 583);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(642, 2);
            this.label3.TabIndex = 136;
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
            this.confirmationPassword.Location = new System.Drawing.Point(27, 667);
            this.confirmationPassword.Margin = new System.Windows.Forms.Padding(4);
            this.confirmationPassword.MaxLength = 32767;
            this.confirmationPassword.Name = "confirmationPassword";
            this.confirmationPassword.Size = new System.Drawing.Size(341, 31);
            this.confirmationPassword.TabIndex = 128;
            this.confirmationPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.label1.Location = new System.Drawing.Point(23, 620);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 22);
            this.label1.TabIndex = 135;
            this.label1.Text = "Enter your password for confirmation";
            // 
            // validationLabel
            // 
            this.validationLabel.AutoSize = true;
            this.validationLabel.BackColor = System.Drawing.Color.White;
            this.validationLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.validationLabel.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.validationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.validationLabel.Location = new System.Drawing.Point(26, 61);
            this.validationLabel.Name = "validationLabel";
            this.validationLabel.Size = new System.Drawing.Size(216, 17);
            this.validationLabel.TabIndex = 134;
            this.validationLabel.Text = " Please Enter A Valid Email Address.";
            this.validationLabel.Visible = false;
            // 
            // addButton
            // 
            this.addButton.AccessibleDescription = "";
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(27, 734);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(215, 40);
            this.addButton.TabIndex = 129;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // authorNameTb
            // 
            this.authorNameTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.authorNameTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.authorNameTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.authorNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.authorNameTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.authorNameTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.authorNameTb.HintForeColor = System.Drawing.Color.Gray;
            this.authorNameTb.HintText = "Author Name";
            this.authorNameTb.isPassword = false;
            this.authorNameTb.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.authorNameTb.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.authorNameTb.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.authorNameTb.LineThickness = 3;
            this.authorNameTb.Location = new System.Drawing.Point(168, 122);
            this.authorNameTb.Margin = new System.Windows.Forms.Padding(4);
            this.authorNameTb.MaxLength = 50;
            this.authorNameTb.Name = "authorNameTb";
            this.authorNameTb.Size = new System.Drawing.Size(271, 31);
            this.authorNameTb.TabIndex = 126;
            this.authorNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.White;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.titleLabel.Location = new System.Drawing.Point(166, 96);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(66, 22);
            this.titleLabel.TabIndex = 132;
            this.titleLabel.Text = "Name";
            // 
            // addlabel
            // 
            this.addlabel.AutoSize = true;
            this.addlabel.BackColor = System.Drawing.Color.White;
            this.addlabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.addlabel.Location = new System.Drawing.Point(23, 19);
            this.addlabel.Name = "addlabel";
            this.addlabel.Size = new System.Drawing.Size(261, 33);
            this.addlabel.TabIndex = 131;
            this.addlabel.Text = "Add A New Author";
            // 
            // changepicture
            // 
            this.changepicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.changepicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changepicture.ForeColor = System.Drawing.Color.White;
            this.changepicture.Location = new System.Drawing.Point(27, 217);
            this.changepicture.Name = "changepicture";
            this.changepicture.Size = new System.Drawing.Size(114, 33);
            this.changepicture.TabIndex = 137;
            this.changepicture.Text = "Upload Picture";
            this.changepicture.UseVisualStyleBackColor = false;
            this.changepicture.Click += new System.EventHandler(this.changepicture_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 138;
            this.pictureBox1.TabStop = false;
            // 
            // AddAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 792);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.changepicture);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.confirmationPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.validationLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.authorNameTb);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.addlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAuthor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox confirmationPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label validationLabel;
        private System.Windows.Forms.Button addButton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox authorNameTb;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label addlabel;
        private System.Windows.Forms.Button changepicture;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
