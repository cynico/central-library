using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

using utilityfunctions;

namespace CentralLibrary
{
    
    public partial class ListAdmins : Form
    {
        Controller controllerObj;
        bool isPrivileged;


        public ListAdmins(ref Controller c)
        {
            InitializeComponent();
            controllerObj = c;
            
            isPrivileged = (controllerObj.employeeType == 0);


            // If the viewing user doesn't have access to add admin, hide the add button.
            if (controllerObj.employeeType != 0)
            {
                addButton.Visible = false;
            }

            if (controllerObj.employeeType == 4)
            {
                filterButton.Visible = true;
                filterComboBox.Visible = true;
                filterComboBox.SelectedIndex = 0;
            }

            adm_listpanel.Parent = this;
            addButton.Parent = this;
            addButton.Location = new Point(540, 690);
            addButton.BringToFront();



            ShowAdministrators();
        }


        private void ShowAdministrators(bool inContractWith = false)
        {
            // Clearing everything first.
            for (int i = adm_listpanel.Controls.Count - 1; i >= 0; --i)
                adm_listpanel.Controls[i].Dispose();

            adm_listpanel.Controls.Clear();
            DataTable administrators = null;


            if (controllerObj.employeeType == 3)
                administrators = controllerObj.GetAdministratorOfBranch();
            else
                administrators = controllerObj.GetStoredProcedure("SelectAllAdm", null);

            if (administrators != null)
            {
                foreach (DataRow row in administrators.Rows)
                {

                    // Don't show the current user in the list. (NO ONE NEEDS TO SEE THEMSELVES)

                    if (row["ID"].ToString() == controllerObj.currID)
                        continue;

                    if (controllerObj.employeeType == 2)
                        if (row["branchID"].ToString() != controllerObj.currBranchID)
                            continue;


                    CPanel admpanel = new CPanel();
                    admpanel.Dock = DockStyle.Top;
                    admpanel.Size = new System.Drawing.Size(640, 113);
                    admpanel.BackColor = Color.Transparent;
                    admpanel.db_id = row["ID"].ToString();
                    admpanel.Cursor = Cursors.Hand;

                    admpanel.MouseClick += (sender, e) =>
                    {

                        FireRaise newform = new FireRaise(ref controllerObj, row["pfirstname"].ToString() + " " + row["plastname"].ToString(), row["email"].ToString(), row["ID"].ToString(), double.Parse(row["salary"].ToString()),
                            DateTime.Parse(row["hired_date"].ToString()).ToString("dd MMM yyyy"), "Administrator", isPrivileged);
                        newform.Show();
                    };



                    // PictureBox
                    PictureBox picture = new PictureBox();
                    picture.Size = new System.Drawing.Size(55, 55);
                    picture.Parent = admpanel;
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
                    branch.Parent = admpanel;
                    branch.Location = new Point(73, 12);
                    branch.AutoSize = true;


                    if (controllerObj.employeeType == 4 && controllerObj.branchesInContractWith.Contains(branch.Text))
                        branch.Text += " (IN CONTRACT WITH)";


                    // Name Label.
                    Label name = new Label();
                    name.Text = row["pfirstname"].ToString() + " " + row["plastname"].ToString();
                    name.Font = new Font("Century Gothic", float.Parse("14.25"), FontStyle.Bold);
                    name.ForeColor = Color.FromArgb(75, 75, 75);
                    name.Parent = admpanel;
                    name.AutoSize = true;
                    name.Location = new Point(74, 29);

                    // Show email of the administrator.
                    Label text = new Label();
                    text.Text = row["email"].ToString();
                    text.Font = new Font("Century Gothic", float.Parse("11.25"), FontStyle.Regular);
                    text.ForeColor = SystemColors.ControlDarkDark;
                    text.Parent = admpanel;
                    text.Location = new Point(74, 52);
                    text.AutoSize = false;
                    text.Size = new System.Drawing.Size(549, 43);

                    // Hired_Date label
                    Label date = new Label();
                    DateTime hired_date = DateTime.Parse(row["hired_date"].ToString());
                    date.Text = hired_date.ToString("dd MMM yyyy");


                    date.Font = new Font("Century Gothic", float.Parse("8.25"), FontStyle.Regular);
                    date.ForeColor = Color.DimGray;
                    date.Parent = admpanel;
                    date.Location = new Point(548, 13);



                    admpanel.keywords = new string[] { row["bname"].ToString(), row["blocation"].ToString(), row["email"].ToString(), row["pfirstname"].ToString(), row["plastname"].ToString(), hired_date.Month.ToString(), hired_date.Year.ToString() };
                    admpanel.Parent = adm_listpanel;

                    if (controllerObj.employeeType == 4 && !controllerObj.branchesInContractWith.Contains(row["bname"] + ", " + row["blocation"]))
                        admpanel.Visible = false;

                }


            }
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            // If there's no search text: check if all the administrators panels are already displayed.
            // If so, no need to do anything. If not, call the ShowAdministrators() function to update the list.
            // This is done to prevent unneeded overhead.


            if (String.IsNullOrEmpty(adm_search_tb.Text.ToString()))
            {
                foreach (CPanel admin in adm_listpanel.Controls)
                {
                    admin.Visible = true;
                }
            }
            else
            {
                string searchtext = adm_search_tb.Text;
                foreach (CPanel admin in adm_listpanel.Controls)
                {
                    bool isamatch = false;
                    foreach (string keyword in admin.keywords)
                    {

                        if (keyword.ToLower() == adm_search_tb.Text.ToLower() || keyword.ToLower().Contains(adm_search_tb.Text.ToLower()))
                        {
                            isamatch = true;
                        }
                    }
                    // If there's no keyword that match the search text, remove the panel.
                    if (!isamatch)
                        admin.Visible = false;
                    else
                        admin.Visible = true;
                }
            }

            return;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).openChildForm(new AddEmployee(ref controllerObj, "Administrator"));
            return;
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            if (filterComboBox.SelectedItem.ToString() == "In Contract With")
            {
                
                foreach(CPanel admin in adm_listpanel.Controls)
                {
                    if (controllerObj.branchesInContractWith.Contains(admin.keywords[0] + ", " + admin.keywords[1]))
                        admin.Visible = true;
                    else
                        admin.Visible = false;
                }

            }
            else
            {
                foreach (CPanel admin in adm_listpanel.Controls)
                    admin.Visible = true;
            }
        }
    }
}
