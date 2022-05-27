
namespace CentralLibrary
{
    partial class InboxForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InboxForm));
            this.controlpanel = new System.Windows.Forms.Panel();
            this.selectallbutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.filterbutton = new System.Windows.Forms.Button();
            this.filtercomboxbox = new System.Windows.Forms.ComboBox();
            this.listpanel = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.deletebutton = new System.Windows.Forms.Button();
            this.validationtextbox = new System.Windows.Forms.Label();
            this.composeButton = new CentralLibrary.CircularButton();
            this.controlpanel.SuspendLayout();
            this.listpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlpanel
            // 
            this.controlpanel.BackColor = System.Drawing.Color.Transparent;
            this.controlpanel.Controls.Add(this.validationtextbox);
            this.controlpanel.Controls.Add(this.selectallbutton);
            this.controlpanel.Controls.Add(this.cancelbutton);
            this.controlpanel.Controls.Add(this.filterbutton);
            this.controlpanel.Controls.Add(this.filtercomboxbox);
            this.controlpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlpanel.Location = new System.Drawing.Point(0, 0);
            this.controlpanel.Name = "controlpanel";
            this.controlpanel.Size = new System.Drawing.Size(640, 104);
            this.controlpanel.TabIndex = 0;
            // 
            // selectallbutton
            // 
            this.selectallbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.selectallbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectallbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectallbutton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectallbutton.ForeColor = System.Drawing.Color.White;
            this.selectallbutton.Location = new System.Drawing.Point(507, 70);
            this.selectallbutton.Name = "selectallbutton";
            this.selectallbutton.Size = new System.Drawing.Size(121, 25);
            this.selectallbutton.TabIndex = 25;
            this.selectallbutton.Text = "Select All";
            this.selectallbutton.UseVisualStyleBackColor = false;
            this.selectallbutton.Visible = false;
            this.selectallbutton.Click += new System.EventHandler(this.selectallbutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.cancelbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbutton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbutton.ForeColor = System.Drawing.Color.White;
            this.cancelbutton.Location = new System.Drawing.Point(380, 70);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(121, 25);
            this.cancelbutton.TabIndex = 24;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = false;
            this.cancelbutton.Visible = false;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // filterbutton
            // 
            this.filterbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.filterbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterbutton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterbutton.ForeColor = System.Drawing.Color.White;
            this.filterbutton.Location = new System.Drawing.Point(12, 70);
            this.filterbutton.Name = "filterbutton";
            this.filterbutton.Size = new System.Drawing.Size(121, 25);
            this.filterbutton.TabIndex = 22;
            this.filterbutton.Text = "Filter";
            this.filterbutton.UseVisualStyleBackColor = false;
            this.filterbutton.Click += new System.EventHandler(this.filterbutton_Click);
            // 
            // filtercomboxbox
            // 
            this.filtercomboxbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtercomboxbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filtercomboxbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtercomboxbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.filtercomboxbox.FormattingEnabled = true;
            this.filtercomboxbox.Items.AddRange(new object[] {
            "Sent",
            "Received",
            "All"});
            this.filtercomboxbox.Location = new System.Drawing.Point(12, 28);
            this.filtercomboxbox.Name = "filtercomboxbox";
            this.filtercomboxbox.Size = new System.Drawing.Size(121, 29);
            this.filtercomboxbox.TabIndex = 21;
            // 
            // listpanel
            // 
            this.listpanel.AutoScroll = true;
            this.listpanel.BackColor = System.Drawing.Color.Transparent;
            this.listpanel.Controls.Add(this.composeButton);
            this.listpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listpanel.Location = new System.Drawing.Point(0, 104);
            this.listpanel.Name = "listpanel";
            this.listpanel.Size = new System.Drawing.Size(640, 688);
            this.listpanel.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "pencil (1).png");
            // 
            // deletebutton
            // 
            this.deletebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.deletebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebutton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.ForeColor = System.Drawing.Color.White;
            this.deletebutton.Location = new System.Drawing.Point(507, 16);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(121, 25);
            this.deletebutton.TabIndex = 23;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = false;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // validationtextbox
            // 
            this.validationtextbox.AutoSize = true;
            this.validationtextbox.BackColor = System.Drawing.Color.White;
            this.validationtextbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.validationtextbox.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.validationtextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.validationtextbox.Location = new System.Drawing.Point(9, 9);
            this.validationtextbox.Name = "validationtextbox";
            this.validationtextbox.Size = new System.Drawing.Size(250, 16);
            this.validationtextbox.TabIndex = 42;
            this.validationtextbox.Text = "Something wrong happened. Try again later.";
            this.validationtextbox.Visible = false;
            // 
            // composeButton
            // 
            this.composeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.composeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.composeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.composeButton.FlatAppearance.BorderSize = 0;
            this.composeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.composeButton.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.composeButton.ForeColor = System.Drawing.Color.White;
            this.composeButton.ImageIndex = 0;
            this.composeButton.ImageList = this.imageList1;
            this.composeButton.Location = new System.Drawing.Point(562, 614);
            this.composeButton.Name = "composeButton";
            this.composeButton.Size = new System.Drawing.Size(66, 66);
            this.composeButton.TabIndex = 0;
            this.composeButton.UseVisualStyleBackColor = false;
            this.composeButton.Click += new System.EventHandler(this.composeButton_Click);
            // 
            // inboxform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 792);
            this.Controls.Add(this.listpanel);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.controlpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "inboxform";
            this.Text = "inboxform";
            this.controlpanel.ResumeLayout(false);
            this.controlpanel.PerformLayout();
            this.listpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controlpanel;
        private System.Windows.Forms.Panel listpanel;
        private System.Windows.Forms.ComboBox filtercomboxbox;
        private System.Windows.Forms.Button filterbutton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button selectallbutton;
        private CircularButton composeButton;
        private System.Windows.Forms.Label validationtextbox;
    }
}