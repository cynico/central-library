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
    public partial class AcceptRefuseRequest : Form
    {
        Controller controllerObj;
        string senderEmail;
        string requestText;
        string senderName;
        int requestID;
        string senderID;
        int requestType;

        ListRequests parent;
        int meetingID;
        int branchOfRequestSender;
        DateTime send_date;

        public AcceptRefuseRequest(ref Controller c, string email, string rtext, string name, int rID, string sID, int rtype, ref ListRequests p, int mID, int b, DateTime s)
        {
            InitializeComponent();
            controllerObj = c;
            senderEmail = email;
            requestText = rtext;
            senderName = name;
            requestID = rID;
            senderID = sID;
            requestType = rtype;
            parent = p;
            meetingID = mID;
            branchOfRequestSender = b;
            send_date = s;


            if (requestType == 0)
                viewButton.Visible = true;


            // Dont' show the contact button on readers whose subscribtions are still pending approval.
            if (senderID.Substring(0, 1) == "5")
                contactSender.Visible = false;


            showContent();
        }


        private void showContent()
        {
            requestbody.AutoSize = true;
            requestbody.Text = senderName + ":\n";
            requestbody.Text += requestText;

            return;
        }

        private void Success(string status)
        {
            requestvalidation.ForeColor = Color.FromArgb(0, 200, 83);
            requestvalidation.Text = String.Format("Request {0} Successfully.", status);
            requestvalidation.Visible = true;

            // Hiding buttons of accept and request.
            acceptRequest.Visible = false;
            rejectRequestButton.Visible = false;
            return;
        }

        private void SomethingWrongHappened()
        {
            requestvalidation.Text = "Something wrong happened, try again later!";
            requestvalidation.Visible = true;
            return;
        }

        private void cancelrequestact_Click(object sender, EventArgs e)
        {
            this.Close();
            ((ListRequests)parent).refreshrequests();
        }

        private void contactSender_Click(object sender, EventArgs e)
        {
            ComposeEmail newform = new ComposeEmail(ref controllerObj, senderEmail);
            newform.Show();
            this.Close();
        }

        private void acceptRequest_Click(object sender, EventArgs e)
        {

            // request status:
            // 0 -> pending
            // 1 -> accepted
            // 2 -> rejected.

            // request types:
            // 0 is for vending
            // 1 is for meetings.
            // 2 for resignation
            // 3 for contract with a vendor
            // 4 for borrowing a book
            // 5 for subscribtion requests
            // 6 for event attendance requests
            // 7 for event unattendance/refund request.

            requestvalidation.ForeColor = Color.FromArgb(244, 67, 54);
            requestvalidation.Visible = false;


            // For vending requests.
            if (requestType == 0)
            {
                try
                {
                    parameterToAProcedure requestIDPar = new parameterToAProcedure("@requestID", requestID);
                    parameterToAProcedure vendorNamePar = new parameterToAProcedure("@vendorName", controllerObj.currVendorName.ToString());


                    if (controllerObj.ExecuteNonStoredProcedure("AcceptVendingRequest", requestIDPar, vendorNamePar) == 0)
                        throw new Exception();
                    else
                        Success("accepted");

                }
                catch
                {
                    requestvalidation.Text = "Something wrong happened. Try again later.";
                    requestvalidation.Visible = true;
                }
            }


            // For business meetings requests.
            else if (requestType == 1)
            {
                // If it's the owner accepting a request for a meeting, just open the create business meeting form,
                // and check the requester as an attendant by default.
                if (controllerObj.currID.Substring(0, 1) == "0")
                {
                    // Open the form for creating a business meeting.
                    ((MainForm)parent.Parent.Parent).openChildForm(new CreateBusinessMeeting(ref controllerObj, true, requestID, senderID));
                    this.Close();
                }

                // If it's the administrator accepting a request for a meeting by the owner, accept it and enlist yourself as
                // and attendant.
                else if (controllerObj.currID.Substring(0, 1) == "1")
                {

                    try
                    {

                        parameterToAProcedure requestIDPar = new parameterToAProcedure();
                        requestIDPar.name = "@requestID";
                        requestIDPar.value = requestID;

                        parameterToAProcedure meetingIDPar = new parameterToAProcedure();
                        meetingIDPar.name = "@meetingID";
                        meetingIDPar.value = meetingID;

                        parameterToAProcedure attendantIDPar = new parameterToAProcedure();
                        attendantIDPar.name = "@attendantID";
                        attendantIDPar.value = controllerObj.currID;

                        if (controllerObj.ExecuteNonStoredProcedure("AcceptAndAttendMeetings", requestIDPar, meetingIDPar, attendantIDPar) == 0)
                            throw new Exception();
                        else
                            Success("accepted");

                    } catch
                    {
                        SomethingWrongHappened();
                    }
                }
            }
            
            // Contract with vendor requests.
            else if (requestType == 3)
            {
                try
                {

                    parameterToAProcedure vendorIDPar = new parameterToAProcedure("@vendorID", controllerObj.currID);
                    parameterToAProcedure requestIDPar = new parameterToAProcedure("@requestID", requestID);
                    parameterToAProcedure adminIDPar = new parameterToAProcedure("@adminID", senderID);
                    parameterToAProcedure branchIDPar = new parameterToAProcedure("@branchID", branchOfRequestSender);
                    parameterToAProcedure vnamePar = new parameterToAProcedure("@vname", controllerObj.currVendorName);

                    if (controllerObj.ExecuteNonStoredProcedure("MakeContract", vendorIDPar, requestIDPar, adminIDPar, branchIDPar, vnamePar) == 0)
                        throw new Exception();
                    else
                    {
                        Success("accepted");
                        controllerObj.UpdateBranchesInContractWith();

                    }

                }
                catch
                {
                    SomethingWrongHappened();
                }
            }

            else if (requestType == 4)
            {
                try
                {
                    parameterToAProcedure requestIDPar = new parameterToAProcedure("@requestID", requestID);
                    parameterToAProcedure authorizerPar = new parameterToAProcedure("@authorizer", controllerObj.currID);
                    parameterToAProcedure branchIDPar = new parameterToAProcedure("@branchID", controllerObj.currBranchID);
                    parameterToAProcedure authorizerNamePar = new parameterToAProcedure("@authorizerName", controllerObj.currFirstname + " " + controllerObj.currLastname);

                    if (controllerObj.ExecuteNonStoredProcedure("AcceptBorrowBook", requestIDPar, authorizerPar, authorizerNamePar, branchIDPar) == 0)
                        throw new Exception();
                    else
                        Success("accepted");
                }
                catch
                {
                    SomethingWrongHappened();
                }
            }

            // For subscribtion requests.
            else if (requestType == 5)
            {
                try
                {

                    if (controllerObj.AcceptRefuseSubscribtionRequest(requestID, 1) == 0)
                        throw new Exception();
                    else
                        Success("accepted");

                } catch
                {
                    SomethingWrongHappened();
                }
            }

            // For event attendance requests.
            else if (requestType == 6)
            {
                try
                {
                    parameterToAProcedure requestIDPar = new parameterToAProcedure("@requestID", requestID);
                    parameterToAProcedure authorizerPar = new parameterToAProcedure("@authorizer", controllerObj.currID);
                    parameterToAProcedure branchIDPar = new parameterToAProcedure("@branchID", controllerObj.currBranchID);
                    parameterToAProcedure requesterIDPar = new parameterToAProcedure("@requesterID", senderID);

                    if (controllerObj.ExecuteNonStoredProcedure("AcceptEventAttendanceRequest", requestIDPar, authorizerPar, requesterIDPar, branchIDPar) == 0)
                        throw new Exception();
                    else
                        Success("accepted");
                }
                catch
                {
                    SomethingWrongHappened();
                }
            }
            // For events unattendace request. (ticket refund)
            else if (requestType == 7)
            {
                try
                {
                    parameterToAProcedure requestIDPar = new parameterToAProcedure("@requestID", requestID);
                    parameterToAProcedure authorizerPar = new parameterToAProcedure("@authorizer", controllerObj.currID);
                    parameterToAProcedure branchIDPar = new parameterToAProcedure("@branchID", controllerObj.currBranchID);
                    parameterToAProcedure requesterIDPar = new parameterToAProcedure("@requesterID", senderID);

                    if (controllerObj.ExecuteNonStoredProcedure("AcceptEventUnattendanceRequest", requestIDPar, authorizerPar, requesterIDPar, branchIDPar) == 0)
                        throw new Exception();
                    else
                        Success("accepted");
                }
                catch
                {
                    SomethingWrongHappened();
                }
            }

            else
            {
                try
                {
                    if (controllerObj.acceptRefuseRequest(requestID, 1) == 0)
                        throw new Exception();
                    else
                        Success("accepted");
                }
                catch
                {
                    SomethingWrongHappened();
                }
            }

            if (requestType != 1)
                ((MainForm)parent.Parent.Parent).UpdateRequestCount();
            return;
        }

        private void rejectRequest_click(object sender, EventArgs e)
        {

            // request status:
            // 0 -> pending
            // 1 -> accepted
            // 2 -> rejected.
            requestvalidation.ForeColor = Color.FromArgb(244, 67, 54);
            requestvalidation.Visible = false;

            // For events unattendace request. (ticket refund)
            if (requestType == 7)
            {
                try
                {
                    parameterToAProcedure requestIDPar = new parameterToAProcedure("@requestID", requestID);
                    parameterToAProcedure authorizerPar = new parameterToAProcedure("@authorizer", controllerObj.currID);
                    parameterToAProcedure requesterIDPar = new parameterToAProcedure("@requesterID", senderID);

                    if (controllerObj.ExecuteNonStoredProcedure("RejectEventUnattendanceRequest", requestIDPar, authorizerPar, requesterIDPar) == 0)
                        throw new Exception();
                    else
                        Success("accepted");
                }
                catch
                {
                    SomethingWrongHappened();
                }
            }


            // For event attendance requests.
            if (requestType == 6)
            {
                try
                {
                    parameterToAProcedure requestIDPar = new parameterToAProcedure("@requestID", requestID);
                    parameterToAProcedure authorizerPar = new parameterToAProcedure("@authorizer", controllerObj.currID);
                    parameterToAProcedure requesterIDPar = new parameterToAProcedure("@requesterID", senderID);

                    if (controllerObj.ExecuteNonStoredProcedure("RejectEventAttendanceRequest", requestIDPar, authorizerPar, requesterIDPar) == 0)
                        throw new Exception();
                    else
                        Success("rejected");
                }
                catch
                {
                    SomethingWrongHappened();
                }
            }

            // For subscribction requests.
            else if (requestType == 5)
            {
                try
                {
                    if (controllerObj.AcceptRefuseSubscribtionRequest(requestID, 2) == 0)
                        throw new Exception();
                    else
                        Success("rejected");
                } catch
                {
                    SomethingWrongHappened();
                }
            }
            // borrowing requests.
            
            else if (requestType == 4)
            {
                try
                {
                    parameterToAProcedure requestIDPar = new parameterToAProcedure("@requestID", requestID);
                    parameterToAProcedure authorizerPar = new parameterToAProcedure("@authorizer", controllerObj.currID);
                    parameterToAProcedure branchIDPar = new parameterToAProcedure("@branchID", controllerObj.currBranchID);
                    parameterToAProcedure authorizerNamePar = new parameterToAProcedure("@authorizerName", controllerObj.currFirstname + " " + controllerObj.currLastname) ;

                    if (controllerObj.ExecuteNonStoredProcedure("RejectBorrowBook", requestIDPar, authorizerPar, authorizerNamePar, branchIDPar) == 0)
                        throw new Exception();
                    else
                        Success("rejected");
                } catch
                {
                    SomethingWrongHappened();
                }
            }

            // For vending requests.
            else if (requestType == 0)
            {
                try
                {
                    parameterToAProcedure requestIDPar = new parameterToAProcedure("@requestID", requestID);
                    parameterToAProcedure vendorNamePar = new parameterToAProcedure("@vendorName", controllerObj.currVendorName.ToString());


                    if (controllerObj.ExecuteNonStoredProcedure("RejectVendingRequest", requestIDPar, vendorNamePar) == 0)
                        throw new Exception();
                    else
                        Success("rejected");

                }
                catch
                {
                    requestvalidation.Text = "Something wrong happened. Try again later.";
                    requestvalidation.Visible = true;
                }
            }

            else
            {
                try
                {
                    if (controllerObj.acceptRefuseRequest(requestID, 2) == 0)
                        throw new Exception();
                    else
                        Success("rejected");
                }
                catch
                {
                    SomethingWrongHappened();
                }

            }

            ((MainForm)parent.Parent.Parent).UpdateRequestCount();
            return;
        }

        private void acceptRefuseRequest_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.DimGray, 3), this.DisplayRectangle);

        }

        private void viewButton_Click(object sender, EventArgs e)
        {

            ((MainForm)parent.Parent.Parent).openChildForm(new ListBooksInRequest(ref controllerObj, senderName, branchOfRequestSender, send_date, requestID));
            this.Close();
        }

    }
}
