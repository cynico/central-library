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
    public partial class Notifications : Form
    {
        Controller controllerObj;
        int numSelected;
        public Notifications(ref Controller c)
        {
            InitializeComponent();
            controllerObj = c;
            numSelected = 0;

            ShowNotifications();
        }

        private void ShowNotifications()
        {
            DataTable notificationsDt = controllerObj.GetNotifications();
            if (notificationsDt != null)
            {
                foreach (DataRow row in notificationsDt.Rows)
                {

                    CPanel notificationPanel = new CPanel();
                    notificationPanel.Dock = DockStyle.Top;
                    notificationPanel.Size = new System.Drawing.Size(640, 113);
                    notificationPanel.BackColor = Color.Transparent;
                    notificationPanel.db_id = row["ID"].ToString();
                    notificationPanel.Cursor = Cursors.Hand;


                    CircularButton nCircle = new CircularButton();
                    nCircle.Size = new System.Drawing.Size(55, 55);
                    nCircle.BackColor = Color.FromArgb(25, 118, 210);
                    nCircle.Parent = notificationPanel;
                    nCircle.Location = new Point(12, 12);
                    nCircle.FlatStyle = FlatStyle.Flat;

                    nCircle.FlatAppearance.MouseDownBackColor = Color.FromArgb(25, 118, 210);
                    nCircle.FlatAppearance.MouseDownBackColor = Color.FromArgb(25, 118, 210);
                    nCircle.FlatAppearance.BorderSize = 0;

                    nCircle.ForeColor = Color.White;
                    nCircle.Font = new Font("Century Gothic", float.Parse("9.75"), System.Drawing.FontStyle.Regular);

                    nCircle.Text = "N";

                    nCircle.MouseClick += (sender, e) =>
                    {

                        if (!((CPanel)nCircle.Parent).selected)
                        {
                            ((CPanel)nCircle.Parent).BackColor = Color.LightGray;
                            ((CPanel)nCircle.Parent).selected = true;
                            numSelected++;
                        }
                        else
                        {
                            ((CPanel)nCircle.Parent).BackColor = Color.Transparent;
                            ((CPanel)nCircle.Parent).selected = false;
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

                    // Title Label.
                    Label title = new Label();
                    title.Text = row["title"].ToString();
                    title.Font = new Font("Century Gothic", float.Parse("14.25"), FontStyle.Bold);
                    title.ForeColor = Color.FromArgb(75, 75, 75);
                    title.Parent = notificationPanel;
                    title.AutoSize = true;
                    title.Location = new Point(74, 13);

                    // Main body of request.
                    Label text = new Label();
                    text.Text = row["content"].ToString().Split('.')[0] + ".";
                    text.Font = new Font("Century Gothic", float.Parse("11.25"), FontStyle.Regular);
                    text.ForeColor = SystemColors.ControlDarkDark;
                    text.Parent = notificationPanel;
                    text.Location = new Point(74, 52);
                    text.AutoSize = false;
                    text.Size = new System.Drawing.Size(549, 43);


                    // sent_date label
                    Label date = new Label();
                    DateTime meeting_date = DateTime.Parse(row["ntimestamp"].ToString());
                    date.Text = meeting_date.ToString("dd MMM yyyy HH:mm");
                    date.Font = new Font("Century Gothic", float.Parse("8.25"), FontStyle.Regular);
                    date.ForeColor = Color.DimGray;
                    date.Parent = notificationPanel;
                    date.Location = new Point(548, 13);
                    date.AutoSize = true;
                    date.MaximumSize = new System.Drawing.Size(85, 0);

                    notificationPanel.Parent = notificationsListPanel;


                }

                return;
            }
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            cancelbutton.Visible = false;
            selectallbutton.Visible = false;
            numSelected = 0;

            foreach (CPanel panel in notificationsListPanel.Controls)
            {
                panel.selected = false;
                panel.BackColor = Color.Transparent;
            }
        }

        private void selectallbutton_Click(object sender, EventArgs e)
        {
            foreach (CPanel panel in notificationsListPanel.Controls)
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

        private void markAsSeenButton_Click(object sender, EventArgs e)
        {
            if (numSelected == 0)
                return;

            DataTable DtOfIds = new DataTable();
            DtOfIds.Columns.Add("ID", typeof(int));

            List<CPanel> PanelsToRemove = new List<CPanel>();

            foreach (CPanel notifcationPanel in notificationsListPanel.Controls)
            {

                if (notifcationPanel.selected)
                {
                    DataRow row = DtOfIds.NewRow();
                    row["ID"] = notifcationPanel.db_id;
                    DtOfIds.Rows.Add(row);
                    PanelsToRemove.Add(notifcationPanel);
                }
            }

            try
            {

                parameterToAProcedure notificationIDsPar = new parameterToAProcedure("@List", DtOfIds);
                if (controllerObj.ExecuteNonStoredProcedure("MarkAsSeen", notificationIDsPar) == 0)
                    throw new Exception();

                foreach (CPanel PanelToRemove in PanelsToRemove)
                {
                    PanelToRemove.Dispose();
                    notificationsListPanel.Controls.Remove(PanelToRemove);
                }

                GC.Collect();
                cancelbutton.PerformClick();
                
                ((MainForm)this.Parent.Parent).UpdateNotificationsCount();

            }
            catch
            {
                cancelbutton.PerformClick();
            }
            return;
        }

    }
}
