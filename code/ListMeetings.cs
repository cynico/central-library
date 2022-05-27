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
    public partial class ListMeetings : Form
    {
        Controller controllerObj;
        int numSelected;
        Delegate openMeetingDelegate;

        public ListMeetings(ref Controller c)
        {
            InitializeComponent();
            controllerObj = c;
            numSelected = 0;
            filterComboBox.SelectedIndex = 0;

            // Show add and delete buttons to owner
            // Show un-attend button to administrator.
            if (controllerObj.employeeType != 0)
            {
                addButton.Visible = false;
                deletebutton.Visible = false;
                unattendbutton.Visible = true;
            } else
            {
                unattendbutton.Visible = false;      
            }

            addButton.Parent = this;
            addButton.Location = new Point(530, 680);
            addButton.BringToFront();
            meetingsList.Parent = this;
            ShowMeetings(0);
        }

        private void openMeeting(object sender, EventArgs e, DataRow row, string bdatetime)
        {
            ((MainForm)this.Parent.Parent).openChildForm(new ShowMeetingEvent(ref controllerObj, int.Parse(row["ID"].ToString()), row["title"].ToString(), row["mdescription"].ToString(), bdatetime, row["bname"].ToString() + " " + row["blocation"].ToString(), 0));
            return;
        }

        // meetingType:
        // 0 for all upcoming meeting.
        // 1 for today's meetings
        // 2 for next week meetings.
        private void ShowMeetings(int meetingType)
        {

            DataTable meetings;
            meetings = controllerObj.GetMeetings(meetingType);

            if (meetings != null)
            {
                foreach (DataRow row in meetings.Rows)
                {
                    CPanel meetingpanel = new CPanel();
                    meetingpanel.Dock = DockStyle.Top;
                    meetingpanel.Size = new System.Drawing.Size(640, 113);
                    meetingpanel.BackColor = Color.Transparent;
                    meetingpanel.db_id = row["ID"].ToString();
                    meetingpanel.Cursor = Cursors.Hand;


                    // meeting_date label
                    Label date = new Label();
                    DateTime meeting_date = DateTime.Parse(row["bdatetime"].ToString());
                    date.Text = meeting_date.ToString("dd MMM yyyy HH:mm");
                    date.Font = new Font("Century Gothic", float.Parse("8.25"), FontStyle.Regular);
                    date.ForeColor = Color.DimGray;
                    date.Parent = meetingpanel;
                    date.Location = new Point(548, 13);
                    date.AutoSize = true;
                    date.MaximumSize = new System.Drawing.Size(85, 0);


                    // Setting type data member to the following:
                    // 1 for today's meetings
                    // 2 for meetings in the span of a week
                    if (meeting_date.Date == DateTime.Today)
                        meetingpanel.type = 1;
                    else if (meeting_date.Date > DateTime.Today && meeting_date.Date <= DateTime.Today.AddDays(6))
                        meetingpanel.type = 2;
                        


                    CircularButton mCircle = new CircularButton();
                    mCircle.Size = new System.Drawing.Size(55, 55);
                    mCircle.BackColor = Color.FromArgb(25, 118, 210);
                    mCircle.Parent = meetingpanel;
                    mCircle.Location = new Point(12, 12);
                    mCircle.FlatStyle = FlatStyle.Flat;

                    mCircle.FlatAppearance.MouseDownBackColor = Color.FromArgb(25, 118, 210);
                    mCircle.FlatAppearance.MouseDownBackColor = Color.FromArgb(25, 118, 210);
                    mCircle.FlatAppearance.BorderSize = 0;

                    mCircle.ForeColor = Color.White;
                    mCircle.Font = new Font("Century Gothic", float.Parse("9.75"), System.Drawing.FontStyle.Regular);

                    mCircle.Text = "B";

                    mCircle.MouseClick += (sender, e) =>
                    {

                        if (!((CPanel)mCircle.Parent).selected)
                        {
                            ((CPanel)mCircle.Parent).BackColor = Color.LightGray;
                            ((CPanel)mCircle.Parent).selected = true;
                            numSelected++;
                        }
                        else
                        {
                            ((CPanel)mCircle.Parent).BackColor = Color.Transparent;
                            ((CPanel)mCircle.Parent).selected = false;
                            numSelected--;
                        }

                        if (numSelected == 0)
                        {
                            cancelbutton.PerformClick();
                        }
                        else
                        {
                            cancelbutton.Visible = true;
                            selectallbutton.Visible = true;
                        }
                    };



                    // branch label.
                    Label branch = new Label();
                    branch.Text = row["bname"] + ", " + row["blocation"];
                    branch.Font = new Font("Century Gothic", float.Parse("9.75"), FontStyle.Regular);
                    branch.ForeColor = Color.DimGray;
                    branch.Parent = meetingpanel;
                    branch.Location = new Point(73, 12);
                    branch.AutoSize = true;

                    // Title Label.
                    Label title = new Label();
                    title.Text = row["title"].ToString();
                    title.Font = new Font("Century Gothic", float.Parse("14.25"), FontStyle.Bold);
                    title.ForeColor = Color.FromArgb(75, 75, 75);
                    title.Parent = meetingpanel;
                    title.AutoSize = true;
                    title.Location = new Point(74, 29);

                    // Show description of the meeting.
                    Label description = new Label();
                    description.Text = row["mdescription"].ToString();
                    description.Font = new Font("Century Gothic", float.Parse("11.25"), FontStyle.Regular);
                    description.ForeColor = SystemColors.ControlDarkDark;
                    description.Parent = meetingpanel;
                    description.Location = new Point(74, 52);
                    description.AutoSize = false;
                    description.Size = new System.Drawing.Size(549, 43);
                



                    meetingpanel.Parent = meetingsList;

                    openMeetingDelegate = new MouseEventHandler((sender, e) => openMeeting(sender, e, row, date.Text));
                    meetingpanel.MouseClick += (MouseEventHandler)openMeetingDelegate;

                    meetingpanel.keywords = new string[] { meeting_date.ToString(), title.Text };
                }
            }


            return;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ((MainForm)(this.Parent.Parent)).openChildForm(new CreateBusinessMeeting(ref controllerObj, false));
        }

        private void filterbutton_Click(object sender, EventArgs e)
        {
            int choice = filterComboBox.SelectedIndex;
            // If (All upcoming) is chosen, show all meetings.
            if (choice == 0)
                foreach (CPanel PanelToHide in meetingsList.Controls)
                    PanelToHide.Visible = true;
            else
            {
                foreach (CPanel PanelToHide in meetingsList.Controls)
                {
                    if (PanelToHide.type != choice)
                        PanelToHide.Visible = false;
                    else
                        PanelToHide.Visible = true;
                }
            }
            return;
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            cancelbutton.Visible = false;
            selectallbutton.Visible = false;
            numSelected = 0;

            foreach (CPanel panel in meetingsList.Controls)
            {
                panel.selected = false;
                panel.BackColor = Color.Transparent;
            }
        }

        private void selectallbutton_Click(object sender, EventArgs e)
        {
            foreach (CPanel panel in meetingsList.Controls)
            {
                if (!panel.selected)
                {
                    numSelected++;
                    panel.selected = true;
                    panel.BackColor = Color.LightGray;
                }
            }
            return;
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {

            //validationtextbox.Visible = false;
            if (numSelected == 0)
                return;

            DataTable DtOfIds = new DataTable();
            DtOfIds.Columns.Add(new DataColumn("ID", typeof(int)));
            List<CPanel> PanelsToRemove = new List<CPanel>();

            foreach (CPanel panel in meetingsList.Controls)
            {
                if (panel.selected)
                {
                    DataRow row = DtOfIds.NewRow();
                    row["ID"] = panel.db_id;
                    DtOfIds.Rows.Add(row);

                    PanelsToRemove.Add(panel);
                }
            }


            try
            {
                parameterToAProcedure DtOfIdsPar = new parameterToAProcedure("@List", DtOfIds);
                controllerObj.ExecuteNonStoredProcedure("DeleteMeetings", DtOfIdsPar);
                foreach (CPanel PanelToRemove in PanelsToRemove)
                {
                    PanelToRemove.Dispose();
                    meetingsList.Controls.Remove(PanelToRemove);
                }
                GC.Collect();
                cancelbutton.PerformClick();
            }
            catch
            {
                cancelbutton.PerformClick();
            }
            return;
        }

        private void unattendbutton_Click(object sender, EventArgs e)
        {

            if (numSelected == 0)
                return;

            DataTable DtOfIds = new DataTable();
            DtOfIds.Columns.Add(new DataColumn("ID", typeof(int)));
            List<CPanel> PanelsToRemove = new List<CPanel>();

            // This is the text of the notification sent to the owner.
            string notificationContent = String.Format("{0} {1} opted out to not attend the following meetings:\n", controllerObj.currFirstname, controllerObj.currLastname);
            int counter = 1;

            foreach (CPanel panel in meetingsList.Controls)
            {
                if (panel.selected)
                {
                    DataRow row = DtOfIds.NewRow();
                    row["ID"] = panel.db_id;
                    DtOfIds.Rows.Add(row);
                    PanelsToRemove.Add(panel);
                    notificationContent += String.Format("{0}. {1} on {2}.\n", counter, panel.keywords[1], panel.keywords[0]);
                    counter++;
                }
            }

            parameterToAProcedure attendantID = new parameterToAProcedure("@attendantID", controllerObj.currID);
            parameterToAProcedure content = new parameterToAProcedure("@notificationContent", notificationContent);
            parameterToAProcedure meetingList = new parameterToAProcedure("@List", DtOfIds);


            try
            {
                controllerObj.ExecuteNonStoredProcedure("UnattendMeetings", meetingList, attendantID, content);
                foreach (CPanel PanelToRemove in PanelsToRemove)
                {
                    PanelToRemove.Dispose();
                    meetingsList.Controls.Remove(PanelToRemove);
                }
                GC.Collect();
                cancelbutton.PerformClick();
            }
            catch
            {
                cancelbutton.PerformClick();
            }
            return;
        }
    }
}
