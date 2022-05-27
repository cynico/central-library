
namespace CentralLibrary
{
    partial class Notifications
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notifications));
            this.controlpanel = new System.Windows.Forms.Panel();
            this.markAsSeenButton = new System.Windows.Forms.Button();
            this.selectallbutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.notificationsListPanel = new System.Windows.Forms.Panel();
            this.buttonImages = new System.Windows.Forms.ImageList(this.components);
            this.controlpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlpanel
            // 
            this.controlpanel.BackColor = System.Drawing.Color.Transparent;
            this.controlpanel.Controls.Add(this.markAsSeenButton);
            this.controlpanel.Controls.Add(this.selectallbutton);
            this.controlpanel.Controls.Add(this.cancelbutton);
            this.controlpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlpanel.Location = new System.Drawing.Point(0, 0);
            this.controlpanel.Name = "controlpanel";
            this.controlpanel.Size = new System.Drawing.Size(640, 56);
            this.controlpanel.TabIndex = 6;
            // 
            // markAsSeenButton
            // 
            this.markAsSeenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.markAsSeenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.markAsSeenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.markAsSeenButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markAsSeenButton.ForeColor = System.Drawing.Color.White;
            this.markAsSeenButton.Location = new System.Drawing.Point(507, 12);
            this.markAsSeenButton.Name = "markAsSeenButton";
            this.markAsSeenButton.Size = new System.Drawing.Size(121, 25);
            this.markAsSeenButton.TabIndex = 30;
            this.markAsSeenButton.Text = "Mark As Seen";
            this.markAsSeenButton.UseVisualStyleBackColor = false;
            this.markAsSeenButton.Click += new System.EventHandler(this.markAsSeenButton_Click);
            // 
            // selectallbutton
            // 
            this.selectallbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.selectallbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectallbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectallbutton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectallbutton.ForeColor = System.Drawing.Color.White;
            this.selectallbutton.Location = new System.Drawing.Point(371, 12);
            this.selectallbutton.Name = "selectallbutton";
            this.selectallbutton.Size = new System.Drawing.Size(121, 25);
            this.selectallbutton.TabIndex = 32;
            this.selectallbutton.Text = "Select All";
            this.selectallbutton.UseVisualStyleBackColor = false;
            this.selectallbutton.Visible = false;
            this.selectallbutton.Click += new System.EventHandler(this.selectallbutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.BackColor = System.Drawing.Color.DimGray;
            this.cancelbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbutton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbutton.ForeColor = System.Drawing.Color.White;
            this.cancelbutton.Location = new System.Drawing.Point(230, 12);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(121, 25);
            this.cancelbutton.TabIndex = 31;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = false;
            this.cancelbutton.Visible = false;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // notificationsListPanel
            // 
            this.notificationsListPanel.AutoScroll = true;
            this.notificationsListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notificationsListPanel.Location = new System.Drawing.Point(0, 56);
            this.notificationsListPanel.Name = "notificationsListPanel";
            this.notificationsListPanel.Size = new System.Drawing.Size(640, 736);
            this.notificationsListPanel.TabIndex = 7;
            // 
            // buttonImages
            // 
            this.buttonImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("buttonImages.ImageStream")));
            this.buttonImages.TransparentColor = System.Drawing.Color.Transparent;
            this.buttonImages.Images.SetKeyName(0, "bell.png");
            // 
            // Notifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 792);
            this.Controls.Add(this.notificationsListPanel);
            this.Controls.Add(this.controlpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notifications";
            this.Text = "notifications";
            this.controlpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controlpanel;
        private System.Windows.Forms.Button markAsSeenButton;
        private System.Windows.Forms.Button selectallbutton;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Panel notificationsListPanel;
        private System.Windows.Forms.ImageList buttonImages;
    }
}