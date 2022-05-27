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
    public partial class ListLibrarians : Form
    {

        Controller controllerObj;
        bool isPrivileged = true;
        List<int> branchIDs;

        public ListLibrarians(ref Controller c)
        {
            InitializeComponent();
            controllerObj = c;


            // If it's an unassigned administrator
            // Only allow administrators assigned to branches to hire librarians WITHIN those branches.
            // if controllerObj.currBranchID is empty, that means that the current logged in administrator
            // is not assigned yet to a branch, and thus can hire no one.
            if (controllerObj.employeeType == 1 && String.IsNullOrEmpty(controllerObj.currBranchID))
                isPrivileged = false;
            else if (controllerObj.employeeType > 1)
                isPrivileged = false;


            // If the viewing user doesn't have access to add librarian, hide the add button.
            if (controllerObj.employeeType > 1 || !isPrivileged)
            {
                addButton.Visible = false;
            }

            // If the viewing user is the owner, add the capability of filtering the librarians by branches.
            if (controllerObj.employeeType == 0)
            {

                DataTable branches = controllerObj.SelectAll("Branch");
                List<string> branchNames = new List<string>();
                branchIDs = new List<int>();
                foreach (DataRow branch in branches.Rows)
                {
                    branchNames.Add(branch["bname"] + ", " + branch["blocation"]);
                    branchIDs.Add(int.Parse(branch["ID"].ToString()));
                }
                branchNames.Add("All");
                
                branchComboBox.DataSource = branchNames;
                branchComboBox.SelectedItem = "All";

                branchComboBox.Visible = true;
                filterByBranch.Visible = true;
            }

            lib_listpanel.Parent = this;
            addButton.Parent = this;
            addButton.Location = new Point(540, 690);
            addButton.BringToFront();
            ShowLibrarians();
        }


        private void ShowLibrarians()
        {
            // Clearing everything first.
            for (int i = lib_listpanel.Controls.Count - 1; i >= 0; --i)
                lib_listpanel.Controls[i].Dispose();

            lib_listpanel.Controls.Clear();
            parameterToAProcedure branchID = new parameterToAProcedure();
            
            
            branchID.name = "@branch";
            if (String.IsNullOrEmpty(controllerObj.currBranchID))
            {

                // If it's the owner, show librarians of all branches.
                // If it's an administrator not yet assigned  to a branch, dont show anyone.

                // NOTE that the implmentation of the store procedure in the database takes branchID 
                // as a parameter, and when it's -1, it retrieves librarians of all branches.
                if (controllerObj.currID.Substring(0, 1) == "0")
                    branchID.value = -1;
                else
                    branchID.value = DBNull.Value;
            }
            else
            {
                
                branchID.value = controllerObj.currBranchID;
                Console.WriteLine(branchID.value);
            }

            DataTable librarians = controllerObj.GetStoredProcedure("SelectAllLib", branchID);
            if (librarians != null)
            {
                foreach (DataRow row in librarians.Rows)
                {
                    if (row["ID"].ToString() == controllerObj.currID)
                        continue;

                    CPanel libpanel = new CPanel();
                    libpanel.Dock = DockStyle.Top;
                    libpanel.Size = new System.Drawing.Size(640, 113);
                    libpanel.BackColor = Color.Transparent;
                    libpanel.db_id = row["ID"].ToString();
                    libpanel.Cursor = Cursors.Hand;

                    libpanel.MouseClick += (sender, e) =>
                    {
                        FireRaise newform = new FireRaise(ref controllerObj, row["pfirstname"].ToString() + " " + row["plastname"].ToString(), row["email"].ToString(), row["ID"].ToString(), double.Parse(row["salary"].ToString()),
                            DateTime.Parse(row["hired_date"].ToString()).ToString("dd MMM yyyy"), "Librarian", isPrivileged);
                        newform.Show();
                    };

                    // PictureBox
                    PictureBox picture = new PictureBox();
                    picture.Size = new System.Drawing.Size(55, 55);
                    picture.Parent = libpanel;
                    picture.Location = new Point(12, 12);
                    string path = Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).ToString()).ToString()).ToString();
                    path += String.Format("\\Images\\Person\\{0}", row["img"].ToString());
                    picture.Image = new Bitmap(path);
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    picture.Refresh();


                    // Creating branch label.
                    Label branch = new Label();
                    branch.Text = row["bname"].ToString() + ", " + row["blocation"].ToString();
                    branch.Font = new Font("Century Gothic", float.Parse("9.75"), FontStyle.Regular);
                    branch.ForeColor = Color.DimGray;
                    branch.Parent = libpanel;
                    branch.Location = new Point(73, 12);
                    branch.AutoSize = true;

                    // Name Label.
                    Label name = new Label();
                    name.Text = row["pfirstname"].ToString() + " " + row["plastname"].ToString();
                    name.Font = new Font("Century Gothic", float.Parse("14.25"), FontStyle.Bold);
                    name.ForeColor = Color.FromArgb(75, 75, 75);
                    name.Parent = libpanel;
                    name.AutoSize = true;
                    name.Location = new Point(74, 29);

                    // Show email of the librarian.
                    Label text = new Label();
                    text.Text = row["email"].ToString();
                    text.Font = new Font("Century Gothic", float.Parse("11.25"), FontStyle.Regular);
                    text.ForeColor = SystemColors.ControlDarkDark;
                    text.Parent = libpanel;
                    text.Location = new Point(74, 52);
                    text.AutoSize = false;
                    text.Size = new System.Drawing.Size(549, 43);

                    // Hired_Date label
                    Label date = new Label();
                    DateTime hired_date = DateTime.Parse(row["hired_date"].ToString());
                    date.Text = hired_date.ToString("dd MMM yyyy");


                    date.Font = new Font("Century Gothic", float.Parse("8.25"), FontStyle.Regular);
                    date.ForeColor = Color.DimGray;
                    date.Parent = libpanel;
                    date.Location = new Point(548, 13);



                    libpanel.keywords = new string[] { row["branchID"].ToString(),  row["email"].ToString(), row["pfirstname"].ToString(), row["plastname"].ToString(), hired_date.Month.ToString(), hired_date.Year.ToString() };
                    libpanel.Parent = lib_listpanel;
                    libpanel.Visible = true;

                }


            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).openChildForm(new AddEmployee(ref controllerObj, "Librarian"));
        }

        private void filterByBranch_Click(object sender, EventArgs e)
        {
            if (branchComboBox.SelectedItem == null)
                return;
            else if (branchComboBox.SelectedItem.ToString() == "All")
            {
                foreach (CPanel librarian in lib_listpanel.Controls)
                    librarian.Visible = true;
            }
            else
            {
                foreach (CPanel librarian in lib_listpanel.Controls)
                {
                    if (int.Parse(librarian.keywords[0]) != branchIDs[branchComboBox.SelectedIndex])
                        librarian.Visible = false;
                    else
                        librarian.Visible = true;
                }
            }
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(libsearchtb.Text.ToString()))
            {
                foreach (CPanel admin in lib_listpanel.Controls)
                {
                    admin.Visible = true;
                }
            }
            else
            {
                string searchtext = libsearchtb.Text;
                foreach (CPanel librarian in lib_listpanel.Controls)
                {
                    bool isamatch = false;
                    foreach (string keyword in librarian.keywords)
                    {

                        if (keyword.ToLower() == libsearchtb.Text.ToLower() || keyword.ToLower().Contains(libsearchtb.Text.ToLower()))
                        {
                            isamatch = true;
                        }
                    }
                    // If there's no keyword that match the search text, remove the panel.
                    if (!isamatch)
                        librarian.Visible = false;
                    else
                        librarian.Visible = true;
                }
            }
        }
    }
}
