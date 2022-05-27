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
using System.Text.RegularExpressions;

namespace CentralLibrary
{
    public partial class ComposeEmail : Form
    {
        Controller controllerObj;
        string filledEmail;
        public ComposeEmail(ref Controller c, string email = "")
        {
            controllerObj = c;
            InitializeComponent();
            filledEmail = email;

            // If the form is initialized with an address in mind.
            if (email != "")
                to_textbox.Text = email;
                    
        }



        private void sendemailbutton_Click(object sender, EventArgs e)
        {
            compose_validation_tb.ForeColor = Color.FromArgb(244, 67, 54);
            compose_validation_tb.Visible = false;
            var regexItem = new Regex("^[a-zA-Z0-9.@\\-]*$");
            string email = to_textbox.Text;
            string subject = subject_textbox.Text;
            string body = emailbody_textbox.Text;

            if (!regexItem.IsMatch(email) || !utilityfunctions.functions.IsValidEmail(email))
            {
                compose_validation_tb.Text = "Enter a valid email address for the recepient.";
                compose_validation_tb.Visible = true;
                return;
            }
            if (String.IsNullOrEmpty(body))
            {
                compose_validation_tb.Text = "Body must not be empty.";
                compose_validation_tb.Visible = true;
                return;
            }
            string receiver_id = "";
            // Only check if a user exists with this email in the library.
            // Passing empty password, and dummy ref id, to utilize the function
            // used in signing in users here, and not have to create an additional one.
            // So the only return value we care about here is -1: indicating that the email doesn't
            // belong to any user.
            if (controllerObj.CheckIfUserExists(email, "", ref receiver_id) == -1)
            {
                compose_validation_tb.Text = "No user exists with this email in the library.";
                compose_validation_tb.Visible = true;
                return;
            }
            
            if (receiver_id == controllerObj.currID)
            {
                compose_validation_tb.Text = "Do you want to save this as a draft?";
                compose_validation_tb.Visible = true;
                return;
            }

            // Send the email.
            if (String.IsNullOrEmpty(subject))
                subject = "No Title.";

            if (controllerObj.SendEmail(subject, body, DateTime.Now, controllerObj.currID, receiver_id) == 0)
            {
                compose_validation_tb.Text = "Something wrong happend sending the email. Please, try again later.";
                compose_validation_tb.Visible = true;
                return;
            }
            else
            {
                compose_validation_tb.ForeColor = Color.FromArgb(0, 200, 83);
                compose_validation_tb.Text = "Sent!";
                compose_validation_tb.Visible = true;
                subject_textbox.Text = emailbody_textbox.Text = to_textbox.Text = "";

                return;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {

            var ancestor = this.Parent;
            if (ancestor != null)
                ((MainForm)ancestor.Parent).openChildForm(new InboxForm(ref controllerObj));
            else
                this.Close();

            return;
        }
    }
}
