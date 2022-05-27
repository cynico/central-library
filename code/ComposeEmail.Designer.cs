
namespace CentralLibrary
{
    partial class ComposeEmail
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
            this.compose_validation_tb = new System.Windows.Forms.Label();
            this.sendemailbutton = new System.Windows.Forms.Button();
            this.to_textbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label17 = new System.Windows.Forms.Label();
            this.emailbody_textbox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.subject_textbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // compose_validation_tb
            // 
            this.compose_validation_tb.AutoSize = true;
            this.compose_validation_tb.BackColor = System.Drawing.Color.White;
            this.compose_validation_tb.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.compose_validation_tb.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.compose_validation_tb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.compose_validation_tb.Location = new System.Drawing.Point(16, 52);
            this.compose_validation_tb.Name = "compose_validation_tb";
            this.compose_validation_tb.Size = new System.Drawing.Size(143, 16);
            this.compose_validation_tb.TabIndex = 49;
            this.compose_validation_tb.Text = "Body must not be empty.";
            this.compose_validation_tb.Visible = false;
            // 
            // sendemailbutton
            // 
            this.sendemailbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.sendemailbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendemailbutton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendemailbutton.ForeColor = System.Drawing.Color.White;
            this.sendemailbutton.Location = new System.Drawing.Point(19, 740);
            this.sendemailbutton.Name = "sendemailbutton";
            this.sendemailbutton.Size = new System.Drawing.Size(163, 40);
            this.sendemailbutton.TabIndex = 4;
            this.sendemailbutton.Text = "Send";
            this.sendemailbutton.UseVisualStyleBackColor = false;
            this.sendemailbutton.Click += new System.EventHandler(this.sendemailbutton_Click);
            // 
            // to_textbox
            // 
            this.to_textbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.to_textbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.to_textbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.to_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.to_textbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.to_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.to_textbox.HintForeColor = System.Drawing.Color.Empty;
            this.to_textbox.HintText = "To";
            this.to_textbox.isPassword = false;
            this.to_textbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.to_textbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.to_textbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.to_textbox.LineThickness = 3;
            this.to_textbox.Location = new System.Drawing.Point(13, 72);
            this.to_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.to_textbox.MaxLength = 32767;
            this.to_textbox.Name = "to_textbox";
            this.to_textbox.Size = new System.Drawing.Size(609, 31);
            this.to_textbox.TabIndex = 1;
            this.to_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.label17.Location = new System.Drawing.Point(12, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(145, 33);
            this.label17.TabIndex = 42;
            this.label17.Text = "Compose";
            // 
            // emailbody_textbox
            // 
            this.emailbody_textbox.Location = new System.Drawing.Point(12, 236);
            this.emailbody_textbox.Name = "emailbody_textbox";
            this.emailbody_textbox.Size = new System.Drawing.Size(609, 487);
            this.emailbody_textbox.TabIndex = 3;
            this.emailbody_textbox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.label2.Location = new System.Drawing.Point(14, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 22);
            this.label2.TabIndex = 52;
            this.label2.Text = "Body";
            // 
            // subject_textbox
            // 
            this.subject_textbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.subject_textbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.subject_textbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.subject_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.subject_textbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.subject_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.subject_textbox.HintForeColor = System.Drawing.Color.Empty;
            this.subject_textbox.HintText = "Subject";
            this.subject_textbox.isPassword = false;
            this.subject_textbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.subject_textbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.subject_textbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.subject_textbox.LineThickness = 3;
            this.subject_textbox.Location = new System.Drawing.Point(13, 135);
            this.subject_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.subject_textbox.MaxLength = 32767;
            this.subject_textbox.Name = "subject_textbox";
            this.subject_textbox.Size = new System.Drawing.Size(609, 31);
            this.subject_textbox.TabIndex = 2;
            this.subject_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.DimGray;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(458, 740);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(163, 40);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // ComposeEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 792);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.subject_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailbody_textbox);
            this.Controls.Add(this.compose_validation_tb);
            this.Controls.Add(this.sendemailbutton);
            this.Controls.Add(this.to_textbox);
            this.Controls.Add(this.label17);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComposeEmail";
            this.Text = "composeemail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label compose_validation_tb;
        private System.Windows.Forms.Button sendemailbutton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox to_textbox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RichTextBox emailbody_textbox;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox subject_textbox;
        private System.Windows.Forms.Button closeButton;
    }
}