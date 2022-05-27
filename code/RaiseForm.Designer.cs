
namespace CentralLibrary
{
    partial class RaiseForm
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
            this.raiseFromRaiseButton = new System.Windows.Forms.Button();
            this.cancelRaise = new System.Windows.Forms.Button();
            this.newSalaryTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.raisePasswordConfirmation = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.raiseValidationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.label17.Location = new System.Drawing.Point(10, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 21);
            this.label17.TabIndex = 36;
            this.label17.Text = "Raise salary";
            // 
            // raiseFromRaiseButton
            // 
            this.raiseFromRaiseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.raiseFromRaiseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.raiseFromRaiseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raiseFromRaiseButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raiseFromRaiseButton.ForeColor = System.Drawing.Color.White;
            this.raiseFromRaiseButton.Location = new System.Drawing.Point(455, 275);
            this.raiseFromRaiseButton.Name = "raiseFromRaiseButton";
            this.raiseFromRaiseButton.Size = new System.Drawing.Size(158, 25);
            this.raiseFromRaiseButton.TabIndex = 34;
            this.raiseFromRaiseButton.Text = "Raise";
            this.raiseFromRaiseButton.UseVisualStyleBackColor = false;
            this.raiseFromRaiseButton.Click += new System.EventHandler(this.raiseFromRaiseButton_Click);
            // 
            // cancelRaise
            // 
            this.cancelRaise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.cancelRaise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelRaise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelRaise.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelRaise.ForeColor = System.Drawing.Color.White;
            this.cancelRaise.Location = new System.Drawing.Point(12, 275);
            this.cancelRaise.Name = "cancelRaise";
            this.cancelRaise.Size = new System.Drawing.Size(158, 25);
            this.cancelRaise.TabIndex = 33;
            this.cancelRaise.Text = "Cancel";
            this.cancelRaise.UseVisualStyleBackColor = false;
            this.cancelRaise.Click += new System.EventHandler(this.cancelRaise_Click);
            // 
            // newSalaryTb
            // 
            this.newSalaryTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.newSalaryTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.newSalaryTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.newSalaryTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newSalaryTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.newSalaryTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newSalaryTb.HintForeColor = System.Drawing.Color.Gray;
            this.newSalaryTb.HintText = "New Salary";
            this.newSalaryTb.isPassword = false;
            this.newSalaryTb.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.newSalaryTb.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.newSalaryTb.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.newSalaryTb.LineThickness = 3;
            this.newSalaryTb.Location = new System.Drawing.Point(12, 157);
            this.newSalaryTb.Margin = new System.Windows.Forms.Padding(4);
            this.newSalaryTb.MaxLength = 32767;
            this.newSalaryTb.Name = "newSalaryTb";
            this.newSalaryTb.Size = new System.Drawing.Size(173, 31);
            this.newSalaryTb.TabIndex = 45;
            this.newSalaryTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // raisePasswordConfirmation
            // 
            this.raisePasswordConfirmation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.raisePasswordConfirmation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.raisePasswordConfirmation.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.raisePasswordConfirmation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.raisePasswordConfirmation.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.raisePasswordConfirmation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.raisePasswordConfirmation.HintForeColor = System.Drawing.Color.Gray;
            this.raisePasswordConfirmation.HintText = "Password";
            this.raisePasswordConfirmation.isPassword = true;
            this.raisePasswordConfirmation.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.raisePasswordConfirmation.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.raisePasswordConfirmation.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.raisePasswordConfirmation.LineThickness = 3;
            this.raisePasswordConfirmation.Location = new System.Drawing.Point(12, 227);
            this.raisePasswordConfirmation.Margin = new System.Windows.Forms.Padding(4);
            this.raisePasswordConfirmation.MaxLength = 32767;
            this.raisePasswordConfirmation.Name = "raisePasswordConfirmation";
            this.raisePasswordConfirmation.Size = new System.Drawing.Size(297, 31);
            this.raisePasswordConfirmation.TabIndex = 46;
            this.raisePasswordConfirmation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.label3.Location = new System.Drawing.Point(8, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 21);
            this.label3.TabIndex = 47;
            this.label3.Text = "Password for confirmation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.label4.Location = new System.Drawing.Point(11, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 21);
            this.label4.TabIndex = 48;
            this.label4.Text = "New Salary";
            // 
            // raiseValidationLabel
            // 
            this.raiseValidationLabel.AutoSize = true;
            this.raiseValidationLabel.BackColor = System.Drawing.Color.White;
            this.raiseValidationLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.raiseValidationLabel.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.raiseValidationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.raiseValidationLabel.Location = new System.Drawing.Point(12, 42);
            this.raiseValidationLabel.Name = "raiseValidationLabel";
            this.raiseValidationLabel.Size = new System.Drawing.Size(0, 16);
            this.raiseValidationLabel.TabIndex = 50;
            this.raiseValidationLabel.Visible = false;
            // 
            // raiseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(625, 312);
            this.Controls.Add(this.raiseValidationLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.raisePasswordConfirmation);
            this.Controls.Add(this.newSalaryTb);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.raiseFromRaiseButton);
            this.Controls.Add(this.cancelRaise);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "raiseForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "raiseForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.raiseForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button raiseFromRaiseButton;
        private System.Windows.Forms.Button cancelRaise;
        private Bunifu.Framework.UI.BunifuMaterialTextbox newSalaryTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox raisePasswordConfirmation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label raiseValidationLabel;
    }
}