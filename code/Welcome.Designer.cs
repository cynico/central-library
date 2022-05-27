
namespace CentralLibrary
{
    partial class Welcome
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
            this.loggedinAs = new System.Windows.Forms.Label();
            this.notificationLabel = new System.Windows.Forms.LinkLabel();
            this.positionlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.label17.Location = new System.Drawing.Point(233, 240);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(143, 33);
            this.label17.TabIndex = 25;
            this.label17.Text = "Welcome";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loggedinAs
            // 
            this.loggedinAs.AutoSize = true;
            this.loggedinAs.BackColor = System.Drawing.Color.White;
            this.loggedinAs.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedinAs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.loggedinAs.Location = new System.Drawing.Point(12, 307);
            this.loggedinAs.Name = "loggedinAs";
            this.loggedinAs.Size = new System.Drawing.Size(154, 24);
            this.loggedinAs.TabIndex = 26;
            this.loggedinAs.Text = "Logged In As: ";
            // 
            // notificationLabel
            // 
            this.notificationLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.notificationLabel.AutoSize = true;
            this.notificationLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationLabel.LinkColor = System.Drawing.Color.DimGray;
            this.notificationLabel.Location = new System.Drawing.Point(12, 384);
            this.notificationLabel.Name = "notificationLabel";
            this.notificationLabel.Size = new System.Drawing.Size(108, 21);
            this.notificationLabel.TabIndex = 27;
            this.notificationLabel.TabStop = true;
            this.notificationLabel.Text = "Notifcations ";
            this.notificationLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.notificationLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkToSignIn_LinkClicked);
            // 
            // positionlabel
            // 
            this.positionlabel.AutoSize = true;
            this.positionlabel.BackColor = System.Drawing.Color.White;
            this.positionlabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.positionlabel.Location = new System.Drawing.Point(12, 348);
            this.positionlabel.Name = "positionlabel";
            this.positionlabel.Size = new System.Drawing.Size(95, 24);
            this.positionlabel.TabIndex = 29;
            this.positionlabel.Text = "Position: ";
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 792);
            this.Controls.Add(this.positionlabel);
            this.Controls.Add(this.notificationLabel);
            this.Controls.Add(this.loggedinAs);
            this.Controls.Add(this.label17);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Welcome";
            this.Text = "welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label loggedinAs;
        private System.Windows.Forms.LinkLabel notificationLabel;
        private System.Windows.Forms.Label positionlabel;
    }
}