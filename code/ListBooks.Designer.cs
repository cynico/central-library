
namespace CentralLibrary
{
    partial class ListBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListBooks));
            this.controlpanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.branchCheckBox = new System.Windows.Forms.CheckBox();
            this.newVendorPhone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.searchbutton = new System.Windows.Forms.Button();
            this.buttonImages = new System.Windows.Forms.ImageList(this.components);
            this.books_listpanel = new System.Windows.Forms.Panel();
            this.addButton = new CentralLibrary.CircularButton();
            this.controlpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.books_listpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlpanel
            // 
            this.controlpanel.BackColor = System.Drawing.Color.White;
            this.controlpanel.Controls.Add(this.panel1);
            this.controlpanel.Controls.Add(this.newVendorPhone);
            this.controlpanel.Controls.Add(this.categoryComboBox);
            this.controlpanel.Controls.Add(this.filterButton);
            this.controlpanel.Controls.Add(this.searchbutton);
            this.controlpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlpanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlpanel.Location = new System.Drawing.Point(0, 0);
            this.controlpanel.Name = "controlpanel";
            this.controlpanel.Size = new System.Drawing.Size(640, 121);
            this.controlpanel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.branchCheckBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 32);
            this.panel1.TabIndex = 51;
            // 
            // branchCheckBox
            // 
            this.branchCheckBox.AutoSize = true;
            this.branchCheckBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchCheckBox.Location = new System.Drawing.Point(12, 8);
            this.branchCheckBox.Name = "branchCheckBox";
            this.branchCheckBox.Size = new System.Drawing.Size(159, 20);
            this.branchCheckBox.TabIndex = 49;
            this.branchCheckBox.Text = "Books In This Branch Only";
            this.branchCheckBox.UseVisualStyleBackColor = true;
            this.branchCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // newVendorPhone
            // 
            this.newVendorPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.newVendorPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.newVendorPhone.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.newVendorPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newVendorPhone.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.newVendorPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newVendorPhone.HintForeColor = System.Drawing.Color.Gray;
            this.newVendorPhone.HintText = "";
            this.newVendorPhone.isPassword = false;
            this.newVendorPhone.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.newVendorPhone.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.newVendorPhone.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.newVendorPhone.LineThickness = 3;
            this.newVendorPhone.Location = new System.Drawing.Point(13, 39);
            this.newVendorPhone.Margin = new System.Windows.Forms.Padding(4);
            this.newVendorPhone.MaxLength = 32767;
            this.newVendorPhone.Name = "newVendorPhone";
            this.newVendorPhone.Size = new System.Drawing.Size(168, 31);
            this.newVendorPhone.TabIndex = 50;
            this.newVendorPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(460, 38);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(168, 29);
            this.categoryComboBox.TabIndex = 48;
            // 
            // filterButton
            // 
            this.filterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.filterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterButton.ForeColor = System.Drawing.Color.White;
            this.filterButton.Location = new System.Drawing.Point(460, 76);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(168, 30);
            this.filterButton.TabIndex = 47;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = false;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // searchbutton
            // 
            this.searchbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.searchbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbutton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbutton.ForeColor = System.Drawing.Color.White;
            this.searchbutton.Location = new System.Drawing.Point(12, 76);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(168, 30);
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
            // books_listpanel
            // 
            this.books_listpanel.AutoScroll = true;
            this.books_listpanel.Controls.Add(this.addButton);
            this.books_listpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.books_listpanel.Location = new System.Drawing.Point(0, 121);
            this.books_listpanel.Name = "books_listpanel";
            this.books_listpanel.Size = new System.Drawing.Size(640, 671);
            this.books_listpanel.TabIndex = 4;
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
            this.addButton.Location = new System.Drawing.Point(553, 603);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(66, 66);
            this.addButton.TabIndex = 1;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // ListBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 792);
            this.Controls.Add(this.books_listpanel);
            this.Controls.Add(this.controlpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListBooks";
            this.Text = "ListBooks";
            this.controlpanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.books_listpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controlpanel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.ImageList buttonImages;
        private System.Windows.Forms.Panel books_listpanel;
        private CircularButton addButton;
        private System.Windows.Forms.CheckBox branchCheckBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox newVendorPhone;
        private System.Windows.Forms.Panel panel1;
    }
}