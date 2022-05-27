using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CentralLibrary
{
    public partial class MainForm : Form
    {
        Controller controllerObj;
        public Form activeForm = null;
        public MainForm(ref Controller c)
        {
            controllerObj = c;
            InitializeComponent();
            customizeDesign();

        }

        public void CustomizeFormAccordingToUserType()
        {
            if (controllerObj.employeeType == 4)
            {
                vendorbutton.Visible = false;
                businessbutton.Visible = false;
                librariansbutton.Visible = false;
                administratorsbutton.Visible = false;
                registeredusersbutton.Visible = false;
                librarypanel.Height = 92;

                employeesbutton.Text = "Administrators";
                employeespanel.Height = 0;
                this.employeesbutton.Click -= new System.EventHandler(this.employeesbutton_Click);
                this.employeesbutton.Click += new System.EventHandler(this.administratorsbutton_Click);
            }
            else if (controllerObj.employeeType == 2)
            {
                businessmeetingbutton.Visible = false;
                businessbutton.Visible = false;
            }
            else if (controllerObj.employeeType == 3)
            {
                businessbutton.Visible = false;


                registeredusersbutton.Visible = false;
                librarypanel.Height = 92;
                requestsbutton.Visible = false;
                
                vendorbutton.Visible = false;
                employeespanel.Height = 92;
                employeesbutton.Text = "Staff";


            }
            return;
        }

        public void UpdateNotificationsCount()
        {
            controllerObj.UpdateNumberOfNotificationsOrRequests("notifications", "seen");
            if (controllerObj.numberOfUnreadNotifications == 0)
            {
                notificationsbutton.Text = "Notifications";
                notificationsbutton.BackColor = Color.FromArgb(25, 118, 210);
            }
            else
            {
                notificationsbutton.Text = String.Format("Notifications ({0})", controllerObj.numberOfUnreadNotifications);
                notificationsbutton.BackColor = Color.DimGray;
            }
            return;
        }
        public void UpdateRequestCount()
        {
            controllerObj.UpdateNumberOfNotificationsOrRequests("Request", "rstatus");
            if (controllerObj.numberOfPendingRequests == 0)
            {
                requestsbutton.Text = "Requests";
                requestsbutton.BackColor = Color.FromArgb(25, 118, 210);
            }
            else
            {
                requestsbutton.Text = String.Format("Requests ({0})", controllerObj.numberOfPendingRequests);
                requestsbutton.BackColor = Color.DimGray;
            }
            return;
        }
        private void customizeDesign()
        {
            accountpanel.Visible = false;
            employeespanel.Visible = false;
            businesspanel.Visible = false;
            librarypanel.Visible = false;

        }
        private void hideSubMenu()
        {
            if (accountpanel.Visible == true)
                accountpanel.Visible = false;
            if (employeespanel.Visible == true)
                employeespanel.Visible = false;
            if (businesspanel.Visible == true)
                businesspanel.Visible = false;
            librarypanel.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            } else
            {
                subMenu.Visible = false;
            }
        }
        
        // Account panel.
        private void accountbutton_Click(object sender, EventArgs e)
        {
            showSubMenu(accountpanel);
        }
        private void profilebutton_Click(object sender, EventArgs e)
        {
            // Open form for profile
            if (activeForm != null)
                activeForm.Close();
            hideSubMenu();
            openChildForm(new ProfileForm(ref controllerObj));
        }
        private void accountsettingsbutton_Click(object sender, EventArgs e)
        {
            // Open form for account settings.
            if (activeForm != null)
                activeForm.Close();
            hideSubMenu();
            openChildForm(new AccountForm(ref controllerObj));
        }
        private void button4_Click(object sender, EventArgs e)
        {
            // Open form for inbox
            if (activeForm != null)
                activeForm.Close();
            hideSubMenu();
            openChildForm(new InboxForm(ref controllerObj));
        }


        // Employees panel.
        private void employeesbutton_Click(object sender, EventArgs e)
        {
            showSubMenu(employeespanel);
        }
        private void administratorsbutton_Click(object sender, EventArgs e)
        {
            // Open form for administrators
            if (activeForm != null)
                activeForm.Close();
            hideSubMenu();
            openChildForm(new ListAdmins(ref controllerObj));
        }
        private void librariansbutton_Click(object sender, EventArgs e)
        {
            // Open form for librarians.
            if (activeForm != null)
                activeForm.Close();
            hideSubMenu();
            openChildForm(new ListLibrarians(ref controllerObj));
        }
        private void vendorbutton_Click(object sender, EventArgs e)
        {
            // Open for for showing vendors.
              if (activeForm != null)
                activeForm.Close();
            hideSubMenu();
            openChildForm(new ListVendors(ref controllerObj));
        }
        
        // Business panel.
        private void businessbutton_Click(object sender, EventArgs e)
        {
            showSubMenu(businesspanel);
        }
        private void button12_Click(object sender, EventArgs e)
        {
            // Open form for finance records
            hideSubMenu();
        }
        private void businessmeetingbutton_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            hideSubMenu();
            openChildForm(new ListMeetings(ref controllerObj));
        }
        private void eventsbutton_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            hideSubMenu();
            openChildForm(new ListEvents(ref controllerObj));
        }


        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childformpanel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void aboutcentrallibrarybutton_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            hideSubMenu();
            openChildForm(new AboutLibrary(ref controllerObj));
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            logout();
        }


        public void logout()
        {
            SignIn signin = new SignIn(ref controllerObj);
            controllerObj.ResetCurrentInfo();
            this.Hide();
            signin.ShowDialog();
            this.Close();
        }

        private void requestsbutton_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            hideSubMenu();
            openChildForm(new ListRequests(ref controllerObj));
        }

        private void notificationsbutton_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            hideSubMenu();
            openChildForm(new Notifications(ref controllerObj));
        }

        private void libraryButton_Click(object sender, EventArgs e)
        {
            showSubMenu(librarypanel);
        }

        private void booksButton_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            hideSubMenu();
            openChildForm(new ListBooks(ref controllerObj));
        }

        private void eventsButon_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            hideSubMenu();
            openChildForm(new ListEvents(ref controllerObj));
        }

        private void registeredusersbutton_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            hideSubMenu();
            openChildForm(new ListUsers(ref controllerObj));
        }

        private void gameButton_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\newdbox\DOSBox-0.74-3\DOSBox.exe");
        }
    }
}
