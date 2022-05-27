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


// 0 is for vending

// 1 is for meetings.

// 2 for resignation


// 3 for vending contracts



// 4 for borrowing a book.
// 5 for subscribtion requests;
// 6 for event attendance.




namespace CentralLibrary
{
    // Please, keep in mind that this form, so far, only lists the received pending requests.
    // Any sent requests are not listed, and any already-accepted/rejected requests are not listed as well.

    public partial class ListRequests : Form
    {
        Controller controllerObj;
        Delegate openRequestDelegate;
        public ListRequests(ref Controller c)
        {
            controllerObj = c;
            InitializeComponent();
            requestfilter.SelectedIndex = 0;


            string[] rts = {"All"};
            List<string> typeOfRequests = new List<string>(rts);

            // ONLY SHOWING Requests of type Resignation for both administrators and owner.
            // Librarians can not have those requests pending.
            if (controllerObj.employeeType < 2)
                typeOfRequests.Add("Resignation");


            if (controllerObj.employeeType <= 1)
            {
                typeOfRequests.Add("Business Meetings");
                typeOfRequests.Add("Vending");
            }
            else if (controllerObj.employeeType == 2)
            {
                typeOfRequests.Add("Library Requests");
                addButton.Visible = false;
            }
            else if (controllerObj.employeeType == 4)
            {
                addButton.Visible = false;
                typeOfRequests.Add("Contract Requests");
                typeOfRequests.Add("Vending");
            }



            requestfilter.DataSource = typeOfRequests;

            addButton.Parent = this;
            addButton.Location = new Point(540, 690);
            addButton.BringToFront();
            
            ShowRequests(-1);
        }

        public void refreshrequests()
        {
            requestfilter.SelectedIndex = 0;
            ShowRequests(-1);

        }


        private void openRequest(object sender, EventArgs e, DataRow row, int meetingID, int branchOfRequestSender, DateTime send_date)
        {
            var me = this;
            
            AcceptRefuseRequest newform = new AcceptRefuseRequest(ref controllerObj,
                               row["email"].ToString(),
                               row["rtext"].ToString(),
                               row["pfirstname"].ToString() + " " + row["plastname"].ToString(),
                               int.Parse(row["ID"].ToString()),
                               row["sender"].ToString(),
                               int.Parse(row["rtype"].ToString()),
                               ref me,
                               meetingID,
                               branchOfRequestSender,
                               send_date
                               );

            newform.Show();

        }
        private void ShowRequests(int requestType)
        {

            // Clearing everything first.
            for (int i = requestlistpanel.Controls.Count - 1; i >= 0; --i)
                requestlistpanel.Controls[i].Dispose();

            requestlistpanel.Controls.Clear();

            DataTable dt = controllerObj.GetReceivedRequests(requestType);
            
            // If the logged in user is a librarian, show them the requests tied to their
            // branch which have a receiver attribute value of NULL.
            // (THESE REQUESTS ARE UP FOR GRABS FOR ANY LIBRARIAN IN THIS BRANCH TO ACCEPT/REFUSE IT).
            
            if (controllerObj.employeeType == 2)
            {

                if (dt == null)
                    dt = controllerObj.GetReaderRequests(-1);
                else
                {
                    DataTable dt2 = controllerObj.GetReaderRequests(-1);
                    dt.Merge(dt2);
                }
            }

            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {

                    CPanel requestpanel = new CPanel();
                    requestpanel.Dock = DockStyle.Top;
                    requestpanel.Size = new System.Drawing.Size(640, 113);
                    requestpanel.BackColor = Color.Transparent;
                    requestpanel.db_id = row["ID"].ToString();
                    requestpanel.Cursor = Cursors.Hand;




                    // Extracting the meeting ID from the text of the request, if the request's type is business
                    // meeting request.
                    int meetingID = -1;
                    if (int.Parse(row["rtype"].ToString()) == 1 && controllerObj.currID.Substring(0, 1) != "0")
                    {
                        meetingID = int.Parse(row["rtext"].ToString().Split('.')[1]);
                    }

                    int branchOfRequestSender = -1;
                    // Setting the mouseclick event based on the type of the request
                    if (row["branchID"] != DBNull.Value)
                        branchOfRequestSender = int.Parse(row["branchID"].ToString());


                    DateTime send_date = DateTime.Parse(row["send_date"].ToString());



                    PictureBox picture = new PictureBox();
                    picture.Size = new System.Drawing.Size(55, 55);
                    picture.Parent = requestpanel;
                    picture.Location = new Point(12, 12);

                    string path = Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).ToString()).ToString()).ToString();
                    path += String.Format("\\Images\\Person\\{0}", row["img"].ToString());
                    picture.Image = new Bitmap(path);
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    picture.Refresh();




