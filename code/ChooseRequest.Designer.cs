
namespace CentralLibrary
{
    partial class ChooseRequest
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
            this.chooserequesttype = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.cancelrequesttype = new System.Windows.Forms.Button();
            this.requestType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // chooserequesttype
            // 
            this.chooserequesttype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.chooserequesttype.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chooserequesttype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooserequesttype.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooserequesttype.ForeColor = System.Drawing.Color.White;
            this.chooserequesttype.Location = new System.Drawing.Point(377, 107);
            this.chooserequesttype.Name = "chooserequesttype";
            this.chooserequesttype.Size = new System.Drawing.Size(158, 25);
            this.chooserequesttype.TabIndex = 35;
            this.chooserequesttype.Text = "Choose";
            this.chooserequesttype.UseVisualStyleBackColor = false;
            this.chooserequesttype.Click += new System.EventHandler(this.chooserequesttype_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.label17.Location = new System.Drawing.Point(10, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(172, 21);
            this.label17.TabIndex = 34;
            this.label17.Text = "Choose request type";
            // 
            // cancelrequesttype
            // 
            this.cancelrequesttype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.cancelrequesttype.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelrequesttype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelrequesttype.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelrequesttype.ForeColor = System.Drawing.Color.White;
            this.cancelrequesttype.Location = new System.Drawing.Point(14, 107);
            this.cancelrequesttype.Name = "cancelrequesttype";
            this.cancelrequesttype.Size = new System.Drawing.Size(158, 25);
            this.cancelrequesttype.TabIndex = 31;
            this.cancelrequesttype.Text = "Cancel";
            this.cancelrequesttype.UseVisualStyleBackColor = false;
            this.cancelrequesttype.Click += new System.EventHandler(this.cancelrequesttype_Click);
            // 
            // requestType
            // 
            this.requestType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.requestType.FormattingEnabled = true;
            this.requestType.Items.AddRange(new object[] {
            "Business Meeting"});
            this.requestType.Location = new System.Drawing.Point(14, 57);
            this.requestType.Name = "requestType";
            this.requestType.Size = new System.Drawing.Size(168, 21);
            this.requestType.TabIndex = 36;
            // 
            // ChooseRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(547, 151);
            this.Controls.Add(this.requestType);
            this.Controls.Add(this.chooserequesttype);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cancelrequesttype);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChooseRequest";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "chooseRequest";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.chooseRequest_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chooserequesttype;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button cancelrequesttype;
        private System.Windows.Forms.ComboBox requestType;
    }
}