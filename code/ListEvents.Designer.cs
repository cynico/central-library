
namespace CentralLibrary
{
    partial class ListEvents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListEvents));
            this.controlpanel = new System.Windows.Forms.Panel();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.unattendbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.selectallbutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.filterbutton = new System.Windows.Forms.Button();
            this.buttonImages = new System.Windows.Forms.ImageList(this.components);
            this.validationLabel = new System.Windows.Forms.Label();
            this.eventsList = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.addButton = new CentralLibrary.CircularButton();
            this.controlpanel.SuspendLayout();
            this.eventsList.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlpanel
            // 
            this.controlpanel.BackColor = System.Drawing.Color.Transparent;
            this.controlpanel.Controls.Add(this.validationLabel);
            this.controlpanel.Controls.Add(this.filterComboBox);
            this.controlpanel.Controls.Add(this.unattendbutton);
            this.controlpanel.Controls.Add(this.deletebutton);
            this.controlpanel.Controls.Add(this.selectallbutton);
            this.controlpanel.Controls.Add(this.cancelbutton);
            this.controlpanel.Controls.Add(this.filterbutton);
            this.controlpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlpanel.Location = new System.Drawing.Point(0, 0);
            this.controlpanel.Name = "controlpanel";
            this.controlpanel.Size = new System.Drawing.Size(640, 122);
            this.controlpanel.TabIndex = 7;
            // 
            // filterComboBox
            // 
            this.filterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Location = new System.Drawing.Point(12, 36);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(168, 29);
            this.filterComboBox.TabIndex = 34;
            // 
            // unattendbutton
            // 
            this.unattendbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.unattendbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unattendbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unattendbutton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unattendbutton.ForeColor = System.Drawing.Color.White;
            this.unattendbutton.Location = new System.Drawing.Point(501, 78);
            this.unattendbutton.Name = "unattendbutton";
            this.unattendbutton.Size = new System.Drawing.Size(121, 25);
            this.unattendbutton.TabIndex = 33;
            this.unattendbutton.Text = "Un-attend";
            this.unattendbutton.UseVisualStyleBackColor = false;
            this.unattendbutton.Visible = false;
            // 
            // deletebutton
            // 
            this.deletebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.deletebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebutton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.ForeColor = System.Drawing.Color.White;
            this.deletebutton.Location = new System.Drawing.Point(501, 78);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(121, 25);
            this.deletebutton.TabIndex = 30;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = false;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // selectallbutton
            // 
            this.selectallbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.selectallbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectallbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectallbutton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectallbutton.ForeColor = System.Drawing.Color.White;
            this.selectallbutton.Location = new System.Drawing.Point(501, 36);
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
            this.cancelbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.cancelbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbutton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbutton.ForeColor = System.Drawing.Color.White;
            this.cancelbutton.Location = new System.Drawing.Point(363, 36);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(121, 25);
            this.cancelbutton.TabIndex = 31;
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
            this.filterbutton.Location = new System.Drawing.Point(12, 82);
            this.filterbutton.Name = "filterbutton";
            this.filterbutton.Size = new System.Drawing.Size(168, 25);
            this.filterbutton.TabIndex = 22;
            this.filterbutton.Text = "Filter";
            this.filterbutton.UseVisualStyleBackColor = false;
            this.filterbutton.Click += new System.EventHandler(this.filterbutton_Click);
            // 
            // buttonImages
            // 
            this.buttonImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("buttonImages.ImageStream")));
            this.buttonImages.TransparentColor = System.Drawing.Color.Transparent;
            this.buttonImages.Images.SetKeyName(0, "add.png");
            // 
            // validationLabel
            // 
            this.validationLabel.AutoSize = true;
            this.validationLabel.BackColor = System.Drawing.Color.White;
            this.validationLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.validationLabel.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.validationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.validationLabel.Location = new System.Drawing.Point(12, 9);
            this.validationLabel.Name = "validationLabel";
            this.validationLabel.Size = new System.Drawing.Size(132, 16);
            this.validationLabel.TabIndex = 42;
            this.validationLabel.Text = "Sample Validation Text";
            this.validationLabel.Visible = false;
            // 
            // eventsList
            // 
            this.eventsList.AutoScroll = true;
            this.eventsList.Controls.Add(this.addButton);
            this.eventsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventsList.Location = new System.Drawing.Point(0, 122);
            this.eventsList.Name = "eventsList";
            this.eventsList.Size = new System.Drawing.Size(640, 670);
            this.eventsList.TabIndex = 8;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add.png");
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
            this.addButton.ImageList = this.imageList1;
            this.addButton.Location = new System.Drawing.Point(556, 576);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(66, 66);
            this.addButton.TabIndex = 1;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // listevents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 792);
            this.Controls.Add(this.eventsList);
            this.Controls.Add(this.controlpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "listevents";
            this.Text = "listevents";
            this.controlpanel.ResumeLayout(false);
            this.controlpanel.PerformLayout();
            this.eventsList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controlpanel;
        private System.Windows.Forms.Button unattendbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button selectallbutton;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button filterbutton;
        private System.Windows.Forms.ImageList buttonImages;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.Label validationLabel;
        private System.Windows.Forms.Panel eventsList;
        private CircularButton addButton;
        private System.Windows.Forms.ImageList imageList1;
    }
}