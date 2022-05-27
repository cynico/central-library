
-- ============================================================================= Emails ===================================================================================================================
/*
1) Procedure for getting all emails for a user.
   A union of two queries.
   
   The first gets the email of which this user is a receiver (and return etype attribute with value of 1, this attribute value is used
   at the application side).
   
   The second gets the email of which the user is a sender (and return etype attribute with a value of 0).
*/



USE centralLibrary;
GO
CREATE PROCEDURE SelectAllEmails @ID varchar(15)
AS
(SELECT Email.ID, Person.email, esubject, etext, vname, send_date,  pfirstname, plastname, 1 AS etype FROM Email JOIN Person ON (Email.sender = Person.ID) WHERE receiver=@ID AND visible_receiver = 1)
UNION ALL
(SELECT Email.ID, Person.email, esubject, etext, vname, send_date,  pfirstname, plastname, 0 AS etype FROM Email JOIN Person ON (Email.receiver = Person.ID) WHERE sender=@ID AND visible_sender = 1)
ORDER BY send_date;
GO


/*
2) Stored procedure for deleting a list of emails.

 This procedure takes a list of emails and deletes them in respect to the requesting user.
 
 It doesn't delete them from the database, it just hides them from that user, setting either
 visible_receiver to 0 if the user is a receiver of this email, 
 or it sets visible_sender to 0 if they are a sender. 
 
 Then it checks if both visible_sender, and visible_receiver are 0, 
 if they are, it deletes the email (no need to keep it if all parties involved have deleted it).

*/

USE centralLibrary;
GO
CREATE TYPE EmailIDList
AS TABLE
(
  ID INT PRIMARY KEY NOT NULL,
  partyType bit -- when it's 0 -> it indicates sender, 1 -> it indicates receiver

);
GO


CREATE PROCEDURE DeleteEmails @List AS EmailIDList READONLY
AS
  BEGIN TRANSACTION;
	  SET XACT_ABORT ON;
	  SET NOCOUNT ON;
	  UPDATE Email SET visible_sender=0 WHERE Email.ID IN (SELECT ID FROM @List WHERE partyType=0);
	  UPDATE Email SET visible_receiver=0 WHERE Email.ID IN (SELECT ID FROM @List WHERE partyType=1);
  
	  -- Deleting emails that all parties (sender and receiver) have opt out to delete.
	  DELETE FROM Email WHERE Email.ID IN (SELECT ID FROM @List) AND Email.visible_sender=0 AND Email.visible_receiver = 0;
  COMMIT;
GO

--- ======================================================================================= Business============================================================================================================

/*
1) Stored procedure for getting all the administrators with all of their personal and professional info.
*/

USE centralLibrary;
GO
CREATE PROCEDURE SelectAllAdm
AS
SELECT Person.ID, email, birthdate, img, gender, plastname, pfirstname, bname, hired_date, blocation, salary, Branch.ID AS branchID FROM Administrator JOIN Person ON (Administrator.ID = Person.ID) JOIN Employee ON (Person.ID = Employee.ID) JOIN Branch ON (Branch.ID = Employee.branchID);
GO

/*
2) Stored procedure for getting all the administrators a specific vendor is in contract with.
   In short, it gets the administrators of the branches with which the vendor is in contract (through the VendorBranch table).
*/

USE centralLibrary;
GO
CREATE PROCEDURE SelectAdminsnContractWith @vendorID varchar(15)
AS
BEGIN
	SELECT Person.ID, email, birthdate, img, gender, plastname, pfirstname, bname, hired_date, blocation, salary FROM VendorBranch JOIN Vendor ON (VendorBranch.VID = Vendor.ID)
	JOIN Employee ON (VendorBranch.branchID = Employee.branchID) JOIN Administrator ON (Employee.ID = Administrator.ID) JOIN Branch ON (VendorBranch.branchID = Branch.ID) WHERE VendorBranch.ID=@vendorID;
END
GO

/*
3) Stored procedure for adding a new administrator.
   Here, we start using the (TRANSACTION), and we 
   set XACT_ABORT ON;

   This ensures that if one of these queries fail, the whole patch will not execute.
   So that we don't end up with a new Person, and not a new Employee for example.
*/

USE centralLibrary;
GO
CREATE PROCEDURE AddAdministrator @ID varchar(15), @email varchar(64), @img varchar(60), @gender varchar(10), @ppassword varchar(60), @plastname varchar(10), @pfirstname varchar(10), @salary real, @hired_date Date, @branchID varchar(3), @birthdate Date
AS
BEGIN
	BEGIN TRANSACTION;
	SET XACT_ABORT ON;
		INSERT INTO Person (ID, email, img, gender, ppassword, plastname, pfirstname, birthdate) VALUES (@ID, @email, @img, @gender, @ppassword, @plastname, @pfirstname, @birthdate);
		INSERT INTO Employee VALUES (@ID, @salary, @hired_date, @branchID);
		INSERT INTO Administrator VALUES (@ID);
	COMMIT;
END
GO



/*
4) Stored procedure for getting all the librarians with all of their personal and professional info.
   If the branchID is -1 : meaning the owner is viewing all librarians, we return librarians of all branches.

   If it does have any other value, we return the librarians of this specific branch.
   (That happens when the administrators, librarians, or readers are viewing librarians of their own branch only).

*/

USE centralLibrary;
GO
CREATE PROCEDURE SelectAllLib @branch int
AS
BEGIN
	IF @branch = -1
	BEGIN
		SELECT Person.ID, email, birthdate, img, plastname, pfirstname, hired_date, salary, blocation, bname, Branch.ID AS branchID FROM Librarian JOIN Person ON (Librarian.ID = Person.ID) JOIN Employee ON (Person.ID = Employee.ID) JOIN Branch ON (Branch.ID = Employee.branchID);
	END

	ELSE
	BEGIN
		SELECT Person.ID, email, birthdate, img, plastname, pfirstname, hired_date, salary, blocation, bname, Branch.ID AS branchID FROM Librarian JOIN Person ON (Librarian.ID = Person.ID) JOIN Employee ON (Person.ID = Employee.ID) JOIN Branch ON (Branch.ID = Employee.branchID) WHERE Employee.branchID=@branch;
	END	
END
GO

/*
5) Stored procedure for adding a new librarian.
   Same as with the previous procedure (AddAdministrator).
*/

USE centralLibrary;
GO
CREATE PROCEDURE AddLibrarian @ID varchar(15), @email varchar(64), @img varchar(60), @gender varchar(10), @ppassword varchar(60), @plastname varchar(10), @pfirstname varchar(10), @salary real, @hired_date Date, @branchID int, @birthdate Date
AS
BEGIN
	BEGIN TRANSACTION;
		SET XACT_ABORT ON;
		INSERT INTO Person (ID, email, img, gender, ppassword, plastname, pfirstname, birthdate) VALUES (@ID, @email, @img, @gender, @ppassword, @plastname, @pfirstname, @birthdate);
		INSERT INTO Employee VALUES (@ID, @salary, @hired_date, @branchID);
		INSERT INTO Librarian VALUES (@ID);
	COMMIT;
END
GO


/*
6) Stored procedure for adding a new branch.
   First, it inserts a new branch.
   Then, it sets the branchID of the Employee given (in the adminID. This admin is typically unassigned to any branch. At least not yet)
   to this new branch's ID.

*/


