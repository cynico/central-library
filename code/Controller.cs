using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using utilityfunctions;

namespace CentralLibrary
{
    public class Controller
    {
        DBManager dbMan;

        // This is the ID of the current logged in employee/reader.
        public string currID = "";

        // This is the ID of th current branch of the logged in employee/reader.
        public string currBranchID = "";

        public int employeeType = -1;
        public int numberOfUnreadNotifications;
        public int numberOfPendingRequests;


        public string currEmail;
        public string currFirstname;
        public string currLastname;
        public string currGender;
        public string currImg;
        public DateTime currBirthdate = DateTime.Now.Date;

        public List<int> branchIDs;
        public List<string> branchNames;
        public List<string> branchesInContractWith;


        public string currBranchName;



        // This is the current name for the logged in user if they are a vendor.
        public string currVendorName;
        public string currVendorPhone;
        public string currVendorAddress;

        public Controller()
        {
            dbMan = new DBManager();

            // This is done to get branches only one time at the start of the session,
            // because they will be needed A LOT, so it seemed wiser to save all those calls
            // to the database server, and just store them one time.
            // This is harmless. When the owner updates anything related to branches, 
            // the function will be called and they will be updated.
            UpdateBranches();
            branchesInContractWith = new List<string>();
        }


        public void ResetCurrentInfo()
        {
            currID = currFirstname = currLastname = currEmail = currGender = currImg = currBranchName = currBranchID = currVendorAddress = currVendorPhone = currVendorAddress = "";
            branchesInContractWith = null;
            numberOfPendingRequests = numberOfUnreadNotifications = 0;
            employeeType = -1;
            currBirthdate = DateTime.Now.Date;

            return;
        }

        #region basicUserFunctionalities

        // This returns the following:
        // 0 If it's the owner
        // 1 If it's an administrator
        // 2 If it's a librarian
        // 3 If it's a reader
        // -1 If it doesn't exist
        // -2 If the password is wrong.


        // It takes one argument: uid, in which it returns back the user's ID if it exists.


        public int CheckIfUserExists(string email, string password, ref string uid)
        {
            string query = "SELECT ID, ppassword FROM Person WHERE Email='" + email + "';";
            DataTable dt = dbMan.ExecuteReader(query);


            if (dt == null)
            {
                return -1;
            } else
            {
                // Of course, it will return only a single row, given the restriction we have
                // on using one email per account. Therefore, there's no need to iterate through 
                // "the returned rows". We'll only use the first row returned.
                uid = dt.Rows[0]["ID"].ToString();
                string storedPassword =  dt.Rows[0]["ppassword"].ToString();
                if (BCrypt.Net.BCrypt.Verify( password , storedPassword))

                {
                    // Checking What type of user it is.
                    // This will depend on the standard for setting users' IDs in the database.
                    // For now this standard is as follows: The first digit indicates what kind of user it is.
                    // 0 For owner
                    // 1 For Administrator
                    // 2 For Librarian
                    // 3 For reader
                    // 4 For Vendor



                    int id = int.Parse(uid.Substring(0, 1));
                    return id;
                }
                else
                {
                    return -2;
                }
            }
            
        }



        // This function is called to fetch and store the current info of the logged in user.
        // It's called on signing in, and whenever the info is updated (in the profile form).
        public void UpdateAndStoreCurrentUserInfo()
        {
            string query = String.Format("SELECT * FROM Person WHERE ID='{0}';", currID);
            DataTable dt = dbMan.ExecuteReader(query);

            if (dt != null)
            {
                currEmail = dt.Rows[0]["email"].ToString();
                currImg = dt.Rows[0]["img"].ToString();
                if (employeeType != 4)
                {
                    currFirstname = dt.Rows[0]["pfirstname"].ToString();
                    currLastname = dt.Rows[0]["plastname"].ToString();
                    currGender = dt.Rows[0]["gender"].ToString();
                    if (DateTime.TryParse(dt.Rows[0]["birthdate"].ToString(), out DateTime result))
                        currBirthdate = result;
                }
                else
                {
                    currVendorName = dt.Rows[0]["vname"].ToString();
                    currVendorPhone = dt.Rows[0]["phone"].ToString();
                    currVendorAddress = dt.Rows[0]["paddress"].ToString();
                }

            }
            return;

        }

