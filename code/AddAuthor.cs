using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace CentralLibrary
{
    public partial class AddAuthor : Form
    {
        Controller controllerObj;
        OpenFileDialog open;

        public AddAuthor(ref Controller c)
        {
            controllerObj = c;
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).openChildForm(new AddBook(ref controllerObj));
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            validationLabel.Visible = false;
            validationLabel.ForeColor = utilityfunctions.Globals.redColor;

            var nameregex = new Regex("^[a-zA-Z. ']*$");


            if (authorNameTb.Text == "")
            {
                validationLabel.Text = "Make sure all fields are filled.";
                validationLabel.Visible = true;
            }
            else if (!nameregex.IsMatch(authorNameTb.Text))
            {
                validationLabel.Text = "Names should only contain alphabetical characters, apostrophes, and dots.";
                validationLabel.Visible = true;
            }
            else if (confirmationPassword.Text == "")
            {
                validationLabel.Text = "Enter your password for confirmation.";
                validationLabel.Visible = true;


            } else if (!controllerObj.verifyPassword(confirmationPassword.Text))
            {
                validationLabel.Text = "Wrong Password.";
                validationLabel.Visible = true;
            } else
            {
                try
                {
                    string imageName;
                    if (open == null)
                        imageName = "nopicture.jpg";
                    else if (open.FileName == "" || open.FileName == null)
                        imageName = "nopicture.jpg";
                    else
                    {
                        imageName = String.Join("", Process.GetCurrentProcess().Id + controllerObj.currID, Path.GetRandomFileName(), DateTime.Now.Subtract(new DateTime(1970, 1, 1)).TotalSeconds, '.', open.FileName.Split('.')[open.FileName.Split('.').Length - 1]);
                        string path = Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).ToString()).ToString()).ToString();
                        path += String.Format("\\Images\\Person\\{0}", imageName);

                        File.Copy(open.FileName, path);
                    }


                    if (controllerObj.AddAuthor(authorNameTb.Text, imageName) == 0)
                        throw new Exception();
                    else
                    {
                        validationLabel.Text = "Author Added Successfully!";
                        validationLabel.ForeColor = utilityfunctions.Globals.greenColor;
                        validationLabel.Visible = true;
                        addButton.Visible = false;
                    }


                } catch
                {
                    validationLabel.Text = "Wrong Password.";
                    validationLabel.Visible = true;
                }
            }
        }

        private void changepicture_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
            }


        }
    }
}
