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
    public partial class ListUsers : Form
    {
        Controller controllerObj;
        Delegate openUserDelegate;


        private void openUser(object sender, EventArgs e, Dictionary<string, string> usersInfo)
        {
            bool privileged = true;
            if (controllerObj.employeeType > 1 || (controllerObj.employeeType == 1 && controllerObj.currBranchID != usersInfo["branchID"]))
                privileged = false;

            FireRaise newform = new FireRaise(ref controllerObj, usersInfo["name"], usersInfo["email"], usersInfo["ID"], 0, usersInfo["subscribtion_date"], "Reader", privileged, "", "", -1, int.Parse(usersInfo["branchID"]));
            newform.Show();
            return;
        }

        public ListUsers(ref Controller c)
        {
            InitializeComponent();

            userslist_panel.Parent = this;
            controllerObj = c;

            List<string> branchNames = new List<string>(controllerObj.branchNames);


            branchNames.Add("All");
            branchComboBox.DataSource = branchNames;
            branchComboBox.SelectedItem = "All";


            if (controllerObj.employeeType != 0)
            {
                branchComboBox.SelectedItem = branchNames[controllerObj.branchIDs.FindIndex(0, a => a == int.Parse(controllerObj.currBranchID))];
                branchComboBox.Visible = false;
                filterButton.Visible = false;
            }

            ShowUsers();


        }

        private void ShowUsers()
        {
            // Clearing everything first.
            for (int i = userslist_panel.Controls.Count - 1; i >= 0; --i)
                userslist_panel.Controls[i].Dispose();

            userslist_panel.Controls.Clear();

            DataTable Users = controllerObj.GetReaders();
            if (Users != null)
            {
                foreach (DataRow user in Users.Rows)
                {
                    if (controllerObj.employeeType != 0)
                        if (user["branchID"].ToString() != controllerObj.currBranchID)
                            continue;



                    CustomPanel userPanel = new CustomPanel();
                    userPanel.Dock = DockStyle.Top;
                    userPanel.Size = new System.Drawing.Size(640, 113);
                    userPanel.BackColor = Color.Transparent;
                    userPanel.Cursor = Cursors.Hand;

                    // subscribtion start date label
                    Label subscribtionStartDate = new Label();
                    subscribtionStartDate.ForeColor = Color.DimGray;
                    if (user["subscribtion_start_date"] != DBNull.Value)
                        subscribtionStartDate.Text = DateTime.Parse(user["subscribtion_start_date"].ToString()).ToString("dd/MM/yyyy");

                    subscribtionStartDate.Font = new Font("Century Gothic", float.Parse("8.25"), FontStyle.Regular);
                    subscribtionStartDate.Parent = userPanel;
                    subscribtionStartDate.Location = new Point(548, 13);
                    subscribtionStartDate.AutoSize = true;
                    subscribtionStartDate.MaximumSize = new System.Drawing.Size(85, 0);

                    


                    PictureBox picture = new PictureBox();
                    picture.Size = new System.Drawing.Size(55, 55);
                    picture.Parent = userPanel;
                    picture.Location = new Point(12, 12);
                    string path = Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).ToString()).ToString()).ToString();
                    path += String.Format("\\Images\\Person\\{0}", user["img"].ToString());
                    picture.Image = new Bitmap(path);
                    picture.Refresh();
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;


                    // Branch label.
                    Label branch = new Label();
                    branch.Text = user["branchName"].ToString();
                    branch.Font = new Font("Century Gothic", float.Parse("9.75"), FontStyle.Regular);
                    branch.ForeColor = Color.DimGray;
                    branch.Parent = userPanel;
                    branch.Location = new Point(73, 12);
                    branch.AutoSize = true;

                    // Name Label.
                    Label title = new Label();
                    title.Text = user["pname"].ToString();
                    title.Font = new Font("Century Gothic", float.Parse("14.25"), FontStyle.Bold);
                    title.ForeColor = Color.FromArgb(75, 75, 75);
                    title.Parent = userPanel;
                    title.AutoSize = true;
                    title.Location = new Point(74, 29);

                    // Show email of the user.
                    Label publihser = new Label();
                    publihser.Text = user["email"].ToString();
                    publihser.Font = new Font("Century Gothic", float.Parse("11.25"), FontStyle.Regular);
                    publihser.ForeColor = SystemColors.ControlDarkDark;
                    publihser.Parent = userPanel;
                    publihser.Location = new Point(74, 52);
                    publihser.AutoSize = false;
                    publihser.Size = new System.Drawing.Size(549, 43);




                    userPanel.Parent = userslist_panel;

                    userPanel.Info.Add("name", user["pname"].ToString());
                    userPanel.Info.Add("email", user["email"].ToString());
                    userPanel.Info.Add("ID", user["ID"].ToString());
                    userPanel.Info.Add("subscribtion_date", user["subscribtion_start_date"].ToString());
                    userPanel.Info.Add("branchID", user["branchID"].ToString());

                    openUserDelegate = new MouseEventHandler((sender, e) => openUser(sender, e, userPanel.Info));
                    userPanel.MouseClick += (MouseEventHandler)openUserDelegate;


                }
            }

            return;

        }
        private void filterButton_Click(object sender, EventArgs e)
        {

            if (branchComboBox.SelectedItem.ToString() == "All")
            {

                if (searchTb.Text == "")
                {
                    foreach (CustomPanel user in userslist_panel.Controls)
                        user.Visible = true;
                }
                else
                {
                    foreach (CustomPanel user in userslist_panel.Controls)
                    {
                        user.Visible = false;
                        foreach (KeyValuePair<string, string> pieceOfInfo in user.Info)
                        {
                            if (pieceOfInfo.Value.ToLower() == searchTb.Text.ToLower() || pieceOfInfo.Value.ToLower().Contains(searchTb.Text.ToLower()))
                            {
                                user.Visible = true;
                                break;
                            }
                        }
                    }
                }

            }
            else
            {
                if (searchTb.Text == "")
                {
                    foreach (CustomPanel user in userslist_panel.Controls)
                    {
                        if (int.Parse(user.Info["branchID"]) == controllerObj.branchIDs[branchComboBox.SelectedIndex])
                            user.Visible = true;
                        else
                            user.Visible = false;
                    }
                }
                else
                {

                    foreach (CustomPanel user in userslist_panel.Controls)
                    {
                        if (int.Parse(user.Info["branchID"]) != controllerObj.branchIDs[branchComboBox.SelectedIndex])
                            user.Visible = false;
                        else
                        {
                            user.Visible = false;
                            foreach (KeyValuePair<string, string> pieceOfInfo in user.Info)
                            {
                                if (pieceOfInfo.Value.ToLower() == searchTb.Text.ToLower() || pieceOfInfo.Value.ToLower().Contains(searchTb.Text.ToLower()))
                                {
                                    user.Visible = true;
                                    break;
                                }
                            }                        
                        }
                    }
                }
            }
            return;
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            if (searchTb.Text == "")
            {
                if (branchComboBox.SelectedItem.ToString() == "All")
                {
                    foreach (CustomPanel user in userslist_panel.Controls)
                        user.Visible = true;
                }
                else
                {
                    foreach(CustomPanel user in userslist_panel.Controls)
                    {
                        if (int.Parse(user.Info["branchID"]) == controllerObj.branchIDs[branchComboBox.SelectedIndex])
                            user.Visible = true;
                        else
                            user.Visible = false;
                    }
                }


            }
            else
            {
                if (branchComboBox.SelectedItem.ToString() == "All")
                {
                    foreach (CustomPanel user in userslist_panel.Controls)
                    {
                        user.Visible = false;
                        foreach (KeyValuePair<string, string> pieceOfInfo in user.Info)
                        {
                            if (pieceOfInfo.Value.ToLower() == searchTb.Text.ToLower() || pieceOfInfo.Value.ToLower().Contains(searchTb.Text.ToLower()))
                            {
                                user.Visible = true;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    foreach (CustomPanel user in userslist_panel.Controls)
                    {
                        if (int.Parse(user.Info["branchID"]) != controllerObj.branchIDs[branchComboBox.SelectedIndex])
                            user.Visible = false;
                        else
                        {
                            user.Visible = false;
                            foreach (KeyValuePair<string, string> pieceOfInfo in user.Info)
                            {
                                if (pieceOfInfo.Value.ToLower() == searchTb.Text.ToLower() || pieceOfInfo.Value.ToLower().Contains(searchTb.Text.ToLower()))
                                {
                                    user.Visible = true;
                                    break;
                                }
                            }
                        }
                    }
                }

            }
        }
    }
}
