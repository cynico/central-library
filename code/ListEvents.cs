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
    public partial class ListEvents : Form
    {
        Controller controllerObj;
        int numSelected;
        Delegate openEventDelegate;

        public ListEvents(ref Controller c)
        {
            InitializeComponent();
            controllerObj = c;

            numSelected = 0;

            List<string> eventType = new List<string>();
            eventType.Add("All (Upcoming)");
            eventType.Add("Today");
            eventType.Add("This Week");
            unattendbutton.Visible = false;

            if (controllerObj.employeeType > 1)
            {
                addButton.Visible = false;
                deletebutton.Visible = false;

            }
            else if (controllerObj.employeeType > 2)
            {
                unattendbutton.Visible = true;
                eventType.Add("Attending");
            }

            // 0 -> All events
            // 1 -> Today's events.
            // 2 -> This week's events.
            // 3 -> The events you're attending (if you are a reader).
            filterComboBox.DataSource = eventType;
            filterComboBox.SelectedIndex = 0;


            addButton.Parent = this;
            addButton.Location = new Point(530, 680);
            addButton.BringToFront();
            eventsList.Parent = this;
            ShowEvents(0);
        }


        private void openEvent(object sender, EventArgs e, DataRow row, string edatetime, bool showAttendButton, bool showUnattendButton)
        {
            ((MainForm)this.Parent.Parent).openChildForm(new ShowMeetingEvent(ref controllerObj, int.Parse(row["ID"].ToString()), row["title"].ToString(), row["edescription"].ToString(), edatetime, row["bname"].ToString() + " " + row["blocation"].ToString(), 1, showAttendButton, showUnattendButton));
            return;
        }
        private void ShowEvents(int etype)
        {
            DataTable events = controllerObj.GetEvents(etype);
            if (events != null)
            {

                foreach (DataRow row in events.Rows)
                {
                    CPanel eventpanel = new CPanel();
                    eventpanel.Dock = DockStyle.Top;
                    eventpanel.Size = new System.Drawing.Size(640, 113);
                    eventpanel.BackColor = Color.Transparent;
                    eventpanel.db_id = row["ID"].ToString();
                    eventpanel.Cursor = Cursors.Hand;



                    // event_date label
                    Label date = new Label();
                    DateTime meeting_date = DateTime.Parse(row["edatetime"].ToString());
                    date.Text = meeting_date.ToString("dd MMM yyyy HH:mm");
                    date.Font = new Font("Century Gothic", float.Parse("8.25"), FontStyle.Regular);
                    date.ForeColor = Color.DimGray;
                    date.Parent = eventpanel;
                    date.Location = new Point(548, 13);
                    date.AutoSize = true;
                    date.MaximumSize = new System.Drawing.Size(85, 0);


                    // Setting type data member to the following:
                    // 1 for today's events
                    // 2 for events in the span of a week
                    if (meeting_date.Date == DateTime.Today)
                        eventpanel.type = 1;
                    else if (meeting_date.Date > DateTime.Today && meeting_date.Date <= DateTime.Today.AddDays(6))
                        eventpanel.type = 2;



                    // PictureBox
                    CircularButton mCircle = new CircularButton();
                    mCircle.Size = new System.Drawing.Size(55, 55);
                    mCircle.BackColor = Color.FromArgb(25, 118, 210);
                    mCircle.Parent = eventpanel;
                    mCircle.Location = new Point(12, 12);
                    mCircle.FlatStyle = FlatStyle.Flat;

                    mCircle.FlatAppearance.MouseDownBackColor = Color.FromArgb(25, 118, 210);
                    mCircle.FlatAppearance.MouseDownBackColor = Color.FromArgb(25, 118, 210);
                    mCircle.FlatAppearance.BorderSize = 0;

                    mCircle.ForeColor = Color.White;
                    mCircle.Font = new Font("Century Gothic", float.Parse("9.75"), System.Drawing.FontStyle.Regular);

                    mCircle.Text = "E";


                    if (controllerObj.employeeType <= 1)
                    {
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

                    }




                    // branch label.
                    Label branch = new Label();
                    branch.Text = row["bname"] + ", " + row["blocation"];
                    branch.Font = new Font("Century Gothic", float.Parse("9.75"), FontStyle.Regular);
                    branch.ForeColor = Color.DimGray;
                    branch.Parent = eventpanel;
                    branch.Location = new Point(73, 12);
                    branch.AutoSize = true;

                    // Title Label.
                    Label name = new Label();
                    name.Text = row["title"].ToString();
                    name.Font = new Font("Century Gothic", float.Parse("14.25"), FontStyle.Bold);
                    name.ForeColor = Color.FromArgb(75, 75, 75);
                    name.Parent = eventpanel;
                    name.AutoSize = true;
                    name.Location = new Point(74, 29);


                    // IF this is a reader, show if they are attending it, or if they requested it (and the status of the request), or if nothing at all.
                    bool showAttendButton = true;
                    bool showUnattendButton = false;

                    if (controllerObj.employeeType == 3)
                    {
                        Label attendingornot = new Label();
                        attendingornot.Font = new Font("Century Gothic", float.Parse("9.75"), FontStyle.Regular);
                        attendingornot.ForeColor = Color.DimGray;
                        attendingornot.Parent = eventpanel;
                        attendingornot.Location = new Point(200, 12);
                        attendingornot.AutoSize = true;


                        // In case they are attending, and have requested to unattend.
                        if (row["attendantID"] != DBNull.Value && row["rtype"] != DBNull.Value)
                        {
                            if (row["rtype"].ToString() == "7")
                            {
                                attendingornot.Text = "(Refund pending approval)";
                                attendingornot.ForeColor = Color.FromArgb(245, 127, 23);
                                showAttendButton = false;
                                showUnattendButton = false;
                            }

                        }
                        // In case they are attending, and have not requested to unattend.
                        else if (row["attendantID"] != DBNull.Value && row["rtype"] == DBNull.Value)
                        {
                            attendingornot.Text = "(Attending)";
                            attendingornot.ForeColor = utilityfunctions.Globals.greenColor;
                            showAttendButton = false;
                            showUnattendButton = true;
                        }
                        // In case they are not attending.
                        else
                        {
                            showAttendButton = true;
                            showUnattendButton = false;
                        }

                    }


                    // Show description of the meeting.
                    Label description = new Label();
                    description.Text = row["edescription"].ToString();
                    description.Font = new Font("Century Gothic", float.Parse("11.25"), FontStyle.Regular);
                    description.ForeColor = SystemColors.ControlDarkDark;
                    description.Parent = eventpanel;
                    description.Location = new Point(74, 52);
                    description.AutoSize = false;
                    description.Size = new System.Drawing.Size(549, 43);


                    eventpanel.Parent = eventsList;
                    eventpanel.Visible = true;
                    openEventDelegate = new MouseEventHandler((sender, e) => openEvent(sender, e, row, date.Text, showAttendButton, showUnattendButton)); ;
                    eventpanel.MouseClick += (MouseEventHandler)openEventDelegate;


                    // set keywords.
                    eventpanel.keywords = new string[] { row["edatetime"].ToString(), row["title"].ToString()};

                }
            }


            return;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ((MainForm)(this.Parent.Parent)).openChildForm(new CreateEvent(ref controllerObj));

        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            cancelbutton.Visible = false;
            selectallbutton.Visible = false;
            numSelected = 0;

            foreach (CPanel panel in eventsList.Controls)
            {
                panel.selected = false;
                panel.BackColor = Color.Transparent;
            }
        }

        private void selectallbutton_Click(object sender, EventArgs e)
        {
            foreach (CPanel panel in eventsList.Controls)
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

            validationLabel.Visible = false;
            validationLabel.ForeColor = Color.FromArgb(244, 67, 54);

            if (numSelected == 0)
                return;

            DataTable DtOfUpcomingIds = new DataTable();
            DataTable DtOfPastIds = new DataTable();

            int counter = 1;

            DtOfUpcomingIds.Columns.Add(new DataColumn("ind", typeof(int)));
            DtOfUpcomingIds.Columns.Add(new DataColumn("eventID", typeof(int)));
            DtOfUpcomingIds.Columns.Add(new DataColumn("etext", typeof(string)));

            DtOfPastIds.Columns.Add(new DataColumn("eventID", typeof(int)));

            List<CPanel> PanelsToRemove = new List<CPanel>();

            foreach (CPanel eventpanel in eventsList.Controls)
            {

                if (eventpanel.selected)
                {
                    // Refer above to where the keywords are set. The first keyword contains the date of the event.
                    DateTime EventDate = DateTime.Parse(eventpanel.keywords[0]);
                    TimeSpan interval = EventDate.Subtract(DateTime.Now);

                    // If this is a past event.
                    if (interval.TotalHours < 0)
                    {
                        Console.WriteLine(interval.TotalHours);
                        DataRow row = DtOfPastIds.NewRow();
                        row["eventID"] = eventpanel.db_id;
                        PanelsToRemove.Add(eventpanel);
                    }
                    else if (interval.TotalHours < 48)
                    {
                        validationLabel.Text = "You can only delete an event occurring at least two days from now for attendants to be notified.";
                        validationLabel.Visible = true;
                        cancelbutton.PerformClick();
                        return;
                    }
                    else
                    {
                        DataRow row = DtOfUpcomingIds.NewRow();
                        row["ind"] = counter;
                        row["eventID"] = eventpanel.db_id;
                        row["etext"] = String.Format("The event of title '{0}' has been cancelled on {1}.", eventpanel.keywords[1], DateTime.Now.ToString());
                        DtOfUpcomingIds.Rows.Add(row);
                        counter++;

                        PanelsToRemove.Add(eventpanel);
                    }
                }
            }

            try
            {

                parameterToAProcedure upcomingPar = new parameterToAProcedure("@List", DtOfUpcomingIds);
                if (controllerObj.ExecuteNonStoredProcedure("DeleteUpcomingEvents", upcomingPar) == 0)
                    throw new Exception();

                foreach (CPanel PanelToRemove in PanelsToRemove)
                {
                    PanelToRemove.Dispose();
                    eventsList.Controls.Remove(PanelToRemove);
                }

                GC.Collect();
                cancelbutton.PerformClick();

                validationLabel.Text = "Events deleted/cancelled Successfully!";
                validationLabel.ForeColor = Color.FromArgb(0, 200, 83);
                validationLabel.Visible = true;
            }
            catch
            {
                validationLabel.Text = "Something wrong happened. Try again later.";
                validationLabel.Visible = true;
                cancelbutton.PerformClick();
            }
            return;
        }

        private void filterbutton_Click(object sender, EventArgs e)
        {
            int choice = filterComboBox.SelectedIndex;
            // If (All upcoming) is chosen, show all meetings.
            if (choice == 0)
                foreach (CPanel PanelToHide in eventsList.Controls)
                    PanelToHide.Visible = true;
            else
            {
                foreach (CPanel PanelToHide in eventsList.Controls)
                {
                    if (PanelToHide.type != choice)
                        PanelToHide.Visible = false;
                    else
                        PanelToHide.Visible = true;
                }
            }
            return;
        }
    }
}
