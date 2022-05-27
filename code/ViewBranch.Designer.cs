
namespace CentralLibrary
{
    partial class ViewBranch
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
            this.contactAdminButton = new System.Windows.Forms.Button();
            this.validationLabel = new System.Windows.Forms.Label();
            this.cancelrequestact = new System.Windows.Forms.Button();
            this.removeBranchButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.passwordConfrimationTb = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.establishedAtLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contactAdminButton
            // 
            this.contactAdminButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.contactAdminButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contactAdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contactAdminButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactAdminButton.ForeColor = System.Drawing.Color.White;
            this.contactAdminButton.Location = new System.Drawing.Point(194, 15);
            this.contactAdminButton.Name = "contactAdminButton";
            this.contactAdminButton.Size = new System.Drawing.Size(158, 42);
            this.contactAdminButton.TabIndex = 63;
            this.contactAdminButton.Text = "Contact Administrator";
            this.contactAdminButton.UseVisualStyleBackColor = false;
            this.contactAdminButton.Click += new System.EventHandler(this.contactAdminButton_Click);
            // 
            // validationLabel
            // 
            this.validationLabel.AutoSize = true;
            this.validationLabel.BackColor = System.Drawing.Color.White;
            this.validationLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.validationLabel.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.validationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.validationLabel.Location = new System.Drawing.Point(13, 31);
            this.validationLabel.Name = "validationLabel";
            this.validationLabel.Size = new System.Drawing.Size(194, 16);
            this.validationLabel.TabIndex = 62;
            this.validationLabel.Text = " Please Enter A Valid Email Address.";
            this.validationLabel.Visible = false;
            // 
            // cancelrequestact
            // 
            this.cancelrequestact.BackColor = System.Drawing.Color.DimGray;
            this.cancelrequestact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelrequestact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelrequestact.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelrequestact.ForeColor = System.Drawing.Color.White;
            this.cancelrequestact.Location = new System.Drawing.Point(12, 15);
            this.cancelrequestact.Name = "cancelrequestact";
            this.cancelrequestact.Size = new System.Drawing.Size(158, 42);
            this.cancelrequestact.TabIndex = 52;
            this.cancelrequestact.Text = "Cancel";
            this.cancelrequestact.UseVisualStyleBackColor = false;
            this.cancelrequestact.Click += new System.EventHandler(this.cancelrequestact_Click);
            // 
            // removeBranchButton
            // 
            this.removeBranchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.removeBranchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeBranchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBranchButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBranchButton.ForeColor = System.Drawing.Color.White;
            this.removeBranchButton.Location = new System.Drawing.Point(373, 15);
            this.removeBranchButton.Name = "removeBranchButton";
            this.removeBranchButton.Size = new System.Drawing.Size(158, 42);
            this.removeBranchButton.TabIndex = 53;
            this.removeBranchButton.Text = "Remove Branch";
            this.removeBranchButton.UseVisualStyleBackColor = false;
            this.removeBranchButton.Click += new System.EventHandler(this.removeBranchButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.Color.White;
            this.headerLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(106, 19);
            this.headerLabel.TabIndex = 54;
            this.headerLabel.Text = "View Branch";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.headerLabel);
            this.panel1.Controls.Add(this.validationLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 53);
            this.panel1.TabIndex = 65;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.removeBranchButton);
            this.panel3.Controls.Add(this.contactAdminButton);
            this.panel3.Controls.Add(this.cancelrequestact);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 171);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(553, 74);
            this.panel3.TabIndex = 67;
            // 
            // infoPanel
            // 
            this.infoPanel.AutoSize = true;
            this.infoPanel.BackColor = System.Drawing.Color.Transparent;
            this.infoPanel.Controls.Add(this.passwordConfrimationTb);
            this.infoPanel.Controls.Add(this.nameLabel);
            this.infoPanel.Controls.Add(this.locationLabel);
            this.infoPanel.Controls.Add(this.establishedAtLabel);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoPanel.Location = new System.Drawing.Point(0, 53);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(553, 118);
            this.infoPanel.TabIndex = 68;
            // 
            // passwordConfrimationTb
            // 
            this.passwordConfrimationTb.BackColor = System.Drawing.Color.White;
            this.passwordConfrimationTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordConfrimationTb.Location = new System.Drawing.Point(16, 72);
            this.passwordConfrimationTb.Name = "passwordConfrimationTb";
            this.passwordConfrimationTb.Size = new System.Drawing.Size(158, 20);
            this.passwordConfrimationTb.TabIndex = 58;
            this.passwordConfrimationTb.Visible = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.White;
            this.nameLabel.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            this.nameLabel.ForeColor = System.Drawing.Color.Black;
            this.nameLabel.Location = new System.Drawing.Point(12, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(59, 19);
            this.nameLabel.TabIndex = 55;
            this.nameLabel.Text = "Name: ";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.BackColor = System.Drawing.Color.White;
            this.locationLabel.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            this.locationLabel.ForeColor = System.Drawing.Color.Black;
            this.locationLabel.Location = new System.Drawing.Point(12, 43);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(77, 19);
            this.locationLabel.TabIndex = 56;
            this.locationLabel.Text = "Location: ";
            // 
            // establishedAtLabel
            // 
            this.establishedAtLabel.AutoSize = true;
            this.establishedAtLabel.BackColor = System.Drawing.Color.White;
            this.establishedAtLabel.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            this.establishedAtLabel.ForeColor = System.Drawing.Color.Black;
            this.establishedAtLabel.Location = new System.Drawing.Point(12, 73);
            this.establishedAtLabel.Name = "establishedAtLabel";
            this.establishedAtLabel.Size = new System.Drawing.Size(112, 19);
            this.establishedAtLabel.TabIndex = 57;
            this.establishedAtLabel.Text = "Established At: ";
            // 
            // ViewBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(553, 245);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewBranch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewBranch";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewBranch_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button contactAdminButton;
        private System.Windows.Forms.Label validationLabel;
        private System.Windows.Forms.Button cancelrequestact;
        private System.Windows.Forms.Button removeBranchButton;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label establishedAtLabel;
        private System.Windows.Forms.TextBox passwordConfrimationTb;
    }
}