                    // Creating branch label.
                    Label branch = new Label();
                    branch.Text = row["bname"] + ", " + row["blocation"];


                    branch.Font = new Font("Century Gothic", float.Parse("9.75"), FontStyle.Regular);
                    branch.ForeColor = Color.DimGray;
                    branch.Parent = requestpanel;
                    branch.Location = new Point(73, 12);
                    branch.AutoSize = true;

                    // name Label
                    Label name = new Label();
                    name.Text = row["pfirstname"].ToString() + " " + row["plastname"].ToString();
                    name.Font = new Font("Century Gothic", float.Parse("14.25"), FontStyle.Bold);
                    name.ForeColor = Color.FromArgb(75, 75, 75);
                    name.Parent = requestpanel;
                    name.AutoSize = true;
                    name.Location = new Point(74, 29);


                    // Main body of request.
                    Label text = new Label();
                    text.Text = row["rtext"].ToString().Split('.')[0] + ".";
                    text.Font = new Font("Century Gothic", float.Parse("11.25"), FontStyle.Regular);
                    text.ForeColor = SystemColors.ControlDarkDark;
                    text.Parent = requestpanel;
                    text.Location = new Point(74, 52);
                    text.AutoSize = false;
                    text.Size = new System.Drawing.Size(549, 43);



                    
                    // sent_date label
                    Label date = new Label();
                    date.Text = send_date.ToString("dd MMM yyyy");


                    date.Font = new Font("Century Gothic", float.Parse("8.25"), FontStyle.Regular);
                    date.ForeColor = Color.DimGray;
                    date.Parent = requestpanel;
                    date.Location = new Point(548, 13);


                    if (row["bname"].ToString() == "")
                        requestpanel.keywords = new string[] { row["email"].ToString(), row["pfirstname"].ToString(), row["plastname"].ToString(), send_date.Month.ToString(), send_date.Year.ToString() };
                    else
                        requestpanel.keywords = new string[] { row["bname"].ToString(), row["blocation"].ToString(), row["email"].ToString(), row["pfirstname"].ToString(), row["plastname"].ToString(), send_date.Month.ToString(), send_date.Year.ToString() };


                    openRequestDelegate = new MouseEventHandler((sender, e) => openRequest(sender, e, row, meetingID, branchOfRequestSender, send_date));
                    requestpanel.MouseClick += (MouseEventHandler)openRequestDelegate;

                    requestpanel.Parent = requestlistpanel;


                }
                Panel controlPanel = new Panel();
                controlPanel.Dock = DockStyle.Top;
                controlPanel.Size = new System.Drawing.Size(640, 113);

                Application.UseWaitCursor = false;
            }

            return;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var me = this;
            ChooseRequest newform = new ChooseRequest(ref controllerObj, ref me);
            newform.Show();
        }

        private void filterbutton_Click(object sender, EventArgs e)
        {

            if (requestfilter.SelectedItem.ToString() == "Business Meetings")
            {
                ShowRequests(1);
            } else if (requestfilter.SelectedItem.ToString() == "Resignation")
            {
                ShowRequests(2);
            } else if (requestfilter.SelectedItem.ToString() == "Contrat Requests")
            {
                ShowRequests(3);
            }
             else if (requestfilter.SelectedItem.ToString() == "Vending")
            {
                ShowRequests(0);
            }
            else
            {
                ShowRequests(-1);
            }
        }
    }

}