
namespace CentralLibrary
{
    partial class ShowEmailContent
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
            this.closeEmailButton = new System.Windows.Forms.Button();
            this.ReplyButton = new System.Windows.Forms.Button();
            this.emailTitle = new System.Windows.Forms.Label();
            this.toppanel = new System.Windows.Forms.Panel();
            this.atLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.booklistpanel = new System.Windows.Forms.Panel();
            this.emailBody = new System.Windows.Forms.Label();
            this.addRemovePanel.SuspendLayout();
            this.toppanel.SuspendLayout();
            this.booklistpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addRemovePanel
            // 
            this.addRemovePanel.BackColor = System.Drawing.Color.White;
            this.addRemovePanel.Controls.Add(this.closeEmailButton);
            this.addRemovePanel.Controls.Add(this.ReplyButton);
            this.addRemovePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addRemovePanel.Location = new System.Drawing.Point(0, 717);
            this.addRemovePanel.Name = "addRemovePanel";
            this.addRemovePanel.Size = new System.Drawing.Size(640, 75);
            this.addRemovePanel.TabIndex = 99;
            // 
            // closeEmailButton
            // 
            this.closeEmailButton.AccessibleDescription = "";
            this.closeEmailButton.BackColor = System.Drawing.Color.DimGray;
            this.closeEmailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeEmailButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeEmailButton.ForeColor = System.Drawing.Color.White;
            this.closeEmailButton.Location = new System.Drawing.Point(492, 23);
            this.closeEmailButton.Name = "closeEmailButton";
            this.closeEmailButton.Size = new System.Drawing.Size(136, 40);
            this.closeEmailButton.TabIndex = 81;
            this.closeEmailButton.Text = "Close";
            this.closeEmailButton.UseVisualStyleBackColor = false;
            this.closeEmailButton.Click += new System.EventHandler(this.closeEmailButton_Click);
            // 
            // ReplyButton
            // 
            this.ReplyButton.AccessibleDescription = "";
            this.ReplyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.ReplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReplyButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReplyButton.ForeColor = System.Drawing.Color.White;
            this.ReplyButton.Location = new System.Drawing.Point(16, 23);
            this.ReplyButton.Name = "ReplyButton";
            this.ReplyButton.Size = new System.Drawing.Size(136, 40);
            this.ReplyButton.TabIndex = 79;
            this.ReplyButton.Text = "Reply";
            this.ReplyButton.UseVisualStyleBackColor = false;
            this.ReplyButton.Click += new System.EventHandler(this.ReplyButton_Click);
            // 
            // emailTitle
            // 
            this.emailTitle.AutoSize = true;
            this.emailTitle.BackColor = System.Drawing.Color.White;
            this.emailTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.emailTitle.Location = new System.Drawing.Point(11, 13);
            this.emailTitle.Name = "emailTitle";
            this.emailTitle.Size = new System.Drawing.Size(132, 30);
            this.emailTitle.TabIndex = 79;
            this.emailTitle.Text = "Email Title";
            // 
            // toppanel
            // 
            this.toppanel.Controls.Add(this.atLabel);
            this.toppanel.Controls.Add(this.fromLabel);
            this.toppanel.Controls.Add(this.emailTitle);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(640, 128);
            this.toppanel.TabIndex = 97;
            // 
            // atLabel
            // 
            this.atLabel.AutoSize = true;
            this.atLabel.BackColor = System.Drawing.Color.White;
            this.atLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atLabel.ForeColor = System.Drawing.Color.DimGray;
            this.atLabel.Location = new System.Drawing.Point(16, 88);
            this.atLabel.Name = "atLabel";
            this.atLabel.Size = new System.Drawing.Size(38, 21);
            this.atLabel.TabIndex = 81;
            this.atLabel.Text = "At: ";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.BackColor = System.Drawing.Color.White;
            this.fromLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLabel.ForeColor = System.Drawing.Color.DimGray;
            this.fromLabel.Location = new System.Drawing.Point(16, 56);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(56, 21);
            this.fromLabel.TabIndex = 80;
            this.fromLabel.Text = "From: ";
            // 
            // booklistpanel
            // 
            this.booklistpanel.AutoScroll = true;
            this.booklistpanel.AutoSize = true;
            this.booklistpanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.booklistpanel.Controls.Add(this.emailBody);
            this.booklistpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.booklistpanel.Location = new System.Drawing.Point(0, 128);
            this.booklistpanel.Name = "booklistpanel";
            this.booklistpanel.Size = new System.Drawing.Size(640, 589);
            this.booklistpanel.TabIndex = 101;
            // 
            // emailBody
            // 
            this.emailBody.AutoSize = true;
            this.emailBody.BackColor = System.Drawing.Color.Transparent;
            this.emailBody.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBody.Location = new System.Drawing.Point(8, 17);
            this.emailBody.MaximumSize = new System.Drawing.Size(620, 0);
            this.emailBody.MinimumSize = new System.Drawing.Size(620, 0);
            this.emailBody.Name = "emailBody";
            this.emailBody.Size = new System.Drawing.Size(620, 20);
            this.emailBody.TabIndex = 0;
            this.emailBody.Text = "Sample text";
            // 
            // ShowEmailContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 792);
            this.Controls.Add(this.booklistpanel);
            this.Controls.Add(this.addRemovePanel);
            this.Controls.Add(this.toppanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowEmailContent";
            this.Text = "showemailcontent";
            this.addRemovePanel.ResumeLayout(false);
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            this.booklistpanel.ResumeLayout(false);
            this.booklistpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel addRemovePanel;
        private System.Windows.Forms.Button closeEmailButton;
        private System.Windows.Forms.Button ReplyButton;
        private System.Windows.Forms.Label emailTitle;
        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label atLabel;
        private System.Windows.Forms.Panel booklistpanel;
        private System.Windows.Forms.Label emailBody;
    }
}