USE centralLibrary;
GO
CREATE PROCEDURE addBranch @bname varchar(15), @blocation varchar(50), @numOfSubscribers int, @KPI float, @numOfStaff int, @established_at Date, @adminID varchar(15)
AS
BEGIN
	BEGIN TRANSACTION;
		SET XACT_ABORT ON;
		INSERT INTO Branch (bname, blocation, numOfSubscribers, KPI, numOfStaff, established_at) VALUES (@bname, @blocation, @numOfSubscribers , @KPI,  @numOfStaff , @established_at);
		UPDATE Employee SET branchID=(SELECT Branch.ID FROM Branch WHERE bname=@bname) WHERE ID=@adminID;
	COMMIT;
END
GO

/*
7) Stored procedure for adding a new reader.
   
    It fires when anyone signs up.

	It inserts the new person.
	Then it inserts them into the reader table BUT WITH AN ID THAT STARTS WITH 5.
	(Readers have ids that start with 3 not five).

	Lastly, it inserts the subscribtion request (with rtype of 5).
	Only when the request is accepted, will the reader id be updated to start with 3.


	When the reader tries to sign in before the request is accepted, on the application side
	it checks whether the id starts with 5, 
	if it does, it shows them that their request is still pending approval.

*/

USE centralLibrary;
GO

CREATE PROCEDURE AddReader @ID VARCHAR(15), @pfirstname VARCHAR(20), @plastname VARCHAR(20), @email VARCHAR(64), @gender VARCHAR(10), @birthdate Date, @ppassword VARCHAR(60), @branchID int
AS
BEGIN
	BEGIN TRANSACTION;
	SET XACT_ABORT ON;
		
		INSERT INTO Person (ID, email, pfirstname, plastname, gender, ppassword, img, birthdate) VALUES 
		(@ID, @email, @pfirstname, @plastname, @gender, @ppassword, 'nopicture.jpg', @birthdate);

		INSERT INTO Reader (ID, subscribtion_start_date, branchID) VALUES (@ID, NULL, @branchID);
		INSERT INTO Request (rtext, rstatus, send_date, sender, receiver, rtype, branchID) VALUES ('This is a request for subscribtion at your branch.', 0, SYSDATETIME(), @ID, NULL, 5, @branchID);

	COMMIT;
END
GO


/*
8) Stored procedure for removing a branch.
*/
USE centralLibrary;
GO
CREATE PROCEDURE RemoveBranch @branchID int 
AS
BEGIN
	BEGIN TRANSACTION;
	SET XACT_ABORT ON;
		
		
		DELETE FROM BooksBorrowed WHERE readerID IN (SELECT Reader.ID FROM Reader WHERE Reader.branchID=@branchID);

		DELETE FROM VendorBranch WHERE branchID=@branchID;
		DELETE FROM BookBranch WHERE branchID=@branchID;

		DELETE FROM FinanceRecords WHERE branchID=@branchID;

		-- deleting past events.
		DELETE FROM EventAttendant WHERE ID IN (SELECT EventAttendant.ID FROM EventAttendant JOIN Eventt ON (EventAttendant.eventID
		= Eventt.ID) WHERE Eventt.branchID=@branchID AND Eventt.edatetime < SYSDATETIME());
		DELETE FROM Eventt WHERE ID IN (SELECT ID FROM Eventt WHERE Eventt.branchID=@branchID AND Eventt.edatetime < SYSDATETIME());



		-- deleting upcoming events

		DECLARE @upcomingEventsList AS UpcomingEventIDList, @counter AS int;
		SET @counter = 1;

		DECLARE @temp AS MeetingIDList;
		INSERT INTO @temp (ID) SELECT ID FROM Eventt WHERE Eventt.branchID=@branchID AND Eventt.edatetime > SYSDATETIME();


		DECLARE @thisEventID AS int = (SELECT TOP 1 ID FROM @temp);
		DECLARE @thisEventTitle AS VARCHAR(100);
		
		WHILE @thisEventID != ''
		BEGIN
			SET @thisEventTitle = (SELECT title FROM Eventt WHERE Eventt.ID=@thisEventID);
			INSERT INTO @upcomingEventsList VALUES (@counter, @thisEventID, CONCAT('This event has been cancelled: ', @thisEventTitle, '.'));

			DELETE FROM @temp WHERE ID=@thisEventID;
			SET @thisEventID = (SELECT TOP 1 ID FROM @temp);
			SET @counter = @counter + 1;
		END

		EXEC DeleteUpcomingEvents @upcomingEventsList;




		DELETE FROM EventRequests WHERE requestID IN (SELECT ID FROM Request WHERE Request.branchID=@branchID); 
		DELETE FROM BooksRequests WHERE requestID IN (SELECT ID FROM Request WHERE Request.branchID=@branchID); 
		DELETE FROM VendingRequestsBooks WHERE requestID IN (SELECT ID FROM Request WHERE Request.branchID=@branchID);
		DELETE FROM Request WHERE branchID=@branchID;


		DELETE FROM MeetingAttendant WHERE ID IN (SELECT MeetingAttendant.ID FROM BusinessMeeting JOIN MeetingAttendant
		ON BusinessMeeting.ID=MeetingAttendant.meetingID WHERE BusinessMeeting.location_branch=@branchID);
		DELETE FROM BusinessMeeting WHERE location_branch=@branchID;

		-- disable foreign key constraint checking
		ALTER TABLE Transactions NOCHECK CONSTRAINT FK_Transactions_Branch_ID;  

		UPDATE Transactions SET branchID = -1 * branchID WHERE branchID=@branchID;
		
		-- disable re-enabling key constraint checking
		ALTER TABLE Transactions CHECK CONSTRAINT FK_Transactions_Branch_ID;  

		UPDATE Reader SET branchID = NULL WHERE branchID=@branchID;
		UPDATE Employee SET branchID = NULL WHERE branchID=@branchID;

		DELETE FROM Branch WHERE ID=@branchID;
END
	COMMIT;
GO
GO


--- ======================================================================================== Meetings =======================================================================================================

/*
1) Stored procedure for creating a business meeting.
   

   It's called whenever the owner creates a meeting.
   It takes what is called @List parameter of the user-defined type (below) attendantsIDs.

   This parameter has the ids of the admins that the owner requested attendance from.


*/


