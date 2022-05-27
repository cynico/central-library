
namespace CentralLibrary
{
    partial class FireRaise
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
            this.raiseEmployeeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.fireEmployeeButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.contactEmployeeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // raiseEmployeeButton
            // 
            this.raiseEmployeeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.raiseEmployeeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.raiseEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raiseEmployeeButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raiseEmployeeButton.ForeColor = System.Drawing.Color.White;
            this.raiseEmployeeButton.Location = new System.Drawing.Point(3, 18);
            this.raiseEmployeeButton.Name = "raiseEmployeeButton";
            this.raiseEmployeeButton.Size = new System.Drawing.Size(158, 25);
            this.raiseEmployeeButton.TabIndex = 27;
            this.raiseEmployeeButton.Text = "Raise";
            this.raiseEmployeeButton.UseVisualStyleBackColor = false;
            this.raiseEmployeeButton.Click += new System.EventHandler(this.raiseadmin_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.DimGray;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(368, 49);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(158, 25);
            this.cancelButton.TabIndex = 26;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.canceladminaction_Click);
            // 
            // fireEmployeeButton
            // 
            this.fireEmployeeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.fireEmployeeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fireEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fireEmployeeButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fireEmployeeButton.ForeColor = System.Drawing.Color.White;
            this.fireEmployeeButton.Location = new System.Drawing.Point(3, 49);
            this.fireEmployeeButton.Name = "fireEmployeeButton";
            this.fireEmployeeButton.Size = new System.Drawing.Size(158, 25);
            this.fireEmployeeButton.TabIndex = 28;
            this.fireEmployeeButton.Text = "Fire";
            this.fireEmployeeButton.UseVisualStyleBackColor = false;
            this.fireEmployeeButton.Click += new System.EventHandler(this.fireEmployeeButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.Color.White;
            this.headerLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.headerLabel.Location = new System.Drawing.Point(8, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(413, 21);
            this.headerLabel.TabIndex = 29;
            this.headerLabel.Text = "What action would you like to take for the following ";
            // 
            // contactEmployeeButton
            // 
            this.contactEmployeeButton.BackColor = System.Drawing.Color.Gray;
            this.contactEmployeeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contactEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contactEmployeeButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactEmployeeButton.ForeColor = System.Drawing.Color.White;
            this.contactEmployeeButton.Location = new System.Drawing.Point(189, 49);
            this.contactEmployeeButton.Name = "contactEmployeeButton";
            this.contactEmployeeButton.Size = new System.Drawing.Size(158, 25);
            this.contactEmployeeButton.TabIndex = 30;
            this.contactEmployeeButton.Text = "Contact";
            this.contactEmployeeButton.UseVisualStyleBackColor = false;
            this.contactEmployeeButton.Click += new System.EventHandler(this.contactAdminButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.headerLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 39);
            this.panel1.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.raiseEmployeeButton);
            this.panel2.Controls.Add(this.cancelButton);
            this.panel2.Controls.Add(this.contactEmployeeButton);
            this.panel2.Controls.Add(this.fireEmployeeButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 90);
            this.panel2.TabIndex = 32;
            // 
            // contentPanel
            // 
            this.contentPanel.AutoSize = true;
            this.contentPanel.BackColor = System.Drawing.Color.Transparent;
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 39);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(547, 77);
            this.contentPanel.TabIndex = 33;
            // 
            // FireRaise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(547, 206);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FireRaise";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.fireRaiseAdmin_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.fireRaiseAdmin_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button raiseEmployeeButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button fireEmployeeButton;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button contactEmployeeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel contentPanel;
    }
}