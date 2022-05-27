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
    public partial class FireRaise : Form
    {
        Controller controllerObj;
        string employeeID, employeeEmail, employeeName, employeeHiredDate, employeePosition, vendorAddress, vendorPhoneNumber;
        double employeeSalary;
        int numOfVendorBranchesContracts;


        // position is used to indicate whether this is an administrator or librarian.
        // This is to reuse the same form for both purposes.

        // privileged is used to inidcate whether the logged-in employee has the privilege
        // to fire/raise this employee they're viewing.
        public FireRaise(ref Controller c, string name, string email, string ID, double salary, string hired_date, string position, bool privileged,
            string address="", string phoneNumber = "", int n = -1, int branchID = -1)
        {
            InitializeComponent();
            controllerObj = c;
            employeeID = ID;
            employeeEmail = email;
            employeeName = name;
            employeeSalary = salary;
            employeeHiredDate = hired_date;
            employeePosition = position;
            vendorAddress = address;
            vendorPhoneNumber = phoneNumber;

            numOfVendorBranchesContracts = n;


            headerLabel.Text += employeePosition.ToLower() + "?";

            if (!privileged)
            {
                fireEmployeeButton.Visible = false;
                raiseEmployeeButton.Visible = false;
            }

            if (position == "Vendor")
            {
                if (controllerObj.employeeType == 0)
                    fireEmployeeButton.Text = "Remove";
                else
                    fireEmployeeButton.Text = "End Contract";

                raiseEmployeeButton.Visible = false;
            }

            if (position == "Reader")
            {
                raiseEmployeeButton.Visible = false;
                fireEmployeeButton.Text = "Remove";
            }


            ShowInfo();
        }

        private void ShowInfo()
        {
            int initialYPosition = 10;
            int i = 0;

            Label nameLabel = new Label();
            nameLabel.Font = new Font("Century Gothic", float.Parse("9.75"), System.Drawing.FontStyle.Regular);
            nameLabel.ForeColor = Color.DimGray;
            nameLabel.Location = new Point(13, initialYPosition + i*28);
            nameLabel.Text = String.Format("{0}: {1}", employeePosition, employeeName);
            nameLabel.Parent = contentPanel;
            nameLabel.AutoSize = true;
            i++;

            Label emailLabel = new Label();
            emailLabel.Font = new Font("Century Gothic", float.Parse("9.75"), System.Drawing.FontStyle.Regular);
            emailLabel.ForeColor = Color.DimGray;
            emailLabel.Location = new Point(13, initialYPosition + i*28);
            emailLabel.Text = "Email: " + employeeEmail;
            emailLabel.Parent = contentPanel;
            emailLabel.AutoSize = true;
            i++;

            if (employeeHiredDate != "" && controllerObj.employeeType != 3)
            {
                Label hiredDateLabel = new Label();
                hiredDateLabel.Font = new Font("Century Gothic", float.Parse("9.75"), System.Drawing.FontStyle.Regular);
                hiredDateLabel.ForeColor = Color.DimGray;
                hiredDateLabel.Location = new Point(13, initialYPosition + i*28);
                
                
                if (employeePosition == "Vendor")
                    hiredDateLabel.Text = "Contract Date: " + employeeHiredDate;
                else if (employeePosition == "Reader")
                    hiredDateLabel.Text = "Subscribtion Date: " + employeeHiredDate;
                else
                    hiredDateLabel.Text = "Hired Date: " + employeeHiredDate;

                
                hiredDateLabel.Parent = contentPanel;
                hiredDateLabel.AutoSize = true;
                i++;
            }

            if (employeePosition == "Vendor")
            {
                Label addressLabel = new Label();
                addressLabel.Font = new Font("Century Gothic", float.Parse("9.75"), System.Drawing.FontStyle.Regular);
                addressLabel.ForeColor = Color.DimGray;
                addressLabel.Location = new Point(13, initialYPosition + i*28);
                addressLabel.Text = "Address: " + vendorAddress;
                addressLabel.Parent = this;
                addressLabel.AutoSize = true;
                i++;

                Label phoneLabel = new Label();
                phoneLabel.Font = new Font("Century Gothic", float.Parse("9.75"), System.Drawing.FontStyle.Regular);
                phoneLabel.ForeColor = Color.DimGray;
                phoneLabel.Location = new Point(13, initialYPosition + i*28);
                phoneLabel.Text = "Phone: " + vendorPhoneNumber;
                phoneLabel.Parent = contentPanel;
                phoneLabel.AutoSize = true;
                i++;
            }

        }

        private void canceladminaction_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fireRaiseAdmin_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.DimGray, 3), this.DisplayRectangle);
        }

        private void contactAdminButton_Click(object sender, EventArgs e)
        {
            ComposeEmail newform = new ComposeEmail(ref controllerObj, employeeEmail);
            newform.Show();
            this.Close();
        }

        private void raiseadmin_Click(object sender, EventArgs e)
        {
            RaiseForm newform = new RaiseForm(ref controllerObj, employeeName, employeeSalary, employeeID, employeePosition);
            newform.Show();
            this.Close();
        }

        private void fireEmployeeButton_Click(object sender, EventArgs e)
        {
            FireForm newform = new FireForm(ref controllerObj, employeeID, employeeName, employeeHiredDate, employeePosition, numOfVendorBranchesContracts);
            newform.Show();
            this.Close();
        }

        private void fireRaiseAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