        public bool verifyPassword(string password)
        {
            string query = String.Format("SELECT ppassword FROM Person WHERE ID='{0}';", currID);
            DataTable dt = dbMan.ExecuteReader(query);

            if (BCrypt.Net.BCrypt.Verify(password, dt.Rows[0]["ppassword"].ToString()))
                return true;

            return false;
        }

        public DataTable GetBranchOfEmployee(string ID)
        {
            string query = String.Format("SELECT Branch.ID AS ID, bname, blocation FROM Employee JOIN Branch ON (Employee.branchID = Branch.ID) WHERE Employee.ID='{0}'", ID);
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetBranchOfReader(string ID)
        {
            string query = String.Format("SELECT Branch.ID AS ID, bname, blocation FROM Reader JOIN Branch ON (Reader.branchID = Branch.ID) WHERE Reader.ID='{0}'", ID);
            return dbMan.ExecuteReader(query);
        }

        public int UpdatePassword(string password)
        {
            string query = String.Format("UPDATE Person SET ppassword='{0}' WHERE ID='{1}';", BCrypt.Net.BCrypt.HashPassword(password), currID);
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetOwnersInfo()
        {
            string query = "SELECT CONCAT(pfirstname, ' ', plastname) AS pname, email, ouWuner.ID AS ID FROM Person JOIN ouWuner ON (Person.ID = ouWuner.ID);";
            return dbMan.ExecuteReader(query);
        }
        
        public string GetIDOfAdministrator()
        {
            string query = String.Format("SELECT Administrator.ID AS ID FROM Administrator JOIN Employee ON(Administrator.ID = Employee.ID) WHERE Employee.branchID = {0};", currBranchID);
            DataTable dt = dbMan.ExecuteReader(query);
            if (dt == null)
                return "";
            else
                return dt.Rows[0]["ID"].ToString();
        
        }  

        public int DeleteReaderAccount()
        {
            string query = String.Format("DELETE FROM Person WHERE ID='{0}';", currID);
            return dbMan.ExecuteNonQuery(query);

        }
        #endregion


        #region generalizedFunctions

        public int DeleteFromTable(string tableName, string attributeName, string attributeValue, bool isString)
        {
            string query;
            if (isString)
                query = String.Format("DELETE FROM {0} WHERE {1}='{2}';", tableName, attributeName, attributeValue);
            else
                query = String.Format("DELETE FROM {0} WHERE {1}={2};", tableName, attributeName, attributeValue);
            return dbMan.ExecuteNonQuery(query);
        }

        // This is used for validation of randomly generated IDs, making sure they aren't already used. Or for checking whether an email is already used.
        public int CheckIfXIsUsed(string tableName, string attributeName, string attributeValue)
        {
            string query = String.Format("SELECT COUNT(*) FROM {0} WHERE {1}='{2}';", tableName, attributeName, attributeValue);
            return (int)dbMan.ExecuteScalar(query);
        }

        public DataTable SelectAll(string tableName)
        {
            string query = "SELECT * FROM " + tableName + ";";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetStoredProcedure(string procedurename, params parameterToAProcedure[] parameters)
        {
            return dbMan.ExecuteReaderStoredProcedure(procedurename, parameters);
        }

        public int ExecuteNonStoredProcedure(string StoredProcedure, params parameterToAProcedure[] parameters)
        {
            return dbMan.ExecuteNonStoredProcedure(StoredProcedure, parameters);
        }


        #endregion


        #region requestsEmailsAndNotifications

        // requests
        public int acceptRefuseRequest(int ID, int status)
        {
            string query = String.Format("UPDATE Request SET rstatus={0} WHERE ID={1};", status, ID);
            return dbMan.ExecuteNonQuery(query);
        }

        // 0 is for vending
        // 1 is for meetings.
        // 2 for resignation
        // 3 for vending contracts
        // 4 for book borrowing
        public int SendRequest(string rtext, int rstatus, DateTime send_date, string senderID, string receiverID, int rtype, int branchID = -1)
        {

            string branch = (branchID == -1) ? "NULL" : branchID.ToString();
            string query = String.Format("INSERT INTO Request (rtext, rstatus, send_date, sender, receiver, rtype, branchID) VALUES ('{0}', {1}, '{2}', '{3}', '{4}', {5}, {6});", rtext, rstatus, send_date.ToString(), senderID, receiverID, rtype, branch);
            return dbMan.ExecuteNonQuery(query);
        }


        public DataTable GetReceivedRequests(int rtype)
        {
            // 0 Is for pending requests.
            // 1 Is for approved requests.
            // 2 Is for rejected requests.
            string query;


            query = String.Format("SELECT Request.ID, rtext, rstatus, rtype, send_date, sender, email, img, pfirstname, plastname, bname, blocation, vname, Request.branchID FROM Request" +
            " JOIN Person ON (Request.sender = Person.ID) JOIN Employee ON (Person.ID = Employee.ID) JOIN Branch ON (Employee.branchID = Branch.ID) WHERE Request.receiver = '{0}' AND rstatus=0 ", currID);

            // GETTING requests of all types.
            if (rtype == -1)
                query += ";";
            else
                query += String.Format("AND rtype={0}", rtype);

            return dbMan.ExecuteReader(query);
        }

        public DataTable GetReaderRequests(int rtype)
        {
            // 0 Is for pending requests.
            // 1 Is for approved requests.
            // 2 Is for rejected requests.
            string query;
            query = String.Format("SELECT Request.ID, rtext, rstatus, rtype, send_date, sender, email, img, pfirstname, plastname, bname, blocation, vname, Request.branchID FROM Request" +
            " JOIN Person ON (Request.sender = Person.ID) JOIN Reader ON (Person.ID = Reader.ID) JOIN Branch ON (Reader.branchID = Branch.ID) WHERE Request.receiver IS NULL AND rstatus=0 AND Request.branchID={1}", currID, currBranchID);

            // GETTING requests of all types.
            if (rtype == -1)
                query += ";";
            else
                query += String.Format("AND rtype={0}", rtype);

            return dbMan.ExecuteReader(query);
        }

        public int AcceptRefuseSubscribtionRequest(int rID, int rstatus)
        {
            // This accepts or refuse subscribtion request.
            // What's special about this, is that it sets the receiver attribute (previously NULL for subscribtion requests)
            // to the ID of the employee accepting/rejecting the request.

            string query = String.Format("UPDATE Request SET receiver='{0}', rstatus={1} WHERE ID={2};", currID, rstatus, rID);
            return dbMan.ExecuteNonQuery(query);
        }




        // emails

        public int SendEmail(string subject, string text, DateTime send_date, string sender, string receiver)
        {
            string query = String.Format("INSERT INTO Email (esubject, etext, send_date, sender, receiver) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", subject, text, send_date, sender, receiver);
            return dbMan.ExecuteNonQuery(query);
        }


        // notifications

        public void UpdateNumberOfNotificationsOrRequests(string tableName, string attributeName)
        {
            string query = String.Format("SELECT COUNT(*) FROM {0} WHERE receiver='{1}' AND {2} = 0;", tableName, currID, attributeName);
            
            if (tableName == "notifications")
                numberOfUnreadNotifications = (int)dbMan.ExecuteScalar(query);
            else
                numberOfPendingRequests = (int)dbMan.ExecuteScalar(query);
            return;
        }


        public DataTable GetNotifications()
        {
            string query = String.Format("SELECT * FROM notifications WHERE receiver='{0}' AND seen = 0;", currID);
            return dbMan.ExecuteReader(query);
        }



        #endregion


        #region Books
        public DataTable GetBooks()
        {
            string query;
            if (currBranchID != "")
            {
                query = String.Format("SELECT TOP 100 Book.ISBN, title, category, blanguage, publicationDate, price, aname, PublisherID, Book.img, pubname, phone, paddress, " +
                    "branchID, numOfRequests, numberOfAvailableCopies FROM Book LEFT OUTER JOIN (SELECT * FROM BookBranch WHERE branchID={0}) AS thisBranchBooks ON(Book.ISBN = thisBranchBooks.ISBN) " +
                    "JOIN Author ON(Book.AuthorID = Author.ID) JOIN Publisher ON(Book.PublisherID = Publisher.ID);", currBranchID);
            }
            else
                query = String.Format("SELECT TOP 100 Book.ISBN, title, category, blanguage, publicationDate, price, aname, PublisherID, Book.img, pubname, phone, paddress " +
                " FROM Book JOIN Author ON(Book.AuthorID = Author.ID) JOIN Publisher ON(Book.PublisherID = Publisher.ID);", currBranchID);
            return dbMan.ExecuteReader(query);

        }

        public int DeleteBookFromBranch(string ISBN)
        {
            string query = String.Format("DELETE FROM BookBranch WHERE ISBN='{0}' AND branchID={1};", ISBN, currBranchID);
            return dbMan.ExecuteNonQuery(query);
        }

        public int AddAuthor(string name, string img)
        {
            string query = String.Format("INSERT INTO Author VALUES ('{0}', '{1}');", name, img);
            return (int)dbMan.ExecuteNonQuery(query);
        }

        public int AddPublisher(params parameterToAProcedure[] parameters)
        {
            string query = String.Format("INSERT INTO Publisher VALUES (@pubname, @phone, @paddress);");
            return dbMan.ExecuteNonQuery(query, parameters);
        }


        #endregion


        #region businessRelated

        public int UpdateSalary(double salary, string ID)
        {
            string query = String.Format("UPDATE Employee SET salary={0} WHERE ID='{1}';", salary, ID);
            return dbMan.ExecuteNonQuery(query);
        }


        public double GetSalary(string ID)
        {
            string query = String.Format("SELECT salary FROM Employee WHERE ID='{0}';", ID);
            return double.Parse(dbMan.ExecuteReader(query).Rows[0]["salary"].ToString());
        }

        public void UpdateBranchesInContractWith()
        {
            string query = String.Format("SELECT CONCAT(bname, ', ', blocation) AS branch FROM VendorBranch JOIN Branch ON(VendorBranch.branchID = Branch.ID) WHERE VID = '{0}'", currID);
            
            DataTable dt = dbMan.ExecuteReader(query);
            if (dt != null)
            {
                if (branchesInContractWith == null)
                    branchesInContractWith = new List<string>();

                foreach (DataRow row in dt.Rows) 
                    branchesInContractWith.Add(row["branch"].ToString());
            }
            return;
        }

        public DataTable GetVendors(bool AdministratorChoosingToHire)
        {

            if (employeeType == 0 || AdministratorChoosingToHire)
                return dbMan.ExecuteReaderStoredProcedure("GetVendorBranches");
            else
            {
                string query = String.Format("SELECT Person.ID, vname, phone, paddress, email, img, contract_date FROM Person JOIN VendorBranch ON (Person.ID = VendorBranch.VID) WHERE VendorBranch.branchID = {0} AND Person.ID LIKE '4%';", currBranchID);
                return dbMan.ExecuteReader(query);
            }
        }

        public DataTable GetUnassignedAdministrators()
        {
            string query = "SELECT pfirstname, plastname, Administrator.ID AS ID FROM Administrator JOIN Employee ON (Administrator.ID = Employee.ID) JOIN Person ON (Administrator.ID = Person.ID) WHERE branchID IS NULL;";
            return dbMan.ExecuteReader(query);
        }


        public DataTable GetAdministratorOfBranch()
        {
            string query = String.Format("SELECT Person.ID, email, birthdate, img, gender, plastname, pfirstname, bname, hired_date, blocation, salary, Branch.ID AS branchID FROM Administrator JOIN Employee ON (Administrator.ID = Employee.ID) JOIN Person ON (Administrator.ID = Person.ID) JOIN Branch ON (Branch.ID = Employee.branchID) WHERE Branch.ID={0};", currBranchID);
            return dbMan.ExecuteReader(query);
        }

        public void UpdateBranches()
        {

            DataTable branches = SelectAll("Branch");
            branchNames = new List<string>();
            branchIDs = new List<int>();

            if (branches != null)
            {
                foreach (DataRow branch in branches.Rows)
                {
                    branchNames.Add(branch["bname"] + ", " + branch["blocation"]);
                    branchIDs.Add(int.Parse(branch["ID"].ToString()));
                }
            }

        }

        public DataTable GetBranches()
        {
            string query = "SELECT bname, blocation, KPI, numOfSubscribers," +
                "numOfStaff, Branch.ID AS branchID, CONCAT(pfirstname, ' ', plastname) AS adminName, Person.email, Branch.established_at " +
                "FROM Administrator JOIN Employee ON (Administrator.ID = Employee.ID) JOIN Person ON (Administrator.ID = Person.ID) " +
                "RIGHT OUTER JOIN Branch ON (Employee.branchID = Branch.ID);";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetLatestBranchInGover(string governorate)
        {
            string query = String.Format("SELECT bname FROM Branch WHERE established_at = (SELECT TOP 1 established_at FROM Branch WHERE bname LIKE '{0}-%' ORDER BY established_at DESC);", governorate);
            return dbMan.ExecuteReader(query);
        }

        public int SendEventAttendanceRequest(string eventTitle)
        {

            eventTitle = eventTitle.Replace('\'', '"');
            string query = String.Format("INSERT INTO Request (rtext, rstatus, send_date, sender, receiver, rtype, branchID) " +
                "VALUES ('Requesting a ticket to attend this event: {0}', 0, '{1}', '{2}', NULL, 6, {3});", eventTitle, DateTime.Now.ToString(), currID, currBranchID);
            return dbMan.ExecuteNonQuery(query);
        }

        #endregion


        #region EventsAndMeetings

        // meetingType:
        // 0 for all upcoming meeting.
        // 1 for today's meetings
        // 2 for next week meetings.
        public DataTable GetMeetings(int meetingType)
        {
            string query = "SELECT BusinessMeeting.ID, title, mdescription, bdatetime, bname, blocation FROM BusinessMeeting JOIN Branch ON (BusinessMeeting.location_branch = Branch.ID) ";
            
            if (currID.Substring(0, 1) == "1")
                query += String.Format("JOIN MeetingAttendant ON (MeetingAttendant.meetingID = BusinessMeeting.ID) ");


            if (meetingType == 0)
                query += "WHERE bdatetime > SYSDATETIME()";
            else if (meetingType == 1)
                query += "WHERE CAST(bdatetime AS Date) = CAST(GETDATE() AS Date)";
            else
                query += "WHERE CAST(bdatetime AS Date) >= CAST(GETDATE() AS Date) AND CAST(bdatetime AS Date) < DATEADD(day, 7, CAST(GETDATE() AS Date))";


            // Showing all meetings to the owner, and to administrators only the ones they are attending.
            if (currID.Substring(0, 1) == "0")
                query += ";";
            else
                query += String.Format(" AND MeetingAttendant.ID = '{0}';", currID);

            return dbMan.ExecuteReader(query);
        }

        public DataTable GetAttendants(int meetingID)
        {
            string query = String.Format("SELECT CONCAT(pfirstname, ' ', plastname) AS pname, email " +
                "FROM (SELECT * FROM BusinessMeeting WHERE BusinessMeeting.ID={0}) AS meeting JOIN MeetingAttendant ON (meeting.ID = MeetingAttendant.meetingID) JOIN Person ON (MeetingAttendant.ID = Person.ID); ", meetingID);
            return dbMan.ExecuteReader(query);
        }

        public int CreateEvent(params parameterToAProcedure[] parameters)
        {
            string query = String.Format("INSERT INTO Eventt VALUES (@title, @edescription, 0, @ticket_price, @edatetime, @branchID);");
            return dbMan.ExecuteNonQuery(query, parameters);
        }


        public DataTable GetEvents(int eventType)
        {
            string query;

            // For readers.
            if (employeeType == 3)
            {
                //query = String.Format("SELECT Eventt.ID, title, edescription, edatetime, bname, blocation, x.ID AS attendantID FROM Eventt JOIN Branch ON (Eventt.branchID = Branch.ID) " +
                //    "LEFT OUTER JOIN(SELECT * FROM EventAttendant WHERE EventAttendant.ID = '{0}') AS x ON(Eventt.ID = x.EventID) " +
                //    "WHERE Eventt.branchID = {1} ", currID, currBranchID);

                query = string.Format("SELECT Eventt.ID, title, edescription, edatetime, bname, blocation, x.ID AS attendantID, y.requestID, y.rstatus, y.rtype " +
                    "FROM Eventt JOIN Branch ON(Eventt.branchID = Branch.ID) " +
                    "LEFT OUTER JOIN(SELECT * FROM EventAttendant WHERE EventAttendant.ID = '{0}') AS x ON(Eventt.ID = x.EventID) " +
                    "LEFT OUTER JOIN(SELECT * FROM EventRequests JOIN Request ON(EventRequests.requestID = Request.ID) WHERE Request.sender = '{0}') AS y " +
                    "ON (y.eventID = Eventt.ID) WHERE Eventt.branchID = {1} ", currID, currBranchID);


                if (eventType == 0)
                    query += "AND edatetime > SYSDATETIME();";
                else if (eventType == 1)
                    query += "AND CAST(edatetime AS Date) = CAST(GETDATE() AS Date);";
                else
                    query += "AND CAST(edatetime AS Date) >= CAST(GETDATE() AS Date) AND CAST(edatetime AS Date) < DATEADD(day, 7, CAST(GETDATE() AS Date));";
            }
            else if (employeeType == 0)
            {
                query = "SELECT Eventt.ID, title, edescription, edatetime, bname, blocation FROM Eventt JOIN Branch ON (Eventt.branchID = Branch.ID) ";
                if (eventType == 0)
                    query += "WHERE edatetime > SYSDATETIME();";
                else if (eventType == 1)
                    query += "WHERE CAST(edatetime AS Date) = CAST(GETDATE() AS Date);";
                else
                    query += "WHERE CAST(edatetime AS Date) >= CAST(GETDATE() AS Date) AND CAST(edatetime AS Date) < DATEADD(day, 7, CAST(GETDATE() AS Date));";
            }
            else
            {
                query = String.Format("SELECT Eventt.ID, title, edescription, edatetime, bname, blocation FROM Eventt JOIN Branch ON (Eventt.branchID = Branch.ID) WHERE Eventt.branchID = {0} ", currBranchID);
                if (eventType == 0)
                    query += "AND edatetime > SYSDATETIME();";
                else if (eventType == 1)
                    query += "AND CAST(edatetime AS Date) = CAST(GETDATE() AS Date);";
                else
                    query += "AND CAST(edatetime AS Date) >= CAST(GETDATE() AS Date) AND CAST(edatetime AS Date) < DATEADD(day, 7, CAST(GETDATE() AS Date));";

            }
            return dbMan.ExecuteReader(query);
        }

        #endregion



        #region Readers

        public DataTable GetReaders()
        {
            string query = "SELECT Person.ID, Person.email, Person.img, CONCAT(Person.pfirstname, ' ', Person.plastname) AS pname, Reader.subscribtion_start_date, CONCAT(Branch.bname, ' ', Branch.blocation) AS branchName, Branch.ID AS branchID FROM Reader JOIN Person ON (Reader.ID = Person.ID) JOIN Branch ON (Reader.branchID = Branch.ID);";
            return dbMan.ExecuteReader(query);
        }

        #endregion
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
