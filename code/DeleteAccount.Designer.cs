
namespace CentralLibrary
{
    partial class DeleteAccount
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
            this.label17 = new System.Windows.Forms.Label();
            this.resignButton = new System.Windows.Forms.Button();
            this.cancelresign = new System.Windows.Forms.Button();
            this.resignvalidation = new System.Windows.Forms.Label();
            this.resignConfirmationPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.label17.Location = new System.Drawing.Point(10, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(377, 21);
            this.label17.TabIndex = 34;
            this.label17.Text = "Are you sure you want to delete your account?";
            // 
            // resignButton
            // 
            this.resignButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.resignButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resignButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resignButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resignButton.ForeColor = System.Drawing.Color.White;
            this.resignButton.Location = new System.Drawing.Point(12, 111);
            this.resignButton.Name = "resignButton";
            this.resignButton.Size = new System.Drawing.Size(158, 37);
            this.resignButton.TabIndex = 33;
            this.resignButton.Text = "Resign";
            this.resignButton.UseVisualStyleBackColor = false;
            this.resignButton.Click += new System.EventHandler(this.resignButton_Click);
            // 
            // cancelresign
            // 
            this.cancelresign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.cancelresign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelresign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelresign.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelresign.ForeColor = System.Drawing.Color.White;
            this.cancelresign.Location = new System.Drawing.Point(377, 111);
            this.cancelresign.Name = "cancelresign";
            this.cancelresign.Size = new System.Drawing.Size(158, 37);
            this.cancelresign.TabIndex = 31;
            this.cancelresign.Text = "Cancel";
            this.cancelresign.UseVisualStyleBackColor = false;
            this.cancelresign.Click += new System.EventHandler(this.cancelresign_Click);
            // 
            // resignvalidation
            // 
            this.resignvalidation.AutoSize = true;
            this.resignvalidation.BackColor = System.Drawing.Color.White;
            this.resignvalidation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.resignvalidation.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.resignvalidation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.resignvalidation.Location = new System.Drawing.Point(10, 33);
            this.resignvalidation.Name = "resignvalidation";
            this.resignvalidation.Size = new System.Drawing.Size(194, 16);
            this.resignvalidation.TabIndex = 42;
            this.resignvalidation.Text = " Please Enter A Valid Email Address.";
            this.resignvalidation.Visible = false;
            // 
            // resignConfirmationPass
            // 
            this.resignConfirmationPass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.resignConfirmationPass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.resignConfirmationPass.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.resignConfirmationPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.resignConfirmationPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.resignConfirmationPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.resignConfirmationPass.HintForeColor = System.Drawing.Color.DimGray;
            this.resignConfirmationPass.HintText = "Password";
            this.resignConfirmationPass.isPassword = true;
            this.resignConfirmationPass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.resignConfirmationPass.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.resignConfirmationPass.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.resignConfirmationPass.LineThickness = 3;
            this.resignConfirmationPass.Location = new System.Drawing.Point(14, 59);
            this.resignConfirmationPass.Margin = new System.Windows.Forms.Padding(4);
            this.resignConfirmationPass.MaxLength = 32767;
            this.resignConfirmationPass.Name = "resignConfirmationPass";
            this.resignConfirmationPass.Size = new System.Drawing.Size(297, 31);
            this.resignConfirmationPass.TabIndex = 43;
            this.resignConfirmationPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.resignConfirmationPass.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(11, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "The owner will be notified by this, and you will need to wait for their approval." +
    "";
            // 
            // DeleteAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(547, 160);
            this.Controls.Add(this.resignConfirmationPass);
            this.Controls.Add(this.resignvalidation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.resignButton);
            this.Controls.Add(this.cancelresign);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "deleteAccount";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.deleteAccount_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button resignButton;
        private System.Windows.Forms.Button cancelresign;
        private System.Windows.Forms.Label resignvalidation;
        private Bunifu.Framework.UI.BunifuMaterialTextbox resignConfirmationPass;
        private System.Windows.Forms.Label label1;
    }
}