USE centralLibrary;
GO
CREATE TYPE attendantsIDS
AS TABLE
(
  ind int NOT NULL PRIMARY KEY,
  attendantID varchar(15)
);
GO
CREATE PROCEDURE CreateBusinessMeeting @List AS attendantsIDS READONLY, @title varchar(30), @mdescription varchar(140), @bdatetime DateTime, @sender varchar(15), @requesterID varchar(15), @requestID int, @location_branch int
AS
BEGIN
  SET NOCOUNT ON;
  BEGIN TRANSACTION;
  SET XACT_ABORT ON;
	  -- CREATING BUSINESS MEETING
	  		
			DECLARE @numOfAttendants AS int;
			SET @numOfAttendants = 1; 
			
			-- Initially, only the owner. And if anyone requested it, enlist them as well.
			IF @requesterID IS NOT NULL
			BEGIN
				SET @numOfAttendants = @numOfAttendants + 1;
			END
			

			INSERT INTO BusinessMeeting VALUES (@title, @mdescription, @numOfAttendants, @bdatetime, @location_branch);
			
			
	-- GETTIG THE ID OF THE (LATEST) CREATED BUSINESS MEETING;
			DECLARE @meetingID AS int;
			SET @meetingID = (SELECT TOP 1 ID FROM BusinessMeeting ORDER BY ID DESC);

			DECLARE @branch AS varchar(60);
			SET @branch = (SELECT CONCAT(bname, ', ', blocation) FROM Branch WHERE ID = @location_branch);



	-- IF SOMEONE REQUESTED THIS MEETING, INSERT THEM DIRECTLY INTO THE ATTENDANTS, DO NOT SEND THEM REQUESTS WITH THE REST.
			IF @requesterID IS NOT NULL
			BEGIN
				INSERT INTO MeetingAttendant VALUES (@requesterID, @meetingID);
			END

	-- ACCEPTING THEIR REQUEST
			IF @requestID IS NOT NULL
			BEGIN
				
				INSERT INTO notifications VALUES ('Business Meeting Request Accepted.', 'The owner has accepted your request for a business meeting', @requesterID, 0, SYSDATETIME());
				DELETE FROM Request WHERE ID=@requestID;

			END
			

			DECLARE @counter AS int;
			SET @counter = 1;
	  
	  -- SENDING REQUESTS TO ALL ADMINS TO ATTEND THIS MEETING.
	  -- FIRST DECLARING THE ID VARIABLE USED TO ITERATE OVER ALL ATTENDANTS, AND INITIALIZING IT TO THE FIRST ELEMENT.	
			
			DECLARE @thisAttendantID AS varchar(15);
			SET @thisAttendantID = (SELECT attendantID FROM @List WHERE ind=@counter);

	  -- LOOPING OVER ALL ATTENDANTS UNTIL THE LIST IS EMPTY.
			WHILE @thisAttendantID != ''
			BEGIN
				
				-- SENDING THE REQUEST.
				 INSERT INTO Request VALUES (CONCAT('You''r invited to attend a meeting on ', CONVERT(VARCHAR(20), @bdatetime, 0), ' at branch: ', @branch, '.', CAST(@meetingID AS varchar(10))), 0, SYSDATETIME(), @sender, @thisAttendantID, 1, NULL);

				-- GETTING THE NEXT ONE IN LINE.
				SET @counter = @counter + 1;
				SET @thisAttendantID = (SELECT attendantID FROM @List WHERE ind=@counter);
			END;
  COMMIT;
  
 END
GO


/*
2) Stored procedure for deleting a list of meetings.
   
	First it deletes all the meeting attendants from the MeetingAttendant table where the meeting is in this parameter list.
	Then it deletes all those selected meeting.

	The user-defined type MeetinIDList contains the ids of these meetings,
	and will be used in later procedure for other functionalities.
*/



USE centralLibrary;
GO
CREATE TYPE MeetingIDList
AS TABLE
(
  ID INT PRIMARY KEY NOT NULL
);
GO


CREATE PROCEDURE DeleteMeetings @List AS MeetingIDList READONLY
AS
BEGIN
  BEGIN TRANSACTION;
	  SET XACT_ABORT ON;
	  SET NOCOUNT ON;
	  
	  DELETE FROM MeetingAttendant WHERE MeetingAttendant.ID IN 
	  (SELECT MeetingAttendant.ID FROM BusinessMeeting JOIN MeetingAttendant ON (BusinessMeeting.ID = MeetingAttendant.meetingID) WHERE BusinessMeeting.ID IN (SELECT ID FROM @List));
	  DELETE FROM BusinessMeeting WHERE BusinessMeeting.ID IN (SELECT ID FROM @List);
  
  COMMIT;

END
GO


/*
3) Stored procedure for accepting a meeting attending request.
   (These request are sent by the owner to the administrators).\

   First it updates the request status to accepted (with rstatus of value 1).
   Then it inserts into the MeetingAttendant Table a row with this admin'd ID and the Id of the meeting.
   Lastly, it increments the number of attendants for the meeting.
   It notifies the owner that this specific admin has accepted their requests.
*/


USE centralLibrary;
GO
CREATE PROCEDURE AcceptAndAttendMeetings @requestID int, @meetingID int, @attendantID varchar(15)
AS
BEGIN
	BEGIN TRANSACTION;
		SET XACT_ABORT ON;
		SET NOCOUNT ON;
		
		DECLARE @ownerID AS VARCHAR(15) = (SELECT Person.ID FROM ouWuner JOIN Person ON (ouWuner.ID=Person.ID));
		DECLARE @adminName AS VARCHAR(50) = (SELECT CONCAT(pfirstname, ' ', plastname) FROM Person WHERE ID=@attendantID);

		INSERT INTO MeetingAttendant VALUES (@attendantID, @meetingID);
		UPDATE BusinessMeeting SET numOfAttendants = numOfAttendants + 1; 

		INSERT INTO notifications VALUES ('Meeting attendance request accepted', CONCAT(@adminName, ' has accepted your meeting request.'), @ownerID, 0, SYSDATETIME()); 
		DELETE FROM Request WHERE ID = @requestID;
	COMMIT;
END
GO


/*
4) Stored procedure for unattending a list of meeting.	

   Here, we use the user-defined type MeetingIDList created above.



   First it deletes from the MeetingAttendant table where the attendantID is the one given in the parametr @attendantID,
   and the meeting ID is in the list of the given meeting ids.
   
   Then, it fetches the ID of the owner to send him a notification,
   informing him that this admin has chosen not to attend any of these meetings.

*/
USE centralLibrary;
GO

CREATE PROCEDURE UnattendMeetings @List AS MeetingIDList READONLY, @attendantID varchar(15), @notificationContent text
AS
BEGIN
  BEGIN TRANSACTION;
	SET XACT_ABORT ON;
	SET NOCOUNT ON;

	DELETE FROM MeetingAttendant WHERE MeetingAttendant.ID = @attendantID AND MeetingAttendant.meetingID IN (SELECT ID FROM @List);
	UPDATE BusinessMeeting SET numOfAttendants = numOfAttendants - 1 WHERE BusinessMeeting.ID IN (SELECT ID FROM @List);
	
	DECLARE @ownerID AS VARCHAR(15);
	SET @ownerID = (SELECT TOP 1 Person.ID FROM Person JOIN ouWuner ON (Person.ID = ouWuner.ID));
	INSERT INTO notifications VALUES ('Meeting Unattendance', @notificationContent, @ownerID, 0, SYSDATETIME());
  
  COMMIT;
END
GO

--- ================================================================================= PROFILE ======================================================================================================


/*
1) Stored procedure for updating a profile of a general person
   There is not much to explain.
*/

USE centralLibrary;
GO
CREATE PROCEDURE UpdateProfile @ID varchar(15), @email varchar(64), @img varchar(60), @gender varchar(10), @plastname varchar(10), @pfirstname varchar(10), @birthdate Date
AS
BEGIN
	UPDATE Person SET 
					email=@email, 
					pfirstname=@pfirstname, 
					plastname=@plastname, 
					img=@img, 
					gender=@gender, 
					birthdate=@birthdate 
					WHERE ID=@ID;
END
GO


/*
2) Stored procedure for updating a profile of a vendor.
   This has to be used instead of the above one for vendors, because they are the only
   ones that can update their address and phone attributes.
   
   And have their name as one piece in the vname attribute while all the other users use pfirstname, and plastname.
*/

USE centralLibrary;
GO

CREATE PROCEDURE UpdateProfileVendor @ID varchar(15), @email varchar(64), @img varchar(60), @vname varchar(10), @paddress varchar(50), @phone varchar(15)
AS
BEGIN
	UPDATE Person SET 
					email=@email, 
					vname=@vname, 
					paddress=@paddress, 
					img=@img, 
					phone=@phone 
					WHERE ID=@ID;
END
GO


-- ======================================================================= Vendors ======================================================================================================= 

