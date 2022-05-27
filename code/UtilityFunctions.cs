using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Windows.Forms;
using System.Drawing;
using System.Data;

namespace utilityfunctions
{

    // A custom panel (CPanel) for database entites
    // with just few extra data members for easiness of management.
    public class CPanel : Panel
    {
        public string db_id; // This contains the id of the element in the database.
        public bool selected = false; // This contains whether an element is selected (in operation of deleting a multiple of elements)
        public string[] keywords; // This contains the keywords describing an element (for the operation of searching).
        public int type; // This has several meaning depending on the element, it's used for example in meetings, events, etc. Check each one for their respective use of it.
    };


    public class CustomPanel : Panel
    {
        public CustomPanel()
        {
            Info = new Dictionary<string, string>();
        }

        public string ISBN;
        public int[] branches;
        public bool selected = false;
        public Dictionary<string, string> Info;
    };


    
    public struct parameterToAProcedure
    {
        public parameterToAProcedure(string argname, dynamic argvalue)
        {
            name = argname;
            value = argvalue;
        }
        public string name;
        public dynamic value;
    }
    public static class Globals
    {
        public static bool changedProfilePicture = false; // modifiable
        public const string bucketname = "centrallibrary"; // unmodifiable
        public static Color mainColor = Color.FromArgb(25, 118, 210);

        public static Color greenColor = Color.FromArgb(0, 200, 83);
        public static Color redColor = Color.FromArgb(244, 67, 54);

    }

    public static class functions
    {

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }


        public static string RandomDigits(int length)
        {
            var random = new Random();
            string s = string.Empty;
            for (int i = 0; i < length; i++)
                s = String.Concat(s, random.Next(10).ToString());
            return s;
        }


        public static bool validatePassword(string password, string repassword, ref Label validationlabel)
        {
            var passwordregex = new Regex("(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^A-Za-z0-9])(?=.{8,})");
            if (password.Length < 8)
            {
                validationlabel.Text = "Password should at least be 8 characters.";
                validationlabel.Visible = true;
                return false;
            }
            if (password != repassword)
            {
                validationlabel.Text = "Passwords should be matching.";
                validationlabel.Visible = true;
                return false;
            }
            if (!passwordregex.IsMatch(password))
            {
                validationlabel.Text = "A password should contain at least one of digits, special characters,\nand upper and smaller characters.";
                validationlabel.Visible = true;
                return false;
            }

            return true;
        }

        public static bool ValidateFields(in string firstname, in string lastname, in string email, in string password, in string repassword, in int age, ref Label validationlabel, bool signup, string address="", string phone="")
        {

            validationlabel.Visible = false;


            var emailregex = new Regex("^[a-zA-Z0-9.@\\-]*$");
            var nameregex = new Regex("^[a-zA-Z. ']*$");
            var passwordregex = new Regex("(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^A-Za-z0-9])(?=.{8,})");
            
            var phoneregex = new Regex("^(\\+[2]{1})?[0-9]{11}$");

            // First: names.
            if (firstname.Length < 3 || lastname.Length < 3)
            {
                validationlabel.Text = "First and last names should at least be 3 characters long.";
                validationlabel.Visible = true;
                return false;
            }

            if (!nameregex.IsMatch(firstname) || !nameregex.IsMatch(lastname))
            {
                validationlabel.Text = "First and last names should only contain alphabetical characters, apostrophes, and dots.";
                validationlabel.Visible = true;
                return false;
            }

            // Adress if exists (For vendors only)
            if (!String.IsNullOrEmpty(address))
            {
                if (address.Length > 50 || address.Length < 10)
                {
                    validationlabel.Text = "Adress should be full and of an appropriate length.";
                    validationlabel.Visible = true;
                    return false;
                }
            }

            // Phone number if exists (For vendors only)
            if (!String.IsNullOrEmpty(phone))
            {
                if (phone.Length > 13 || phone.Length < 11)
                {
                    validationlabel.Text = "Minimum Length of phone number is 11, and maximum of 13 (with the international prefix +2).";
                    validationlabel.Visible = true;
                    return false;
                } 
                else if (!phoneregex.IsMatch(phone))
                {
                    validationlabel.Text = "Phone numbers can only contain digits and the plus sign. (Make sure there are no spaces).";
                    validationlabel.Visible = true;
                    return false;
                }
            }

            // Secondly: emails.
            if (!emailregex.IsMatch(email) || !IsValidEmail(email))
            {
                validationlabel.Text = "Please Enter A Valid Email Address.";
                validationlabel.Visible = true;
                return false;
            }

            // Thirdly: passwords.
            if (signup)
            {
                validatePassword(password, repassword, ref validationlabel);
            }


            // Fourthly: age.
            if (age < 13)
            {
                validationlabel.Text = "Minimum age to subscribe is 13 year old.";
                validationlabel.Visible = true;
                return false;
            }

            return true;
        }

    }
}
