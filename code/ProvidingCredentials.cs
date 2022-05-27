using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace CentralLibrary
{
    public partial class ProvidingCredentials : Form
    {
        string employeeEmail;
        string employeePassword;
        string employeePosition;

        public ProvidingCredentials(string email, string password, string position)
        {
            InitializeComponent();
            employeeEmail = email;
            employeePassword = password;
            employeePosition = position;

            mainlabel.Text = String.Format("{0}'s new credentials", employeePosition);
            ShowInfo();
        }

        private void ShowInfo()
        {
            Label emailLabel = new Label();
            emailLabel.Font = new Font("Century Gothic", float.Parse("9.25"), System.Drawing.FontStyle.Regular);
            emailLabel.ForeColor = Color.DimGray;
            emailLabel.Location = new Point(13, 55);
            emailLabel.Text = String.Format("Email: {0}", employeeEmail);
            emailLabel.Parent = this;
            emailLabel.AutoSize = true;
            emailLabel.Cursor = Cursors.IBeam;


            LinkLabel passwordLabel = new LinkLabel();
            passwordLabel.Font = new Font("Century Gothic", float.Parse("9.25"), System.Drawing.FontStyle.Regular);
            passwordLabel.Location = new Point(13, 83);
            passwordLabel.Text = "Password: " + employeePassword;
            passwordLabel.Parent = this;
            passwordLabel.AutoSize = true;
            passwordLabel.LinkColor = Color.DimGray;
            passwordLabel.ActiveLinkColor = Color.FromArgb(25, 118, 210);
            passwordLabel.MouseClick += (sender, e) =>
            {
                Clipboard.SetText(employeePassword);
                passworcopied.Visible = true;
            };
        }


        private void closecred_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void providingCredentials_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.DimGray, 3), this.DisplayRectangle);

        }
    }
}
