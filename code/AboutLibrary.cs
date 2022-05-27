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
    public partial class AboutLibrary : Form
    {
        Controller controllerObj;
        Delegate openBranchDelegate;

        public AboutLibrary(ref Controller c)
        {
            InitializeComponent();
            controllerObj = c;
            branch_listpanel.Parent = this;

            // Only show the add branch button to the owner.
            if (controllerObj.employeeType != 0)
            {
                addButton.Visible = false;
            } else
            {
                addButton.Parent = this;
                addButton.Location = new Point(540, 690);
                addButton.BringToFront();
            }
            ShowBranches();

        }

        private void openBranch(object sender, EventArgs e, Dictionary<string, string> branchInfo)
        {
            var me = this;
            ViewBranch newform = new ViewBranch(ref controllerObj, branchInfo, ref me);
            newform.Show();
            return;
        }


        public void ShowBranches()
        {
            // Clearing everything first.
            for (int i = branch_listpanel.Controls.Count - 1; i >= 0; --i)
                branch_listpanel.Controls[i].Dispose();

            branch_listpanel.Controls.Clear();

            DataTable Branches = controllerObj.GetBranches();
            if (Branches != null)
            {
                foreach (DataRow branch in Branches.Rows)
                {

                    CustomPanel branchPanel = new CustomPanel();
                    branchPanel.Dock = DockStyle.Top;
                    branchPanel.Size = new System.Drawing.Size(640, 113);
                    branchPanel.BackColor = Color.Transparent;
                    branchPanel.Cursor = Cursors.Hand;

                    // established_at date label
                    Label establishedatDate = new Label();
                    establishedatDate.ForeColor = Color.DimGray;
                    if (branch["established_at"] != DBNull.Value)
                        establishedatDate.Text = DateTime.Parse(branch["established_at"].ToString()).ToString("dd/MM/yyyy");

                    establishedatDate.Font = new Font("Century Gothic", float.Parse("8.25"), FontStyle.Regular);
                    establishedatDate.Parent = branchPanel;
                    establishedatDate.Location = new Point(548, 13);
                    establishedatDate.AutoSize = true;
                    establishedatDate.MaximumSize = new System.Drawing.Size(85, 0);

                    PictureBox picture = new PictureBox();
                    picture.Size = new System.Drawing.Size(55, 55);
                    picture.Parent = branchPanel;
                    picture.Location = new Point(12, 12);


                    string path = Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).ToString()).ToString()).ToString();
                    path += "\\Images\\Library\\branch.jpg";
                    picture.Image = new Bitmap(path);
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    picture.Refresh();


                    // Branch label.
                    Label branchLabel = new Label();
                    branchLabel.Text = branch["blocation"].ToString();
                    branchLabel.Font = new Font("Century Gothic", float.Parse("9.75"), FontStyle.Regular);
                    branchLabel.ForeColor = Color.DimGray;
                    branchLabel.Parent = branchPanel;
                    branchLabel.Location = new Point(73, 12);
                    branchLabel.AutoSize = true;

                    // Name Label.
                    Label branchNameLabel = new Label();
                    branchNameLabel.Text = branch["bname"].ToString();
                    branchNameLabel.Font = new Font("Century Gothic", float.Parse("14.25"), FontStyle.Bold);
                    branchNameLabel.ForeColor = Color.FromArgb(75, 75, 75);
                    branchNameLabel.Parent = branchPanel;
                    branchNameLabel.AutoSize = true;
                    branchNameLabel.Location = new Point(74, 29);

                    // Show administrator of the branch.
                    Label administratorLabel = new Label();

                    if (branch["adminName"].ToString() != " ")
                    {
                        administratorLabel.Text = String.Format("Run By: {0}", branch["adminName"]);
                        branchPanel.Info["adminName"] = branch["adminName"].ToString();
                        branchPanel.Info["adminEmail"] = branch["email"].ToString();
                    }
                    else
                    {
                        branchPanel.Info["adminName"] = "";
                        branchPanel.Info["adminEmail"] = "";

                    }
                    administratorLabel.Font = new Font("Century Gothic", float.Parse("11.25"), FontStyle.Regular);
                    administratorLabel.ForeColor = SystemColors.ControlDarkDark;
                    administratorLabel.Parent = branchPanel;
                    administratorLabel.Location = new Point(74, 52);
                    administratorLabel.AutoSize = false;
                    administratorLabel.Size = new System.Drawing.Size(549, 43);



                    branchPanel.Parent = branch_listpanel;

                    branchPanel.Info.Add("bname", branch["bname"].ToString());
                    branchPanel.Info.Add("blocation", branch["blocation"].ToString());
                    branchPanel.Info.Add("branchID", branch["branchID"].ToString());
                    branchPanel.Info.Add("established_at", branch["established_at"].ToString());
                    branchPanel.Info.Add("KPI", branch["KPI"].ToString());
                    branchPanel.Info.Add("numOfSubscribers", branch["numOfSubscribers"].ToString());
                    branchPanel.Info.Add("numOfStaff", branch["numOfStaff"].ToString());

                    openBranchDelegate = new MouseEventHandler((sender, e) => openBranch(sender, e, branchPanel.Info));
                    branchPanel.MouseClick += (MouseEventHandler)openBranchDelegate;


                }
            }

            return;

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).openChildForm(new AddBranch(ref controllerObj));
        }
    }
}
