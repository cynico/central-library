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
    public partial class RaiseForm : Form
    {
        Controller controllerObj;
        string employeeName;
        string employeeID;
        double employeeSalary;
        string employeePosition;
        bool doubleConfirmation = false;
        Label nameLabel;
        Label salaryLabel;

        public RaiseForm(ref Controller c, string name, double salary, string ID, string position)
        {
            InitializeComponent();
            controllerObj = c;
            employeeName = name;
            employeeID = ID;
            employeeSalary = salary;
            employeePosition = position;
            ShowInfo();
        }


        private void ShowInfo()
        {
            nameLabel = new Label();
            nameLabel.Font = new Font("Century Gothic", float.Parse("9.75"), System.Drawing.FontStyle.Regular);
            nameLabel.ForeColor = Color.DimGray;
            nameLabel.Location = new Point(11, 73);
            nameLabel.Text = String.Format("{0}: {1}", employeePosition ,employeeName);
            nameLabel.AutoSize = true;
            nameLabel.Parent = this;

            salaryLabel = new Label();
            salaryLabel.Font = new Font("Century Gothic", float.Parse("9.75"), System.Drawing.FontStyle.Regular);
            salaryLabel.ForeColor = Color.DimGray;
            salaryLabel.Location = new Point(11, 101);
            salaryLabel.Text = "Salary: " + employeeSalary;
            salaryLabel.AutoSize = true;
            salaryLabel.Parent = this;
        }
        private void raiseForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.DimGray, 3), this.DisplayRectangle);
        }

        private void cancelRaise_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void raiseFromRaiseButton_Click(object sender, EventArgs e)
        {



            raiseValidationLabel.ForeColor = Color.FromArgb(244, 67, 54);
            raiseValidationLabel.Visible = false;

            if (doubleConfirmation)
            {
                try
                {
                    controllerObj.UpdateSalary(double.Parse(newSalaryTb.Text.ToString()), employeeID);
                    raiseValidationLabel.ForeColor = Color.FromArgb(0, 200, 83);
                    raiseValidationLabel.Text = "Raise applied successfully!";
                    raiseValidationLabel.Visible = true;
                    doubleConfirmation = false;
                    newSalaryTb.Text = "";
                    raisePasswordConfirmation.Text = "";
                }
                catch
                {
                    raiseValidationLabel.Text = "Something wrong happened updating the salary. Try again later.";
                    raiseValidationLabel.Visible = true;
                }

                // Getting update salary and showing it.
                double UpdatedSalary = controllerObj.GetSalary(employeeID);
                salaryLabel.Text = "Salary: " + UpdatedSalary;

                return;
            }

            if (!double.TryParse(newSalaryTb.Text.ToString(), out double newSalary))
            {
                raiseValidationLabel.Text = "Enter valid value for salary.";
                raiseValidationLabel.Visible = true;
                return;

            } else
            {
                if (String.IsNullOrEmpty(raisePasswordConfirmation.Text))
                {
                    raiseValidationLabel.Text = "Enter password for confirmation.";
                    raiseValidationLabel.Visible = true;
                } else if (!controllerObj.verifyPassword(raisePasswordConfirmation.Text))
                {
                    raiseValidationLabel.Text = "Wrong Password.";
                    raiseValidationLabel.Visible = true;
                } else
                {
                    if (newSalary < employeeSalary)
                    {
                        raiseValidationLabel.Text = "Are you sure you want to decrease the salary? Press Raise button again for confirmation.";
                        raiseValidationLabel.Visible = true;
                        doubleConfirmation = true;
                    } else
                    {
                        try
                        {
                            controllerObj.UpdateSalary(newSalary, employeeID);
                            raiseValidationLabel.ForeColor = Color.FromArgb(0, 200, 83);
                            raiseValidationLabel.Text = "Raise applied successfully!";
                            raiseValidationLabel.Visible = true;
                            newSalaryTb.Text = "";
                            raisePasswordConfirmation.Text = "";
                        } catch
                        {
                            raiseValidationLabel.Text = "Something wrong happened updating the salary. Try again later.";
                            raiseValidationLabel.Visible = true;
                        }
                        // Getting updated salary and showing it
                        double UpdatedSalary = controllerObj.GetSalary(employeeID);
                        salaryLabel.Text = "Salary: " + UpdatedSalary;

                    }
                }
            }
        }
    }
}
