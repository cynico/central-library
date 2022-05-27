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


namespace CentralLibrary
{
    public partial class CreateEvent : Form
    {
        Controller controllerObj;
        public CreateEvent(ref Controller c)
        {
            InitializeComponent();
            controllerObj = c;

            List<string> listOfBranches;

            if (controllerObj.employeeType == 0)
            {
                listOfBranches = new List<string> (controllerObj.branchNames);
            } else
            {
                listOfBranches = new List<string>();
                listOfBranches.Add(controllerObj.currBranchName);
            }

                branchComboBox.DataSource = listOfBranches;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).openChildForm(new ListEvents(ref controllerObj));

        }

        private void createEventButton_Click(object sender, EventArgs e)
        {

            createEventValidation.ForeColor = Color.FromArgb(244, 67, 54);
            createEventValidation.Visible = false;
            if (titletextbox.Text == "" || description_textbox.Text == "" || branchComboBox.SelectedItem == null || ticketPrice.Text == "")
            {
                createEventValidation.Text = "Enter a title, a description, a ticket price, and a location for the event.";
                createEventValidation.Visible = true;
            }
            else if (titletextbox.Text.Length > 40)
            {
                createEventValidation.Text = "Title must not be more than 40 characters long.";
                createEventValidation.Visible = true;
            }
            else if (description_textbox.Text.Length > 140)
            {
                createEventValidation.Text = "Description must not be more than 140 characters long.";
                createEventValidation.Visible = true;
            }
            else if (!double.TryParse(ticketPrice.Text.ToString(), out double price))
            {
                createEventValidation.Text = "Enter valid value for price.";
                createEventValidation.Visible = true;
            }
            else if (confirmationPassword.Text == "")
            {
                createEventValidation.Text = "Please enter your password for confirmation.";
                createEventValidation.Visible = true;
            }
            else if (int.Parse(datepicker.Value.Subtract(DateTime.Today).Days.ToString()) > 90)
            {
                createEventValidation.Text = "You can only make an event in the next 90 days.";
                createEventValidation.Visible = true;
            }
            else if
                      (int.Parse(datepicker.Value.Subtract(DateTime.Today).Days.ToString()) <= 0 &&
                      int.Parse(timepicker.Value.TimeOfDay.Subtract(DateTime.Now.TimeOfDay).Hours.ToString()) == 0 &&
                      int.Parse(timepicker.Value.TimeOfDay.Subtract(DateTime.Now.TimeOfDay).Minutes.ToString()) < 59
                      )
            {
                createEventValidation.Text = "You can only make an event a day from now.";
                createEventValidation.Visible = true;
            }
            else if (!controllerObj.verifyPassword(confirmationPassword.Text))
            {
                createEventValidation.Text = "Wrong Password.";
                createEventValidation.Visible = true;
            }
            else
            {
                try {

                    DateTime edatetime = datepicker.Value.Date + timepicker.Value.TimeOfDay;

                    parameterToAProcedure titlePar = new parameterToAProcedure("@title", titletextbox.Text);
                    parameterToAProcedure descriptionPar = new parameterToAProcedure("@edescription", description_textbox.Text);
                    parameterToAProcedure pricePar = new parameterToAProcedure("@ticket_price", price);
                    parameterToAProcedure edatetimePar = new parameterToAProcedure("@edatetime", edatetime);
                    parameterToAProcedure branchIdPar = new parameterToAProcedure("@branchID", controllerObj.branchIDs[branchComboBox.SelectedIndex]);
                    if (controllerObj.employeeType != 0)
                        branchIdPar.value = controllerObj.currBranchID;


                    // Creating the event.
                    if (controllerObj.CreateEvent(titlePar, descriptionPar, pricePar, edatetimePar, branchIdPar) == 0)
                        throw new Exception();


                    // Show message of success.
                    createEventValidation.ForeColor = Color.FromArgb(0, 200, 83);
                    createEventValidation.Text = "Event Created Successfully!";
                    createEventValidation.Visible = true;
                    confirmationPassword.Text = "";
                    createEventButton.Visible = false;

                }
                catch
                {
                        createEventValidation.Text = "Something wrong happened. Try again later.";
                        createEventValidation.Visible = true;
                }
            }
        }
    }
}
