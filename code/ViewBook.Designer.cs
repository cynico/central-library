
namespace CentralLibrary
{
    partial class ViewBook
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
            this.cancelrequestact = new System.Windows.Forms.Button();
            this.borrowRemoveBook = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.languageLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.publishedAtLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.validationLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.numLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelrequestact
            // 
            this.cancelrequestact.BackColor = System.Drawing.Color.DimGray;
            this.cancelrequestact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelrequestact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelrequestact.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelrequestact.ForeColor = System.Drawing.Color.White;
            this.cancelrequestact.Location = new System.Drawing.Point(16, 337);
            this.cancelrequestact.Name = "cancelrequestact";
            this.cancelrequestact.Size = new System.Drawing.Size(158, 42);
            this.cancelrequestact.TabIndex = 31;
            this.cancelrequestact.Text = "Cancel";
            this.cancelrequestact.UseVisualStyleBackColor = false;
            this.cancelrequestact.Click += new System.EventHandler(this.cancelrequestact_Click);
            // 
            // borrowRemoveBook
            // 
            this.borrowRemoveBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.borrowRemoveBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.borrowRemoveBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowRemoveBook.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowRemoveBook.ForeColor = System.Drawing.Color.White;
            this.borrowRemoveBook.Location = new System.Drawing.Point(377, 337);
            this.borrowRemoveBook.Name = "borrowRemoveBook";
            this.borrowRemoveBook.Size = new System.Drawing.Size(158, 42);
            this.borrowRemoveBook.TabIndex = 32;
            this.borrowRemoveBook.Text = "Borrow";
            this.borrowRemoveBook.UseVisualStyleBackColor = false;
            this.borrowRemoveBook.Click += new System.EventHandler(this.borrowRemoveBook_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.Color.White;
            this.headerLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.headerLabel.Location = new System.Drawing.Point(5, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(89, 19);
            this.headerLabel.TabIndex = 37;
            this.headerLabel.Text = "View Book";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.White;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            this.titleLabel.ForeColor = System.Drawing.Color.Black;
            this.titleLabel.Location = new System.Drawing.Point(12, 56);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(42, 19);
            this.titleLabel.TabIndex = 42;
            this.titleLabel.Text = "Title: ";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.BackColor = System.Drawing.Color.White;
            this.authorLabel.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            this.authorLabel.ForeColor = System.Drawing.Color.Black;
            this.authorLabel.Location = new System.Drawing.Point(12, 91);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(62, 19);
            this.authorLabel.TabIndex = 43;
            this.authorLabel.Text = "Author: ";
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.BackColor = System.Drawing.Color.White;
            this.languageLabel.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            this.languageLabel.ForeColor = System.Drawing.Color.Black;
            this.languageLabel.Location = new System.Drawing.Point(12, 127);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(88, 19);
            this.languageLabel.TabIndex = 44;
            this.languageLabel.Text = "Language: ";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.BackColor = System.Drawing.Color.White;
            this.categoryLabel.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            this.categoryLabel.ForeColor = System.Drawing.Color.Black;
            this.categoryLabel.Location = new System.Drawing.Point(12, 164);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(82, 19);
            this.categoryLabel.TabIndex = 45;
            this.categoryLabel.Text = "Category: ";
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.BackColor = System.Drawing.Color.White;
            this.publisherLabel.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            this.publisherLabel.ForeColor = System.Drawing.Color.Black;
            this.publisherLabel.Location = new System.Drawing.Point(12, 202);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(77, 19);
            this.publisherLabel.TabIndex = 46;
            this.publisherLabel.Text = "Publisher: ";
            // 
            // publishedAtLabel
            // 
            this.publishedAtLabel.AutoSize = true;
            this.publishedAtLabel.BackColor = System.Drawing.Color.White;
            this.publishedAtLabel.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            this.publishedAtLabel.ForeColor = System.Drawing.Color.Black;
            this.publishedAtLabel.Location = new System.Drawing.Point(12, 238);
            this.publishedAtLabel.Name = "publishedAtLabel";
            this.publishedAtLabel.Size = new System.Drawing.Size(101, 19);
            this.publishedAtLabel.TabIndex = 47;
            this.publishedAtLabel.Text = "Published At: ";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.BackColor = System.Drawing.Color.White;
            this.priceLabel.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            this.priceLabel.ForeColor = System.Drawing.Color.Black;
            this.priceLabel.Location = new System.Drawing.Point(12, 275);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(50, 19);
            this.priceLabel.TabIndex = 48;
            this.priceLabel.Text = "Price: ";
            // 
            // validationLabel
            // 
            this.validationLabel.AutoSize = true;
            this.validationLabel.BackColor = System.Drawing.Color.White;
            this.validationLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.validationLabel.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.validationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.validationLabel.Location = new System.Drawing.Point(6, 31);
            this.validationLabel.Name = "validationLabel";
            this.validationLabel.Size = new System.Drawing.Size(194, 16);
            this.validationLabel.TabIndex = 49;
            this.validationLabel.Text = " Please Enter A Valid Email Address.";
            this.validationLabel.Visible = false;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.Location = new System.Drawing.Point(196, 337);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(158, 42);
            this.updateButton.TabIndex = 50;
            this.updateButton.Text = "Update Available Number Of Copies";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // numLabel
            // 
            this.numLabel.AutoSize = true;
            this.numLabel.BackColor = System.Drawing.Color.White;
            this.numLabel.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            this.numLabel.ForeColor = System.Drawing.Color.Black;
            this.numLabel.Location = new System.Drawing.Point(12, 305);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(212, 19);
            this.numLabel.TabIndex = 51;
            this.numLabel.Text = "Number Of Available Copies: ";
            // 
            // ViewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(547, 391);
            this.Controls.Add(this.numLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.validationLabel);
            this.Controls.Add(this.cancelrequestact);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.borrowRemoveBook);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.publishedAtLabel);
            this.Controls.Add(this.publisherLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewBook";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewBook_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelrequestact;
        private System.Windows.Forms.Button borrowRemoveBook;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.Label publishedAtLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label validationLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label numLabel;
    }
}