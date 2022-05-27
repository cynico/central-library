
namespace CentralLibrary
{
    partial class ListUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListUsers));
            this.controlpanel = new System.Windows.Forms.Panel();
            this.searchTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.branchComboBox = new System.Windows.Forms.ComboBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.searchbutton = new System.Windows.Forms.Button();
            this.buttonImages = new System.Windows.Forms.ImageList(this.components);
            this.userslist_panel = new System.Windows.Forms.Panel();
            this.controlpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlpanel
            // 
            this.controlpanel.BackColor = System.Drawing.Color.White;
            this.controlpanel.Controls.Add(this.searchTb);
            this.controlpanel.Controls.Add(this.branchComboBox);
            this.controlpanel.Controls.Add(this.filterButton);
            this.controlpanel.Controls.Add(this.searchbutton);
            this.controlpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlpanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlpanel.Location = new System.Drawing.Point(0, 0);
            this.controlpanel.Name = "controlpanel";
            this.controlpanel.Size = new System.Drawing.Size(640, 96);
            this.controlpanel.TabIndex = 5;
            // 
            // searchTb
            // 
            this.searchTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.searchTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.searchTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.searchTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.searchTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchTb.HintForeColor = System.Drawing.Color.Gray;
            this.searchTb.HintText = "";
            this.searchTb.isPassword = false;
            this.searchTb.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.searchTb.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.searchTb.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.searchTb.LineThickness = 3;
            this.searchTb.Location = new System.Drawing.Point(13, 13);
            this.searchTb.Margin = new System.Windows.Forms.Padding(4);
            this.searchTb.MaxLength = 32767;
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(168, 31);
            this.searchTb.TabIndex = 50;
            this.searchTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // branchComboBox
            // 
            this.branchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.branchComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.branchComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.branchComboBox.FormattingEnabled = true;
            this.branchComboBox.Location = new System.Drawing.Point(460, 12);
            this.branchComboBox.Name = "branchComboBox";
            this.branchComboBox.Size = new System.Drawing.Size(168, 29);
            this.branchComboBox.TabIndex = 48;
            // 
            // filterButton
            // 
            this.filterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.filterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterButton.ForeColor = System.Drawing.Color.White;
            this.filterButton.Location = new System.Drawing.Point(460, 50);
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
            this.searchbutton.Location = new System.Drawing.Point(12, 50);
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
            // userslist_panel
            // 
            this.userslist_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userslist_panel.Location = new System.Drawing.Point(0, 96);
            this.userslist_panel.Name = "userslist_panel";
            this.userslist_panel.Size = new System.Drawing.Size(640, 696);
            this.userslist_panel.TabIndex = 6;
            // 
            // ListUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 792);
            this.Controls.Add(this.userslist_panel);
            this.Controls.Add(this.controlpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListUsers";
            this.Text = "ListUsers";
            this.controlpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controlpanel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox searchTb;
        private System.Windows.Forms.ComboBox branchComboBox;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.ImageList buttonImages;
        private System.Windows.Forms.Panel userslist_panel;
    }
}