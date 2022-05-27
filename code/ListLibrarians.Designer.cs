
namespace CentralLibrary
{
    partial class ListLibrarians
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListLibrarians));
            this.controlpanel = new System.Windows.Forms.Panel();
            this.branchComboBox = new System.Windows.Forms.ComboBox();
            this.filterByBranch = new System.Windows.Forms.Button();
            this.libsearchtb = new System.Windows.Forms.TextBox();
            this.searchbutton = new System.Windows.Forms.Button();
            this.buttonImages = new System.Windows.Forms.ImageList(this.components);
            this.lib_listpanel = new System.Windows.Forms.Panel();
            this.addButton = new CentralLibrary.CircularButton();
            this.controlpanel.SuspendLayout();
            this.lib_listpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlpanel
            // 
            this.controlpanel.BackColor = System.Drawing.Color.Transparent;
            this.controlpanel.Controls.Add(this.branchComboBox);
            this.controlpanel.Controls.Add(this.filterByBranch);
            this.controlpanel.Controls.Add(this.libsearchtb);
            this.controlpanel.Controls.Add(this.searchbutton);
            this.controlpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlpanel.Location = new System.Drawing.Point(0, 0);
            this.controlpanel.Name = "controlpanel";
            this.controlpanel.Size = new System.Drawing.Size(640, 100);
            this.controlpanel.TabIndex = 3;
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
            this.branchComboBox.TabIndex = 46;
            this.branchComboBox.Visible = false;
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
            // libsearchtb
            // 
            this.libsearchtb.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libsearchtb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.libsearchtb.Location = new System.Drawing.Point(12, 17);
            this.libsearchtb.Name = "libsearchtb";
            this.libsearchtb.Size = new System.Drawing.Size(168, 21);
            this.libsearchtb.TabIndex = 27;
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
            // buttonImages
            // 
            this.buttonImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("buttonImages.ImageStream")));
            this.buttonImages.TransparentColor = System.Drawing.Color.Transparent;
            this.buttonImages.Images.SetKeyName(0, "add.png");
            // 
            // lib_listpanel
            // 
            this.lib_listpanel.AutoScroll = true;
            this.lib_listpanel.BackColor = System.Drawing.Color.Transparent;
            this.lib_listpanel.Controls.Add(this.addButton);
            this.lib_listpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lib_listpanel.Location = new System.Drawing.Point(0, 100);
            this.lib_listpanel.Name = "lib_listpanel";
            this.lib_listpanel.Size = new System.Drawing.Size(640, 692);
            this.lib_listpanel.TabIndex = 4;
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
            // ListLibrarians
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 792);
            this.Controls.Add(this.lib_listpanel);
            this.Controls.Add(this.controlpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListLibrarians";
            this.Text = "listlibrarians";
            this.controlpanel.ResumeLayout(false);
            this.controlpanel.PerformLayout();
            this.lib_listpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controlpanel;
        private System.Windows.Forms.TextBox libsearchtb;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.ImageList buttonImages;
        private System.Windows.Forms.Panel lib_listpanel;
        private CircularButton addButton;
        private System.Windows.Forms.Button filterByBranch;
        private System.Windows.Forms.ComboBox branchComboBox;
    }
}