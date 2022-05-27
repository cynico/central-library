using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using utilityfunctions;

namespace CentralLibrary
{
    public partial class AddBook : Form
    {
        Controller controllerObj;
        OpenFileDialog open;

        List<string> authorsNames;
        List<int> authorIDs;
        
        List<string> categories;
        
        List<string> PublisherNames;
        List<int> PublisherIDs;

        public AddBook(ref Controller c)
        {
            InitializeComponent();

            controllerObj = c;


            if (controllerObj.employeeType == 0)
            {
                numberlabel.Visible = false;
                availableCopiesNumeric.Visible = false;
            }

            DataTable authorDt = controllerObj.SelectAll("Author");
            DataTable categoriesDt = controllerObj.SelectAll("Category");
            DataTable PublisherDt = controllerObj.SelectAll("Publisher");

            if (categoriesDt != null)
            {
                categories = new List<string>();
                foreach (DataRow row in categoriesDt.Rows)
                {
                    categories.Add(row["cname"].ToString());
                }
            }
            if (authorDt != null)
            {
                authorsNames = new List<string>();
                authorIDs = new List<int>();

                foreach (DataRow row in authorDt.Rows)
                {
                    authorsNames.Add(row["aname"].ToString());
                    authorIDs.Add(int.Parse(row["ID"].ToString()));
                }
            }
            if (PublisherDt != null)
            {
                PublisherNames = new List<string>();
                PublisherIDs = new List<int>();

                foreach (DataRow row in PublisherDt.Rows)
                {
                    PublisherNames.Add(row["pubname"].ToString());
                    PublisherIDs.Add(int.Parse(row["ID"].ToString()));
                }
            }

            categoryComboBox.DataSource = categories;
            authorComboBox.DataSource = authorsNames;
            publisherComboBox.DataSource = PublisherNames;

            categoryComboBox.SelectedItem = "All";


        }

        private void linkToSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ((MainForm)this.Parent.Parent).openChildForm(new AddAuthor(ref controllerObj));
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            validationLabel.ForeColor = utilityfunctions.Globals.redColor;
            validationLabel.Visible = false;

            var ISBNregex = new Regex("^[0-9]*$");


            validationLabel.Visible = false;
            if (String.IsNullOrEmpty(bookTitle.Text) || String.IsNullOrEmpty(ISBNtb.Text) ||
                categoryComboBox.SelectedItem == null ||
                authorComboBox.SelectedItem == null ||
                publisherComboBox.SelectedItem == null ||
                languageComboBox.SelectedItem == null ||
                pricenumeric.Value == 0 ||
                pubdate.Value.Date > DateTime.Today ||
                confirmationPassword.Text == "" ||
                !ISBNregex.IsMatch(ISBNtb.Text) ||
                ISBNtb.Text.Length < 10 ||
                bookTitle.Text.Length < 5
                )
            {
                validationLabel.Text = "Please, fill all fields with valid info.";
                validationLabel.Visible = true;

            }
            else if (!controllerObj.verifyPassword(confirmationPassword.Text))
            {
                validationLabel.Text = "Wrong Password.";
                validationLabel.Visible = true;
            }
            else if (controllerObj.CheckIfXIsUsed("Book", "ISBN", ISBNtb.Text) != 0)
            {
                validationLabel.Text = "A book already exists with this ISBN.";
                validationLabel.Visible = true;
            }
            else
            {
                try
                {

                    string newImageName;

                    if (open == null)
                        newImageName = "Book.jpg";

                    else if (open.FileName == null || open.FileName == "")
                        newImageName = "Book.jpg";

                    else
                    {
                        newImageName = String.Join("", Process.GetCurrentProcess().Id + controllerObj.currID, Path.GetRandomFileName(), DateTime.Now.Subtract(new DateTime(1970, 1, 1)).TotalSeconds, '.', open.FileName.Split('.')[open.FileName.Split('.').Length - 1]);
                        string path = Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).ToString()).ToString()).ToString();
                        path += String.Format("\\Images\\Books\\{0}", newImageName);


                        File.Copy(open.FileName, path);
                    }

                    parameterToAProcedure titlePar = new parameterToAProcedure("@title", bookTitle.Text);
                    parameterToAProcedure booksISBNPar = new parameterToAProcedure("@bookISBN", ISBNtb.Text);
                    parameterToAProcedure authorIDPar = new parameterToAProcedure("@authorID", authorIDs[authorComboBox.SelectedIndex]);
                    parameterToAProcedure pubIDPar = new parameterToAProcedure("@pubID", PublisherIDs[publisherComboBox.SelectedIndex]);
                    parameterToAProcedure languagePar = new parameterToAProcedure("@language", languageComboBox.SelectedItem.ToString());
                    parameterToAProcedure categoryPar = new parameterToAProcedure("@category", categoryComboBox.SelectedItem.ToString());
                    parameterToAProcedure imgPar = new parameterToAProcedure("@img", newImageName);
                    parameterToAProcedure pricePar = new parameterToAProcedure("@price", pricenumeric.Value);
                    parameterToAProcedure publicationDatePar = new parameterToAProcedure("@publicationDate", pubdate.Value.Date);

                    parameterToAProcedure branchIDPar = new parameterToAProcedure();
                    branchIDPar.name = "@branchID";


                    if (controllerObj.employeeType == 0)
                        branchIDPar.value = -1;
                    else
                        branchIDPar.value = controllerObj.currBranchID;

                    parameterToAProcedure numberOfAvailableCopiesPar = new parameterToAProcedure("@numberOfAvailableCopies", availableCopiesNumeric.Value);

                    if (controllerObj.ExecuteNonStoredProcedure("AddBook", numberOfAvailableCopiesPar, titlePar, booksISBNPar, authorIDPar, pubIDPar, languagePar, categoryPar, imgPar, publicationDatePar, branchIDPar, pricePar) == 0)
                        throw new Exception();
                    else
                    {
                        validationLabel.Text = "Book Added Successfully!";
                        validationLabel.ForeColor = utilityfunctions.Globals.greenColor;
                        validationLabel.Visible = true;
                        addButton.Visible = false;
                    }
                }
                catch
                {
                    validationLabel.Text = "Something wrong happened. Try again later.";
                    validationLabel.ForeColor = utilityfunctions.Globals.redColor;
                    validationLabel.Visible = true;
                }
            }
            
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).openChildForm(new ListBooks(ref controllerObj));
        }

        private void changepicture_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ((MainForm)this.Parent.Parent).openChildForm(new AddPublisher(ref controllerObj));

        }
    }
}
