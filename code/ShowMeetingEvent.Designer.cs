
namespace CentralLibrary 
{
    partial class ShowMeetingEvent
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
            this.addRemovePanel = new System.Windows.Forms.Panel();
            this.attendButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.toppanel = new System.Windows.Forms.Panel();
            this.validationLabel = new System.Windows.Forms.Label();
            this.atLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.descriptionpanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.listAttendantsBody = new System.Windows.Forms.Panel();
            this.listAdminPanel = new System.Windows.Forms.Panel();
            this.ownernameLabel = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.unattendbutton = new System.Windows.Forms.Button();
            this.addRemovePanel.SuspendLayout();
            this.toppanel.SuspendLayout();
            this.descriptionpanel.SuspendLayout();
            this.listAttendantsBody.SuspendLayout();
            this.listAdminPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addRemovePanel
            // 
            this.addRemovePanel.BackColor = System.Drawing.Color.White;
            this.addRemovePanel.Controls.Add(this.unattendbutton);
            this.addRemovePanel.Controls.Add(this.attendButton);
            this.addRemovePanel.Controls.Add(this.closeButton);
            this.addRemovePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addRemovePanel.Location = new System.Drawing.Point(0, 717);
            this.addRemovePanel.Name = "addRemovePanel";
            this.addRemovePanel.Size = new System.Drawing.Size(640, 75);
            this.addRemovePanel.TabIndex = 103;
            // 
            // attendButton
            // 
            this.attendButton.AccessibleDescription = "";
            this.attendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.attendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attendButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendButton.ForeColor = System.Drawing.Color.White;
            this.attendButton.Location = new System.Drawing.Point(492, 17);
            this.attendButton.Name = "attendButton";
            this.attendButton.Size = new System.Drawing.Size(136, 40);
            this.attendButton.TabIndex = 82;
            this.attendButton.Text = "Attend";
            this.attendButton.UseVisualStyleBackColor = false;
            this.attendButton.Visible = false;
            this.attendButton.Click += new System.EventHandler(this.attendButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.AccessibleDescription = "";
            this.closeButton.BackColor = System.Drawing.Color.DimGray;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(20, 17);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(136, 40);
            this.closeButton.TabIndex = 81;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.White;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.titleLabel.Location = new System.Drawing.Point(11, 13);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(167, 30);
            this.titleLabel.TabIndex = 79;
            this.titleLabel.Text = "Meeting Title";
            // 
            // toppanel
            // 
            this.toppanel.Controls.Add(this.validationLabel);
            this.toppanel.Controls.Add(this.atLabel);
            this.toppanel.Controls.Add(this.locationLabel);
            this.toppanel.Controls.Add(this.titleLabel);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(640, 128);
            this.toppanel.TabIndex = 102;
            // 
            // validationLabel
            // 
            this.validationLabel.AutoSize = true;
            this.validationLabel.BackColor = System.Drawing.Color.White;
            this.validationLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.validationLabel.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.validationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.validationLabel.Location = new System.Drawing.Point(17, 43);
            this.validationLabel.Name = "validationLabel";
            this.validationLabel.Size = new System.Drawing.Size(194, 16);
            this.validationLabel.TabIndex = 82;
            this.validationLabel.Text = " Please Enter A Valid Email Address.";
            this.validationLabel.Visible = false;
            // 
            // atLabel
            // 
            this.atLabel.AutoSize = true;
            this.atLabel.BackColor = System.Drawing.Color.White;
            this.atLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atLabel.ForeColor = System.Drawing.Color.DimGray;
            this.atLabel.Location = new System.Drawing.Point(16, 100);
            this.atLabel.Name = "atLabel";
            this.atLabel.Size = new System.Drawing.Size(38, 21);
            this.atLabel.TabIndex = 81;
            this.atLabel.Text = "At: ";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.BackColor = System.Drawing.Color.White;
            this.locationLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.ForeColor = System.Drawing.Color.DimGray;
            this.locationLabel.Location = new System.Drawing.Point(16, 68);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(86, 21);
            this.locationLabel.TabIndex = 80;
            this.locationLabel.Text = "Location: ";
            // 
            // descriptionpanel
            // 
            this.descriptionpanel.AutoSize = true;
            this.descriptionpanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.descriptionpanel.Controls.Add(this.label1);
            this.descriptionpanel.Controls.Add(this.descriptionLabel);
            this.descriptionpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.descriptionpanel.Location = new System.Drawing.Point(0, 128);
            this.descriptionpanel.MinimumSize = new System.Drawing.Size(640, 165);
            this.descriptionpanel.Name = "descriptionpanel";
            this.descriptionpanel.Size = new System.Drawing.Size(640, 165);
            this.descriptionpanel.TabIndex = 104;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 80;
            this.label1.Text = "Description";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.descriptionLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(12, 54);
            this.descriptionLabel.MaximumSize = new System.Drawing.Size(620, 0);
            this.descriptionLabel.MinimumSize = new System.Drawing.Size(620, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(620, 20);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "Sample text";
            // 
            // listAttendantsBody
            // 
            this.listAttendantsBody.AutoScroll = true;
            this.listAttendantsBody.AutoSize = true;
            this.listAttendantsBody.BackColor = System.Drawing.Color.Gainsboro;
            this.listAttendantsBody.Controls.Add(this.listAdminPanel);
            this.listAttendantsBody.Controls.Add(this.panel1);
            this.listAttendantsBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listAttendantsBody.Location = new System.Drawing.Point(0, 293);
            this.listAttendantsBody.MinimumSize = new System.Drawing.Size(640, 295);
            this.listAttendantsBody.Name = "listAttendantsBody";
            this.listAttendantsBody.Size = new System.Drawing.Size(640, 424);
            this.listAttendantsBody.TabIndex = 105;
            // 
            // listAdminPanel
            // 
            this.listAdminPanel.AutoScroll = true;
            this.listAdminPanel.BackColor = System.Drawing.Color.Transparent;
            this.listAdminPanel.Controls.Add(this.ownernameLabel);
            this.listAdminPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listAdminPanel.Location = new System.Drawing.Point(0, 44);
            this.listAdminPanel.Name = "listAdminPanel";
            this.listAdminPanel.Size = new System.Drawing.Size(640, 380);
            this.listAdminPanel.TabIndex = 84;
            // 
            // ownernameLabel
            // 
            this.ownernameLabel.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.ownernameLabel.AutoSize = true;
            this.ownernameLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ownernameLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.ownernameLabel.Location = new System.Drawing.Point(16, 13);
            this.ownernameLabel.Name = "ownernameLabel";
            this.ownernameLabel.Size = new System.Drawing.Size(267, 20);
            this.ownernameLabel.TabIndex = 24;
            this.ownernameLabel.TabStop = true;
            this.ownernameLabel.Text = "* Already have an account? Sign in";
            this.ownernameLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 44);
            this.panel1.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.CausesValidation = false;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.label3.Location = new System.Drawing.Point(16, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 22);
            this.label3.TabIndex = 82;
            this.label3.Text = "Attendants";
            // 
            // unattendbutton
            // 
            this.unattendbutton.AccessibleDescription = "";
            this.unattendbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.unattendbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unattendbutton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unattendbutton.ForeColor = System.Drawing.Color.White;
            this.unattendbutton.Location = new System.Drawing.Point(492, 17);
            this.unattendbutton.Name = "unattendbutton";
            this.unattendbutton.Size = new System.Drawing.Size(136, 40);
            this.unattendbutton.TabIndex = 83;
            this.unattendbutton.Text = "Unattend";
            this.unattendbutton.UseVisualStyleBackColor = false;
            this.unattendbutton.Visible = false;
            this.unattendbutton.Click += new System.EventHandler(this.unattendbutton_Click);
            // 
            // ShowMeetingEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 792);
            this.Controls.Add(this.listAttendantsBody);
            this.Controls.Add(this.descriptionpanel);
            this.Controls.Add(this.addRemovePanel);
            this.Controls.Add(this.toppanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowMeetingEvent";
            this.Text = "showmeetingdetails";
            this.addRemovePanel.ResumeLayout(false);
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            this.descriptionpanel.ResumeLayout(false);
            this.descriptionpanel.PerformLayout();
            this.listAttendantsBody.ResumeLayout(false);
            this.listAdminPanel.ResumeLayout(false);
            this.listAdminPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel addRemovePanel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Label atLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Panel descriptionpanel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Panel listAttendantsBody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel listAdminPanel;
        private System.Windows.Forms.LinkLabel ownernameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button attendButton;
        private System.Windows.Forms.Label validationLabel;
        private System.Windows.Forms.Button unattendbutton;
    }
}