using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using Amazon.S3;
using Amazon.S3.Model;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using utilityfunctions;

namespace CentralLibrary
{

    public partial class ProfileForm : Form
    {

        Controller controllerObj;
        OpenFileDialog open;
        string imageLocalPath;
        string configdirectory;

        // Current info of the user.


                
        public ProfileForm(ref Controller c)
        
        {
            InitializeComponent();
            controllerObj = c;
            
            if (controllerObj.employeeType == 4)
            {
                profilelastname.Visible = false;
                profilefirstname.Visible = false;
                vendorName.Visible = true;

                profileGenderCombo.Visible = false;
                genderlabel.Text = "Address";
                vendorAddress.Visible = true;

                dobDatePicker.Visible = false;
                doblabel.Text = "Phone Number";
                vendorphoneNumber.Visible = true;

                vendorName.HintText = controllerObj.currVendorName;
                vendorName.Text = "";
                vendorAddress.HintText = controllerObj.currVendorAddress;
                vendorAddress.Text = "";
                vendorphoneNumber.HintText = controllerObj.currVendorPhone;
                vendorphoneNumber.Text = "";

            }

            
            configdirectory = Directory.GetCurrentDirectory();
            string configdirectoryWithAtrailingslash;




            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                configdirectory += "\\.appconfig";
                configdirectoryWithAtrailingslash = configdirectory + "\\";
            }
            else
            {
                configdirectory += "/.appconfig";
                configdirectoryWithAtrailingslash = configdirectory + "/";
            }

            if (!Directory.Exists(configdirectory))
            {
                Directory.CreateDirectory(configdirectory);
            }

            // Get the picture and store it.
            imageLocalPath = configdirectoryWithAtrailingslash + ".profilepic";


            ShowInfo();
        }

