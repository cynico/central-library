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
    public partial class ViewBranch : Form
    {
        Controller controllerObj;
        AboutLibrary parent;
        string email;
        int i = 0;
        Label KPILabel;
        Label numOfSubscribersLabel;
        Label numOfStaffLabel;
        Label runByLabel;

        public ViewBranch(ref Controller c, Dictionary<string, string> branchInfo, ref AboutLibrary p)
        {
            InitializeComponent();

            controllerObj = c;
            parent = p;

            if (controllerObj.employeeType != 0)
                removeBranchButton.Visible = false;

            if (branchInfo["adminEmail"] == "" || (controllerObj.employeeType == 1 && branchInfo["branchID"] == controllerObj.currBranchID))
                contactAdminButton.Visible = false;
            

            nameLabel.Text += branchInfo["bname"];
            locationLabel.Text += branchInfo["blocation"];
            establishedAtLabel.Text += DateTime.Parse(branchInfo["established_at"]).ToString("dd/MM/yyyy") ;
            email = branchInfo["adminEmail"];

            if (branchInfo["adminName"] != "")
            {
                Console.WriteLine(branchInfo["adminName"]);
                runByLabel = new Label();
                runByLabel.ForeColor = Color.Black;
                runByLabel.Font = new Font("Century Gothic", float.Parse("10.5"), FontStyle.Regular);
                runByLabel.Text = "Run By: " + branchInfo["adminName"];
                runByLabel.Parent = infoPanel;
                runByLabel.Location = new Point(12, 73+i*30);
                runByLabel.AutoSize = true;
                i++;
            }

            if (controllerObj.employeeType == 0 || (controllerObj.employeeType == 1 && branchInfo["branchID"] == controllerObj.currBranchID))
            {
                KPILabel = new Label();
                KPILabel.ForeColor = Color.Black;
                KPILabel.Font = new Font("Century Gothic", float.Parse("10.5"), FontStyle.Regular);
                KPILabel.Text = "KPI: " + branchInfo["KPI"];
                KPILabel.Parent = infoPanel;
                KPILabel.Location = new Point(12, 73 + i * 30);
                i++;

                numOfSubscribersLabel = new Label();
                numOfSubscribersLabel.ForeColor = Color.Black;
                numOfSubscribersLabel.Font = new Font("Century Gothic", float.Parse("10.5"), FontStyle.Regular);
                numOfSubscribersLabel.Text = "Number Of Subscribers: " + branchInfo["numOfSubscribers"];
                numOfSubscribersLabel.Parent = infoPanel;
                numOfSubscribersLabel.Location = new Point(12, 73 + i * 30);
                numOfSubscribersLabel.AutoSize = true;
                i++;

                numOfStaffLabel = new Label();
                numOfStaffLabel.ForeColor = Color.Black;
                numOfStaffLabel.Font = new Font("Century Gothic", float.Parse("10.5"), FontStyle.Regular);
                numOfStaffLabel.Text = "Number Of Staff: " + branchInfo["numOfStaff"];
                numOfStaffLabel.Parent = infoPanel;
                numOfStaffLabel.Location = new Point(12, 73 + i * 30);
                numOfStaffLabel.AutoSize = true;

                i++;



            }



        }

        private void removeBranchButton_Click(object sender, EventArgs e)
        { 
            validationLabel.ForeColor = utilityfunctions.Globals.redColor;
            validationLabel.Visible = false;
            if (removeBranchButton.Text == "Remove Branch")
            {
                removeBranchButton.Text = "Confirm";
                contactAdminButton.Visible = false;
                headerLabel.Text = "CONFIRM DELETION OF BRANCH.";
                establishedAtLabel.Visible = false;
                nameLabel.Text = "Are you sure? All employees associated with this branch will be removed.";
                nameLabel.ForeColor = utilityfunctions.Globals.redColor;
                nameLabel.Font = new Font("Century Gothic", float.Parse("10.5"), FontStyle.Bold);

                locationLabel.Text = "Enter password for confirmation: ";
                locationLabel.ForeColor =  Color.DimGray;
                passwordConfrimationTb.Visible = true;

                if (runByLabel != null)
                    runByLabel.Dispose();
                if (KPILabel != null)
                    KPILabel.Dispose();
                if (numOfStaffLabel != null)
                    numOfStaffLabel.Dispose();
                if (numOfSubscribersLabel != null)
                    numOfSubscribersLabel.Dispose();

                this.AutoSize = false;
                infoPanel.AutoSize = false;

                infoPanel.Size = new Size(553, 118);

            }
            else
            {
                if (passwordConfrimationTb.Text == "")
                {
                    validationLabel.Text = "Empty Password";
                    validationLabel.Visible = true;
                }
                else if (!controllerObj.verifyPassword(passwordConfrimationTb.Text))
                {
                    validationLabel.Text = "Wrong Password";
                    validationLabel.Visible = true;
                }
                else
                {
                    try
                    {
                        if (controllerObj.ExecuteNonStoredProcedure("RemoveBranch") == 0)
                            throw new Exception();
                        else
                        {
                            validationLabel.Text = "Branch removed succesffully!";
                            validationLabel.ForeColor = utilityfunctions.Globals.greenColor;
                            validationLabel.Visible = true;
                        }

                    } catch
                    {
                        validationLabel.Text = "Something wrong happened. Try again later.";
                        validationLabel.Visible = true;
                    }
                }
            }
        }

        private void cancelrequestact_Click(object sender, EventArgs e)
        {
            parent.ShowBranches();
            this.Close();
        }

        private void ViewBranch_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.DimGray, 3), this.DisplayRectangle);

        }

        private void contactAdminButton_Click(object sender, EventArgs e)
        {
            ComposeEmail newform = new ComposeEmail(ref controllerObj, email);
            newform.Show();
            this.Close();
        }
    }
}
