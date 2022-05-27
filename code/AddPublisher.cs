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
    public partial class AddPublisher : Form
    {
        Controller controllerObj;
        public AddPublisher(ref Controller c)
        {
            InitializeComponent();
            controllerObj = c;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).openChildForm(new AddBook(ref controllerObj));
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var phoneregex = new Regex("^(\\+[2]{1})?[0-9]{10,13}$");
            var nameregex = new Regex("^[a-zA-Z. \\-']*$");


            if (String.IsNullOrEmpty(newPublisherAddress.Text) 
                || String.IsNullOrEmpty(newPublisherPhone.Text) 
                || String.IsNullOrEmpty(newPublisherName.Text) 
                || String.IsNullOrEmpty(confirmationPassword.Text))
            {
                validationLabel.Text = "Make sure all fields are filled.";
                validationLabel.Visible = true;
            }
            else if (!nameregex.IsMatch(newPublisherName.Text))
            {
                validationLabel.Text = "Names should only contain alphabetical characters, apostrophes, and dots.";
                validationLabel.Visible = true;
            }
            else if (!phoneregex.IsMatch(newPublisherPhone.Text))
            {
                validationLabel.Text = "Phone numbers can only contain digits and the plus sign. (Make sure there are no spaces).";
                validationLabel.Visible = true;
            }

            else if (!controllerObj.verifyPassword(confirmationPassword.Text))
            {
                validationLabel.Text = "Wrong Password.";
                validationLabel.Visible = true;
            }
            else
            {
                try
                {
                    parameterToAProcedure namePar = new parameterToAProcedure("@pubname", newPublisherName.Text);
                    parameterToAProcedure addressPar = new parameterToAProcedure("@paddress", newPublisherAddress.Text);
                    parameterToAProcedure phonePar = new parameterToAProcedure("@phone", newPublisherPhone.Text);
                    if (controllerObj.AddPublisher(namePar, addressPar, phonePar) == 0)
                        throw new Exception();
                    else
                    {
                        validationLabel.Text = "Publisher Added Successfully!";
                        validationLabel.ForeColor = utilityfunctions.Globals.greenColor;
                        validationLabel.Visible = true;
                        addButton.Visible = false;
                    }


                } catch
                {
                    validationLabel.Text = "Something wrong happened. Try again later.";
                    validationLabel.Visible = true;
                }
            }



        
        }
    }
}
