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
    public partial class CreateBusinessMeeting : Form
    {

        Controller controllerObj;
        
        // This variable is passed in the constructor as an indication
        // of whether this form was opened in responding to a meeting request.
        
        // This will help making sure that the request in that case in accepeted, 
        // and its status updated in the database, after the creation of the meeting.
        bool fromRequest;
        int requestID;
        string requesterID;

        List<string> adminsNames;
        List<string> adminIDs;
        List<int> listOfBranchesIDs;

        public CreateBusinessMeeting(ref Controller c, bool fr, int rID=-1, string sID="")
        {
            InitializeComponent();
            controllerObj = c;
            requestID = rID;
            fromRequest = fr;
            requesterID = sID;


            DataTable branches = controllerObj.SelectAll("Branch");
            List<string> listOfBranches = new List<string>();
            listOfBranchesIDs = new List<int>();
            if (branches != null)
            {
                foreach (DataRow branch in branches.Rows)
                {
                    listOfBranches.Add(branch["bname"] + ", " + branch["blocation"]);
                    listOfBranchesIDs.Add(int.Parse(branch["ID"].ToString()));
                }
                branchComboBox.DataSource = listOfBranches;
            }
            ShowContent();

        }

        private void ShowContent()
        {
            DataTable dt = controllerObj.GetStoredProcedure("SelectAllAdm", null);
            adminsNames = new List<string>();
            adminIDs = new List<string>();

            if (dt == null)
                return;
            else
            {


                foreach (DataRow row in dt.Rows)
                {
                    string adminname = row["pfirstname"].ToString() + " " + row["plastname"].ToString();
                    
                    // Make this admin checked by default if it's the one sending the request.
                    adminsListBox.Items.Add(adminname, Convert.ToBoolean( (fromRequest && (row["ID"].ToString() == requesterID))));
                    adminIDs.Add(row["ID"].ToString());
                }

            }

            return;
        }

        private void createMeetingButton_Click(object sender, EventArgs e)
        {
            createmeetingvalidation.ForeColor = Color.FromArgb(244, 67, 54);
            createmeetingvalidation.Visible = false;
            if (titletextbox.Text == "" || description_textbox.Text == "" || branchComboBox.SelectedItem == null)
            {
                createmeetingvalidation.Text = "Enter a title, a description, and a location for the meeting.";
                createmeetingvalidation.Visible = true;
            } else if (titletextbox.Text.Length > 40)
            {
                createmeetingvalidation.Text = "Title must not be more than 40 characters long.";
                createmeetingvalidation.Visible = true;
            } else if (description_textbox.Text.Length > 140)
            {
                createmeetingvalidation.Text = "Description must not be more than 140 characters long.";
                createmeetingvalidation.Visible = true;
            }
            else if (confirmationPassword.Text == "")
            {
                createmeetingvalidation.Text = "Please enter your password for confirmation.";
                createmeetingvalidation.Visible = true;
            }
            else
            {
                if (int.Parse(datepicker.Value.Subtract(DateTime.Today).Days.ToString()) > 90)                {
                    createmeetingvalidation.Text = "You can only make meeting in the next 90 days.";
                    createmeetingvalidation.Visible = true;
                } else if 
                        (int.Parse(datepicker.Value.Subtract(DateTime.Today).Days.ToString()) <= 0 &&
                        int.Parse(timepicker.Value.TimeOfDay.Subtract(DateTime.Now.TimeOfDay).Hours.ToString()) == 0 &&
                        int.Parse(timepicker.Value.TimeOfDay.Subtract(DateTime.Now.TimeOfDay).Minutes.ToString()) < 59
                        )
                {
                    createmeetingvalidation.Text = "You can only make meeting an hour from now.";
                    createmeetingvalidation.Visible = true;
                }
                else
                {
                    int numOfChecked = 0;
                    List<string> attendingAdminsIDs = new List<string>();
                    for (int i = 0; i < adminsListBox.Items.Count; i++)
                    {
                        if (adminsListBox.GetItemChecked(i))
                        {
                            numOfChecked++;
                            attendingAdminsIDs.Add(adminIDs[i]);
                        }
                    }

                    // If no admins are selected.
                    if (numOfChecked == 0)
                    {
                        createmeetingvalidation.Text = "You must select at least one admin to attend the meeting.";
                        createmeetingvalidation.Visible = true;
                    }
                    // If the password is wrong.
                    else if (!controllerObj.verifyPassword(confirmationPassword.Text))
                    {
                        createmeetingvalidation.Text = "Wrong Password.";
                        createmeetingvalidation.Visible = true;
                    }
                    // Else
                    else
                    {
                        try
                        {
                            int counter = 1;
                            DataTable DtOfAttendants = new DataTable();
                            DtOfAttendants.Columns.Add(new DataColumn("ind", typeof(int)));
                            DtOfAttendants.Columns.Add(new DataColumn("attendantID", typeof(string)));


                            DateTime bdatetime = datepicker.Value.Date + timepicker.Value.TimeOfDay;


                            foreach (string adminID in attendingAdminsIDs)
                            {

                                // If this is the requester, do not send them a request.
                                if (fromRequest && adminID == requesterID)
                                    continue;
                                DataRow dr = DtOfAttendants.NewRow();
                                dr["ind"] = counter;
                                dr["attendantID"] = adminID;
                                DtOfAttendants.Rows.Add(dr);
                                counter++;
                            }

                            parameterToAProcedure titlePar = new parameterToAProcedure("@title", titletextbox.Text);
                            parameterToAProcedure descriptionPar = new parameterToAProcedure("@mdescription", description_textbox.Text);
                            parameterToAProcedure bdatetimePar = new parameterToAProcedure("@bdatetime", bdatetime);
                            parameterToAProcedure senderPar = new parameterToAProcedure("@sender", controllerObj.currID);
                            parameterToAProcedure branchPar = new parameterToAProcedure("@location_branch", listOfBranchesIDs[branchComboBox.SelectedIndex]);


                            parameterToAProcedure requesterIDPar = new parameterToAProcedure("@requesterID", requesterID);
                            if (requesterID == "")
                            {
                                requesterIDPar.value = DBNull.Value;
                            }

                            parameterToAProcedure requestIDPar = new parameterToAProcedure("@requestID", requestID);
                            if (requestID == -1)
                                requestIDPar.value = DBNull.Value;

                            parameterToAProcedure DtOfAttendantsPar = new parameterToAProcedure("@List", DtOfAttendants);

                            


                            // Creating the meeting, and sending requests to all the administrators.
                            if (controllerObj.ExecuteNonStoredProcedure("CreateBusinessMeeting", DtOfAttendantsPar, titlePar, descriptionPar, bdatetimePar, senderPar, branchPar, requesterIDPar, requestIDPar) == 0)
                                throw new Exception("Something wrong happened.");

                            // If this admin was the one requesting the meeting, accept their request, and automatically add them to the business meeting attendants.


                            // If they did not request it, send them a request to attend.
                            // Only when they accept that request, will they be added to the meetings attendants.

                            // Create the business meeting.
                            createmeetingvalidation.ForeColor = Color.FromArgb(0, 200, 83);
                            createmeetingvalidation.Text = "Meeting created, and requests for attending admins sent!!";
                            createmeetingvalidation.Visible = true;
                            confirmationPassword.Text = "";
                            createMeetingButton.Visible = false;

                            if (fromRequest)
                                ((MainForm)this.Parent.Parent).UpdateRequestCount();
                        }
                        catch
                        {
                            createmeetingvalidation.Text = "Something wrong happened. Try again later.";
                            createmeetingvalidation.Visible = true;
                        }
                    }
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).openChildForm(new ListMeetings(ref controllerObj));
        }
    }
}
