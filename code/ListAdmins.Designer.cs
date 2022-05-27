
namespace CentralLibrary
{
    partial class ListAdmins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListAdmins));
            this.controlpanel = new System.Windows.Forms.Panel();
            this.adm_search_tb = new System.Windows.Forms.TextBox();
            this.searchbutton = new System.Windows.Forms.Button();
            this.buttonImages = new System.Windows.Forms.ImageList(this.components);
            this.addButton = new CentralLibrary.CircularButton();
            this.adm_listpanel = new System.Windows.Forms.Panel();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.controlpanel.SuspendLayout();
            this.adm_listpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlpanel
            // 
            this.controlpanel.BackColor = System.Drawing.Color.Transparent;
            this.controlpanel.Controls.Add(this.filterComboBox);
            this.controlpanel.Controls.Add(this.filterButton);
            this.controlpanel.Controls.Add(this.adm_search_tb);
            this.controlpanel.Controls.Add(this.searchbutton);
            this.controlpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlpanel.Location = new System.Drawing.Point(0, 0);
            this.controlpanel.Name = "controlpanel";
            this.controlpanel.Size = new System.Drawing.Size(640, 100);
            this.controlpanel.TabIndex = 1;
            // 
            // adm_search_tb
            // 
            this.adm_search_tb.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adm_search_tb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.adm_search_tb.Location = new System.Drawing.Point(12, 17);
            this.adm_search_tb.Name = "adm_search_tb";
            this.adm_search_tb.Size = new System.Drawing.Size(168, 21);
            this.adm_search_tb.TabIndex = 27;
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
            // adm_listpanel
            // 
            this.adm_listpanel.AutoScroll = true;
            this.adm_listpanel.BackColor = System.Drawing.Color.Transparent;
            this.adm_listpanel.Controls.Add(this.addButton);
            this.adm_listpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adm_listpanel.Location = new System.Drawing.Point(0, 100);
            this.adm_listpanel.Name = "adm_listpanel";
            this.adm_listpanel.Size = new System.Drawing.Size(640, 692);
            this.adm_listpanel.TabIndex = 2;
            // 
            // filterComboBox
            // 
            this.filterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Items.AddRange(new object[] {
            "In Contract With",
            "All"});
            this.filterComboBox.Location = new System.Drawing.Point(460, 12);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(168, 29);
            this.filterComboBox.TabIndex = 48;
            this.filterComboBox.Visible = false;
            // 
            // filterButton
            // 
            this.filterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.filterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterButton.ForeColor = System.Drawing.Color.White;
            this.filterButton.Location = new System.Drawing.Point(460, 54);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(168, 25);
            this.filterButton.TabIndex = 47;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = false;
            this.filterButton.Visible = false;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // ListAdmins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 792);
            this.Controls.Add(this.adm_listpanel);
            this.Controls.Add(this.controlpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListAdmins";
            this.Text = "owner_listadministrators";
            this.controlpanel.ResumeLayout(false);
            this.controlpanel.PerformLayout();
            this.adm_listpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controlpanel;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.TextBox adm_search_tb;
        private System.Windows.Forms.ImageList buttonImages;
        private CircularButton addButton;
        private System.Windows.Forms.Panel adm_listpanel;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.Button filterButton;
    }
}