/*
1) Stored procedure for adding a new vendor.
   If the @initialBranchID is passed AS NULL, the vendor is only inserted in the Person table.
   If it's not, it's also inserted in the VendorBranch with this initial branch ID they are making a contract with.

*/

USE centralLibrary;
GO
CREATE PROCEDURE AddVendor @ID varchar(15), @vname varchar(50), @phone varchar(15), @paddress varchar(50), @email varchar(64), @vpassword varchar(60), @initialBranchID int
AS
BEGIN
	BEGIN TRANSACTION;
		SET XACT_ABORT ON;
		INSERT INTO Person (ID, vname, phone, paddress, email, ppassword) VALUES (@ID, @vname, @phone, @paddress, @email, @vpassword);
		
		IF @initialBranchID IS NOT NULL
		BEGIN
			INSERT INTO VendorBranch (VID, branchID, contract_date) VALUES (@ID, @initialBranchID, GETDATE());
		END
	
	COMMIT;
END
GO

/*
2) A view of all the vendors tied to the branches they are in contract with.
   Its use is explained in the next procedure.

*/

USE centralLibrary;
GO
CREATE VIEW VendorBranchForTheOwner AS

SELECT Person.ID AS ID, vname, phone, paddress, email, img, bname 
FROM Person LEFT OUTER JOIN VendorBranch ON (Person.ID = VendorBranch.VID) LEFT OUTER JOIN Branch ON (VendorBranch.branchID = Branch.ID) WHERE Person.ID LIKE '4%';

GO


/*
 3) This procedure is only for the following: getting each vendor with the names of branches they vend for concatenated in one string.
 Like The following: ID, vname, vaddress, 'Cairo-1,Cairo-2,Cairo-3'
 It only helps in displaying them for the owner.
 It saves time of running a query for each of them to fetch the branch names they vend for.
 It uses the view created above. The view is a simple join of the tables: Vendor, VendorBranch, and Branch.
 */

USE centralLibrary;
GO
CREATE PROCEDURE GetVendorBranches AS
BEGIN
	SELECT Main.ID, Main.vname, Main.phone, Main.paddress, Main.email, Main.img, LEFT(Main.bname, Len(Main.bname)-1) AS "bname"
	FROM
	(
	SELECT DISTINCT VD2.ID,
	(
		SELECT VD1.bname + ', ' AS [text()]
		FROM VendorBranchForTheOwner AS VD1
		WHERE VD1.ID = VD2.ID
		ORDER BY VD1.ID
		FOR XML PATH (''), TYPE
	).value('text()[1]', 'nvarchar(max)') [bname], VD2.vname, VD2.phone, VD2.paddress, VD2.email, VD2.img 
	FROM VendorBranchForTheOwner AS VD2
	) AS Main;
END
GO



/*
 4) This procedure is for ending a vendor's contract with a branch.
    First it deletes them from the VendorBranch table.

	Then, it checks if they have any contracts with any other branch (through counting the rows in the VendorBranch here VID=theirID)
	If the count=0, that means they have no contracts with any other branches, and the admin is notified and given the choice to delete them
	altogether if they want.

 */


CREATE PROCEDURE DeleteVendorBranch @VID varchar(15), @branchID int
AS
BEGIN

	BEGIN TRANSACTION;
	SET XACT_ABORT ON;
		-- Delete them from this branch.
		DELETE FROM VendorBranch WHERE VendorBranch.VID=@VID AND VendorBranch.branchID=@branchID;

		-- Check if they aren't working with any other branches, if not: notify the owner
		DECLARE @count AS int = (SELECT COUNT(*) FROM VendorBranch WHERE VendorBranch.VID=@VID);

		IF @count = 0
		BEGIN
		DECLARE @ownerID AS varchar(15) = (SELECT Person.ID FROM Person JOIN ouWuner ON (Person.ID = ouWuner.ID));
		DECLARE @vendorName AS varchar(50) = (SELECT vname FROM Person WHERE ID=@VID); 
		INSERT INTO notifications VALUES ('Vendor pending deletion', CONCAT('The vendor ', @vendorName, ' has had their contracts ended in all branches.\nIf you like, you can head to the vendors tab to delete their info.'), @ownerID, 0, SYSDATETIME());
		END
	COMMIT
END
GO


/*
 5) This procedure is for requesting a list of books from the vendor
	Its parameters:

	@List => of the BookRequestedList user-defined type. This type has three attributes:
			 ind => a counter index going from 1 to number of requested books.
			 bookISBN => ISBN of this book
			 numOfCopies => the number of copies requested for this book.

    @vendorID => The ID of the vendor to whom this is a request.
	@senderID => The ID of the requester. (So far, only admins).
	@branchID => The branch ID of the requester.


	What it does:
	1. It inserts into the Request table a new request with rtype of 0 (vending request).
	2. It fetches this newly inserted request id into the @requestID variable.
	3. It starts looping through the @List parameter, and for each book it does the following:
	   - Inserts it into the VendingRequestsBooks table (requestID, ISBN, numberOfCOpies)
	4. It gets the next book in the list and does the same till the end of the list.

 */

CREATE TYPE BookRequestedList
AS TABLE
(
  ind int NOT NULL PRIMARY KEY,
  bookISBN varchar(30) NOT NULL,
  numOfCopies int  
);
GO

USE centralLibrary;
GO
CREATE PROCEDURE VendingRequest @List BookRequestedList READONLY, @vendorID varchar(15), @senderID varchar(15), @branchID int
AS
BEGIN
	BEGIN TRANSACTION;
	SET XACT_ABORT ON
		
		-- INSERT REQUEST

		DECLARE @temp AS TABLE (ID INT);

		INSERT INTO Request OUTPUT INSERTED.ID INTO @temp(ID) VALUES ('Requesting these books.', 0, SYSDATETIME(), @senderID, @vendorID, 0, @branchID);
		DECLARE @requestID AS int = (SELECT TOP 1 ID FROM @temp);

		-- INSERTING BOOKS TIED TO THE REQUEST.
		DECLARE @counter AS int = 1;
		DECLARE @thisBookISBN AS varchar(30) = (SELECT bookISBN FROM @List WHERE ind = @counter);
		DECLARE @thisBookNumOfCopies  AS int = (SELECT numOfCopies FROM @List WHERE ind = @counter);
		
		WHILE @thisBookISBN != ''
		BEGIN	
			INSERT INTO VendingRequestsBooks VALUES (@requestID, @thisBookISBN, @thisBookNumOfCopies);
			SET @counter = @counter + 1;
			SET @thisBookISBN = (SELECT bookISBN FROM @List WHERE ind = @counter);
			SET  @thisBookNumOfCopies = (SELECT numOfCopies FROM @List WHERE ind = @counter);
		END


END
	COMMIT;
GO


/*
 6) This procedure is for accpting a vendor contract request. 
	Its parameters are:
		@vendorID => ID of the vendor.
		@requestID => The request (done by an admin, accepted by the vendor) of contract.
		@branchID => The branch of the admin requesting the contract.
		@vname => The name of the vendor

	It does the following:
	1. It inserts into the VendorBranch a new row.
	2. It updates the requests rstatus to accepted (value of 1)
	3. It inserts a new notification notifying the admin that the vendor has accepted their contract requesst.

 */

CREATE PROCEDURE MakeContract @vendorID varchar(15), @requestID int, @adminID varchar(15), @branchID int, @vname varchar(50)
AS
BEGIN
	BEGIN TRANSACTION;
	SET XACT_ABORT ON;
		
		INSERT INTO VendorBranch VALUES (@vendorID, @branchID, GETDATE());
		INSERT INTO notifications (title, content, receiver, seen, ntimestamp) VALUES ('Vendor Accepted Contract Request', CONCAT('Vendor ', @vname, ' accepted your contract request.'), @adminID, 0,SYSDATETIME());
		DELETE FROM Request WHERE Request.ID=@requestID;
	COMMIT;

