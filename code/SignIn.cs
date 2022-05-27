using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;

using utilityfunctions;

namespace CentralLibrary
{
    public partial class SignIn : Form
    {

        Controller controllerObj;
        public SignIn(ref Controller c)
        {
            InitializeComponent();
            controllerObj = c;
        }

        private void notasub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SingUp signup = new SingUp(ref controllerObj);
            this.Hide();
            signup.ShowDialog();
            this.Close();
        }

        private void signinbutton_Click(object sender, EventArgs e)
        {

            validationLabel.Visible = false;

            string email = signinemailtextbox.Text.ToLower();
            string password = signinpassword.Text;

            var regexItem = new Regex("^[a-zA-Z0-9.@\\-]*$");


            // Uncomment whoever you want to log in as, and comment the rest.





            // A vendor
            email = "new2@gmail.com";
            password = "AoL{RsBA=DRx";

            // The owner


 




            //"I? iV; PZ % @n4O";


            // A reader in Cairo-4 dokki branch.
            email = "abdullah@gmail.com";
            password = "asdfghjkl;'A3@";





            email = "salemvendor@gmail.com";
            password = "9QW$gCwg3dDP";

            // The administrator in Cairo-4 dokki branch.
            email = "yusuf@gmail.com";
            password = "u)bVk@p;Te];";



            // A librarian in Cairo-4 dokki branch.
            email = "mahmoud@gmail.com";
            password = "VG/Z[;00j_bn";

            email = "belle@centrallibrary.gov";
            password = "ouwuner";



            // Validating the email: both to check it doesn't contain any forbidden characters, and to check it's in the
            // right form an email must have.

            if (!regexItem.IsMatch(email) || !utilityfunctions.functions.IsValidEmail(email))
            {
                validationLabel.Text = "Please Enter A Valid Email Address.";
                validationLabel.Visible = true;
            } else if (password.Length == 0)
            {
                validationLabel.Text = "Empty password.";
                validationLabel.Visible = true;
            } 
            else
            {

                validationLabel.Visible = false;
                string ID = "";
                // Check if the user exists in the database.
                int status = controllerObj.CheckIfUserExists(email, password, ref ID);
                MainForm mainForm = null;
                switch(status)
                {
                    case -1:
                        validationLabel.Text = "No user exists with this credentials.";
                        validationLabel.Visible = true;
                        return;
                    case -2:
                        validationLabel.Text = "Wrong Password.";
                        validationLabel.Visible = true;
                        return;
                    
                    case 0:
                        validationLabel.Visible = false;
                        mainForm = new MainForm(ref controllerObj);
                        break;

                    case 1:
                        validationLabel.Visible = false;
                        mainForm = new MainForm(ref controllerObj);
                        break;
                    
                    case 2:
                        validationLabel.Visible = false;
                        mainForm = new MainForm(ref controllerObj);
                        break;
                    case 3:
                        // Show the form associated with the readers and log them in. 
                        validationLabel.Visible = false;
                        mainForm = new MainForm(ref controllerObj);
                        break;

                    case 4:
                        validationLabel.Visible = false;
                        mainForm = new MainForm(ref controllerObj);
                        break;

                    case 5:
                        validationLabel.Text = "Your subscribtion request is pending approval. Contact any of the librarians in the branch you're subscribing to.";
                        validationLabel.Visible = true;
                        return;
                }

                // Storing the relevant info of the user.
                controllerObj.currID = ID;
                controllerObj.employeeType = int.Parse(controllerObj.currID.Substring(0, 1));
                controllerObj.UpdateAndStoreCurrentUserInfo();

                ((MainForm)mainForm).UpdateNotificationsCount();
                ((MainForm)mainForm).UpdateRequestCount();
                ((MainForm)mainForm).CustomizeFormAccordingToUserType();

                DataTable dt = null;
                if (controllerObj.employeeType < 3)
                    dt = controllerObj.GetBranchOfEmployee(controllerObj.currID);
                else if (controllerObj.employeeType == 3)
                    dt = controllerObj.GetBranchOfReader(controllerObj.currID);

                if (dt != null)
                {
                    controllerObj.currBranchID = dt.Rows[0]["ID"].ToString();
                    controllerObj.currBranchName = dt.Rows[0]["bname"].ToString() + ", " + dt.Rows[0]["blocation"].ToString();
                }
                if (controllerObj.employeeType == 4)
                    controllerObj.UpdateBranchesInContractWith();


                this.Hide();
                ((MainForm)mainForm).openChildForm(new Welcome(ref controllerObj));
                mainForm.ShowDialog();
                this.Close();

            }

        }
    }
}
