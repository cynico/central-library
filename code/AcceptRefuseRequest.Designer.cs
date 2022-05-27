
namespace CentralLibrary
{
    partial class AcceptRefuseRequest
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
            this.contactSender = new System.Windows.Forms.Button();
            this.rejectRequestButton = new System.Windows.Forms.Button();
            this.acceptRequest = new System.Windows.Forms.Button();
            this.cancelrequestact = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.requestvalidation = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.mainbodypanel = new System.Windows.Forms.Panel();
            this.requestbody = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.viewButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.mainbodypanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // contactSender
            // 
            this.contactSender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.contactSender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contactSender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contactSender.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactSender.ForeColor = System.Drawing.Color.White;
            this.contactSender.Location = new System.Drawing.Point(7, 12);
            this.contactSender.Name = "contactSender";
            this.contactSender.Size = new System.Drawing.Size(158, 25);
            this.contactSender.TabIndex = 35;
            this.contactSender.Text = "Contact Sender";
            this.contactSender.UseVisualStyleBackColor = false;
            this.contactSender.Click += new System.EventHandler(this.contactSender_Click);
            // 
            // rejectRequestButton
            // 
            this.rejectRequestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.rejectRequestButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rejectRequestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rejectRequestButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rejectRequestButton.ForeColor = System.Drawing.Color.White;
            this.rejectRequestButton.Location = new System.Drawing.Point(194, 43);
            this.rejectRequestButton.Name = "rejectRequestButton";
            this.rejectRequestButton.Size = new System.Drawing.Size(158, 25);
            this.rejectRequestButton.TabIndex = 33;
            this.rejectRequestButton.Text = "Reject";
            this.rejectRequestButton.UseVisualStyleBackColor = false;
            this.rejectRequestButton.Click += new System.EventHandler(this.rejectRequest_click);
            // 
            // acceptRequest
            // 
            this.acceptRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.acceptRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acceptRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptRequest.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptRequest.ForeColor = System.Drawing.Color.White;
            this.acceptRequest.Location = new System.Drawing.Point(377, 43);
            this.acceptRequest.Name = "acceptRequest";
            this.acceptRequest.Size = new System.Drawing.Size(158, 25);
            this.acceptRequest.TabIndex = 32;
            this.acceptRequest.Text = "Accept";
            this.acceptRequest.UseVisualStyleBackColor = false;
            this.acceptRequest.Click += new System.EventHandler(this.acceptRequest_Click);
            // 
            // cancelrequestact
            // 
            this.cancelrequestact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.cancelrequestact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelrequestact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelrequestact.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelrequestact.ForeColor = System.Drawing.Color.White;
            this.cancelrequestact.Location = new System.Drawing.Point(7, 43);
            this.cancelrequestact.Name = "cancelrequestact";
            this.cancelrequestact.Size = new System.Drawing.Size(158, 25);
            this.cancelrequestact.TabIndex = 31;
            this.cancelrequestact.Text = "Cancel";
            this.cancelrequestact.UseVisualStyleBackColor = false;
            this.cancelrequestact.Click += new System.EventHandler(this.cancelrequestact_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.requestvalidation);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 59);
            this.panel1.TabIndex = 36;
            // 
            // requestvalidation
            // 
            this.requestvalidation.AutoSize = true;
            this.requestvalidation.BackColor = System.Drawing.Color.White;
            this.requestvalidation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.requestvalidation.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.requestvalidation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.requestvalidation.Location = new System.Drawing.Point(4, 30);
            this.requestvalidation.Name = "requestvalidation";
            this.requestvalidation.Size = new System.Drawing.Size(194, 16);
            this.requestvalidation.TabIndex = 42;
            this.requestvalidation.Text = " Please Enter A Valid Email Address.";
            this.requestvalidation.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.label17.Location = new System.Drawing.Point(3, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(190, 21);
            this.label17.TabIndex = 37;
            this.label17.Text = "Accept/reject request.";
            // 
            // mainbodypanel
            // 
            this.mainbodypanel.AutoSize = true;
            this.mainbodypanel.BackColor = System.Drawing.Color.Transparent;
            this.mainbodypanel.Controls.Add(this.requestbody);
            this.mainbodypanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainbodypanel.Location = new System.Drawing.Point(0, 59);
            this.mainbodypanel.Name = "mainbodypanel";
            this.mainbodypanel.Size = new System.Drawing.Size(547, 141);
            this.mainbodypanel.TabIndex = 37;
            // 
            // requestbody
            // 
            this.requestbody.AutoSize = true;
            this.requestbody.BackColor = System.Drawing.Color.White;
            this.requestbody.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestbody.ForeColor = System.Drawing.Color.DimGray;
            this.requestbody.Location = new System.Drawing.Point(12, 14);
            this.requestbody.MaximumSize = new System.Drawing.Size(519, 0);
            this.requestbody.Name = "requestbody";
            this.requestbody.Size = new System.Drawing.Size(152, 17);
            this.requestbody.TabIndex = 38;
            this.requestbody.Text = "Accept/reject request.";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.viewButton);
            this.panel3.Controls.Add(this.cancelrequestact);
            this.panel3.Controls.Add(this.rejectRequestButton);
            this.panel3.Controls.Add(this.contactSender);
            this.panel3.Controls.Add(this.acceptRequest);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(547, 80);
            this.panel3.TabIndex = 38;
            // 
            // viewButton
            // 
            this.viewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.viewButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewButton.ForeColor = System.Drawing.Color.White;
            this.viewButton.Location = new System.Drawing.Point(194, 12);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(158, 25);
            this.viewButton.TabIndex = 36;
            this.viewButton.Text = "View Details";
            this.viewButton.UseVisualStyleBackColor = false;
            this.viewButton.Visible = false;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // AcceptRefuseRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(547, 200);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.mainbodypanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AcceptRefuseRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "acceptRefuseRequest";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.acceptRefuseRequest_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mainbodypanel.ResumeLayout(false);
            this.mainbodypanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button contactSender;
        private System.Windows.Forms.Button rejectRequestButton;
        private System.Windows.Forms.Button acceptRequest;
        private System.Windows.Forms.Button cancelrequestact;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel mainbodypanel;
        private System.Windows.Forms.Label requestbody;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label requestvalidation;
        private System.Windows.Forms.Button viewButton;
    }
}