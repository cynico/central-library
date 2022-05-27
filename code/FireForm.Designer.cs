
namespace CentralLibrary
{
    partial class FireForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.firebutton = new System.Windows.Forms.Button();
            this.canceladminaction = new System.Windows.Forms.Button();
            this.fireConfirmationPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.fireValidationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.Color.White;
            this.headerLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.headerLabel.Location = new System.Drawing.Point(10, 21);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(268, 21);
            this.headerLabel.TabIndex = 34;
            this.headerLabel.Text = "Your\'e about to fire the following ";
            // 
            // firebutton
            // 
            this.firebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.firebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.firebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firebutton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firebutton.ForeColor = System.Drawing.Color.White;
            this.firebutton.Location = new System.Drawing.Point(12, 171);
            this.firebutton.Name = "firebutton";
            this.firebutton.Size = new System.Drawing.Size(158, 25);
            this.firebutton.TabIndex = 33;
            this.firebutton.Text = "Fire";
            this.firebutton.UseVisualStyleBackColor = false;
            this.firebutton.Click += new System.EventHandler(this.firebutton_Click);
            // 
            // canceladminaction
            // 
            this.canceladminaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.canceladminaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.canceladminaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.canceladminaction.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canceladminaction.ForeColor = System.Drawing.Color.White;
            this.canceladminaction.Location = new System.Drawing.Point(377, 171);
            this.canceladminaction.Name = "canceladminaction";
            this.canceladminaction.Size = new System.Drawing.Size(158, 25);
            this.canceladminaction.TabIndex = 31;
            this.canceladminaction.Text = "Cancel";
            this.canceladminaction.UseVisualStyleBackColor = false;
            this.canceladminaction.Click += new System.EventHandler(this.canceladminaction_Click);
            // 
            // fireConfirmationPass
            // 
            this.fireConfirmationPass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.fireConfirmationPass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.fireConfirmationPass.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.fireConfirmationPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fireConfirmationPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.fireConfirmationPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fireConfirmationPass.HintForeColor = System.Drawing.Color.Gray;
            this.fireConfirmationPass.HintText = "Password";
            this.fireConfirmationPass.isPassword = true;
            this.fireConfirmationPass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.fireConfirmationPass.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.fireConfirmationPass.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.fireConfirmationPass.LineThickness = 3;
            this.fireConfirmationPass.Location = new System.Drawing.Point(12, 130);
            this.fireConfirmationPass.Margin = new System.Windows.Forms.Padding(4);
            this.fireConfirmationPass.MaxLength = 32767;
            this.fireConfirmationPass.Name = "fireConfirmationPass";
            this.fireConfirmationPass.Size = new System.Drawing.Size(282, 31);
            this.fireConfirmationPass.TabIndex = 64;
            this.fireConfirmationPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.label1.Location = new System.Drawing.Point(10, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 21);
            this.label1.TabIndex = 65;
            this.label1.Text = "Password for confirmation";
            // 
            // fireValidationLabel
            // 
            this.fireValidationLabel.AutoSize = true;
            this.fireValidationLabel.BackColor = System.Drawing.Color.White;
            this.fireValidationLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.fireValidationLabel.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.fireValidationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.fireValidationLabel.Location = new System.Drawing.Point(12, 114);
            this.fireValidationLabel.Name = "fireValidationLabel";
            this.fireValidationLabel.Size = new System.Drawing.Size(27, 16);
            this.fireValidationLabel.TabIndex = 66;
            this.fireValidationLabel.Text = "test";
            this.fireValidationLabel.Visible = false;
            // 
            // FireForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(547, 208);
            this.Controls.Add(this.fireValidationLabel);
            this.Controls.Add(this.fireConfirmationPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.firebutton);
            this.Controls.Add(this.canceladminaction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FireForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fireForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.fireForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button firebutton;
        private System.Windows.Forms.Button canceladminaction;
        private Bunifu.Framework.UI.BunifuMaterialTextbox fireConfirmationPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fireValidationLabel;
    }
}