        private void ShowInfo()
        {


            profilefirstname.Text = "";
            profilefirstname.HintText = controllerObj.currFirstname;

            profilelastname.Text = "";
            profilelastname.HintText = controllerObj.currLastname;

            profileemail.Text = "";
            profileemail.HintText = controllerObj.currEmail;

            profileGenderCombo.Text = controllerObj.currGender;
            dobDatePicker.Value = controllerObj.currBirthdate;

            // Getting and storing the image locally.
            getAndStoreProfilePicture();

            // Show the image.

            //FileStream ImageFileStream = new FileStream(imageLocalPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            //ImageFileStream.Close();

            string path = Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).ToString()).ToString()).ToString();
            path += String.Format("\\Images\\Person\\{0}", controllerObj.currImg);

            pictureBox1.Image = new Bitmap(path);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Refresh();
        }

        private void getAndStoreProfilePicture()
        {
            if (!File.Exists(imageLocalPath))
            {
                using (var fileStream = File.Create(imageLocalPath))
                {
                    GetImageFromAWS(controllerObj.currImg).CopyTo(fileStream);
                    fileStream.Close();
                }
            }
            return;

        }
        private static Stream GetImageFromAWS(string objectname)
        {
            var s3Client = new AmazonS3Client();
            var getResponse = s3Client.GetObject(utilityfunctions.Globals.bucketname, objectname);
            return getResponse.ResponseStream;
        }

        private void changepicture_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
                utilityfunctions.Globals.changedProfilePicture = true;
            }
        }
        

        private void savechanges_Click(object sender, EventArgs e)
        {

            validationLabel.ForeColor = Color.FromArgb(244, 67, 54);
            validationLabel.Visible = false;

            // First check the password.
            if (profilepasswordtextbox.Text == "")
            {
                validationLabel.Text = "Please, enter current password to confirm changes.";
                validationLabel.Visible = true;
            } else
            {

                if (controllerObj.employeeType == 4)
                {

                    string newName = controllerObj.currVendorName;
                    string newEmail = controllerObj.currEmail;

                    string newPhone = controllerObj.currVendorPhone;
                    string newAddress = controllerObj.currVendorAddress;
                    string newImageObjKey = controllerObj.currImg;

                    if (vendorName.Text != "")
                        newName = vendorName.Text;
                    if (vendorphoneNumber.Text != "")
                        newPhone = vendorphoneNumber.Text;
                    if (vendorAddress.Text != "")
                        newAddress = vendorAddress.Text;
                    if (profileemail.Text != "")
                        newEmail = profileemail.Text;

                    if (functions.ValidateFields(newName, newName, newEmail, profilepasswordtextbox.Text, profilepasswordtextbox.Text, 99, ref validationLabel, false, newAddress, newPhone))
                    {
                        if (controllerObj.verifyPassword(profilepasswordtextbox.Text))
                        {
                            try
                            {
                                int x = controllerObj.CheckIfXIsUsed("Person", "email", newEmail);
                                if ((x != 0) && !(x == 1 && controllerObj.currEmail == newEmail))
                                {
                                    validationLabel.Text = "An account already exists with this email.";
                                    validationLabel.Visible = true;
                                    return;
                                }
                                // If the image changed, upload the picture and update the cached file.
                                if (utilityfunctions.Globals.changedProfilePicture)
                                {

                                    // Generating a random title to upload the image with.
                                    newImageObjKey = String.Join("", Process.GetCurrentProcess().Id + controllerObj.currID, Path.GetRandomFileName(), DateTime.Now.Subtract(new DateTime(1970, 1, 1)).TotalSeconds);

                                    // Creating the upload request.
                                    PutObjectRequest uploadRequest = new PutObjectRequest();
                                    uploadRequest.BucketName = utilityfunctions.Globals.bucketname;
                                    uploadRequest.Key = newImageObjKey;
                                    uploadRequest.FilePath = open.FileName;


                                    // Uploading the image.
                                    using (var s3Client = new AmazonS3Client())
                                    {
                                        s3Client.PutObject(uploadRequest);
                                    }

                                    utilityfunctions.Globals.changedProfilePicture = false;
                                    using (FileStream ImageFileStream = new FileStream(imageLocalPath, FileMode.Open, FileAccess.Write, FileShare.ReadWrite))
                                    {
                                        GetImageFromAWS(newImageObjKey).CopyTo(ImageFileStream);
                                        ImageFileStream.Close();
                                    }
                                }

                                // Updating changes to database
                                parameterToAProcedure emailPar = new parameterToAProcedure("@email", newEmail);
                                parameterToAProcedure IDPar = new parameterToAProcedure("@ID", controllerObj.currID);
                                parameterToAProcedure imgPar = new parameterToAProcedure("@img", newImageObjKey);
                                parameterToAProcedure vnamePar = new parameterToAProcedure("@vname", newName);
                                parameterToAProcedure addressPar = new parameterToAProcedure("@paddress", newAddress);
                                parameterToAProcedure phonePar = new parameterToAProcedure("@phone", newPhone);

                                if (controllerObj.ExecuteNonStoredProcedure("UpdateProfileVendor", emailPar, IDPar, imgPar, vnamePar, addressPar, phonePar) == 0)
                                    throw new Exception();
                                else
                                {
                                    // Showing message of success.
                                    validationLabel.ForeColor = Color.FromArgb(0, 200, 83);
                                    validationLabel.Text = "Updated Successfully!";
                                    validationLabel.Visible = true;
                                    profilepasswordtextbox.Text = "";

                                    controllerObj.UpdateAndStoreCurrentUserInfo();

                                    ShowInfo();
                                }
                            }
                            catch
                            {
                                validationLabel.Text = "Something wrong happened. Try again later!";
                                validationLabel.Visible = true;
                            }
                        }
                    }


                }
                else
                {

                    // Validate changes.
                    string newFirstname = controllerObj.currFirstname,
                           newLastname = controllerObj.currLastname,
                           newEmail = controllerObj.currEmail,
                           newGender = controllerObj.currGender,
                           newImageObjKey = controllerObj.currImg;

                    DateTime newBirthDate = controllerObj.currBirthdate;

                    if (profilefirstname.Text != "")
                    {
                        newFirstname = profilefirstname.Text;
                    }
                    if (profilelastname.Text != "")
                    {
                        newLastname = profilelastname.Text;
                    }
                    if (profileemail.Text != "")
                    {
                        newEmail = profileemail.Text;
                    }
                    if (dobDatePicker.Value != controllerObj.currBirthdate)
                    {
                        newBirthDate = dobDatePicker.Value;
                    }
                    if (profileGenderCombo.Text != controllerObj.currGender)
                    {
                        newGender = profileGenderCombo.Text;
                    }

                    // Calculating age.
                    int age = DateTime.Now.Year - newBirthDate.Year;
                    if (newBirthDate.AddYears(age) > DateTime.Now) age--;


                    if (functions.ValidateFields(newFirstname, newLastname, newEmail, profilepasswordtextbox.Text, profilepasswordtextbox.Text, age, ref validationLabel, false))
                    {
                        if (controllerObj.verifyPassword(profilepasswordtextbox.Text))
                        {
                            try
                            {
                                int x = controllerObj.CheckIfXIsUsed("Person", "email", newEmail);
                                if ((x != 0) && !(x == 1 && controllerObj.currEmail == newEmail))
                                {
                                    validationLabel.Text = "An account already exists with this email.";
                                    validationLabel.Visible = true;
                                    return;
                                }
                                // If the image changed, upload the picture and update the cached file.
                                if (utilityfunctions.Globals.changedProfilePicture)
                                {

                                    // Generating a random title to upload the image with.
                                    //newImageObjKey = String.Join("", Process.GetCurrentProcess().Id + controllerObj.currID, Path.GetRandomFileName(), DateTime.Now.Subtract(new DateTime(1970, 1, 1)).TotalSeconds);

                                    newImageObjKey = String.Join("", Process.GetCurrentProcess().Id + controllerObj.currID, Path.GetRandomFileName(), DateTime.Now.Subtract(new DateTime(1970, 1, 1)).TotalSeconds, '.', open.FileName.Split('.')[open.FileName.Split('.').Length - 1]);

                                    string path = Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).ToString()).ToString()).ToString();
                                    path += String.Format("\\Images\\Person\\{0}", newImageObjKey);
                                    File.Copy(open.FileName, path);


                                    // Creating the upload request.
                                    PutObjectRequest uploadRequest = new PutObjectRequest();
                                    uploadRequest.BucketName = utilityfunctions.Globals.bucketname;
                                    uploadRequest.Key = newImageObjKey;
                                    uploadRequest.FilePath = open.FileName;







                                    // Uploading the image.
                                    using (var s3Client = new AmazonS3Client())
                                    {
                                        s3Client.PutObject(uploadRequest);
                                    }

                                    utilityfunctions.Globals.changedProfilePicture = false;
                                    using (FileStream ImageFileStream = new FileStream(imageLocalPath, FileMode.Open, FileAccess.Write, FileShare.ReadWrite))
                                    {
                                        GetImageFromAWS(newImageObjKey).CopyTo(ImageFileStream);
                                        ImageFileStream.Close();
                                    }


                                }

                                // Updating changes to database
                                parameterToAProcedure emailPar = new parameterToAProcedure("@email", newEmail);
                                parameterToAProcedure IDPar = new parameterToAProcedure("@ID", controllerObj.currID);
                                parameterToAProcedure imgPar = new parameterToAProcedure("@img", newImageObjKey);
                                parameterToAProcedure genderPar = new parameterToAProcedure("@gender", newGender);
                                parameterToAProcedure plastnamePar = new parameterToAProcedure("@plastname", newLastname);
                                parameterToAProcedure pfirstnamePar = new parameterToAProcedure("@pfirstname", newFirstname);
                                parameterToAProcedure birthdatePar = new parameterToAProcedure("@birthdate", newBirthDate);

                                if (controllerObj.ExecuteNonStoredProcedure("UpdateProfile", emailPar, IDPar, imgPar, genderPar, plastnamePar, pfirstnamePar, birthdatePar) == 0)
                                    throw new Exception();
                                else
                                {
                                    // Showing message of success.
                                    validationLabel.ForeColor = Color.FromArgb(0, 200, 83);
                                    validationLabel.Text = "Updated Successfully!";
                                    validationLabel.Visible = true;
                                    profilepasswordtextbox.Text = "";
                                    controllerObj.UpdateAndStoreCurrentUserInfo();


                                    ShowInfo();
                                }
                            }
                            catch
                            {
                                validationLabel.Text = "Something wrong happened. Try again later!";
                                validationLabel.Visible = true;
                            }

                        }
                        else
                        {
                            validationLabel.Text = "Wrong Password.";
                            validationLabel.Visible = true;
                        }
                    }
                }
                
            }
        }
    }
}
