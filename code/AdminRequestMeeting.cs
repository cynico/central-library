using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentralLibrary
{
    public partial class AdminRequestMeeting : Form
    {
        Controller controllerObj;
        public AdminRequestMeeting(ref Controller c)
        {
            InitializeComponent();
            controllerObj = c;
        }

        private void cancelmeetingrequest_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void requestMeetingAdmin_Click(object sender, EventArgs e)
        {
            validation.ForeColor = Color.FromArgb(244, 67, 54);
            validation.Visible = false;
            if (requestmettingconfirm.Text == "")
            {
                validation.Text = "Please enter your password for confirmation.";
                validation.Visible = true;
            } else
            {
                if (int.Parse(meetingTimePicker.Value.Subtract(DateTime.Today).Days.ToString()) > 90 || int.Parse(meetingTimePicker.Value.Subtract(DateTime.Today).Days.ToString()) < 3)
                {
                    validation.Text = "You can only request meeting in the next 3 to 90 days.";
                    validation.Visible = true;
                } else
                {
                    if (!controllerObj.verifyPassword(requestmettingconfirm.Text))
                    {
                        validation.Text = "Wrong Password.";
                        validation.Visible = true;
                    } else
                    {
                        try
                        {

                            // Get owner ID.
                            string ownerID = controllerObj.GetOwnersInfo().Rows[0]["ID"].ToString();

                            // If we couldn't get the owner ID.
                            if (ownerID == "")
                                throw new Exception("Something wrong happened");
                            if (controllerObj.SendRequest("May I request a meeting with you on the following day: " + meetingTimePicker.Value.ToString("dd-MM-yyyy") + " ?", 0, DateTime.Now, controllerObj.currID, ownerID, 1) == 0)
                            {
                                throw new Exception("Something wrong happened");
                            }
                            

                            validation.ForeColor = Color.FromArgb(0, 200, 83);
                            validation.Text = "Request sent Successfully!";
                            validation.Visible = true;
                            requestmettingconfirm.Text = "";
                            requestButton.Visible = false;

                        } catch
                        {
                            validation.Text = "Something wrong happened. Try again later.";
                            validation.Visible = true;
                        }
                    }
                }
            }
        }

        private void adminRequestMeeting_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.DimGray, 3), this.DisplayRectangle);

        }
    }
}