END
GO

/*
 6) This procedure is for accpting a vending request. 
	Its parameters are:
		@requestID => The request (done by an admin, accepted by the vendor) of vending.
		@vendorName => The name of the vendor

	It does the following:
	1. It fetches the ID of the admin who requested, their branch
	2. It starts fetching all the books associated with this request, and the number of copies requested
		For each book it does the following:
			- If the book exists in that branch, it simply increments the number of copies available by the amount specified in the row from VendingRequestsBooks
			- If it doesn't, it inserts a new row into the BookBranch, and set the initial number of copies to the amount speicified.....
			- Lastly, it deletes it from the VendingRequestsBooks, and fetches the next one in line
	3. When it's done, it ensures that all books tied to this request are indeed deleted from the VendingRequestsBooks
	4. It updates the request rstatus to accepted (value of 1).
	5. It notifies the admin that their vending request has been accepted.
*/


USE centralLibrary;
GO
CREATE PROCEDURE AcceptVendingRequest @requestID int, @vendorName varchar(50)
AS
BEGIN
	BEGIN TRANSACTION;
	SET XACT_ABORT ON;
		
		DECLARE @adminID AS varchar(15) = (SELECT sender FROM Request WHERE Request.ID = @requestID);
		DECLARE @branchID AS  int = (SELECT branchID FROM Request WHERE Request.ID = @requestID);
		
		DECLARE @thisBookISBN AS varchar(15) = (SELECT TOP 1 bookISBN FROM VendingRequestsBooks WHERE requestID = @requestID);
		DECLARE @thisBookNumOfCopies AS varchar(15) = (SELECT numberOfCopies FROM VendingRequestsBooks WHERE
			requestID=@requestID AND bookISBN=@thisBookISBN);

		DECLARE @thisBookExistingCount AS int;

		WHILE @thisBookISBN != ''
		BEGIN
			SET @thisBookExistingCount = (SELECT COUNT(*) FROM BookBranch WHERE BookBranch.ISBN = @thisBookISBN  AND BookBranch.branchID = @branchID);
			
			-- If this book doesn't exist in the branch, insert it
			IF @thisBookExistingCount = 0
			BEGIN
				INSERT INTO BookBranch VALUES (@thisBookISBN, @branchID, 0, @thisBookNumOfCopies);
			END
			ELSE
			BEGIN
				UPDATE BookBranch SET numberOfAvailableCopies = numberOfAvailableCopies + @thisBookNumOfCopies, numOfRequests = 0;
			END

			DELETE FROM VendingRequestsBooks WHERE requestID=@requestID AND bookISBN=@thisBookISBN;

			SET @thisBookISBN  = (SELECT TOP 1 bookISBN FROM VendingRequestsBooks WHERE requestID = @requestID);
			SET @thisBookNumOfCopies = (SELECT numberOfCopies FROM VendingRequestsBooks WHERE requestID=@requestID AND bookISBN=@thisBookISBN);

		END

		DELETE FROM VendingRequestsBooks WHERE VendingRequestsBooks.requestID = @requestID;
		-- NOTIFYING ADMIN
		INSERT INTO notifications VALUES ('Vending Request Accepted', CONCAT('The vending request you made to vendor: ', @vendorName, ', has been accepted. Books have been deliverd and number of copies updated.'), @adminID, 0, SYSDATETIME());
	
		DELETE FROM Request WHERE Request.ID = @requestID;

	COMMIT;
END
GO


/*
 7) This procedure is for rejecting a vending request. 
	Its parameters are:
		@requestID => The request (done by an admin, accepted by the vendor) of vending.
		@vendorName => The name of the vendor

	It does the following:
	1. It fetches the ID of the admin who requested, their branch
	2. It deletes all books tied to this request from the VendingRequestsBooks
	3. It updates the request rstatus to rejected (value of 2).
	4. It notifies the admin that their vending request has been rejected.
*/

USE centralLibrary;
GO
CREATE PROCEDURE RejectVendingRequest @requestID int, @vendorName varchar(50)
AS
BEGIN
	BEGIN TRANSACTION;
	SET XACT_ABORT ON;
		
		DECLARE @adminID AS varchar(15) = (SELECT sender FROM Request WHERE Request.ID = @requestID);
		DECLARE @branchID AS  int = (SELECT branchID FROM Request WHERE Request.ID = @requestID);

		DELETE FROM VendingRequestsBooks WHERE VendingRequestsBooks.requestID = @requestID;
		-- NOTIFYING ADMIN
		INSERT INTO notifications VALUES ('Vending Request Rejected', CONCAT('The vending request you made to vendor: ', @vendorName, ', has been rejected. Books have been deliverd and number of copies updated.'), @adminID, 0, SYSDATETIME());
		DELETE FROM Request WHERE Request.ID = @requestID;
	COMMIT;
END
GO



/*
 8) 
	This trigger is used for multiple purposes.
	It fires whenever a request status is updated. It fetches the request type into @requestType variable, and does
	different things according to its type


	
	1. IF THIS IS A RESIGNATION REQUEST:

		=> If the request is accepted:
			- It deletes the sender of the reqeuest (the one resigning) from the Person table.
		=> If it's rejected:
			- It notifies them that their request is rejected.


	2. If this a subscribtion requested:
		
		=> If the request is accepted it does the following:
			- Updates the reader id to start with the digit 3 instead of 5.
			- Inserts a new transaction with the subscribtion fee (constant 100 pounds for now)
			- Increments the number of subscribers of the branch.
		
		=> If the request is rejected:
			- Deletes the reader from the Person table (cascades by default to the Reader table).

*/


USE centralLibrary;
GO
CREATE TRIGGER OnRequestAcceptOrReject ON Request FOR UPDATE
AS
BEGIN
	BEGIN TRANSACTION;
	SET XACT_ABORT ON;

		DECLARE @requestType AS INT, @requestID AS INT, @requestStatus AS INT, @senderID AS VARCHAR(15), @receiverID AS VARCHAR(15), @receiverName varchar(50), @branchID int;
		
		SELECT @requestType = ins.rtype FROM INSERTED AS ins;
		SELECT @requestID = ins.ID FROM INSERTED AS ins;
		SELECT @requestStatus = ins.rstatus FROM INSERTED AS ins;
		SELECT @senderID = ins.sender FROM INSERTED AS ins;
		SELECT @receiverID = ins.receiver FROM INSERTED AS ins;
		SELECT @branchID = ins.branchID FROM INSERTED AS ins;

		-- If it doesn't have a NULL receiver, as is the case with the request of type 5  (subscribtion request)
		IF @requestType != 5
		BEGIN
			SELECT @receiverName = CONCAT(pfirstname, ' ', plastname) FROM INSERTED AS ins JOIN Person ON (Person.ID = ins.receiver);
		END

		-- IF THIS IS A RESIGNATION REQUEST
		IF @requestType = 2
		BEGIN
			-- IN CASE IT IS ACCEPTED.
			IF @requestStatus = 1
			BEGIN
				DELETE FROM Person WHERE ID = @senderID;
			END

			-- IN CASE IT IS REJECTED.
			ELSE
			BEGIN
				INSERT INTO notifications VALUES 
				('Resignation request refused.', CONCAT('Your resignation request has been refused by: ', @receiverName, '.'), @senderID, 0, SYSDATETIME());
			END
		
			DELETE FROM Request WHERE ID=@requestID;
		END


		-- IF THIS IS A SUBSCRIBTION REQUEST
		IF @requestType = 5
		BEGIN
			
			IF @requestStatus = 1
			BEGIN

				DECLARE @newReaderID AS VARCHAR(15) = (SELECT SUBSTRING(@senderID, 2, 14)); 
				SET @newReaderID = CONCAT('3', @newReaderID);

				-- update id of reader
				UPDATE Person SET ID = @newReaderID WHERE ID = @senderID;

				-- insert into transactions
				INSERT INTO Transactions (ttype, ttimestamp, tvalue, branchID, authorizedBy, initiatedBy) VALUES (5, SYSDATETIME(), 100, @branchID, @receiverID, @newReaderID);

				-- update number of subscribers in the branch.
				UPDATE Branch SET numOfSubscribers = numOfSubscribers + 1 WHERE ID=@branchID;

			END

			ELSE
			BEGIN
				DELETE FROM Person WHERE ID = @senderID;
			END
			DELETE FROM Request WHERE ID=@requestID;
		END


	COMMIT;
