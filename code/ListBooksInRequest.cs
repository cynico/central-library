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
    public partial class ListBooksInRequest : Form
    {
        Controller controllerObj;
        string senderName;
        int branch;
        DateTime send_date;
        int requestID;
        public ListBooksInRequest(ref Controller c, string s, int branchOfRequestSender, DateTime d, int r)
        {
            InitializeComponent();
            controllerObj = c;
            senderName = s;
            branch = branchOfRequestSender;
            send_date = d;
            requestID = r;



            fromLabel.Text += senderName;
            branchLabel.Text += branch.ToString();
            atLabel.Text += send_date.ToString("dd MMM yyyy HH:mm");

            ShowBooks();
        }

        public void ShowBooks()
        {
            DataTable RequestedBooks = controllerObj.SelectAll(String.Format("VendingRequestsBooks JOIN Book ON (VendingRequestsBooks.bookISBN = Book.ISBN) WHERE requestID={0};", requestID));
            if (RequestedBooks != null)
            {
                foreach(DataRow row in RequestedBooks.Rows)
                {
                    Panel newBookPanel = new Panel();
                    newBookPanel.Parent = booklistpanel;
                    newBookPanel.Dock = DockStyle.Top;

                    Label newBookLabel = new Label();
                    newBookLabel.AutoSize = true;
                    newBookLabel.BackColor = System.Drawing.Color.White;
                    newBookLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    newBookLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
                    newBookLabel.Location = new System.Drawing.Point(16, 24);
                    newBookLabel.Size = new System.Drawing.Size(46, 20);
                    newBookLabel.TabIndex = 91;
                    newBookLabel.Text = "Book";
                    newBookLabel.Parent = newBookPanel;

                    //

                    Label nameOfBook = new Label();
                    nameOfBook.AutoSize = true;
                    nameOfBook.BackColor = System.Drawing.Color.White;
                    nameOfBook.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    nameOfBook.ForeColor = System.Drawing.Color.DimGray;
                    nameOfBook.Location = new System.Drawing.Point(12, 49);
                    nameOfBook.Size = new System.Drawing.Size(46, 20);
                    nameOfBook.TabIndex = 91;
                    nameOfBook.Text = row["title"].ToString();
                    nameOfBook.Parent = newBookPanel;


                    Label newnumOfCopiesLabel = new Label();
                    newnumOfCopiesLabel.AutoSize = true;
                    newnumOfCopiesLabel.BackColor = System.Drawing.Color.White;
                    newnumOfCopiesLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    newnumOfCopiesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
                    newnumOfCopiesLabel.Location = new System.Drawing.Point(380, 24);
                    newnumOfCopiesLabel.Size = new System.Drawing.Size(144, 20);
                    newnumOfCopiesLabel.TabIndex = 92;
                    newnumOfCopiesLabel.Text = "Number Of Copies";
                    newnumOfCopiesLabel.Parent = newBookPanel;


                    Label numOfCopies = new Label();
                    numOfCopies.AutoSize = true;
                    numOfCopies.BackColor = System.Drawing.Color.White;
                    numOfCopies.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    numOfCopies.ForeColor = System.Drawing.Color.DimGray;
                    numOfCopies.Location = new System.Drawing.Point(384, 56);
                    numOfCopies.Size = new System.Drawing.Size(46, 20);
                    numOfCopies.TabIndex = 91;
                    numOfCopies.Text = row["numberOfCopies"].ToString();
                    numOfCopies.Parent = newBookPanel;

                } 
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).openChildForm(new ListRequests(ref controllerObj));
        }

        private void ListBooksInRequest_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.DimGray, 3), this.DisplayRectangle);

        }
    }
}
