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
    public partial class DeleteAccount : Form
    {
        Controller controllerObj;
        AccountForm parent;
        public DeleteAccount(ref Controller c, ref AccountForm p)
        {

            InitializeComponent();
            controllerObj = c;
            parent = p;
            resignConfirmationPass.Visible = false;
            if (controllerObj.employeeType == 4)
                resignButton.Text = "End Your Contracts";
            else if (controllerObj.employeeType == 3)
                resignButton.Text = "Delete your account";

        }

        private void cancelresign_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resignButton_Click(object sender, EventArgs e)
        {
            resignvalidation.ForeColor = Color.FromArgb(244, 67, 54);
            resignvalidation.Visible = false;

            if (resignButton.Text != "Confirm")
            {
                label1.Visible = false;
                label17.Text = "Enter password to confirm deletion.";
                resignConfirmationPass.Visible = true;
                resignButton.Text = "Confirm";
            } else
            {
                if (String.IsNullOrEmpty(resignConfirmationPass.Text)) {
                    resignvalidation.Text = "Empty password.";
                    resignvalidation.Visible = true;
                }
                else if (!controllerObj.verifyPassword(resignConfirmationPass.Text)) {
                    resignvalidation.Text = "Wrong Password!";
                    resignvalidation.Visible = true;
                }
                else {
                    try
                    {
                        // If it's an administrator, send a request to the owner.
                        if (controllerObj.employeeType == 1)
                        {
                            // Get ID of owner
                            string ownerID = controllerObj.GetOwnersInfo().Rows[0]["ID"].ToString();

                            if (controllerObj.SendRequest("Please accept this letter as formal notification that I am resigning from my position.", 0, DateTime.Now, controllerObj.currID, ownerID, 2) == 0)
                                throw new Exception();
                            else
                            {
                                resignvalidation.Text = "The owner has been notified.";
                                resignvalidation.ForeColor = Color.FromArgb(0, 200, 83);
                                resignvalidation.Visible = true;
                                resignConfirmationPass.Text = "";
                                resignButton.Visible = false;
                            }
                        }
                        // If it's a librarian, send a request to the administrator above them.
                        else if (controllerObj.employeeType == 2)
                        {
                            string adminID = controllerObj.GetIDOfAdministrator();
                            if (adminID != "")
                            {
                                if (controllerObj.SendRequest("Please accept this letter as formal notification that I am resigning from my position as a librarian.", 0, DateTime.Now, controllerObj.currID, adminID, 2) == 0)
                                    throw new Exception();
                                else
                                {
                                    resignvalidation.Text = "Your admininstrator has been notified.";
                                    resignvalidation.ForeColor = Color.FromArgb(0, 200, 83);
                                    resignvalidation.Visible = true;
                                    resignConfirmationPass.Text = "";
                                    resignButton.Visible = false;
                                }
                            }
                            // In case there's no administrator assigned to their branch, yet. 
                            else 
                            {
                                string ownerID = controllerObj.GetOwnersInfo().Rows[0]["ID"].ToString();
                                if (controllerObj.SendRequest(String.Format("Please accept this letter as formal notification that I am resigning from my position as a librarian in branch {0}.", controllerObj.currBranchName) , 0, DateTime.Now, controllerObj.currID, ownerID, 2) == 0)
                                    throw new Exception();
                                else
                                {
                                    resignvalidation.Text = "The owner has been notified.";
                                    resignvalidation.ForeColor = Color.FromArgb(0, 200, 83);
                                    resignvalidation.Visible = true;
                                    resignConfirmationPass.Text = "";
                                    resignButton.Visible = false;
                                }
                            }
                        }
                        // If it's a reader, just delete their account.
                        else if (controllerObj.employeeType == 3)
                        {
                            if (controllerObj.DeleteReaderAccount() == 0)
                                throw new Exception(); 
                            else
                                ((MainForm)parent.Parent.Parent).logout();

                        }
                        // If it's a vendor.
                        else if (controllerObj.employeeType == 4)
                        {
                            if (controllerObj.DeleteReaderAccount() == 0)
                                throw new Exception();
                            else
                                ((MainForm)parent.Parent.Parent).logout();
                        }


                    } catch
                    {
                        resignvalidation.Text = "Something wrong happened. Try again later!";
                        resignvalidation.Visible = true;
                    }
                   
                }


            }
        }

        private void deleteAccount_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.DimGray, 3), this.DisplayRectangle);

        }
    }
}