END
GO

--- =================================================================================== Notifications =============================================================================================================================

/*
1) Procedure for marking a list of notification as seen.
   (Refer above to the definition of the user-defined type MeetingIDList)
*/


USE centralLibrary;
GO

CREATE PROCEDURE MarkAsSeen @List MeetingIDList READONLY AS
	BEGIN TRANSACTION
	SET XACT_ABORT ON;
		UPDATE notifications SET seen = 1 WHERE notifications.ID IN (SELECT ID FROM @List);
	COMMIT;
GO

--- ===============================================================================================================================================================================================================================

/* TRIGGERS ON DELETING EMAILS AND REQUESTS
   The use of this trigger is the following:

   Both email and request has two attributes (sender, and receiver), which reference
   the same table (Person).
   
   It's forbidden to set both foreign keys to be cascading on deletion,
   because that my caus 'multiple cascading cycles/paths.'.

   Thus, in these tables, only receivers foregin key are set to be cascadibng.
   What about sender?

   Well, this trigger fires whenever a delete operation is done on the Person table.
   Instead of the deleting actaully happening, this trigger fires.

   What it does is the following:
   - First, it deletes all email that this person was a sender of.
   - Same with requests.
   - Same with notifictions (this was not strictly necessary, because notifications have only one attribute referencing Person)

   Then lastly, it deletes this person.


   The person intended for deletion is availabe in the DELETED keyword (by the sql sever engine).
*/


USE centralLibrary;
GO
CREATE TRIGGER DELETE_SENDER_EMAIL_REQUEST ON Person INSTEAD OF DELETE
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @deletedID AS varchar(15) = (SELECT ID FROM DELETED);
	DELETE FROM Email WHERE Email.sender = @deletedID;
	DELETE FROM Request WHERE Request.sender = @deletedID;
	DELETE FROM notifications WHERE receiver = @deletedID;
	DELETE FROM Person WHERE ID = @deletedID;

END
GO

-- ======================================================================================================= Books ===================================================================================================================


/*
1) Procedure for reader requesting a book that is not available.
     It checks whether this books exists in this branch at all 
	 by checking the number of rows in the table (BookBranch) 
	 with this book and this branch.
	 
	 If the count of rows is zero (the book doesn't yet exist in this branch), 
	 it inserts it into the BookBranch table and sets the numOfRequests to 1.

	 If the count of rows is not zero, meaning that the book already exists, 
	 it just increments the numOfRequests.
*/

USE centralLibrary;
GO
CREATE PROCEDURE RequestBook @bookISBN varchar(15), @branchID int
AS
BEGIN
	BEGIN TRANSACTION;
	SET XACT_ABORT ON;
		
		DECLARE @count AS int = (SELECT COUNT(*) FROM BookBranch WHERE branchID=@branchID AND
		ISBN=@bookISBN);

		IF @count = 0
		BEGIN
			-- 1 number of requests, 0 number of copies.
			INSERT INTO BookBranch VALUES (@bookISBN, @branchID, 1, 0);
		END
		ELSE
		BEGIN
			UPDATE BookBranch SET numOfRequests = numOfRequests + 1 WHERE branchID=@branchID AND ISBN=@bookISBN;
		END

	COMMIT;
END
GO

/*
2) Procedure for inserting a new book.
   It receives all the relevant info as parametrs, and inserts it into the Book table.
   
   If the @branchID parameter is -1, that means just inserting the book without tying it 
   to any branch (like when the owner inserts a book).

   If the @branchID parameter has any other value,
   it inserts it first into the Book Table
   then into the BookBranch table with the specifed branchID, and the specified initial number of available copies.

*/


USE centralLibrary;
GO
CREATE PROCEDURE AddBook @bookISBN varchar(15), @authorID int, @pubID int, @language varchar(15), @title varchar(50), 
						@category varchar(15), @publicationDate Date, @price float, @img varchar(60), @branchID int,
						@numberOfAvailableCopies int
AS
BEGIN
	BEGIN TRANSACTION;
	SET XACT_ABORT ON;
		INSERT INTO Book VALUES (@bookISBN, @title, @category, @language, @publicationDate, @price, @authorID, @pubID, @img);
		
		IF @branchID != -1
		BEGIN
			INSERT INTO BookBranch VALUES (@bookISBN, @branchID, 0, @numberOfAvailableCopies);
		END
	COMMIT;
END
GO

/*
3) Procedure for updating number of availble copies of a book in a branch.
   Just like adding a book in the procedure number 1 above (in the books section),
   it checks whether the book exists in the first place in this branch.

   If it does, it updates the number of copies.
   If it doesn't, it inserts it with the given number of copies.
*/



USE centralLibrary;
GO
CREATE PROCEDURE UpdateNumberOfCopies @branchID int, @bookISBN varchar(15), @numberOfCopies int
AS
BEGIN
	BEGIN TRANSACTION;
	SET XACT_ABORT ON;

		DECLARE @count AS int = (SELECT COUNT(*) FROM BookBranch WHERE ISBN=@bookISBN AND branchID=@branchID);
		IF @count != 0
		BEGIN
			UPDATE BookBranch SET numberOfAvailableCopies = @numberOfCopies WHERE branchID=@branchID AND ISBN=@bookISBN;
		END
		ELSE
		BEGIN
			INSERT INTO BookBranch VALUES (@bookISBN, @branchID, 0, @numberOfCopies);
		END
	COMMIT;
END
GO

/*
4) Procedure for requesting a book for borrowing by the reader.
   First, it inserts the request with type of 4 (borrowing).
   Then it gets this newly inserted request's id into the @requestID variable.
   Lastly, it inserts into the BooksRequests a row with this requestID, and this bookISBN.
*/

CREATE PROCEDURE RequestBookForBorrowing @bookISBN VARCHAR(30), @requesterID varchar(15), @bookTitle VARCHAR(50), @branchID int
AS
BEGIN
	BEGIN TRANSACTION;
	SET XACT_ABORT ON;

		DECLARE @temp AS TABLE (ID INT);
		
		INSERT INTO Request (rtext, rstatus, send_date, sender, receiver, rtype, branchID) 
		OUTPUT INSERTED.ID INTO @temp(ID) VALUES (CONCAT('Requesting this book for borrowing: ', @bookTitle), 0, SYSDATETIME(), @requesterID, NULL, 4, @branchID) ;

		DECLARE @requestID AS int = (SELECT TOP 1 ID FROM @temp);
		INSERT INTO BooksRequests (requestID, bookISBN) VALUES (@requestID, @bookISBN);


	COMMIT;

