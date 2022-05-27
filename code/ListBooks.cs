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
using System.IO;

namespace CentralLibrary
{
    public partial class ListBooks : Form
    {
        Controller controllerObj;
        List<string> categories;


        Delegate openBookDelegate;
        public ListBooks(ref Controller c)
        {
            InitializeComponent();
            controllerObj = c;


            if (controllerObj.employeeType > 2)
                addButton.Visible = false;

            books_listpanel.Parent = this;
            addButton.Parent = this;
            addButton.Location = new Point(540, 690);
            addButton.BringToFront();



            DataTable categoriesDt = controllerObj.SelectAll("Category");

            if (categoriesDt != null)
            {
                categories = new List<string>();
                foreach (DataRow row in categoriesDt.Rows)
                {
                    categories.Add(row["cname"].ToString());
                }
            }

            if (controllerObj.employeeType == 0 || controllerObj.employeeType == 4)
            {
                branchCheckBox.Visible = false;
            }

            categories.Add("All");
            categoryComboBox.DataSource = categories;
            categoryComboBox.SelectedItem = "All";

            ShowBooks();

        }

        private void openBook(object sender, EventArgs e, Dictionary<string, string> Info)
        {
            var me = this;
            ViewBook newform = new ViewBook(ref controllerObj, Info, ref me);
            newform.Show();
            return;
        }


        public void ShowBooks()
        {

            // Clearing everything first.
            for (int i = books_listpanel.Controls.Count - 1; i >= 0; --i)
                books_listpanel.Controls[i].Dispose();

            books_listpanel.Controls.Clear();

            DataTable Books = controllerObj.GetBooks();

            if (Books != null)
            {
                foreach(DataRow book in Books.Rows)
                {

                    
                    CustomPanel bookPanel = new CustomPanel();
                    bookPanel.Dock = DockStyle.Top;
                    bookPanel.Size = new System.Drawing.Size(640, 113);
                    bookPanel.BackColor = Color.Transparent;
                    bookPanel.Cursor = Cursors.Hand;


                    // Setting data members of the CustomPanel

                    bookPanel.Info.Add("ISBN", book["ISBN"].ToString());
                    bookPanel.Info.Add("category", book["category"].ToString());
                    bookPanel.Info.Add("title", book["title"].ToString());
                    bookPanel.Info.Add("language", book["blanguage"].ToString());
                    bookPanel.Info.Add("authorName", book["aname"].ToString());
                    bookPanel.Info.Add("publisherName", book["pubname"].ToString());
                    bookPanel.Info.Add("publisherPhone", book["phone"].ToString());
                    bookPanel.Info.Add("publisherAddress", book["paddress"].ToString());
                    bookPanel.Info.Add("price", book["price"].ToString());
                    bookPanel.Info.Add("publicationDate", DateTime.Parse(book["publicationDate"].ToString()).ToString("dd/MM/yyyy"));
                    
                    
                    if (controllerObj.employeeType != 0 && controllerObj.employeeType != 4)
                    {

                        if (book["numberOfAvailableCopies"] == DBNull.Value)
                            bookPanel.Info.Add("numberOfAvailableCopies", "0");
                        else
                            bookPanel.Info.Add("numberOfAvailableCopies", book["numberOfAvailableCopies"].ToString());

                        if (book["numOfRequests"] == DBNull.Value)
                            bookPanel.Info.Add("numberOnumberOfRequestsfAvailableCopies", "0");
                        else
                            bookPanel.Info.Add("numberOfRequests", book["numOfRequests"].ToString());



                    }

                    // available status label
                    if (controllerObj.employeeType != 0 && controllerObj.employeeType != 4)
                    {
                        Label availableStatus = new Label();


                        availableStatus.ForeColor = Color.FromArgb(244, 67, 54);
                        if (book["numberOfAvailableCopies"] == DBNull.Value)
                            availableStatus.Text = "Unavailable";
                        else if (int.Parse(book["numberOfAvailableCopies"].ToString()) == 0)
                            availableStatus.Text = "Unavailable";
                        else
                        {
                            availableStatus.Text = "Available";
                            availableStatus.ForeColor = Color.FromArgb(0, 200, 83);
                        }

                        availableStatus.Font = new Font("Century Gothic", float.Parse("8.25"), FontStyle.Regular);
                        availableStatus.Parent = bookPanel;
                        availableStatus.Location = new Point(548, 13);
                        availableStatus.AutoSize = true;
                        availableStatus.MaximumSize = new System.Drawing.Size(85, 0);

                    }


                    PictureBox picture = new PictureBox();
                    picture.Size = new System.Drawing.Size(55, 55);
                    picture.Parent = bookPanel;
                    picture.Location = new Point(12, 12);


                    string path = Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).ToString()).ToString()).ToString();
                    path += String.Format("\\Images\\Books\\{0}", book["img"].ToString());
                    picture.Image = new Bitmap(path);
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    picture.Refresh();


