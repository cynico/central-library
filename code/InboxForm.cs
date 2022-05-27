using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using utilityfunctions;
using System.Globalization;
using System.Reflection;
using System.Windows;

namespace CentralLibrary
{



    public partial class InboxForm : Form
    {
        Controller controllerObj;
        Delegate openemailDelegate;
        int numSelected = 0;

        public InboxForm(ref Controller c)
        {
            InitializeComponent();
            controllerObj = c;


            filtercomboxbox.SelectedIndex = 2;
            listpanel.Parent = this;
            composeButton.Parent = this;
            composeButton.Location = new Point(530, 680);
            composeButton.BringToFront();
            showemails(2);
        }
        

        private void openEmail(object sender, EventArgs e, DataRow row, string send_date)
        {
            // this refers to the inboxform.
            ((MainForm)this.Parent.Parent).openChildForm(new ShowEmailContent(ref controllerObj, row["esubject"].ToString(), row["etext"].ToString(), row["email"].ToString(), row["pfirstname"].ToString() + " " + row["plastname"].ToString(), send_date, int.Parse(row["etype"].ToString())));
            return;
        }

        // Type values
        // 0 for sender
        // 1 for receiver
        // 2 for ALL
        private void showemails(int type)
        {

            validationtextbox.Visible = false;
            Application.UseWaitCursor = true;

            parameterToAProcedure x = new parameterToAProcedure();
            x.name = "@ID";
            x.value = controllerObj.currID;

            DataTable dt = controllerObj.GetStoredProcedure("SelectAllEmails", x);


            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {

                    if (int.Parse(row["etype"].ToString()) == type || type == 2)
                    {

                        CPanel emailpanel = new CPanel();
                        emailpanel.Dock = DockStyle.Top;
                        emailpanel.Size = new System.Drawing.Size(640, 113);
                        emailpanel.BackColor = Color.Transparent;
                        emailpanel.db_id = row["ID"].ToString();
                        emailpanel.Cursor = Cursors.Hand;

                        // Name initials
                        CircularButton nameInit = new CircularButton();
                        nameInit.Size = new System.Drawing.Size(55, 55);
                        nameInit.BackColor = Color.FromArgb(25, 118, 210);
                        nameInit.Parent = emailpanel;
                        nameInit.Location = new Point(12, 12);
                        nameInit.FlatStyle = FlatStyle.Flat;
                        
                        nameInit.FlatAppearance.MouseDownBackColor = Color.FromArgb(25, 118, 210);
                        nameInit.FlatAppearance.MouseDownBackColor = Color.FromArgb(25, 118, 210);
                        nameInit.FlatAppearance.BorderSize = 0;

                        nameInit.ForeColor = Color.White;
                        nameInit.Font = new Font("Century Gothic", float.Parse("9.75"), System.Drawing.FontStyle.Regular);

                        if (row["pfirstname"] == DBNull.Value)
                            nameInit.Text = row["vname"].ToString().Substring(0, 1); 
                        else
                            nameInit.Text = row["pfirstname"].ToString().Substring(0, 1) + row["plastname"].ToString().Substring(0, 1);


                        nameInit.MouseClick += (sender, e) =>
                        {

                            if (!((CPanel)nameInit.Parent).selected)
                            {
                                ((CPanel)nameInit.Parent).BackColor = Color.LightGray;
                                ((CPanel)nameInit.Parent).selected = true;
                                numSelected++;
                            }
                            else
                            {
                                ((CPanel)nameInit.Parent).BackColor = Color.Transparent;
                                ((CPanel)nameInit.Parent).selected = false;
                                numSelected--;
                            }

                            if (numSelected == 0)
                            {
                                cancelbutton.PerformClick();
                            } else
                            {
                                cancelbutton.Visible = true;
                                selectallbutton.Visible = true;
                            }
                           

                          
                        };


                        // Creating name label.
                        Label name = new Label();

                        if (int.Parse(row["etype"].ToString()) == 0)
                        {
                            name.Text = "YOU";
                        }
                        else
                        {
                            name.Text = row["pfirstname"].ToString() + " " + row["plastname"].ToString();
                        }

                        emailpanel.type = int.Parse(row["etype"].ToString());


                        name.Font = new Font("Century Gothic", float.Parse("9.75"), System.Drawing.FontStyle.Regular);
                        name.ForeColor = Color.DimGray;
                        name.Parent = emailpanel;
                        name.Location = new Point(73, 12);


                        

                        // Subject Label
                        Label subject = new Label();
                        subject.Text = row["esubject"].ToString();
                        subject.Font = new Font("Century Gothic", float.Parse("14.25"), System.Drawing.FontStyle.Bold);
                        subject.ForeColor = Color.FromArgb(75, 75, 75);
                        subject.Parent = emailpanel;
                        subject.Location = new Point(74, 29);

                        // Main body of email.
                        Label text = new Label();
                        text.Text = row["etext"].ToString();
                        text.Font = new Font("Century Gothic", float.Parse("11.25"), System.Drawing.FontStyle.Regular);
                        text.ForeColor = SystemColors.ControlDarkDark;
                        text.Parent = emailpanel;
                        text.Location = new Point(74, 52);
                        text.AutoSize = false;
                        text.Size = new System.Drawing.Size(549, 43);

                        // Date label
                        Label date = new Label();
                        DateTime send_date = DateTime.Parse(row["send_date"].ToString());

                        if (send_date.Year != DateTime.Now.Year) {

                            date.Text = send_date.Day + " " + send_date.Month.ToString("MMMM") + " " + send_date.Year;

                        } else if (send_date.Day != DateTime.Now.Day)
                        {
                            date.Text = send_date.Day + " " + CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(send_date.Month).Substring(0, 3);
                        } else
                        {
                            date.Text = send_date.Hour + ":" + send_date.Minute;
                        }
                       

                        date.Font = new Font("Century Gothic", float.Parse("8.25"), System.Drawing.FontStyle.Regular);
                        date.ForeColor = Color.DimGray;
                        date.Parent = emailpanel;
                        date.Location = new Point(548, 13);

                        emailpanel.Parent = listpanel;


                        openemailDelegate = new MouseEventHandler((sender, e) => openEmail(sender, e, row, date.Text));
                        emailpanel.MouseClick += (MouseEventHandler)openemailDelegate;



                        //emailpanel.MouseEnter += (sender, e) =>
                        //{
                        //    emailpanel.BackColor = Color.DimGray;
                        //};
                        //emailpanel.MouseHover += (sender, e) =>
                        //{
                        //    emailpanel.BackColor = Color.DimGray;
                        //};
                        //emailpanel.MouseLeave += (sender, e) =>
                        //{
                        //    emailpanel.BackColor = Color.White;
                        //};
                    }
                    else
                        continue;
                }


            }
            Panel controlPanel = new Panel();
            controlPanel.Dock = DockStyle.Top;
            controlPanel.Size = new System.Drawing.Size(640, 113);

