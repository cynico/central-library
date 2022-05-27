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
    public partial class ContractWithVendorAffirmation : Form
    {

        string vendorID;
        string vendorName;
        string vendorAddress;
        string vendorEmail;
        Controller controllerObj;
        public ContractWithVendorAffirmation(ref Controller c, string ID, string name, string address, string email)
        {
            InitializeComponent();
            controllerObj = c;
            vendorName = name;
            vendorAddress = address;
            vendorEmail = email;
            vendorID = ID;

            nameLabel.Text += name;
            addressLabel.Text += address;
            emailLabel.Text += email;
        }

        private void canceladminaction_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void requestbutton_Click(object sender, EventArgs e)
        {
            validationLabel.Visible = false;
            validationLabel.ForeColor = Color.FromArgb(244, 67, 54);

            if (String.IsNullOrEmpty(confirmationPass.Text)) { 
                validationLabel.Text = "Empty password.";
                validationLabel.Visible = true;
                return;
            } else if (!controllerObj.verifyPassword(confirmationPass.Text))
            {
                validationLabel.Text = "Wrong password.";
                validationLabel.Visible = true;
            } else
            {
                try
                {
                    if (controllerObj.SendRequest(String.Format("Contract request with branch {0} of Central Library.", controllerObj.currBranchName), 0, DateTime.Now, controllerObj.currID, vendorID, 3, int.Parse(controllerObj.currBranchID)) == 0)
                        throw new Exception();
                    else
                    {
                        validationLabel.ForeColor = Color.FromArgb(0, 200, 83);
                        validationLabel.Text = "Request sent successfully!";
                        validationLabel.Visible = true;
                        confirmationPass.Text = "";
                        requestbutton.Visible = false;
                    }
                } catch
                {
                    validationLabel.Text = "Something wrong happened. Try again later.";
                    validationLabel.Visible = true;
                }
            }
        
        
        }

        private void requestbutton_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.DimGray, 3), this.DisplayRectangle);

        }
    }
}
