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
    public partial class VendorAddChoice : Form
    {

        Controller controllerObj;
        ListVendors parent;
        public VendorAddChoice(ref Controller c, ref ListVendors v)
        {
            InitializeComponent();
            controllerObj = c;
            parent = v;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VendorAddChoice_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.DimGray, 3), this.DisplayRectangle);
        }

        private void addnewVendor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ((MainForm)parent.Parent.Parent).openChildForm(new AddVendor(ref controllerObj));
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ((MainForm)parent.Parent.Parent).openChildForm(new ListVendors(ref controllerObj, true));
            this.Close();
        }
    }
}
