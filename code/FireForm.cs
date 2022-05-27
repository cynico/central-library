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
    public partial class FireForm : Form
    {
        Controller controllerObj;
        string employeeID;
        string employeeName;
        string employeeHiredDate;
        string employeePosition;
        int numOfVendorBranchesContracts;
        public FireForm(ref Controller c, string ID, string name, string hired_date, string position, int n = -1)
        {
            InitializeComponent();
            controllerObj = c;
            employeeID = ID;
            employeeName = name;
            employeeHiredDate = hired_date;
            employeePosition = position;
            numOfVendorBranchesContracts = n;

            if (employeePosition == "Vendor")
            {
                if (controllerObj.employeeType == 0)
                    firebutton.Text = "End All Contracts";
                else
                    firebutton.Text = "End Contract";
            } else if (employeePosition == "Reader")
            {
                firebutton.Text = "Remove Reader";
                headerLabel.Text = "You're about to remove the following ";
            }


            headerLabel.Text += employeePosition + ":";

            ShowInfo();
        }
        private void ShowInfo()
        {
            Label nameLabel = new Label();
            nameLabel.Font = new Font("Century Gothic", float.Parse("9"), System.Drawing.FontStyle.Regular);
            nameLabel.ForeColor = Color.DimGray;
            nameLabel.Location = new Point(13, 50);
            nameLabel.Text = String.Format("Name: {0}", employeeName);
            nameLabel.Parent = this;
            nameLabel.AutoSize = true;

            if (employeeHiredDate != "")
            {
                Label hiredDateLabel = new Label();
                hiredDateLabel.Font = new Font("Century Gothic", float.Parse("9"), System.Drawing.FontStyle.Regular);
                hiredDateLabel.ForeColor = Color.DimGray;
                hiredDateLabel.Location = new Point(13, 73);
                hiredDateLabel.Text = "Hired at: " + employeeHiredDate;
                hiredDateLabel.Parent = this;
                hiredDateLabel.AutoSize = true;
            }
            if (numOfVendorBranchesContracts != 1 && numOfVendorBranchesContracts != -1)
            {
                Label numOfLabel = new Label();
                numOfLabel.Font = new Font("Century Gothic", float.Parse("9"), System.Drawing.FontStyle.Regular);
                numOfLabel.ForeColor = Color.DimGray;
                numOfLabel.Location = new Point(13, 73);
                numOfLabel.Text = "Has contracts with: " + numOfVendorBranchesContracts + " branches.";
                numOfLabel.Parent = this;
                numOfLabel.AutoSize = true;
            }


            return;
        }

        private void canceladminaction_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void firebutton_Click(object sender, EventArgs e)
        {
            fireValidationLabel.ForeColor = Color.FromArgb(244, 67, 54);
            fireValidationLabel.Visible = false;

            if (String.IsNullOrEmpty(fireConfirmationPass.Text))
            {
                fireValidationLabel.Text = "Enter password for confirmation.";
                fireValidationLabel.Visible = true;
            } else if (!controllerObj.verifyPassword(fireConfirmationPass.Text))
            {
                fireValidationLabel.Text = "Wrong password.";
                fireValidationLabel.Visible = true;
            } else
            {
                // First if this is ending a contract with a vendor.
                if (employeePosition == "Vendor")
                {
                    // If it's by the owner: Delete all their contracts with all branches.
                    if (controllerObj.employeeType == 0)
                    {
                        try
                        {
                            if (controllerObj.DeleteFromTable("Person", "ID", employeeID, true) == 0)
                                throw new Exception();
                            else
                            {
                                fireValidationLabel.ForeColor = Color.FromArgb(0, 200, 83);
                                fireValidationLabel.Text = "All of vendor's contracts have been ended successfully!";
                                fireValidationLabel.Visible = true;
                                firebutton.Visible = false;
                                fireConfirmationPass.Text = "";
                            }

                        } catch
                        {
                            fireValidationLabel.Text = "Something wrong happened. Try again later";
                            fireValidationLabel.Visible = true;
                        }

                    } 

                    // If it's by the administrator: just end the contract with the branch.
                    else 
                    {

                        try
                        {
                            parameterToAProcedure vendorIDPar = new parameterToAProcedure("@VID", employeeID);
                            parameterToAProcedure branchIDPar = new parameterToAProcedure("@branchID", controllerObj.currBranchID);
                            if (controllerObj.ExecuteNonStoredProcedure("DeleteVendorBranch", vendorIDPar, branchIDPar) == 0)
                                throw new Exception();
                            else
                            {
                                fireValidationLabel.ForeColor = Color.FromArgb(0, 200, 83);
                                fireValidationLabel.Text = "Vendor's contract has been ended successfully!";
                                fireValidationLabel.Visible = true;
                                firebutton.Visible = false;
                                fireConfirmationPass.Text = "";
                            }
                        }
                        catch
                        {
                            fireValidationLabel.Text = "Something wrong happened. Try again later";
                            fireValidationLabel.Visible = true;
                        }
                    }



                }

                // If this is a regulare employee, like an administrator or a librarian.

                else
                {
                    try
                    {
                        if (controllerObj.DeleteFromTable("Person", "ID", employeeID, true) == 0)
                            throw new Exception();
                        else
                        {
                            fireValidationLabel.ForeColor = Color.FromArgb(0, 200, 83);
                            fireValidationLabel.Text = String.Format("{0} removed!", employeePosition);
                            fireValidationLabel.Visible = true;
                            firebutton.Visible = false;
                            fireConfirmationPass.Text = "";
                        }
                    }
                    catch
                    {
                        fireValidationLabel.Text = "Something wrong happened. Please try again later.";
                        fireValidationLabel.Visible = true;
                    }
                }

            }

            return;

        }

        private void fireForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.DimGray, 3), this.DisplayRectangle);

        }
    }
}
