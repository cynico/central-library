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
using System.IO;

namespace CentralLibrary
{
    public partial class ListVendors : Form
    {
        Controller controllerObj;
        int numOfVendorBranchesContracts = 1;
        bool AdministratorChoosingToHire;

        // AdministratorChoosingToHire is a flag to indicate if an administrator is 
        // listing the vendors of all branches to make a contract with one of them.

        // By default administrators only view vendors of their branch.
        // But when they choose to make a contract with an existing vendor, 
        // they are redirected here, with the flag AdministratorChoosingToHire set to true.


        public ListVendors(ref Controller c, bool ACH = false)
        {
            InitializeComponent();
            controllerObj = c;
            AdministratorChoosingToHire = ACH;

            if (controllerObj.employeeType != 0 && !AdministratorChoosingToHire)
            {
                // Administrators will only view vendors of their branch.
                // Owner can view all the vendors, and filter them by branch.
                branchComboBox.Visible = false;
                filterByBranch.Visible = false;
            } 
            else 
            {
                List<string> branchNames = new List<string> (controllerObj.branchNames);
                branchNames.Add("All");

                branchComboBox.DataSource = branchNames;
                branchComboBox.SelectedItem = "All";

                branchComboBox.Visible = true;
                filterByBranch.Visible = true;
            }

            // Only allow the owner and administrators to add vendors. 
            if (controllerObj.employeeType > 1)
                addButton.Visible = false;

            if (AdministratorChoosingToHire)
            {
                addButton.BackColor = Color.DimGray;
                addButton.ImageIndex = 1;
            }

            vendorlistpanel.Parent = this;
            addButton.Parent = this;
            addButton.Location = new Point(540, 690);
            addButton.BringToFront();
            ShowVendors();

        }

        private void ShowVendors()
        {


            DataTable vendors = controllerObj.GetVendors(AdministratorChoosingToHire);
            if (vendors != null)
            {
                foreach (DataRow row in vendors.Rows)
                {
                    CPanel vendorpanel = new CPanel();
                    vendorpanel.Dock = DockStyle.Top;
                    vendorpanel.Size = new System.Drawing.Size(640, 113);
                    vendorpanel.BackColor = Color.Transparent;
                    vendorpanel.db_id = row["ID"].ToString();
                    vendorpanel.Cursor = Cursors.Hand;



                    // Show contract_date (specific with each vendor to each branch) with the vendor only to administrators and librarians.
                    // Not to the owner. Why? Because a vendor can vend for multiple of branches.
            

                    if (controllerObj.employeeType != 0 && !AdministratorChoosingToHire)
                    {
                        //  contract_date label
                        Label contractDateLabel = new Label();
                        DateTime contract_date = DateTime.Parse(row["contract_date"].ToString());
                        contractDateLabel.Text = contract_date.ToString("dd MMM yyyy");
                        contractDateLabel.Font = new Font("Century Gothic", float.Parse("8.25"), FontStyle.Regular);
                        contractDateLabel.ForeColor = Color.DimGray;
                        contractDateLabel.Parent = vendorpanel;
                        contractDateLabel.Location = new Point(548, 13);
                        contractDateLabel.AutoSize = true;
                        contractDateLabel.MaximumSize = new System.Drawing.Size(85, 0);
                    }


                    // PictureBox
                    PictureBox vendorImage = new PictureBox();
                    vendorImage.Size = new System.Drawing.Size(55, 55);
                    vendorImage.Parent = vendorpanel;
                    vendorImage.Location = new Point(12, 12);

                    string path = Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).ToString()).ToString()).ToString();
                    path += String.Format("\\Images\\Person\\{0}", row["img"].ToString());
                    vendorImage.Image = new Bitmap(path);
                    vendorImage.SizeMode = PictureBoxSizeMode.StretchImage;



                    if (AdministratorChoosingToHire)
                    {
                        vendorpanel.MouseClick += (sender, e) =>
                        {
                            ContractWithVendorAffirmation newform = new ContractWithVendorAffirmation(ref controllerObj, row["ID"].ToString(), row["vname"].ToString(), row["paddress"].ToString(), row["email"].ToString());
                            newform.Show();
                        };
                    }
                    else
                    {
                        vendorpanel.MouseClick += (sender, e) =>
                        {
                            string contract_date;
                            if (controllerObj.employeeType == 0)
                                contract_date = "";
                            else
                                contract_date = DateTime.Parse(row["contract_date"].ToString()).ToString("dd MMM yyyy");

                            bool x = (controllerObj.employeeType < 2);

                            FireRaise newform = new FireRaise(ref controllerObj, row["vname"].ToString(), row["email"].ToString(), row["ID"].ToString(), 0,
                                contract_date, "Vendor", x, row["paddress"].ToString(), row["phone"].ToString(), numOfVendorBranchesContracts);
                            newform.Show();
                        };
                    }

                  

