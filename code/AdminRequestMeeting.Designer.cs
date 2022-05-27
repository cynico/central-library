
namespace CentralLibrary
{
    partial class AdminRequestMeeting
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
            this.requestButton = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.cancelmeetingrequest = new System.Windows.Forms.Button();
            this.meetingTimePicker = new System.Windows.Forms.DateTimePicker();
            this.requestmettingconfirm = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.validation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // requestButton
            // 
            this.requestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.requestButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.requestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.requestButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestButton.ForeColor = System.Drawing.Color.White;
            this.requestButton.Location = new System.Drawing.Point(377, 169);
            this.requestButton.Name = "requestButton";
            this.requestButton.Size = new System.Drawing.Size(158, 25);
            this.requestButton.TabIndex = 39;
            this.requestButton.Text = "Request";
            this.requestButton.UseVisualStyleBackColor = false;
            this.requestButton.Click += new System.EventHandler(this.requestMeetingAdmin_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.label17.Location = new System.Drawing.Point(8, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(331, 22);
            this.label17.TabIndex = 38;
            this.label17.Text = "Request Meeting From The Owner?";
            // 
            // cancelmeetingrequest
            // 
            this.cancelmeetingrequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.cancelmeetingrequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelmeetingrequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelmeetingrequest.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelmeetingrequest.ForeColor = System.Drawing.Color.White;
            this.cancelmeetingrequest.Location = new System.Drawing.Point(12, 169);
            this.cancelmeetingrequest.Name = "cancelmeetingrequest";
            this.cancelmeetingrequest.Size = new System.Drawing.Size(158, 25);
            this.cancelmeetingrequest.TabIndex = 37;
            this.cancelmeetingrequest.Text = "Cancel";
            this.cancelmeetingrequest.UseVisualStyleBackColor = false;
            this.cancelmeetingrequest.Click += new System.EventHandler(this.cancelmeetingrequest_Click);
            // 
            // meetingTimePicker
            // 
            this.meetingTimePicker.Location = new System.Drawing.Point(18, 59);
            this.meetingTimePicker.Name = "meetingTimePicker";
            this.meetingTimePicker.Size = new System.Drawing.Size(200, 20);
            this.meetingTimePicker.TabIndex = 40;
            // 
            // requestmettingconfirm
            // 
            this.requestmettingconfirm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.requestmettingconfirm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.requestmettingconfirm.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.requestmettingconfirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.requestmettingconfirm.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.requestmettingconfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.requestmettingconfirm.HintForeColor = System.Drawing.Color.Gray;
            this.requestmettingconfirm.HintText = "Password";
            this.requestmettingconfirm.isPassword = true;
            this.requestmettingconfirm.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.requestmettingconfirm.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.requestmettingconfirm.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.requestmettingconfirm.LineThickness = 3;
            this.requestmettingconfirm.Location = new System.Drawing.Point(15, 119);
            this.requestmettingconfirm.Margin = new System.Windows.Forms.Padding(4);
            this.requestmettingconfirm.MaxLength = 32767;
            this.requestmettingconfirm.Name = "requestmettingconfirm";
            this.requestmettingconfirm.Size = new System.Drawing.Size(297, 31);
            this.requestmettingconfirm.TabIndex = 42;
            this.requestmettingconfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.label7.Location = new System.Drawing.Point(14, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 22);
            this.label7.TabIndex = 41;
            this.label7.Text = "Password";
            // 
            // validation
            // 
            this.validation.AutoSize = true;
            this.validation.BackColor = System.Drawing.Color.White;
            this.validation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.validation.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.validation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.validation.Location = new System.Drawing.Point(12, 31);
            this.validation.Name = "validation";
            this.validation.Size = new System.Drawing.Size(216, 17);
            this.validation.TabIndex = 43;
            this.validation.Text = " Please Enter A Valid Email Address.";
            this.validation.Visible = false;
            // 
            // adminRequestMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(547, 206);
            this.Controls.Add(this.validation);
            this.Controls.Add(this.requestmettingconfirm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.meetingTimePicker);
            this.Controls.Add(this.requestButton);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cancelmeetingrequest);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminRequestMeeting";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminRequestMeeting";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.adminRequestMeeting_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button requestButton;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button cancelmeetingrequest;
        private System.Windows.Forms.DateTimePicker meetingTimePicker;
        private Bunifu.Framework.UI.BunifuMaterialTextbox requestmettingconfirm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label validation;
    }
}