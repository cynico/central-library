
namespace CentralLibrary
{
    partial class ListRequests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListRequests));
            this.controlpanel = new System.Windows.Forms.Panel();
            this.filterbutton = new System.Windows.Forms.Button();
            this.requestfilter = new System.Windows.Forms.ComboBox();
            this.requestlistpanel = new System.Windows.Forms.Panel();
            this.addButton = new CentralLibrary.CircularButton();
            this.buttonImages = new System.Windows.Forms.ImageList(this.components);
            this.controlpanel.SuspendLayout();
            this.requestlistpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlpanel
            // 
            this.controlpanel.BackColor = System.Drawing.Color.Transparent;
            this.controlpanel.Controls.Add(this.filterbutton);
            this.controlpanel.Controls.Add(this.requestfilter);
            this.controlpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlpanel.Location = new System.Drawing.Point(0, 0);
            this.controlpanel.Name = "controlpanel";
            this.controlpanel.Size = new System.Drawing.Size(640, 100);
            this.controlpanel.TabIndex = 1;
            // 
            // filterbutton
            // 
            this.filterbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.filterbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterbutton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterbutton.ForeColor = System.Drawing.Color.White;
            this.filterbutton.Location = new System.Drawing.Point(12, 54);
            this.filterbutton.Name = "filterbutton";
            this.filterbutton.Size = new System.Drawing.Size(121, 25);
            this.filterbutton.TabIndex = 22;
            this.filterbutton.Text = "Filter";
            this.filterbutton.UseVisualStyleBackColor = false;
            this.filterbutton.Click += new System.EventHandler(this.filterbutton_Click);
            // 
            // requestfilter
            // 
            this.requestfilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.requestfilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.requestfilter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestfilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.requestfilter.FormattingEnabled = true;
            this.requestfilter.Items.AddRange(new object[] {
            "Pending"});
            this.requestfilter.Location = new System.Drawing.Point(12, 12);
            this.requestfilter.Name = "requestfilter";
            this.requestfilter.Size = new System.Drawing.Size(121, 29);
            this.requestfilter.TabIndex = 21;
            // 
            // requestlistpanel
            // 
            this.requestlistpanel.AutoScroll = true;
            this.requestlistpanel.BackColor = System.Drawing.Color.Transparent;
            this.requestlistpanel.Controls.Add(this.addButton);
            this.requestlistpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requestlistpanel.Location = new System.Drawing.Point(0, 100);
            this.requestlistpanel.Name = "requestlistpanel";
            this.requestlistpanel.Size = new System.Drawing.Size(640, 692);
            this.requestlistpanel.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.ImageIndex = 0;
            this.addButton.ImageList = this.buttonImages;
            this.addButton.Location = new System.Drawing.Point(562, 614);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(66, 66);
            this.addButton.TabIndex = 1;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // buttonImages
            // 
            this.buttonImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("buttonImages.ImageStream")));
            this.buttonImages.TransparentColor = System.Drawing.Color.Transparent;
            this.buttonImages.Images.SetKeyName(0, "add.png");
            // 
            // ListRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 792);
            this.Controls.Add(this.requestlistpanel);
            this.Controls.Add(this.controlpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListRequests";
            this.Text = "requestsfrom";
            this.controlpanel.ResumeLayout(false);
            this.requestlistpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controlpanel;
        private System.Windows.Forms.Button filterbutton;
        private System.Windows.Forms.ComboBox requestfilter;
        private System.Windows.Forms.Panel requestlistpanel;
        private CircularButton addButton;
        private System.Windows.Forms.ImageList buttonImages;
    }
}