END
GO

/*
5) Procedure for accepting a borrow request.

   First, it updates the request status to accepted (rstatus value of 1), and sets the receiver attribute of the request to the ID 
   of the librarian who accepted it (The ID is given in the parameters with the name of @authorizerr)
   *** EDITED: Now it deletes the request. I don't think there's need to keep the request any longer. ***
   
   Secondly, it inserts into the transaction a new one with type of 4 (borrowing),
   the value of the price of the book,
   the authorziedBy -> id of librarian,
   the initiatedBy -> the id of the borrower.

   Thridly, it decrements the available number of copies of this book in that branch.

   Lastly, it notifies the reader that his borrowing request has been accepted.

*/
USE centralLibrary;
GO
CREATE PROCEDURE AcceptBorrowBook @requestID int, @authorizer varchar(15), @branchID int, @authorizerName VARCHAR(50)
AS
	BEGIN TRANSACTION;
	SET XACT_ABORT ON;

		-- accept request
		-- add transaction
		-- add book borrowed
		-- update number of available copies

		DECLARE @requesterID AS VARCHAR(15) = (SELECT sender FROM Request WHERE Request.ID=@requestID);
		
		

		DECLARE @bookISBN AS VARCHAR(30) = (SELECT bookISBN FROM BooksRequests WHERE requestID=@requestID);		
		
		DECLARE @price AS real = (SELECT price FROM Book WHERE ISBN=@bookISBN);

		DECLARE @bookTitle AS VARCHAR(50) = (SELECT title FROM Book WHERE ISBN=@bookISBN);


		INSERT INTO Transactions (ttype, ttimestamp, tvalue, branchID, authorizedBy, initiatedBy) VALUES (4, SYSDATETIME(), @price, @branchID, @authorizer, @requesterID);
		
		INSERT INTO BooksBorrowed (readerID, bookISBN, returnDate) VALUES (@requesterID, @bookISBN, DATEADD(DAY,3,GETDATE()));
		
		UPDATE BookBranch SET numberOfAvailableCopies = numberOfAvailableCopies - 1 WHERE branchID=@branchID AND ISBN=@bookISBN;
		
		INSERT INTO notifications (title, content, receiver, seen, ntimestamp) VALUES ('Borrow request approved.', CONCAT('Your request for borrowing the book: "', @bookTitle, '" has been approved by: ', @authorizerName, '.'), 
		@requesterID, 0, SYSDATETIME());

		DELETE FROM BooksRequests WHERE bookISBN=@bookISBN AND requestID=@requestID;
		DELETE FROM Request WHERE ID=@requestID;


	COMMIT;
GO


/*
6) Procedure for rejecting a borrow request.

   First, it updates the request status to rejected (rstatus value of 2), and sets the receiver attribute of the request to the ID 
   of the librarian who rejected it (The ID is given in the parameters with the name of @authorizerr)
   *** EDITED: Now it deletes the request. I don't think there's need to keep the request any longer. ***

   
   Secondly, it notifies the reader that his borrowing request has been rejected.

   Lastly, it deletes from the BooksRequests table the row associated with this request.

*/
USE centralLibrary;
GO
CREATE PROCEDURE RejectBorrowBook @requestID int, @authorizer varchar(15), @branchID int, @authorizerName VARCHAR(50)
AS
BEGIN
	BEGIN TRANSACTION;
	SET XACT_ABORT ON;

		DECLARE @requesterID AS VARCHAR(15) = (SELECT sender FROM Request WHERE Request.ID=@requestID);
		DECLARE @bookISBN AS VARCHAR(30) = (SELECT bookISBN FROM BooksRequests WHERE requestID=@requestID);		

		DECLARE @price AS real = (SELECT price FROM Book WHERE ISBN=@bookISBN);
		DECLARE @bookTitle AS VARCHAR(50) = (SELECT title FROM Book WHERE ISBN=@bookISBN);


		INSERT INTO notifications (title, content, receiver, seen, ntimestamp) VALUES ('Borrow request rejected.', CONCAT('Your request for borrowing the book: "', @bookTitle, '" has been rejected by: ', @authorizerName, '.'), 
		@requesterID, 0, SYSDATETIME());

		DELETE FROM BooksRequests WHERE bookISBN=@bookISBN AND requestID=@requestID;

		DELETE FROM Request WHERE ID=@requestID;

	COMMIT;
END
GO




-- ======================================================================================================= Events ===================================================================================================================

/*
1) Stored procedure for deleting an event and their attendants.
   This procedure is used to delete a list of upcoming events.

  @List => It takes the @List parameter of the user-defined type UpcomingEventIDList.
           It's a table of events' IDs, some text attribute, and an index as a primary key (going from 1 to the number of events).



   It loops through the list with @counter variable,
   inserts a row into the EventsDummyTable (an explanation of why is in the next trigger below) with the eventID, and the etext attribute
   then it deletes the event from the Eventt table.


*/


USE centralLibrary;
GO

CREATE TYPE UpcomingEventIDList
AS TABLE
(
  ind int NOT NULL PRIMARY KEY,
  eventID int NOT NULL,
  etext varchar(140) -- This is created at the application side, and passed to be concatenated in the 
--			 -- content of the notifications sent to the users.
);
GO

CREATE PROCEDURE DeleteUpcomingEvents @List AS UpcomingEventIDList READONLY
AS
BEGIN
  BEGIN TRANSACTION;
	  SET XACT_ABORT ON;
	  SET NOCOUNT ON;

	  DECLARE @counter AS int = 1;
	  
	  DECLARE @thisEventID AS int = (SELECT eventID FROM @List WHERE ind = @counter);
	  DECLARE @thisEventText AS varchar(140) = (SELECT etext FROM @List WHERE ind = @counter);



	  -- Looping over all events, and inserting them into the dummy table.
	  -- Causing a trigger to fire.
	  WHILE @thisEventText != ''
	  BEGIN

	  INSERT INTO EventsDummyTable VALUES(@thisEventID, @thisEventText, SYSDATETIME());

	  -- Incrementing and getting the next event.
	  SET @counter = @counter + 1;
	  SET @thisEventID = (SELECT eventID FROM @List WHERE ind = @counter);
	  SET @thisEventText = (SELECT etext FROM @List WHERE ind = @counter);
	  
	  END

	  DELETE FROM Eventt WHERE Eventt.ID IN (SELECT eventID FROM @List);
  COMMIT;
 END
GO


/*
2) Trigger for notifying event attendants that an event has been cancelled.
   It fires whenever the EventsDummyTable is inserted into. (See the above procedure).

   It sends a notification to all the event attendants 
   (gets the eventID from the EventsDummyTable newly inserted row, which is accessed through the INSERTED keyword, and 
   gets the content of the notification of the etext attribute of the row).

	After sending to each attendant, it deletes them from the EventAttendant table.

	Lastly, it deletes the newly inserted row in EventsDummyTable.

*/

