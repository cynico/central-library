
namespace CentralLibrary
{
    partial class ProvidingCredentials
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
            this.closecred = new System.Windows.Forms.Button();
            this.mainlabel = new System.Windows.Forms.Label();
            this.passworcopied = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closecred
            // 
            this.closecred.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.closecred.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closecred.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closecred.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closecred.ForeColor = System.Drawing.Color.White;
            this.closecred.Location = new System.Drawing.Point(273, 123);
            this.closecred.Name = "closecred";
            this.closecred.Size = new System.Drawing.Size(83, 30);
            this.closecred.TabIndex = 32;
            this.closecred.Text = "Close";
            this.closecred.UseVisualStyleBackColor = false;
            this.closecred.Click += new System.EventHandler(this.closecred_Click);
            // 
            // mainlabel
            // 
            this.mainlabel.AutoSize = true;
            this.mainlabel.BackColor = System.Drawing.Color.White;
            this.mainlabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.mainlabel.Location = new System.Drawing.Point(12, 9);
            this.mainlabel.Name = "mainlabel";
            this.mainlabel.Size = new System.Drawing.Size(199, 21);
            this.mainlabel.TabIndex = 66;
            this.mainlabel.Text = "Admin\'s new credentials";
            // 
            // passworcopied
            // 
            this.passworcopied.AutoSize = true;
            this.passworcopied.BackColor = System.Drawing.Color.White;
            this.passworcopied.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.passworcopied.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.passworcopied.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(83)))));
            this.passworcopied.Location = new System.Drawing.Point(13, 30);
            this.passworcopied.Name = "passworcopied";
            this.passworcopied.Size = new System.Drawing.Size(189, 17);
            this.passworcopied.TabIndex = 67;
            this.passworcopied.Text = "Password copied to clipboard!";
            this.passworcopied.Visible = false;
            // 
            // providingCredentials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(368, 168);
            this.Controls.Add(this.passworcopied);
            this.Controls.Add(this.mainlabel);
            this.Controls.Add(this.closecred);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "providingCredentials";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "providingCredentials";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.providingCredentials_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closecred;
        private System.Windows.Forms.Label mainlabel;
        private System.Windows.Forms.Label passworcopied;
    }
}