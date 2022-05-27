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
    public partial class ShowEmailContent : Form
    {
        Controller controllerObj;
        string email;
        public ShowEmailContent(ref Controller c, string subject, string text, string from_email, string from_name, string send_date, int type)
        {
            InitializeComponent();
            controllerObj = c;


            if (type != 1)
                fromLabel.Text = "To: ";


            emailTitle.Text = subject;
            emailBody.Text = text;
            fromLabel.Text += from_email;
            atLabel.Text += send_date;

            email = from_email;
        }

        private void closeEmailButton_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).openChildForm(new InboxForm(ref controllerObj));
        }

        private void ReplyButton_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).openChildForm(new ComposeEmail(ref controllerObj, email));

        }
    }
}
