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
    public partial class AccountForm : Form
    {
        Controller controllerObj;
        public AccountForm(ref Controller c)
        {
            controllerObj = c;
            InitializeComponent();
            if (controllerObj.employeeType != 0)
                deleteAccount.Visible = true;

            if (controllerObj.employeeType == 4)
                deleteAccount.Text = "Delete your account and end all your contracts.";
            else if (controllerObj.employeeType == 3)
                deleteAccount.Text = "Delete your account and end your subscribtion.";

        }

        private void accountsavechanges_Click(object sender, EventArgs e)
        {
            accountvalidation.Visible = false;
            accountvalidation.ForeColor = Color.FromArgb(244, 67, 54);
            string new_pass = accountpass.Text;
            string re_new_pass = accountrepass.Text;
            string currpass = accountcurrpass.Text;


            if (String.IsNullOrEmpty(new_pass) || String.IsNullOrEmpty(re_new_pass) || String.IsNullOrEmpty(currpass))
            {
                accountvalidation.Text = "All password fields should be filled.";
                accountvalidation.Visible = true;
                return;
            }
            if (new_pass != re_new_pass)
            {
                accountvalidation.Text = "Passwords should be matching.";
                accountvalidation.Visible = true;
                return;
            }

            if (utilityfunctions.functions.validatePassword(new_pass, re_new_pass, ref accountvalidation))
            {
                if (!controllerObj.verifyPassword(currpass))
                {
                    accountvalidation.Text = "Wrong current password.";
                    accountvalidation.Visible = true;
                }
                else
                {
                    if (controllerObj.UpdatePassword(new_pass) == 0)
                    {
                        accountvalidation.Text = "Something wrong happened while updating your password. Try again later.";
                        accountvalidation.Visible = true;
                    } else
                    {
                        accountvalidation.Text = "Updated Successfully!";
                        accountvalidation.ForeColor = Color.FromArgb(0, 200, 83);
                        accountvalidation.Visible = true;
                    }
                }
                return;
            }

        }

        private void deleteAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var me = this;
            DeleteAccount newform = new DeleteAccount(ref controllerObj, ref me);
            newform.Show();
        }
    }
}
