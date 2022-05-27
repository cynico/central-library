using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Security;
using utilityfunctions;

namespace CentralLibrary
{
    public partial class AddVendor : Form
    {
        Controller controllerObj;

        public AddVendor(ref Controller c)
        {
            InitializeComponent();
            controllerObj = c;

            List<string> branchNames = new List<string>(controllerObj.branchNames);

            if (controllerObj.employeeType == 0)
            {
                branchNames.Add("No Initial Contract");
                newbranchComboBox.DataSource = branchNames;
            }
            else
            {
                newbranchComboBox.Items.Add(controllerObj.currBranchName);
            }

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).openChildForm(new ListVendors(ref controllerObj));

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
            newVendorValidation.ForeColor = Color.FromArgb(244, 67, 54);
            newVendorValidation.Visible = false;

            // First validating all entered data.
            string name = newVendorName.Text;
            string email = newVendorEmail.Text.ToLower();
            string address = newVendorAddress.Text;
            string phoneNumber = newVendorPhone.Text;

            string password = Membership.GeneratePassword(12, 1);


            // First validation: All values are filled.
            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(email) || String.IsNullOrEmpty(address)
                || String.IsNullOrEmpty(phoneNumber) || newbranchComboBox.SelectedItem == null)
            {
                newVendorValidation.Text = "Please, fill all the required fields.";
                newVendorValidation.Visible = true;
                return;
            }

            if (utilityfunctions.functions.ValidateFields(name, name, email, password, password, 99, ref newVendorValidation, true, address, phoneNumber))
            {
                if (controllerObj.CheckIfXIsUsed("Person", "email", email) != 0)
                {
                    newVendorValidation.Text = "A vendor account already exists with this email.";
                    newVendorValidation.Visible = true;
                    return;
                }
                else
                {
                    if (String.IsNullOrEmpty(confirmationPassword.Text))
                    {
                        newVendorValidation.Text = "Please, enter your password to complete singing this administrator up.";
                        newVendorValidation.Visible = true;
                    }
                    else if (!controllerObj.verifyPassword(confirmationPassword.Text))
                    {
                        newVendorValidation.Text = "Wrong password.";
                        newVendorValidation.Visible = true;
                    }
                    else
                    {
                        // Random ID generation.
                        string startingDigit = "4";
                        string ID = startingDigit + utilityfunctions.functions.RandomDigits(14);

                        // If this ID is used, keep generating till finding an unused one.
                        while (controllerObj.CheckIfXIsUsed("Person", "ID", ID) > 0)
                            ID = startingDigit + utilityfunctions.functions.RandomDigits(14);

                        parameterToAProcedure parID = new parameterToAProcedure("@ID", ID);
                        parameterToAProcedure parEmail = new parameterToAProcedure("@email", email.ToLower());
                        parameterToAProcedure parVPassword = new parameterToAProcedure("vpassword", (string)BCrypt.Net.BCrypt.HashPassword(password).ToString());

                        parameterToAProcedure parVname = new parameterToAProcedure("@vname", name);
                        parameterToAProcedure parVAdress = new parameterToAProcedure("@paddress", address);
                        parameterToAProcedure parPhone = new parameterToAProcedure("@phone", phoneNumber);
                        parameterToAProcedure parBranchID = new parameterToAProcedure();
                        parBranchID.name = "@initialBranchID";



                        if (controllerObj.employeeType == 0)
                        {
                            if (newbranchComboBox.SelectedItem.ToString() == "No Initial Contract")
                                parBranchID.value = DBNull.Value;
                            else
                                parBranchID.value = controllerObj.branchIDs[newbranchComboBox.SelectedIndex];
                        }
                        else
                        {
                            parBranchID.value = controllerObj.currBranchID;
                        }

                        try
                        {
                            if (controllerObj.ExecuteNonStoredProcedure("AddVendor", parID, parVname, parEmail, parVPassword, parVAdress, parBranchID, parPhone) == 0)
                                throw new Exception();

                            else
                            {
                                newVendorValidation.ForeColor = Color.FromArgb(0, 200, 83);
                                newVendorValidation.Text = "Vendor Added Successfully! They can now log in with the provided credentials.";
                                newVendorValidation.Visible = true;


                                // Clearing all fields.
                                newVendorAddress.Text = "";
                                newVendorEmail.Text = "";
                                newVendorName.Text = "";
                                newVendorPhone.Text = "";
                                confirmationPassword.Text = "";
                                newbranchComboBox.Text = "";


                                // Creating a form with the credentials.
                                ProvidingCredentials newform = new ProvidingCredentials(email, password, "Vendor");
                                newform.Show();

                            }
                        } catch
                        {
                            newVendorValidation.Text = "Something wrong happened adding this vendor. Try again later.";
                            newVendorValidation.Visible = true;
                        }
                      
                    }
                }
            }
            // */
            return;
        }
    
    
    
      }
}
