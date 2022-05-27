
namespace CentralLibrary
{
    partial class ListVendors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListVendors));
            this.buttonImages = new System.Windows.Forms.ImageList(this.components);
            this.searchbutton = new System.Windows.Forms.Button();
            this.vendorSearchTb = new System.Windows.Forms.TextBox();
            this.filterByBranch = new System.Windows.Forms.Button();
            this.controlpanel = new System.Windows.Forms.Panel();
            this.branchComboBox = new System.Windows.Forms.ComboBox();
            this.vendorlistpanel = new System.Windows.Forms.Panel();
            this.addButton = new CentralLibrary.CircularButton();
            this.controlpanel.SuspendLayout();
            this.vendorlistpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonImages
            // 
            this.buttonImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("buttonImages.ImageStream")));
            this.buttonImages.TransparentColor = System.Drawing.Color.Transparent;
            this.buttonImages.Images.SetKeyName(0, "add.png");
            this.buttonImages.Images.SetKeyName(1, "close.png");
            // 
            // searchbutton
            // 
            this.searchbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.searchbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbutton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbutton.ForeColor = System.Drawing.Color.White;
            this.searchbutton.Location = new System.Drawing.Point(12, 54);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(168, 25);
            this.searchbutton.TabIndex = 22;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = false;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // vendorSearchTb
            // 
            this.vendorSearchTb.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorSearchTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.vendorSearchTb.Location = new System.Drawing.Point(12, 17);
            this.vendorSearchTb.Name = "vendorSearchTb";
            this.vendorSearchTb.Size = new System.Drawing.Size(168, 21);
            this.vendorSearchTb.TabIndex = 27;
            // 
            // filterByBranch
            // 
            this.filterByBranch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.filterByBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterByBranch.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterByBranch.ForeColor = System.Drawing.Color.White;
            this.filterByBranch.Location = new System.Drawing.Point(458, 54);
            this.filterByBranch.Name = "filterByBranch";
            this.filterByBranch.Size = new System.Drawing.Size(168, 25);
            this.filterByBranch.TabIndex = 29;
            this.filterByBranch.Text = "Filter By Branch";
            this.filterByBranch.UseVisualStyleBackColor = false;
            this.filterByBranch.Visible = false;
            this.filterByBranch.Click += new System.EventHandler(this.filterByBranch_Click);
            // 
            // controlpanel
            // 
            this.controlpanel.BackColor = System.Drawing.Color.Transparent;
            this.controlpanel.Controls.Add(this.branchComboBox);
            this.controlpanel.Controls.Add(this.filterByBranch);
            this.controlpanel.Controls.Add(this.vendorSearchTb);
            this.controlpanel.Controls.Add(this.searchbutton);
            this.controlpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlpanel.Location = new System.Drawing.Point(0, 0);
            this.controlpanel.Name = "controlpanel";
            this.controlpanel.Size = new System.Drawing.Size(640, 100);
            this.controlpanel.TabIndex = 5;
            // 
            // branchComboBox
            // 
            this.branchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.branchComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.branchComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.branchComboBox.FormattingEnabled = true;
            this.branchComboBox.Location = new System.Drawing.Point(458, 12);
            this.branchComboBox.Name = "branchComboBox";
            this.branchComboBox.Size = new System.Drawing.Size(168, 29);
            this.branchComboBox.TabIndex = 47;
            // 
            // vendorlistpanel
            // 
            this.vendorlistpanel.AutoScroll = true;
            this.vendorlistpanel.BackColor = System.Drawing.Color.Transparent;
            this.vendorlistpanel.Controls.Add(this.addButton);
            this.vendorlistpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vendorlistpanel.Location = new System.Drawing.Point(0, 100);
            this.vendorlistpanel.Name = "vendorlistpanel";
            this.vendorlistpanel.Size = new System.Drawing.Size(640, 692);
            this.vendorlistpanel.TabIndex = 6;
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
            this.addButton.TabIndex = 0;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // ListVendors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 792);
            this.Controls.Add(this.vendorlistpanel);
            this.Controls.Add(this.controlpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListVendors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "listvendor";
            this.controlpanel.ResumeLayout(false);
            this.controlpanel.PerformLayout();
            this.vendorlistpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList buttonImages;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.TextBox vendorSearchTb;
        private System.Windows.Forms.Button filterByBranch;
        private System.Windows.Forms.Panel controlpanel;
        private System.Windows.Forms.ComboBox branchComboBox;
        private System.Windows.Forms.Panel vendorlistpanel;
        private CircularButton addButton;
    }
}