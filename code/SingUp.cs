using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

using utilityfunctions;

namespace CentralLibrary
{
    public partial class SingUp : Form
    {
        Controller controllerObj;
        List<int> branchIDs;
        public SingUp(ref Controller c)
        {
            InitializeComponent();
            controllerObj = c;
            
            try
            {
                DataTable branches = controllerObj.SelectAll("Branch");
                if (branches != null)
                {
                    List<string> listOfBranches = new List<string>();
                    branchIDs = new List<int>();
                    foreach (DataRow branch in branches.Rows)
                    {
                        listOfBranches.Add(branch["bname"] + ", " + branch["blocation"]);
                        branchIDs.Add(int.Parse(branch["ID"].ToString()));
                    }
                    branchComboBox.DataSource = listOfBranches;

                } else
                {
                    signupvalidation.Text = "Make sure you have a working internet connection.";
                    signupvalidation.Visible = true;
                }
            } 
            // This catch will probably NOT get executed, because any exceptions to occur will be caught by the dbManager first.
            // I kept it just for reassurance.
            catch
            {
                signupvalidation.Text = "Make sure you have a working internet connection.";
                signupvalidation.Visible = true;
            }


        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Hiding the sign up form, and creating a new form for signing in.
            SignIn signin = new SignIn(ref controllerObj);
            this.Hide();
            signin.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            signupvalidation.ForeColor = utilityfunctions.Globals.redColor;
            signupvalidation.Visible = false;

            // First validating all entered data.
            string firstname = signinfirstname.Text;
            string lastname = signinlastname.Text;
            string email = signinemailtextbox.Text;
            string password = signinpassowrdtextbox.Text;
            string repassword = signinrepasswordtextbox.Text;

            DateTime example = agedatetimepicker.Value;
            // Calculating age.
            int age = DateTime.Now.Year - agedatetimepicker.Value.Year;
            if (agedatetimepicker.Value.AddYears(age) > DateTime.Now) age--;

            

            // First validation: All values are filled.
            if (String.IsNullOrEmpty(firstname) || String.IsNullOrEmpty(lastname) || String.IsNullOrEmpty(email)
                || String.IsNullOrEmpty(password) || gendercombobox.SelectedItem == null
                || String.IsNullOrEmpty(repassword) || termsandconditions.Checked == false
                || branchComboBox.SelectedItem == null
                )
            {
                signupvalidation.Text = "Please, fill all the required fields, and agree to the terms and conditions.";
                signupvalidation.Visible = true;
                return;
            }

            if (functions.ValidateFields(firstname, lastname, email, password, repassword, age, ref signupvalidation, true))
            {
                if (controllerObj.CheckIfXIsUsed("Person", "email", email) != 0)
                {
                    signupvalidation.Text = "An account already exists with this email.";
                    signupvalidation.Visible = true;
                    return;
                }
                else
                {
                    try
                    {
                        // ID Generation. 
                        // The reader's ID will start with 3 originally.
                        // But here, it starts with 5 only till their subscribtion request is accepted.
                        // Only then, their ID will be updated, and the 5 will be replaced by 3.
                        // See in SignIn form the switch case for 5.
                        string x = utilityfunctions.functions.RandomDigits(14);
                        while (controllerObj.CheckIfXIsUsed("Person", "ID", "5" + x) > 0 || controllerObj.CheckIfXIsUsed("Person", "ID", "3" + x) > 0)
                            x = utilityfunctions.functions.RandomDigits(14);

                        string PendingID = "5" + x;
                        string encryptedPassword = BCrypt.Net.BCrypt.HashPassword(password);


                        parameterToAProcedure IDPar = new parameterToAProcedure("@ID", PendingID);
                        parameterToAProcedure passwordPar = new parameterToAProcedure("@ppassword", encryptedPassword);
                        parameterToAProcedure firstnamePar = new parameterToAProcedure("@pfirstname", firstname);
                        parameterToAProcedure lastnamePar = new parameterToAProcedure("@plastname", lastname);
                        parameterToAProcedure emailPar = new parameterToAProcedure("@email", email);
                        parameterToAProcedure genderPar = new parameterToAProcedure("@gender", gendercombobox.SelectedItem.ToString());
                        parameterToAProcedure birthdatePar = new parameterToAProcedure("@birthdate", agedatetimepicker.Value.Date);
                        parameterToAProcedure branchIDPar = new parameterToAProcedure("@branchID", controllerObj.branchIDs[branchComboBox.SelectedIndex]);

                        if (controllerObj.ExecuteNonStoredProcedure("AddReader", IDPar, passwordPar, firstnamePar, lastnamePar, emailPar, genderPar, birthdatePar, branchIDPar) == 0)
                            throw new Exception();
                        else
                        {
                            signupvalidation.Text = "Request for subscribtion has been sent successfully and is waiting for a librarian's approval!";
                            signupvalidation.Visible = true;
                            signupvalidation.ForeColor = utilityfunctions.Globals.greenColor;
                            
                            
                            // Clearing all the fields.
                            signinfirstname.Text = signinlastname.Text = signinpassowrdtextbox.Text = signinrepasswordtextbox.Text = signinemailtextbox.Text = "";
                            gendercombobox.SelectedItem = null;
                            branchComboBox.SelectedItem = null;
                            termsandconditions.Checked = false;
                            agedatetimepicker.Value = DateTime.Today;
                        }
                    }
                    catch
                    {
                        signupvalidation.Text = "Something wrong happened. Try signing up again later.";
                        signupvalidation.Visible = true;
                        return;
                    }
                }
            }

        }
    }
}
