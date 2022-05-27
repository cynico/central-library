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
    public partial class Welcome : Form
    {
        Controller controllerObj;
        public Welcome(ref Controller c)
        {
            InitializeComponent();
            controllerObj = c;


            if (controllerObj.employeeType != 4)
                loggedinAs.Text += controllerObj.currFirstname + " " + controllerObj.currLastname;
            else
                loggedinAs.Text += controllerObj.currVendorName;


            if (controllerObj.employeeType == 0)
                positionlabel.Text += "Owner";
            else if (controllerObj.employeeType == 1)
                positionlabel.Text += "Administrator";
            else if (controllerObj.employeeType == 2)
                positionlabel.Text += "Librarian";
            else if (controllerObj.employeeType == 3)
                positionlabel.Visible = false;
            else if (controllerObj.employeeType == 4)
                positionlabel.Text += "Vendor";

            notificationLabel.Text = String.Format("You have {0} new notifications.", controllerObj.numberOfUnreadNotifications);
        }

        private void linkToSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ((MainForm)this.Parent.Parent).openChildForm(new Notifications(ref controllerObj));
        }
    }
}
