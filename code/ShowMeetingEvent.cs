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
    public partial class ShowMeetingEvent : Form
    {

        Controller controllerObj;
        Point initialLocation = new Point(16, 22);
        int counter;
        int type;
        string title;
        int dbID;


        // type:
        // 0 -> meetings
        // 1 -> events
        public ShowMeetingEvent(ref Controller c, int ID, string titlearg, string description, string bedatetime, string location_branch, int t, bool showAttendButton = false, bool showUnattendButton=false)
        {
            InitializeComponent();
            controllerObj = c;

            titleLabel.Text = titlearg;
            title = titlearg;
            descriptionLabel.Text = description;
            locationLabel.Text += location_branch;
            atLabel.Text += bedatetime;
            type = t;
            dbID = ID;


            if (type == 0)
            {
                DataTable ownersInfo = controllerObj.GetOwnersInfo();
                if (ownersInfo != null)
                {
                    ownernameLabel.Text = ownersInfo.Rows[0]["pname"].ToString();
                    ownernameLabel.MouseClick += (sender, e) =>
                    {
                        ComposeEmail newform = new ComposeEmail(ref controllerObj, ownersInfo.Rows[0]["email"].ToString());
                        newform.Show();
                    };
                }
                else
                {
                    ownernameLabel.Visible = false;
                }
                counter = 1;
            }
            else
            {
                counter = 0;
            }

            // Show attend button to readers on events.
            if (controllerObj.employeeType == 3 && type == 1 && showAttendButton)
                attendButton.Visible = true;
            else if (controllerObj.employeeType == 3 && type == 1 && showUnattendButton)
                unattendbutton.Visible = true;


            ShowAttendingAdmins(ID);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            if (type == 0)
                ((MainForm)this.Parent.Parent).openChildForm(new ListMeetings(ref controllerObj));
            else
                ((MainForm)this.Parent.Parent).openChildForm(new ListEvents(ref controllerObj));

        }
        private void ShowAttendingAdmins(int ID)
        {
            if (type == 0)
            {
                DataTable attendants = controllerObj.GetAttendants(ID);

                if (attendants != null)
                {
                    foreach (DataRow attendant in attendants.Rows)
                    {
                        LinkLabel newLabel = new LinkLabel();
                        newLabel.Text = attendant["pname"].ToString();

                        newLabel.Location = new Point(ownernameLabel.Location.X, ownernameLabel.Location.Y + counter * 30);
                        newLabel.ActiveLinkColor = Color.FromArgb(25, 118, 210);
                        newLabel.VisitedLinkColor = Color.FromArgb(25, 118, 210);

                        newLabel.Font = new Font("Century Gothic", float.Parse("11.25"), System.Drawing.FontStyle.Regular);
                        newLabel.LinkColor = Color.DimGray;
                        newLabel.Parent = listAdminPanel;
                        newLabel.MouseClick += (sender, e) =>
                        {
                            ComposeEmail newform = new ComposeEmail(ref controllerObj, attendant["email"].ToString());
                            newform.Show();
                        };

                        counter++;
                    }
                }
            }

            return;
        }

        private void attendButton_Click(object sender, EventArgs e)
        {
            validationLabel.Visible = false;
            validationLabel.ForeColor = utilityfunctions.Globals.redColor;

            try
            {
                parameterToAProcedure eventIDPar = new parameterToAProcedure("@eventID", dbID);
                parameterToAProcedure eventTitlePar = new parameterToAProcedure("@eventTitle", title);
                parameterToAProcedure requesterIDPar = new parameterToAProcedure("@requesterID", controllerObj.currID);
                parameterToAProcedure branchIDPar = new parameterToAProcedure("@branchID", controllerObj.currBranchID);

                if (controllerObj.ExecuteNonStoredProcedure("RequestEventAttendance", eventIDPar, eventTitlePar, requesterIDPar, branchIDPar) == 0)
                    throw new Exception();
                else
                {
                    validationLabel.Text = "A request for attending this event has been sent successfully!";
                    validationLabel.ForeColor = utilityfunctions.Globals.greenColor;
                    validationLabel.Visible = true;
                    attendButton.Visible = false;
                }

            }
            catch
            {
                validationLabel.Text = "Something wrong happened. Try again later.";
                validationLabel.Visible = true;
            }


        }

        private void unattendbutton_Click(object sender, EventArgs e)
        {
            parameterToAProcedure eventIDPar = new parameterToAProcedure("@eventID", dbID);
            parameterToAProcedure eventTitlePar = new parameterToAProcedure("@eventTitle", title);
            parameterToAProcedure requesterIDPar = new parameterToAProcedure("@requesterID", controllerObj.currID);
            parameterToAProcedure branchIDPar = new parameterToAProcedure("@branchID", controllerObj.currBranchID);
            try
            {
                if (controllerObj.ExecuteNonStoredProcedure("RequestToUnattendAnEvent", eventIDPar, eventTitlePar, requesterIDPar, branchIDPar) == 0)
                    throw new Exception();
                else
                {
                    validationLabel.Text = "A request for refund for this event's ticket has been sent successfully!";
                    validationLabel.ForeColor = utilityfunctions.Globals.greenColor;
                    validationLabel.Visible = true;
                    unattendbutton.Visible = false;
                }
            }
            catch
            {
                validationLabel.Text = "Something wrong happened. Try again later.";
                validationLabel.Visible = true;
            }
            return;
        }
    }
}