                    // Author label.
                    Label author = new Label();
                    author.Text = bookPanel.Info["authorName"];
                    author.Font = new Font("Century Gothic", float.Parse("9.75"), FontStyle.Regular);
                    author.ForeColor = Color.DimGray;
                    author.Parent = bookPanel;
                    author.Location = new Point(73, 12);
                    author.AutoSize = true;

                    // Title Label.
                    Label title = new Label();
                    title.Text = book["title"].ToString();
                    title.Font = new Font("Century Gothic", float.Parse("14.25"), FontStyle.Bold);
                    title.ForeColor = Color.FromArgb(75, 75, 75);
                    title.Parent = bookPanel;
                    title.AutoSize = true;
                    title.Location = new Point(74, 29);

                    // Show publisher of the book.
                    Label publihser = new Label();
                    publihser.Text = book["pubname"].ToString();
                    publihser.Font = new Font("Century Gothic", float.Parse("11.25"), FontStyle.Regular);
                    publihser.ForeColor = SystemColors.ControlDarkDark;
                    publihser.Parent = bookPanel;
                    publihser.Location = new Point(74, 52);
                    publihser.AutoSize = false;
                    publihser.Size = new System.Drawing.Size(549, 43);




                    bookPanel.Parent = books_listpanel;


                    openBookDelegate = new MouseEventHandler((sender, e) => openBook(sender, e, bookPanel.Info));
                    bookPanel.MouseClick += (MouseEventHandler)openBookDelegate;


                }
            }

            return;
        }

        private void filterButton_Click(object sender, EventArgs e)
        {

            if (categoryComboBox.SelectedItem.ToString() == "All")
            {
                if (branchCheckBox.Checked == true)
                {
                    foreach (CustomPanel book in books_listpanel.Controls)
                    {
                        if (int.Parse(book.Info["numberOfAvailableCopies"]) > 0)
                            book.Visible = true;
                        else
                            book.Visible = false;
                    }
                }
                else
                {
                    foreach (CustomPanel book in books_listpanel.Controls)
                            book.Visible = true;
                }
            }

            else
            {

                if (branchCheckBox.Checked == true)
                {
                    foreach (CustomPanel book in books_listpanel.Controls)
                    {
                        if (int.Parse(book.Info["numberOfAvailableCopies"]) > 0 && book.Info["category"] == categoryComboBox.SelectedItem.ToString())
                            book.Visible = true;
                        else
                            book.Visible = false;
                    }
                }
                else
                {
                    foreach (CustomPanel book in books_listpanel.Controls)
                    {
                        if (book.Info["category"] == categoryComboBox.SelectedItem.ToString())
                            book.Visible = true;
                        else
                            book.Visible = false;
                    }
                }

            }

            return;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (branchCheckBox.Checked == true)
            {

                if (categoryComboBox.SelectedItem.ToString() == "All")
                {
                    foreach (CustomPanel book in books_listpanel.Controls)
                    {
                        if (int.Parse(book.Info["numberOfAvailableCopies"]) > 0)
                            book.Visible = true;
                        else
                            book.Visible = false;
                    }

                }
                else
                {
                    foreach (CustomPanel book in books_listpanel.Controls)
                    {
                        if (int.Parse(book.Info["numberOfAvailableCopies"]) > 0 && book.Info["category"] == categoryComboBox.SelectedItem.ToString())
                            book.Visible = true;
                        else
                            book.Visible = false;
                    }
                }

            } else
            {
                if (categoryComboBox.SelectedItem.ToString() == "All")
                {
                    foreach (CustomPanel book in books_listpanel.Controls)
                        book.Visible = true;
                }
                else
                {
                    foreach (CustomPanel book in books_listpanel.Controls)
                    {
                        if (book.Info["category"] == categoryComboBox.SelectedItem.ToString())
                            book.Visible = true;
                        else
                            book.Visible = false;
                    }
                }



            }

            return;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).openChildForm(new AddBook(ref controllerObj));
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {


            return;

        }
    }
}
