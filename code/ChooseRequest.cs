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
    public partial class ChooseRequest : Form
    {

        Controller controllerObj;
        ListRequests parent;
        public ChooseRequest(ref Controller c, ref ListRequests r)
        {
            InitializeComponent();
            controllerObj = c;
            parent = r;

            if (controllerObj.employeeType != 0)
                requestType.Items.Add("Vending");

        }

        private void cancelrequesttype_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chooseRequest_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.DimGray, 3), this.DisplayRectangle);

        }

        private void chooserequesttype_Click(object sender, EventArgs e)
        {
            if (requestType.SelectedItem == null)
                return;
            
            else if (requestType.SelectedItem.ToString() == "Vending")
            {
                ((MainForm)parent.Parent.Parent).openChildForm(new VendingRequest(ref controllerObj));
                this.Close();
            } 

            else if (requestType.SelectedItem.ToString() == "Business Meeting")
            {
                // If it's the owner.
                if (controllerObj.employeeType == 0)
                    ((MainForm)parent.Parent.Parent).openChildForm(new CreateBusinessMeeting(ref controllerObj, false));
                else
                {
                    AdminRequestMeeting newform = new AdminRequestMeeting(ref controllerObj);
                    newform.Show();
                    this.Close();
                }
            }
        }
    }
}
