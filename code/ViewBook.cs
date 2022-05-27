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
    public partial class ViewBook : Form
    {
        Controller controllerObj;
        ListBooks parent;
        string ISBN;
        string title;
        int currNum;


        public ViewBook(ref Controller c, Dictionary<string, string> bookInfo, ref ListBooks p)
        {
            InitializeComponent();
            controllerObj = c;
            parent = p;
            ISBN = bookInfo["ISBN"];
            title = bookInfo["title"];

            if (controllerObj.employeeType != 4 && controllerObj.employeeType != 0)
                currNum = int.Parse(bookInfo["numberOfAvailableCopies"].ToString());

            if (controllerObj.employeeType > 2)
            {
                if (controllerObj.employeeType != 4)
                {
                    borrowRemoveBook.BackColor = Color.FromArgb(25, 118, 210);
                    if (int.Parse(bookInfo["numberOfAvailableCopies"]) == 0)
                        borrowRemoveBook.Text = "Request";
                    else
                        borrowRemoveBook.Text = "Borrow";
                }

            } else
            {
                borrowRemoveBook.BackColor = Color.FromArgb(244, 67, 54);
                borrowRemoveBook.Text = "Remove Book";
            }

            if (controllerObj.employeeType != 1 && controllerObj.employeeType != 2)
                updateButton.Visible = false;

            if (controllerObj.employeeType == 0 || controllerObj.employeeType == 4)
            {
                numLabel.Visible = false;
            }
            else
            {
                numLabel.Text += bookInfo["numberOfAvailableCopies"].ToString();
            }



            titleLabel.Text += bookInfo["title"];
            authorLabel.Text += bookInfo["authorName"];
            categoryLabel.Text += bookInfo["category"];
            languageLabel.Text += bookInfo["language"];
            publisherLabel.Text += bookInfo["publisherName"];
            publishedAtLabel.Text += bookInfo["publicationDate"];
            priceLabel.Text += bookInfo["price"];

        }

        private void ViewBook_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.DimGray, 3), this.DisplayRectangle);

        }

        private void cancelrequestact_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.ShowBooks();

        }

        private void borrowRemoveBook_Click(object sender, EventArgs e)
        {

            validationLabel.ForeColor = utilityfunctions.Globals.redColor;
            validationLabel.Visible = false;


            // If this click is on the borrow/request button by the reader.
            if (controllerObj.employeeType > 2)
            {
                if (borrowRemoveBook.Text == "Borrow")
                {

                    parameterToAProcedure bookISBNPar = new parameterToAProcedure("@bookISBN", ISBN);
                    parameterToAProcedure requesterIDPar = new parameterToAProcedure("@requesterID", controllerObj.currID);
                    parameterToAProcedure bookTitlePar = new parameterToAProcedure("@bookTitle", title);
                    parameterToAProcedure branchIDPar = new parameterToAProcedure("@branchID", controllerObj.currBranchID);

                    if (controllerObj.ExecuteNonStoredProcedure("RequestBookForBorrowing", bookISBNPar, requesterIDPar, bookTitlePar, branchIDPar) == 0)
                        throw new Exception();
                    else
                    {
                        validationLabel.Text = "Request for book borrowing sent Successfully!";
                        validationLabel.ForeColor = utilityfunctions.Globals.greenColor;
                        validationLabel.Visible = true;
                        borrowRemoveBook.Visible = false;
                    }

                }
                // In case it's requesting
                else
                {
                     try
                    {
                        parameterToAProcedure branchIDPar = new parameterToAProcedure("@branchID", controllerObj.currBranchID);
                        parameterToAProcedure bookISBNPar = new parameterToAProcedure("@bookISBN", ISBN);

                        if (controllerObj.ExecuteNonStoredProcedure("RequestBook", branchIDPar, bookISBNPar) == 0)
                            throw new Exception();
                        else
                        {
                            validationLabel.Text = "Book Requested Successfully!";
                            validationLabel.ForeColor = utilityfunctions.Globals.greenColor;
                            validationLabel.Visible = true;
                            borrowRemoveBook.Visible = false;
                        }


                    } catch
                    {
                        validationLabel.Text = "Something wrong happened. Try again later.";
                        validationLabel.ForeColor = utilityfunctions.Globals.redColor;
                        validationLabel.Visible = true;
                    }

                }



            } else
            {
                // If this click is the first click on the remove book button, change its text to confirm and return.
                if (borrowRemoveBook.Text == "Remove Book")
                {
                    borrowRemoveBook.Text = "Confirm";
                    return;
                } 
                // If this click is on the confirm button.
                else
                {
                    // If it's the owner, delete the book from the library.
                    if (controllerObj.employeeType == 0)
                    {
                        try
                        {
                            if (controllerObj.DeleteFromTable("Book", "ISBN", ISBN, true) == 0)
                                throw new Exception();
                            else
                            {
                                validationLabel.Text = "Book Removed From All Branches Successfully!";
                                validationLabel.ForeColor = utilityfunctions.Globals.greenColor;
                                validationLabel.Visible = true;
                                borrowRemoveBook.Visible = false;

                            }

                        } catch
                        {
                            validationLabel.Text = "Something wrong happened. Try again later.";
                            validationLabel.ForeColor = utilityfunctions.Globals.redColor;
                            validationLabel.Visible = true;
                        }
                    }

                    // If it's the librarian or the administrator, delete the book from the branch only.
                    else
                    {
                        try
                        {
                            if (controllerObj.DeleteBookFromBranch(ISBN) == 0)
                                throw new Exception();
                            else
                            {
                                validationLabel.Text = "Book Removed From This Branch Successfully!";
                                validationLabel.ForeColor = utilityfunctions.Globals.greenColor;
                                validationLabel.Visible = true;
                                borrowRemoveBook.Visible = false;
                            }

                        } catch
                        {
                            validationLabel.Text = "Something wrong happened. Try again later.";
                            validationLabel.ForeColor = utilityfunctions.Globals.redColor;
                            validationLabel.Visible = true;
                        }
                    }


                }


            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateNumberOfCopies newform = new UpdateNumberOfCopies(ref controllerObj, title, currNum, ISBN);
            newform.Show();
            this.Close();
        }
    }
}