USE centralLibrary;
GO
CREATE TRIGGER NotifyAttendantsOfEventCancellation ON EventsDummyTable AFTER INSERT
AS 
BEGIN
	SET NOCOUNT ON;
	DECLARE @EventID AS int = (SELECT eventID FROM INSERTED);
	DECLARE @content AS varchar(140) = (SELECT content FROM INSERTED);
	DECLARE @scancellationDate AS DateTime = (SELECT cancellationDate FROM INSERTED);

	DECLARE @toNotify AS varchar(15) = (SELECT TOP 1 ID FROM EventAttendant WHERE EventID=@EventID);

	WHILE @toNotify != ''
	BEGIN	
		INSERT INTO notifications VALUES ('Event Cancelled', @content, @toNotify, 0, SYSDATETIME());
		DELETE FROM EventAttendant WHERE ID=@toNotify AND EventID=@EventID;
		SET @toNotify = (SELECT TOP 1 ID FROM EventAttendant WHERE EventID=@eventID);
	END

	DELETE FROM EventsDummyTable WHERE eventID=@EventID;

END
GO


/*
3) Procedure for requesting to attend an event by the reader.
   First, it inserts the request with type of 6 (event attending).
   Then it gets this newly inserted request's id into the @requestID variable.
   Lastly, it inserts into the EventRequests a row with this requestID, and this eventID.

*/



USE centralLibrary;
GO
CREATE PROCEDURE RequestEventAttendance @eventID int, @eventTitle VARCHAR(50), @requesterID VARCHAR(15), @branchID int
AS
BEGIN
	BEGIN TRANSACTION;
	SET XACT_ABORT ON;

		DECLARE @temp AS TABLE (ID INT);

		INSERT INTO Request (rtext, rstatus, send_date, sender, receiver, rtype, branchID) 
		OUTPUT INSERTED.ID INTO @temp(ID) VALUES (CONCAT('Requesting a ticket to attend this event: ', @eventTitle), 0, SYSDATETIME(), @requesterID, NULL, 6, @branchID);
			
		DECLARE @requestID AS int = (SELECT TOP 1 ID FROM @temp);
			
		INSERT INTO EventRequests VALUES (@requestID, @eventID);

	COMMIT;
END
GO


USE centralLibrary;
GO
CREATE PROCEDURE RequestToUnattendAnEvent @eventID int, @eventTitle VARCHAR(50), @requesterID VARCHAR(15), @branchID int
AS
BEGIN
	BEGIN TRANSACTION;
	SET XACT_ABORT ON;

		DECLARE @temp AS TABLE (ID INT);

		INSERT INTO Request (rtext, rstatus, send_date, sender, receiver, rtype, branchID) 
		OUTPUT INSERTED.ID INTO @temp(ID) VALUES (CONCAT('Requesting a refund for this event ticket: ', @eventTitle), 0, SYSDATETIME(), @requesterID, NULL, 7, @branchID);
			
		DECLARE @requestID AS int = (SELECT TOP 1 ID FROM @temp);
			
		INSERT INTO EventRequests VALUES (@requestID, @eventID);

	COMMIT;
END
GO



/*
4) Procedure for accepting event attendance request.

*/


USE centralLibrary;
GO
CREATE PROCEDURE AcceptEventAttendanceRequest @requestID int, @requesterID VARCHAR(15), @branchID int, @authorizer VARCHAR(15)
AS
BEGIN
	BEGIN TRANSACTION;
	SET XACT_ABORT ON;

		DECLARE @eventID AS int, @price AS real, @eventTitle AS VARCHAR(50);
		SET @eventID = (SELECT eventID FROM EventRequests WHERE requestID=@requestID);
		SET @price = (SELECT ticket_price FROM Eventt WHERE ID=@eventID);
		SET @eventTitle = (SELECT title FROM Eventt WHERE ID=@eventID);


		INSERT INTO EventAttendant (ID, eventID) VALUES (@requesterID, @eventID);
		INSERT INTO Transactions (ttype, ttimestamp, tvalue, branchID, authorizedBy, initiatedBy) VALUES (6, SYSDATETIME(), @price, @branchID, @authorizer, @requesterID);
		INSERT INTO notifications VALUES ('Event attendance request accepted', CONCAT('Your request to attend the event: ''', @eventTitle, ''' has been accepted.'), @requesterID, 0, SYSDATETIME());
		DELETE FROM EventRequests WHERE requestID=@requestID AND eventID=@eventID;
		UPDATE Eventt SET numOfVisitors = numOfVisitors + 1 WHERE ID=@eventID;

		DELETE Request WHERE ID=@requestID;

	COMMIT;
END
GO



USE centralLibrary;
GO
CREATE PROCEDURE AcceptEventUnattendanceRequest @requestID int, @requesterID VARCHAR(15), @branchID int, @authorizer VARCHAR(15)
AS
BEGIN
	BEGIN TRANSACTION;
	SET XACT_ABORT ON;

		DECLARE @eventID AS int, @price AS real, @eventTitle AS VARCHAR(50);
		SET @eventID = (SELECT eventID FROM EventRequests WHERE requestID=@requestID);
		SET @price = (SELECT ticket_price FROM Eventt WHERE ID=@eventID);
		SET @eventTitle = (SELECT title FROM Eventt WHERE ID=@eventID);


		INSERT INTO Transactions (ttype, ttimestamp, tvalue, branchID, authorizedBy, initiatedBy) VALUES (6, SYSDATETIME(), -1 * @price, @branchID, @authorizer, @requesterID);
		INSERT INTO notifications VALUES ('Ticket refund request accepted', CONCAT('Your request to refund the ticket for the event: ''', @eventTitle, ''' has been accepted.'), @requesterID, 0, SYSDATETIME());
		
		DELETE FROM EventRequests WHERE requestID=@requestID AND eventID=@eventID;
		DELETE FROM EventAttendant WHERE eventID=@eventID AND ID=@requesterID;
		UPDATE Eventt SET numOfVisitors = numOfVisitors - 1 WHERE ID=@eventID;
		DELETE Request WHERE ID=@requestID;

	COMMIT;
END
GO


/*
5) Procedure for rejecting event attendace request.
*/
CREATE PROCEDURE RejectEventAttendanceRequest @requestID int, @requesterID VARCHAR(15), @authorizer VARCHAR(15)
AS
BEGIN
	BEGIN TRANSACTION;
	SET XACT_ABORT ON;

		DECLARE @eventID AS int, @eventTitle AS VARCHAR(50);
		SET @eventID = (SELECT eventID FROM EventRequests WHERE requestID=@requestID);
		SET @eventTitle = (SELECT title FROM Eventt WHERE ID=@eventID);

		
		INSERT INTO notifications VALUES ('Event attendance request rejected', CONCAT('Your request to attend the event: ''', @eventTitle, ''' has been rejected.'), @requesterID, 0, SYSDATETIME());
		DELETE FROM EventRequests WHERE requestID=@requestID AND eventID=@eventID;
		DELETE FROM Request WHERE ID=@requestID;

	COMMIT;
END
GO

/*
6) Procedure for rejecting event ticket refund request.

*/

CREATE PROCEDURE RejectEventUnattendanceRequest @requestID int, @requesterID VARCHAR(15), @authorizer VARCHAR(15)
AS
BEGIN
	BEGIN TRANSACTION;
	SET XACT_ABORT ON;

		DECLARE @eventID AS int, @eventTitle AS VARCHAR(50);
		SET @eventID = (SELECT eventID FROM EventRequests WHERE requestID=@requestID);
		SET @eventTitle = (SELECT title FROM Eventt WHERE ID=@eventID);

		
		INSERT INTO notifications VALUES ('Request for refund rejected', CONCAT('Your request to refund the ticket of the event: ''', @eventTitle, ''' has been rejected.'), @requesterID, 0, SYSDATETIME());
		DELETE FROM EventRequests WHERE requestID=@requestID AND eventID=@eventID;
		DELETE FROM Request WHERE ID=@requestID;

	COMMIT;
END
GO