
namespace CentralLibrary
{
    partial class ListBooksInRequest
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
            this.booklistpanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.confirmationpanel = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.addlabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.atLabel = new System.Windows.Forms.Label();
            this.toppanel = new System.Windows.Forms.Panel();
            this.branchLabel = new System.Windows.Forms.Label();
            this.confirmationpanel.SuspendLayout();
            this.toppanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // booklistpanel
            // 
            this.booklistpanel.AutoScroll = true;
            this.booklistpanel.AutoSize = true;
            this.booklistpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.booklistpanel.Location = new System.Drawing.Point(0, 178);
            this.booklistpanel.Name = "booklistpanel";
            this.booklistpanel.Size = new System.Drawing.Size(640, 534);
            this.booklistpanel.TabIndex = 100;
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "";
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(422, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 40);
            this.button1.TabIndex = 86;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // confirmationpanel
            // 
            this.confirmationpanel.Controls.Add(this.button1);
            this.confirmationpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.confirmationpanel.Location = new System.Drawing.Point(0, 712);
            this.confirmationpanel.Name = "confirmationpanel";
            this.confirmationpanel.Size = new System.Drawing.Size(640, 80);
            this.confirmationpanel.TabIndex = 98;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.comboBox2.Location = new System.Drawing.Point(281, 677);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(233, 29);
            this.comboBox2.TabIndex = 96;
            // 
            // addlabel
            // 
            this.addlabel.AutoSize = true;
            this.addlabel.BackColor = System.Drawing.Color.White;
            this.addlabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.addlabel.Location = new System.Drawing.Point(11, 13);
            this.addlabel.Name = "addlabel";
            this.addlabel.Size = new System.Drawing.Size(241, 33);
            this.addlabel.TabIndex = 79;
            this.addlabel.Text = "Requested Books";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.BackColor = System.Drawing.Color.White;
            this.fromLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLabel.ForeColor = System.Drawing.Color.DimGray;
            this.fromLabel.Location = new System.Drawing.Point(17, 66);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(56, 21);
            this.fromLabel.TabIndex = 91;
            this.fromLabel.Text = "From: ";
            // 
            // atLabel
            // 
            this.atLabel.AutoSize = true;
            this.atLabel.BackColor = System.Drawing.Color.White;
            this.atLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atLabel.ForeColor = System.Drawing.Color.DimGray;
            this.atLabel.Location = new System.Drawing.Point(17, 129);
            this.atLabel.Name = "atLabel";
            this.atLabel.Size = new System.Drawing.Size(38, 21);
            this.atLabel.TabIndex = 92;
            this.atLabel.Text = "At: ";
            // 
            // toppanel
            // 
            this.toppanel.Controls.Add(this.branchLabel);
            this.toppanel.Controls.Add(this.atLabel);
            this.toppanel.Controls.Add(this.fromLabel);
            this.toppanel.Controls.Add(this.addlabel);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(640, 178);
            this.toppanel.TabIndex = 97;
            // 
            // branchLabel
            // 
            this.branchLabel.AutoSize = true;
            this.branchLabel.BackColor = System.Drawing.Color.White;
            this.branchLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchLabel.ForeColor = System.Drawing.Color.DimGray;
            this.branchLabel.Location = new System.Drawing.Point(17, 97);
            this.branchLabel.Name = "branchLabel";
            this.branchLabel.Size = new System.Drawing.Size(73, 21);
            this.branchLabel.TabIndex = 93;
            this.branchLabel.Text = "Branch: ";
            // 
            // ListBooksInRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 792);
            this.Controls.Add(this.booklistpanel);
            this.Controls.Add(this.confirmationpanel);
            this.Controls.Add(this.toppanel);
            this.Controls.Add(this.comboBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListBooksInRequest";
            this.Text = "ListBooksInRequest";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ListBooksInRequest_Paint);
            this.confirmationpanel.ResumeLayout(false);
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel booklistpanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel confirmationpanel;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label addlabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label atLabel;
        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Label branchLabel;
    }
}