                    // Branch label.
                    Label branch = new Label();
                    branch.Font = new Font("Century Gothic", float.Parse("9.75"), FontStyle.Regular);
                    branch.ForeColor = Color.DimGray;
                    branch.Parent = vendorpanel;
                    branch.Location = new Point(73, 12);
                    branch.AutoSize = true;

                    // Show the list of branches the vendor vends for to the owner.
                    if (controllerObj.employeeType == 0 || AdministratorChoosingToHire)
                    {
                        if (row["bname"].ToString() == "")
                        {
                            branch.Text = "Not currently affiliated with any branch.";
                            branch.ForeColor = Color.FromArgb(244, 67, 54);
                        }
                        else
                            branch.Text = row["bname"].ToString();

                    }

                    else
                        branch.Text = controllerObj.currBranchName;

                    // Name Label.
                    Label name = new Label();
                    name.Text = row["vname"].ToString();
                    name.Font = new Font("Century Gothic", float.Parse("14.25"), FontStyle.Bold);
                    name.ForeColor = Color.FromArgb(75, 75, 75);
                    name.Parent = vendorpanel;
                    name.AutoSize = true;
                    name.Location = new Point(74, 29);

                    // Show address of the administrator.
                    Label vadderss = new Label();
                    vadderss.Text = row["paddress"].ToString();
                    vadderss.Font = new Font("Century Gothic", float.Parse("11.25"), FontStyle.Regular);
                    vadderss.ForeColor = SystemColors.ControlDarkDark;
                    vadderss.Parent = vendorpanel;
                    vadderss.Location = new Point(74, 52);
                    vadderss.AutoSize = false;
                    vadderss.Size = new System.Drawing.Size(549, 43);



                    vendorpanel.Parent = vendorlistpanel;
                    if (controllerObj.employeeType == 0 || AdministratorChoosingToHire)
                    {
                        // Notice how the row["bname"] is at index 0. This is used down in the code in the filterByBranch_Click function.
                        vendorpanel.keywords = new string[] { row["bname"].ToString(), row["vname"].ToString(), row["paddress"].ToString(), row["email"].ToString(), row["phone"].ToString() };
                        numOfVendorBranchesContracts = row["bname"].ToString().Split(',').Length;

                    }
                    else
                    {
                        vendorpanel.keywords = new string[] { row["vname"].ToString(), row["paddress"].ToString(), row["email"].ToString(), row["phone"].ToString() };

                    }


                    
                    if (AdministratorChoosingToHire)
                    {
                        if (vendorpanel.keywords[0].Contains(controllerObj.currBranchName.Split(',')[0]))
                        {
                            vendorpanel.Dispose();

                            GC.Collect();
                        }
                    }


                }
            }


            return;
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            if (AdministratorChoosingToHire)
              ((MainForm)this.Parent.Parent).openChildForm(new ListVendors(ref controllerObj));
            else
            {
                if (controllerObj.employeeType == 0)
                    ((MainForm)this.Parent.Parent).openChildForm(new AddVendor(ref controllerObj));
                else
                {
                    var me = this;
                    VendorAddChoice newform = new VendorAddChoice(ref controllerObj, ref me);
                    newform.Show();
                }
            }
            return;

        }

        private void filterByBranch_Click(object sender, EventArgs e)
        {

            if (branchComboBox.SelectedItem.ToString() == "All")
            {
                foreach (CPanel PanelToHide in vendorlistpanel.Controls)
                    PanelToHide.Visible = true;
            }
            else
            {
                string selectedBranchName = branchComboBox.SelectedItem.ToString();
                foreach(CPanel PanelToHide in vendorlistpanel.Controls)
                {
                    if (PanelToHide.keywords[0].ToLower().Contains(selectedBranchName.ToLower().Split(',')[0]))
                        PanelToHide.Visible = true;
                    else
                        PanelToHide.Visible = false;
                }
            }
            return;
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(vendorSearchTb.Text.ToString()))
            {
                foreach (CPanel Vendor in vendorlistpanel.Controls)
                    Vendor.Visible = true;
            }
            else
            {
                string searchtext = vendorSearchTb.Text;
                foreach (CPanel Vendor in vendorlistpanel.Controls)
                {
                    bool isamatch = false;
                    foreach (string keyword in Vendor.keywords)
                    {

                        if (keyword.ToLower() == searchtext.ToLower() || keyword.ToLower().Contains(searchtext.ToLower()))
                        {
                            Console.WriteLine(searchtext);
                            Console.WriteLine(keyword);

                            isamatch = true;
                        } else
                        {
                            Console.WriteLine(searchtext);
                            Console.WriteLine(keyword);
                        }
                    }
                    // If there's no keyword that match the search text, remove the panel.
                    if (!isamatch)
                        Vendor.Visible = false;
                    else
                        Vendor.Visible = true;
                }
            }
            return;
        }
    }
}
