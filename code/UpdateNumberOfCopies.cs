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
    public partial class UpdateNumberOfCopies : Form
    {
        Controller controllerObj;
        string bookISBN;
        public UpdateNumberOfCopies(ref Controller c, string title, int num, string ISBN)
        {
            InitializeComponent();
            controllerObj = c;
            titleLabel.Text += title;
            numLabel.Text += num.ToString();
            bookISBN = ISBN;
        }

        private void cancelrequestact_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            validationLabel.Visible = false;
            validationLabel.ForeColor = utilityfunctions.Globals.redColor;

            try
            {
                parameterToAProcedure branchIDPar = new parameterToAProcedure("@branchID", controllerObj.currBranchID);
                parameterToAProcedure ISBNPar = new parameterToAProcedure("@bookISBN", bookISBN);
                parameterToAProcedure numberOfCopiesPar = new parameterToAProcedure("@numberOfCopies", numericNum.Value);


                if (controllerObj.ExecuteNonStoredProcedure("UpdateNumberOfCopies", branchIDPar, ISBNPar, numberOfCopiesPar) == 0)
                    throw new Exception();
                else
                {
                    validationLabel.Text = "Number of copies updated successfully!";
                    validationLabel.ForeColor = utilityfunctions.Globals.greenColor;
                    validationLabel.Visible = true;
                    updateButton.Visible = false;
                }
            }
            catch
            {
                validationLabel.Text = "Something wrong happened. Try again later.";
                validationLabel.Visible = true;
            }



        }
    }
}