            Application.UseWaitCursor = false;
        }

        private void filterbutton_Click(object sender, EventArgs e)
        {
            // 0 for Sent, 1 for received, 2 for all.
            int choice = filtercomboxbox.SelectedIndex;
            if (choice == 2)
                foreach (CPanel PanelToHide in listpanel.Controls)
                    PanelToHide.Visible = true;
            else
            {
                foreach(CPanel PanelToHide in listpanel.Controls)
                {
                    if (PanelToHide.type != choice)
                        PanelToHide.Visible = false;
                    else
                        PanelToHide.Visible = true;
                }
            }

        }

        private void deletebutton_Click(object sender, EventArgs e)
        {

            validationtextbox.Visible = false;
            if (numSelected == 0)
                return;

            DataTable DtOfIds = new DataTable();
            DtOfIds.Columns.Add(new DataColumn("ID", typeof(int)));
            DtOfIds.Columns.Add(new DataColumn("partyType", typeof(int)));
            List<CPanel> PanelsToRemove = new List<CPanel>();
                
            foreach (CPanel panel in listpanel.Controls)
            {
                if (panel.selected)
                {
                    DataRow row = DtOfIds.NewRow();
                    row["ID"] = panel.db_id;
                    row["partyType"] = panel.type;
                    DtOfIds.Rows.Add(row);
                  
                    PanelsToRemove.Add(panel);
                }
            }

            parameterToAProcedure DtOfIdsPar = new parameterToAProcedure("@List", DtOfIds);


            try
            {
                controllerObj.ExecuteNonStoredProcedure("DeleteEmails", DtOfIdsPar);
                foreach(CPanel PanelToRemove in PanelsToRemove)
                {
                    PanelToRemove.Dispose();
                    listpanel.Controls.Remove(PanelToRemove);
                }
                GC.Collect();
                cancelbutton.PerformClick();
            } catch
            {
                cancelbutton.PerformClick();
            }
            return;
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            validationtextbox.Visible = false;
            cancelbutton.Visible = false;
            selectallbutton.Visible = false;
            numSelected = 0;

            foreach (CPanel panel in listpanel.Controls)
            {
                panel.selected = false;
                panel.BackColor = Color.Transparent;
            }
        }

        private void selectallbutton_Click(object sender, EventArgs e)
        {
            foreach (CPanel panel in listpanel.Controls)
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

        private void composeButton_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).openChildForm(new ComposeEmail(ref controllerObj)); ;
            return;
        }
    }
}
