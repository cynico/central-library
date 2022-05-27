using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using utilityfunctions;
using System.Web.Security;

namespace CentralLibrary
{
    public partial class AddEmployee : Form
    {
        Controller controllerObj;
        string employeePosition;
        List<int> branchIDs;

        public AddEmployee(ref Controller c, string position)
        {
            InitializeComponent();
            controllerObj = c;
            employeePosition = position;

            addlabel.Text = String.Format("Add {0}", employeePosition);
            addButton.Text = addlabel.Text;

            branchIDs = new List<int>();
            List<string> listOfBranches = new List<string>();



            // IF it's the hiring of an administrator by the owner, show all branches.
            if (employeePosition.ToLower() == "administrator")
            {

                DataTable branches = controllerObj.SelectAll("Branch");
                if (branches != null)
                {
                    foreach (DataRow branch in branches.Rows)
                    {
                        listOfBranches.Add(branch["bname"] + ", " + branch["blocation"]);
                        branchIDs.Add(int.Parse(branch["ID"].ToString()));
                    }
                    listOfBranches.Add("Unassigned");
                    branchComboBox.DataSource = listOfBranches;
                }


            } else // IF it's the hiring of a librarian
            {
                // By the owner

                if (controllerObj.employeeType == 0)
                {
                    DataTable branches = controllerObj.SelectAll("Branch");
                    if (branches != null)
                    {
                        foreach (DataRow branch in branches.Rows)
                        {
                            listOfBranches.Add(branch["bname"] + ", " + branch["blocation"]);
                            branchIDs.Add(int.Parse(branch["ID"].ToString()));
                        }
                        branchComboBox.DataSource = listOfBranches;
                    }
                }
                // By an administrator (only administrators assigned to a branch are forwarded to this from, thus )
                // there's no need to check upon that.

                else
                {

                    using (DataTable branches = controllerObj.GetBranchOfEmployee(controllerObj.currID))
                    {
                        if (branches == null)
                        {
                            // This an unassigned administrator, do not allow them to hire librarian at all.
                        }
                        else
                        {
                            foreach (DataRow branch in branches.Rows)
                            {
                                listOfBranches.Add(branch["bname"] + ", " + branch["blocation"]);
                                branchIDs.Add(int.Parse(branch["branchID"].ToString()));
                            }
                            branchComboBox.DataSource = listOfBranches;
                        }
                    }

                }
             
            
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            newEmployeeValidation.ForeColor = Color.FromArgb(244, 67, 54);
            newEmployeeValidation.Visible = false;

            // First validating all entered data.
            string firstname = NewEmployeeFname.Text;
            string lastname = newEmployeeLname.Text;
            string email = newEmployeeEmail.Text.ToLower();
            string password = Membership.GeneratePassword(12, 1);

            // Calculating age.
            int age = DateTime.Now.Year - newEmployeeAge.Value.Year;
            if (newEmployeeAge.Value.AddYears(age) > DateTime.Now) age--;



            // First validation: All values are filled.
            if (String.IsNullOrEmpty(firstname) || String.IsNullOrEmpty(lastname) || String.IsNullOrEmpty(email)
                || newEmployeeGender.SelectedItem == null)
            {
                newEmployeeValidation.Text = "Please, fill all the required fields.";
                newEmployeeValidation.Visible = true;
                return;
            }

            if (functions.ValidateFields(firstname, lastname, email, password, password, age, ref newEmployeeValidation, true))
            {

                if (double.TryParse(initsalarytb.Text, out double initSalary))
                {
                    if (controllerObj.CheckIfXIsUsed("Person", "email", email) != 0)
                    {
                        newEmployeeValidation.Text = "An account already exists with this email.";
                        newEmployeeValidation.Visible = true;
                        return;
                    }
                    else
                    {
                        if (String.IsNullOrEmpty(confirmationPassword.Text))
                        {
                            newEmployeeValidation.Text = "Please, enter your password to complete singing this administrator up.";
                            newEmployeeValidation.Visible = true;
                        }
                        else if (!controllerObj.verifyPassword(confirmationPassword.Text))
                        {
                            newEmployeeValidation.Text = "Wrong password.";
                            newEmployeeValidation.Visible = true;
                        }
                        else
                        {
                            // Random ID generation. ID starts with 1 for administrators, and 2 for librarians.
                            string startingDigit = "";
                            if (employeePosition == "Administrator")
                                startingDigit = "1";
                            else if (employeePosition == "Librarian")
                                startingDigit = "2";

                            string ID = startingDigit + utilityfunctions.functions.RandomDigits(14);
                            
                            // If this ID is used, keep generating till finding an unused one.
                            while (controllerObj.CheckIfXIsUsed("Person", "ID", ID) > 0)
                                ID = startingDigit + utilityfunctions.functions.RandomDigits(14);

                            parameterToAProcedure parID = new parameterToAProcedure();
                            parID.name = "@ID";
                            parID.value = ID;

                            parameterToAProcedure parEmail = new parameterToAProcedure();
                            parEmail.name = "@email";
                            parEmail.value = email;

                            parameterToAProcedure parImg = new parameterToAProcedure();
                            parImg.name = "@img";
                            parImg.value = "nopicture.jpg";

                            parameterToAProcedure parGender = new parameterToAProcedure();
                            parGender.name = "@gender";
                            parGender.value = newEmployeeGender.SelectedItem.ToString();

                            parameterToAProcedure parPpassowrd = new parameterToAProcedure();
                            parPpassowrd.name = "@ppassword";
                            parPpassowrd.value = (string)BCrypt.Net.BCrypt.HashPassword(password).ToString();


                            parameterToAProcedure parplastname = new parameterToAProcedure();
                            parplastname.name = "@plastname";
                            parplastname.value = (string)lastname;

                            parameterToAProcedure parpfirstname = new parameterToAProcedure();
                            parpfirstname.name = "@pfirstname";
                            parpfirstname.value = firstname;

                            parameterToAProcedure parSalary = new parameterToAProcedure();
                            parSalary.name = "@salary";
                            parSalary.value = (double)initSalary;

                            parameterToAProcedure parHiredDate = new parameterToAProcedure();
                            parHiredDate.name = "@hired_date";
                            parHiredDate.value = DateTime.Today;

                            parameterToAProcedure parBranchID = new parameterToAProcedure();
                            parBranchID.name = "@branchID";

                            if (branchComboBox.SelectedItem.ToString() == "Unassigned")
                                parBranchID.value = DBNull.Value;
                            else
                                parBranchID.value = branchIDs[branchComboBox.SelectedIndex];


                            parameterToAProcedure parExpDate = new parameterToAProcedure();
                            parExpDate.name = "@birthdate";
                            parExpDate.value = newEmployeeAge.Value;

                            if (controllerObj.ExecuteNonStoredProcedure(String.Format("Add{0}", employeePosition), parID, parEmail, parImg, parGender, parPpassowrd, parplastname, parpfirstname, parSalary, parHiredDate, parBranchID, parExpDate) == 0)
                            {
                                newEmployeeValidation.Text = String.Format("Something wrong happened adding this {0}. Try again later.", employeePosition);
                                newEmployeeValidation.Visible = true;
                            } else
                            {
                                newEmployeeValidation.ForeColor = Color.FromArgb(0, 200, 83);
                                newEmployeeValidation.Text = String.Format("{0} added Successfully! They can now log in with the provided credentials.", employeePosition);
                                newEmployeeValidation.Visible = true;

                                
                                // Clearing all fields.
                                NewEmployeeFname.Text = "";
                                newEmployeeLname.Text = "";
                                newEmployeeEmail.Text = "";
                                initsalarytb.Text = "";
                                confirmationPassword.Text = "";
                                newEmployeeAge.Value = DateTime.Today;
                                newEmployeeGender.Text = "";
                                branchComboBox.Text = "";
                                addButton.Visible = false;

                                // Creating a form with the credentials.
                                ProvidingCredentials newform = new ProvidingCredentials(email, password, employeePosition);
                                newform.Show();

                            }
                        }
                    }
                } else
                {
                    newEmployeeValidation.Text = "Please, enter valid initial salary value.";
                    newEmployeeValidation.Visible = true;
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (employeePosition == "Administrator")
                ((MainForm)this.Parent.Parent).openChildForm(new ListAdmins(ref controllerObj));
            else
                ((MainForm)this.Parent.Parent).openChildForm(new ListLibrarians(ref controllerObj));
        }
    }
}
