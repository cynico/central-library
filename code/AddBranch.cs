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
    public partial class AddBranch : Form
    {
        Controller controllerObj;
        List<string> adminNames;
        List<string> adminIDs;
        DataTable unassignedAdmins;
        public AddBranch(ref Controller c)
        {
            InitializeComponent();
            controllerObj = c;

            updateAdmins();

            string[] governorates = { "Alexandria", "Aswan", "Asyut", "Beheira", "Beni Suef", "Cairo", "Dakahlia", "Damietta", "Faiyum", "Gharbia", "Giza", "Ismailia", "Kafr El-Sheikh",  "Luxor", "Matruh", "Minya", "Monufia", "New Valley", "North Sinai", "Port Said" };
            List<string> governoratesList = new List<string>(governorates);
            governorateCombobox.DataSource = governoratesList;

        }

        private void updateAdmins()
        {
            adminNames = new List<string>();
            adminIDs = new List<string>();

            unassignedAdmins = controllerObj.GetUnassignedAdministrators();
            if (unassignedAdmins != null)
            {
                foreach (DataRow admin in unassignedAdmins.Rows)
                {
                    adminNames.Add(admin["pfirstname"] + " " + admin["plastname"]);
                    adminIDs.Add(admin["ID"].ToString());
                }
            }
            administratorComboBox.DataSource = adminNames;
        }

        private void addBranchButton_Click(object sender, EventArgs e)
        {
            var nameregex = new Regex("^[a-zA-Z.-]*$");
            newBranchValidation.ForeColor = Color.FromArgb(244, 67, 54);
            newBranchValidation.Visible = false;
            if (governorateCombobox.SelectedItem == null || String.IsNullOrEmpty(branchlocationtb.Text.ToString()) || administratorComboBox.SelectedItem == null || String.IsNullOrEmpty(addBranchConfirmationPass.Text))
            {
                newBranchValidation.Text = "Make sure all fields are filled out.";
                newBranchValidation.Visible = true;
            }
            else if (!nameregex.IsMatch(branchlocationtb.Text))
            {
                newBranchValidation.Text = "City name can only include alphabetical characters.";
                newBranchValidation.Visible = true;
            } 
            else if (!controllerObj.verifyPassword(addBranchConfirmationPass.Text))
            {
                newBranchValidation.Text = "Wrong Password.";
                newBranchValidation.Visible = true;
            } else
            {
                try
                {
                    // First generating the branch name (such as: Cairo-1, Cairo-2.. etc)
                    // This is done by fetching the latest established branch in that governorate,
                    // Extracting the number at the end of its name (such as 3 in Cairo-3)
                    // Then incrementing it and making it the new name of the branch (Cair-4, in the preceding example).
                    int nameId = int.MinValue;
                    DataTable governoratesBranches = controllerObj.GetLatestBranchInGover(governorateCombobox.Text);
                    if (governoratesBranches == null)
                    {
                        nameId = 1;
                    } else
                    {
                        foreach (DataRow b in governoratesBranches.Rows)
                        {
                            string[] x = b["bname"].ToString().Split('-');
                            if (int.Parse(x[x.Length - 1]) > nameId)
                            {
                                nameId = int.Parse(x[x.Length - 1]);
                            }
                        }
                        nameId++;
                    }

                    string bname = governorateCombobox.SelectedItem.ToString() + "-" + nameId.ToString();

                    parameterToAProcedure parBname = new parameterToAProcedure();
                    parBname.name = "@bname";
                    parBname.value = bname;


                    parameterToAProcedure parBlocation = new parameterToAProcedure();
                    parBlocation.name = "@blocation";
                    parBlocation.value = branchlocationtb.Text;

                    parameterToAProcedure numOfSubscribers = new parameterToAProcedure();
                    numOfSubscribers.name = "@numOfSubscribers";
                    numOfSubscribers.value = 0;

                    parameterToAProcedure KPI = new parameterToAProcedure();
                    KPI.name = "@KPI";
                    KPI.value = DBNull.Value;

                    parameterToAProcedure numOfStaff = new parameterToAProcedure();
                    numOfStaff.name = "@numOfStaff";
                    numOfStaff.value = 1;


                    parameterToAProcedure established_at = new parameterToAProcedure();
                    established_at.name = "@established_at";
                    established_at.value = DateTime.Today.ToString();


                    parameterToAProcedure adminID = new parameterToAProcedure();
                    adminID.name = "@adminID";
                    adminID.value = adminIDs[administratorComboBox.SelectedIndex];

                    if (controllerObj.ExecuteNonStoredProcedure("addBranch", parBname,  parBlocation, numOfSubscribers, KPI, numOfStaff, established_at, adminID) == 0)
                        throw new Exception("Something wrong happend.");


                    //if (controllerObj.addBranch(bname, branchlocationtb.Text, DateTime.Today) == 0)
                    //    throw new Exception("Something wrong happend.");



                    // Clearing all textboxes and showing message of success.
                    newBranchValidation.ForeColor = Color.FromArgb(0, 200, 83);
                    newBranchValidation.Text = "New Branch added successfully";
                    newBranchValidation.Visible = true;
                    
                    addBranchConfirmationPass.Text = "";
                    governorateCombobox.Text = "";
                    branchlocationtb.Text = "";
                    updateAdmins();

                }
                catch
                {
                    newBranchValidation.Text = "Something wrong happened. Try again later.";
                    newBranchValidation.Visible = true;
                }
            }
        }

        private void hireAdminAbout_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).openChildForm(new AddEmployee(ref controllerObj, "Administrator"));
        }

        private void addBranch_Load(object sender, EventArgs e)
        {

        }
    }
}
