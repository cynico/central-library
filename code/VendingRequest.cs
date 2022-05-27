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
    public partial class VendingRequest : Form
    {
        Controller controllerObj;
        int numOfBooks = 2;
        List<string> vendorIDs;
        List<string> Books;
        List<string> ISBNS;


        public VendingRequest(ref Controller c)
        {
            InitializeComponent();
            controllerObj = c;




            // Don't give the option of making a vending request for a specific branch to anyone except to the owner.
            // Each administrator would be able to request for their branch ONLY.
            if (controllerObj.employeeType != 0)
            {
                branchcombobox.Visible = false;
                branchlabel.Visible = false;
            }
            else
                branchcombobox.DataSource = controllerObj.branchNames;

            DataTable vendors = controllerObj.GetVendors(false);
            List<string> vendorsNames = new List<string>();
            vendorIDs = new List<string>();
            if (vendors != null)
            {
                foreach(DataRow row in vendors.Rows)
                {
                    vendorsNames.Add(row["vname"].ToString());
                    vendorIDs.Add(row["ID"].ToString());
                }
            }

            vendorcombobox.DataSource = vendorsNames;

            Books = new List<string>();
            ISBNS = new List<string>();

            DataTable booksDt = controllerObj.SelectAll("Book JOIN Author ON (Book.AuthorID = Author.ID)");
            if (booksDt != null)
            {
                foreach(DataRow row in booksDt.Rows)
                {
                    Books.Add(row["title"].ToString() + ", By: " + row["aname"].ToString());
                    ISBNS.Add(row["ISBN"].ToString());
                }
            }
            //bookCombox.DataSource = Books;

        }

        //private void bookpanel_Paint(object sender, PaintEventArgs e)
        //{
        //    ControlPaint.DrawBorder(e.Graphics, this.bookpanel1.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid); ;

        //}

        private void removeBookButton_Click(object sender, EventArgs e)
        {

            foreach (Panel p in booklistpanel.Controls)
            {
                if (p.Name == ("bookpanel" + (numOfBooks-1).ToString()))
                {
                    // remove everything inside it.
                    // Clearing everything first.
                    for (int i = p.Controls.Count - 1; i >= 0; --i)
                        p.Controls[i].Dispose();

                    p.Controls.Clear();
                    p.Dispose();
                    numOfBooks--;
                    break;
                }
            }
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            Panel newBookPanel = new Panel();
            newBookPanel.Parent = booklistpanel;
            newBookPanel.Dock = DockStyle.Top;
            newBookPanel.Name = "bookpanel" + numOfBooks.ToString();

            Label newBookLabel = new Label();
            newBookLabel.AutoSize = true;
            newBookLabel.BackColor = System.Drawing.Color.White;
            newBookLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            newBookLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            newBookLabel.Location = new System.Drawing.Point(16, 24);
            newBookLabel.Name = "booklabel" + numOfBooks.ToString();
            newBookLabel.Size = new System.Drawing.Size(46, 20);
            newBookLabel.TabIndex = 91;
            newBookLabel.Text = "Book";
            newBookLabel.Parent = newBookPanel;

            // 
            ComboBox newBookCombox = new ComboBox();
            newBookCombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            newBookCombox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            newBookCombox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            newBookCombox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            newBookCombox.FormattingEnabled = true;
            newBookCombox.Location = new System.Drawing.Point(12, 49);
            newBookCombox.Name = "bookCombox" + numOfBooks.ToString();
            newBookCombox.Size = new System.Drawing.Size(299, 29);
            newBookCombox.TabIndex = 90;
            newBookCombox.Parent = newBookPanel;


            
            newBookCombox.DataSource = Books;

            Label newnumOfCopiesLabel = new Label();
            newnumOfCopiesLabel.AutoSize = true;
            newnumOfCopiesLabel.BackColor = System.Drawing.Color.White;
            newnumOfCopiesLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            newnumOfCopiesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            newnumOfCopiesLabel.Location = new System.Drawing.Point(380, 24);
            newnumOfCopiesLabel.Name = "numOfCopiesLabel" + numOfBooks.ToString();
            newnumOfCopiesLabel.Size = new System.Drawing.Size(144, 20);
            newnumOfCopiesLabel.TabIndex = 92;
            newnumOfCopiesLabel.Text = "Number Of Copies";
            newnumOfCopiesLabel.Parent = newBookPanel;

            NumericUpDown newNumOfCopiesBox = new NumericUpDown();
            newNumOfCopiesBox.Location = new System.Drawing.Point(384, 56);
            newNumOfCopiesBox.Name = "numOfCopiesBox";
            newNumOfCopiesBox.Size = new System.Drawing.Size(162, 20);
            newNumOfCopiesBox.TabIndex = 90;
            newNumOfCopiesBox.Parent = newBookPanel;

            numOfBooks++;

        }

        private void toppanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.toppanel.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid); ;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).openChildForm(new ListRequests(ref controllerObj));
        }

        private void addRequestButton_Click(object sender, EventArgs e)
        {
            newRequestValidation.Visible = false;
            newRequestValidation.ForeColor = Color.FromArgb(244, 67, 54);


            List<string> RequestedISBNS = new List<string>();
            List<int> RequestedNumOfCopies = new List<int>();

            // Validation
            foreach(Panel bookPanel in booklistpanel.Controls)
            {

                ComboBox thisBook = null;
                NumericUpDown thisBooksCopies = null;

                foreach(Control c in bookPanel.Controls)
                {
                    if (c is ComboBox)
                    {
                        if (((ComboBox)c).SelectedItem == null)
                        {
                            newRequestValidation.Text = "Make sure all fields are filled. If there's an extra field you don't need, click the Remove Book button.";
                            newRequestValidation.Visible = true;
                            return;
                        }
                        thisBook = (ComboBox)c;
                    }
                    else if (c is NumericUpDown)
                    {
                        if (((NumericUpDown)c).Value == 0)
                        {
                            newRequestValidation.Text = "No number of copies is not allowed to be zero. If you don't want to request a book, click the Remove Book button.";
                            newRequestValidation.Visible = true;
                            return;
                        }
                        thisBooksCopies = (NumericUpDown)c;
                    }

                }
                if (RequestedISBNS.Contains(ISBNS[thisBook.SelectedIndex]))
                {
                    newRequestValidation.Text = "Two panels request the same book. Instead, use one with the combined number of copies.";
                    newRequestValidation.Visible = true;
                    return;
                } else
                {
                    RequestedISBNS.Add(ISBNS[thisBook.SelectedIndex]);
                    RequestedNumOfCopies.Add(int.Parse(thisBooksCopies.Value.ToString()));
                }

            }


            if (confirmationPassword.Text == "")
            {
                newRequestValidation.Text = "Empty Password.";
                newRequestValidation.Visible = true;
            } else if (!controllerObj.verifyPassword(confirmationPassword.Text))
            {
                newRequestValidation.Text = "Wrong Password.";
                newRequestValidation.Visible = true;
            } else {

                try
                {

                    DataTable RequestedBooksDt = new DataTable();
                    RequestedBooksDt.Columns.Add("ind", typeof(int));
                    RequestedBooksDt.Columns.Add("bookISBN", typeof(string));
                    RequestedBooksDt.Columns.Add("numOfCopies", typeof(int));

                    for (int i = 0; i < RequestedISBNS.Count; i++)
                    {
                        DataRow row = RequestedBooksDt.NewRow();
                        row["ind"] = i + 1;
                        row["bookISBN"] = RequestedISBNS[i];
                        row["numOfCopies"] = RequestedNumOfCopies[i];
                        RequestedBooksDt.Rows.Add(row);
                    }

                    parameterToAProcedure booksListPar = new parameterToAProcedure("@List", RequestedBooksDt);
                    parameterToAProcedure branchIDPar = new parameterToAProcedure("@branchID", controllerObj.currBranchID);
                    parameterToAProcedure senderIDPar = new parameterToAProcedure("@senderID", controllerObj.currID);
                    parameterToAProcedure vendorIDPar = new parameterToAProcedure("@vendorID", vendorIDs[vendorcombobox.SelectedIndex]);


                    if (controllerObj.ExecuteNonStoredProcedure("VendingRequest", booksListPar, branchIDPar, senderIDPar, vendorIDPar) == 0)
                        throw new Exception();
                    else
                    {
                        newRequestValidation.Text = "Books Requested Successfully!";
                        newRequestValidation.ForeColor = Color.FromArgb(0, 200, 83);
                        newRequestValidation.Visible = true;
                        confirmationPassword.Text = "";
                        addRequestButton.Visible = false;

                    }
                } catch
                {
                    newRequestValidation.Text = "Something wrong happened. Try again later.";
                    newRequestValidation.Visible = true;
                }

            }


            return;
        
        }

    }
}
