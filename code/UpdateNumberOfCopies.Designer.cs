
namespace CentralLibrary
{
    partial class UpdateNumberOfCopies
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
            this.numLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.cancelrequestact = new System.Windows.Forms.Button();
            this.bookTitleSample = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.numericNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.validationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericNum)).BeginInit();
            this.SuspendLayout();
            // 
            // numLabel
            // 
            this.numLabel.AutoSize = true;
            this.numLabel.BackColor = System.Drawing.Color.White;
            this.numLabel.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            this.numLabel.ForeColor = System.Drawing.Color.Black;
            this.numLabel.Location = new System.Drawing.Point(12, 85);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(267, 19);
            this.numLabel.TabIndex = 65;
            this.numLabel.Text = "Current Number Of Available Copies: ";
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.Location = new System.Drawing.Point(359, 176);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(158, 42);
            this.updateButton.TabIndex = 64;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // cancelrequestact
            // 
            this.cancelrequestact.BackColor = System.Drawing.Color.DimGray;
            this.cancelrequestact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelrequestact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelrequestact.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelrequestact.ForeColor = System.Drawing.Color.White;
            this.cancelrequestact.Location = new System.Drawing.Point(12, 176);
            this.cancelrequestact.Name = "cancelrequestact";
            this.cancelrequestact.Size = new System.Drawing.Size(158, 42);
            this.cancelrequestact.TabIndex = 53;
            this.cancelrequestact.Text = "Cancel";
            this.cancelrequestact.UseVisualStyleBackColor = false;
            this.cancelrequestact.Click += new System.EventHandler(this.cancelrequestact_Click);
            // 
            // bookTitleSample
            // 
            this.bookTitleSample.AutoSize = true;
            this.bookTitleSample.BackColor = System.Drawing.Color.White;
            this.bookTitleSample.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTitleSample.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.bookTitleSample.Location = new System.Drawing.Point(12, 9);
            this.bookTitleSample.Name = "bookTitleSample";
            this.bookTitleSample.Size = new System.Drawing.Size(212, 19);
            this.bookTitleSample.TabIndex = 55;
            this.bookTitleSample.Text = "Update Number Of Copies";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.White;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            this.titleLabel.ForeColor = System.Drawing.Color.Black;
            this.titleLabel.Location = new System.Drawing.Point(12, 57);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(42, 19);
            this.titleLabel.TabIndex = 56;
            this.titleLabel.Text = "Title: ";
            // 
            // numericNum
            // 
            this.numericNum.Location = new System.Drawing.Point(157, 122);
            this.numericNum.Name = "numericNum";
            this.numericNum.Size = new System.Drawing.Size(158, 20);
            this.numericNum.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 19);
            this.label1.TabIndex = 67;
            this.label1.Text = "Updated Number: ";
            // 
            // validationLabel
            // 
            this.validationLabel.AutoSize = true;
            this.validationLabel.BackColor = System.Drawing.Color.White;
            this.validationLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.validationLabel.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.validationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.validationLabel.Location = new System.Drawing.Point(13, 30);
            this.validationLabel.Name = "validationLabel";
            this.validationLabel.Size = new System.Drawing.Size(216, 17);
            this.validationLabel.TabIndex = 146;
            this.validationLabel.Text = " Please Enter A Valid Email Address.";
            this.validationLabel.Visible = false;
            // 
            // UpdateNumberOfCopies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(529, 230);
            this.Controls.Add(this.validationLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericNum);
            this.Controls.Add(this.numLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.cancelrequestact);
            this.Controls.Add(this.bookTitleSample);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateNumberOfCopies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateNumberOfCopies";
            ((System.ComponentModel.ISupportInitialize)(this.numericNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button cancelrequestact;
        private System.Windows.Forms.Label bookTitleSample;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.NumericUpDown numericNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label validationLabel;
    }
}