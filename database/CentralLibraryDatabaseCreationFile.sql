USE centralLibrary
GO

CREATE TABLE Person (ID varchar(15) NOT NULL PRIMARY KEY, email varchar(64) NOT NULL, 
	img varchar(60) NULL DEFAULT 'nopicture.jpg',
	gender varchar(10) NULL,
	plastname varchar(20) NULL,
	pfirstname varchar(20) NULL,
	birthdate date NULL,
	ppassword varchar(60) NOT NULL,
	phone varchar(15) NULL,
	paddress varchar(100) NULL,
	vname varchar(50) NULL, 
	CONSTRAINT UC_Person_email UNIQUE (email)
);


CREATE TABLE Branch(
	ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	bname varchar(30) NOT NULL,
	blocation varchar(50) NOT NULL,
	numOfSubscribers int NULL,
	KPI float NULL,
	numOfStaff int NULL,
	established_at date NOT NULL,
);


CREATE TABLE Employee(
	ID varchar(15) NOT NULL PRIMARY KEY,
	salary real NULL,
	hired_date date NULL,
	branchID int NULL,
	CONSTRAINT FK_Employee_Branch_ID FOREIGN KEY (branchID) REFERENCES Branch(ID) ON DELETE CASCADE
);

CREATE TABLE Administrator (
	ID varchar(15) NOT NULL PRIMARY KEY, 
	CONSTRAINT FK_Administrator_Employee_ID FOREIGN KEY (ID) REFERENCES Employee(ID) ON DELETE CASCADE
);

CREATE TABLE Librarian (
	ID varchar(15) NOT NULL PRIMARY KEY, 
	CONSTRAINT FK_Librarian_Employee_ID FOREIGN KEY (ID) REFERENCES Employee(ID) ON DELETE CASCADE
);

CREATE TABLE ouWuner (
	ID varchar(15) NOT NULL PRIMARY KEY, 
	CONSTRAINT FK_ouWuner_Employee_ID FOREIGN KEY (ID) REFERENCES Employee(ID) ON DELETE CASCADE
);

CREATE TABLE Reader (
	ID varchar(15) NOT NULL PRIMARY KEY, 
	subscribtion_start_date date NULL,
	branchID int NULL,
	
	CONSTRAINT FK_Reader_Person_ID FOREIGN KEY (ID) REFERENCES Person(ID) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT FK_Reader_Branch_ID FOREIGN KEY (branchID) REFERENCES Branch(ID) ON DELETE CASCADE
);


CREATE TABLE BusinessMeeting(
	ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	title varchar(30) NULL,
	mdescription varchar(140) NULL,
	numOfAttendants int NULL,
	bdatetime datetime NULL,
	location_branch int NOT NULL,
	CONSTRAINT FK_Meeting_Branch_ID FOREIGN KEY (location_branch) REFERENCES Branch (ID) ON UPDATE CASCADE
);

CREATE TABLE MeetingAttendant(
	ID varchar(15) NOT NULL,
	meetingID int NOT NULL,
	CONSTRAINT PK_MeetingAttendant PRIMARY KEY (ID, meetingID),
	CONSTRAINT FK_MeetingAttendant_Administrator_ID FOREIGN KEY(ID) REFERENCES Administrator (ID) ON UPDATE CASCADE ON DELETE CASCADE,
	CONSTRAINT FK_MeetingAttendant_BusinessMeeting_ID FOREIGN KEY(meetingID) REFERENCES BusinessMeeting (ID) ON UPDATE CASCADE ON DELETE CASCADE
);




CREATE TABLE EMAIL (
	ID bigint IDENTITY(1,1) NOT NULL PRIMARY KEY,  
	esubject varchar(50) NULL, 
	etext text NOT NULL, 
	send_date datetime2 NOT NULL, 
	sender varchar(15) NOT NULL, 
	receiver varchar(15) NOT NULL, 
	visible_sender int NULL DEFAULT 1, 
	visible_receiver int NULL DEFAULT 1, 

	CONSTRAINT FK_Email_Receiver_Person_ID FOREIGN KEY (receiver) REFERENCES Person(ID) ON DELETE CASCADE,
	CONSTRAINT FK_Email_Sender_Person_ID FOREIGN KEY (sender) REFERENCES Person(ID)
);


CREATE TABLE Request(
	ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	rtext text NULL,
	rstatus tinyint NULL,
	send_date datetime2(7) NULL,
	sender varchar(15) NULL,
	receiver varchar(15) NULL,
	rtype tinyint NOT NULL,
	branchID int NULL,
	CONSTRAINT FK_Request_Branch_ID FOREIGN KEY (branchID) REFERENCES Branch(ID) ON DELETE CASCADE,
	CONSTRAINT FK_Request_Sender_Person_ID FOREIGN KEY (sender) REFERENCES Person(ID) ON UPDATE CASCADE,
	CONSTRAINT FK_Request_Receiver_Person_ID FOREIGN KEY (receiver) REFERENCES Person(ID) ON DELETE CASCADE,
	CONSTRAINT CC_Request_Sender_Receiver CHECK (sender != receiver)
);



CREATE TABLE Transactions(
	ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ttype tinyint NULL,
	ttimestamp datetime2 (7) NULL,
	tvalue real NULL,
	branchID int NULL,
	authorizedBy varchar(15) NOT NULL DEFAULT '-1',
	initiatedBy varchar(15) NULL DEFAULT '-1',
	
	CONSTRAINT FK_Transactions_Branch_ID FOREIGN KEY (branchID) REFERENCES Branch(ID) ON DELETE CASCADE,
	CONSTRAINT FK_Transactions_Employee_authorizedBy_ID FOREIGN KEY (authorizedBy) REFERENCES Employee(ID),
	CONSTRAINT FK_Transactions_Person__initiatedBy_ID FOREIGN KEY (initiatedBy) REFERENCES Person(ID) ON DELETE SET NULL ON UPDATE CASCADE

);

CREATE TABLE Author(
	ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	aname varchar(50) NOT NULL,
	img varchar(60) NULL
);

CREATE TABLE Publisher(
	ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	pubname varchar(50) NOT NULL,
	phone varchar(15) NULL,
	paddress varchar(100) NOT NULL
);

CREATE TABLE Category(
	cname varchar(15) NOT NULL PRIMARY KEY
);

CREATE TABLE Book(
	ISBN varchar(30) NOT NULL PRIMARY KEY,
	title varchar(50) NULL,
	category varchar(15) NULL,
	blanguage varchar(15) NULL,
	publicationDate date NULL,
	price float NULL,
	AuthorID int NULL,
	PublisherID int NULL,
	img varchar(60) NULL,
	CONSTRAINT FK_Book_Author_ID FOREIGN KEY (AuthorID) REFERENCES Author (ID),
	CONSTRAINT FK_Book_Category_cname FOREIGN KEY (category) REFERENCES Category (cname),
	CONSTRAINT FK_Book_Publisher_ID FOREIGN KEY (PublisherID) REFERENCES Publisher (ID)
);


CREATE TABLE BooksRequests(
	requestID int NOT NULL,
	bookISBN varchar(30) NOT NULL,
	CONSTRAINT PK_BooksRequests PRIMARY KEY (requestID, bookISBN),
	CONSTRAINT FK_BooksRequests_Book_ISBN FOREIGN KEY (bookISBN) REFERENCES Book (ISBN),
	CONSTRAINT FK_BooksRequests_Request_ID FOREIGN KEY(requestID) REFERENCES Request (ID)
);


CREATE TABLE BooksBorrowed(
	readerID varchar(15) NOT NULL,
	bookISBN varchar(30) NOT NULL DEFAULT '-1',
	returnDate date NULL,
	
	CONSTRAINT PK_BooksBorrowed PRIMARY KEY (readerID, bookISBN),
	CONSTRAINT FK_BooksBorrowed_Book_ISBN FOREIGN KEY (bookISBN) REFERENCES Book (ISBN) ON UPDATE CASCADE ON DELETE SET DEFAULT,
	CONSTRAINT FK_BooksBorrowed_Reader_ID FOREIGN KEY(readerID) REFERENCES Reader (ID) ON UPDATE CASCADE ON DELETE CASCADE
);


CREATE TABLE BookBranch(
	ISBN varchar(30) NOT NULL,
	branchID int NOT NULL,
	numOfRequests int NULL DEFAULT 0,
	numberOfAvailableCopies int NULL DEFAULT 0,
	CONSTRAINT PK_BookBranch PRIMARY KEY (ISBN, branchID),
	CONSTRAINT FK_BookBranch_Book_ISBN FOREIGN KEY(ISBN) REFERENCES Book (ISBN) ON DELETE CASCADE,
	CONSTRAINT FK_BookBranch_Branch_branchID FOREIGN KEY(branchID) REFERENCES Branch (ID) ON DELETE CASCADE
);


CREATE TABLE Eventt(
	ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	title varchar(30) NULL,
	edescription varchar(140) NULL,
	numOfVisitors int NULL,
	ticket_price real NULL,
	edatetime datetime NULL,
	branchID int NULL,
	CONSTRAINT FK_Event_Branch_ID FOREIGN KEY(branchID) REFERENCES Branch (ID) ON DELETE SET NULL
);


CREATE TABLE EventAttendant(
	ID varchar(15) NOT NULL,
	EventID int NOT NULL,
	CONSTRAINT PK_EventAttendant PRIMARY KEY (ID, EventID),
	CONSTRAINT FK_EventAttendant_Eventt_ID FOREIGN KEY(EventID) REFERENCES Eventt (ID),
	CONSTRAINT FK_EventAttendant_Person_ID FOREIGN KEY(ID) REFERENCES Person (ID) ON DELETE CASCADE
);


CREATE TABLE EventRequests(
	requestID int NOT NULL,
	eventID int NOT NULL,
	CONSTRAINT PK_EventRequests PRIMARY KEY (requestID, eventID),
	CONSTRAINT FK_EventRequests_Event_ID FOREIGN KEY(eventID) REFERENCES Eventt (ID) ON DELETE CASCADE,
    CONSTRAINT FK_EventRequests_Request_ID FOREIGN KEY(requestID) REFERENCES Request (ID) ON DELETE CASCADE,
);


CREATE TABLE EventsDummyTable(
	eventID int NOT NULL PRIMARY KEY,
	content varchar(140) NULL,
	cancellationDate datetime NULL,
);


CREATE TABLE FinanceRecords(
	ID varchar(15) NOT NULL PRIMARY KEY,
	rvalue real NOT NULL,
	rday date NULL,
	branchID int NULL,
	CONSTRAINT FK_Frecord_Branch_ID FOREIGN KEY(branchID) REFERENCES Branch (ID) ON DELETE SET NULL
);


CREATE TABLE notifications(
	ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	title varchar(100) NULL,
	content text NULL,
	receiver varchar(15) NOT NULL,
	seen bit NULL DEFAULT 0,
	ntimestamp datetime NOT NULL,
	CONSTRAINT FK_notifications_Person_ID FOREIGN KEY(receiver) REFERENCES Person (ID) ON DELETE CASCADE
);



CREATE TABLE VendingRequestsBooks(
	requestID int NOT NULL,
	bookISBN varchar(30) NOT NULL,
	numberOfCopies int NOT NULL,
	CONSTRAINT PK_VendingRequestsBooks PRIMARY KEY (requestID, bookISBN),
	CONSTRAINT FK_VendingRequestsBooks_Book_ISBN FOREIGN KEY(bookISBN) REFERENCES Book (ISBN) ON DELETE CASCADE,
	CONSTRAINT FK_VendingRequestsBooks_Request_ID FOREIGN KEY(requestID) REFERENCES Request (ID) ON DELETE CASCADE
);


CREATE TABLE VendorBranch(
	VID varchar(15) NOT NULL,
	branchID int NOT NULL,
	contract_date date NULL,
	CONSTRAINT PK_VendorBranch PRIMARY KEY (VID, branchID),
	CONSTRAINT FK_VendorBranch_Branch_ID FOREIGN KEY(branchID) REFERENCES Branch (ID) ON DELETE CASCADE,
	CONSTRAINT FK_VendorBranch_Vendor_ID FOREIGN KEY(VID) REFERENCES Person (ID) ON DELETE CASCADE
);


CREATE TABLE VendorCategory(
	VID varchar(15) NOT NULL,
	cname varchar(15) NOT NULL,
	CONSTRAINT PK_VendorCategory PRIMARY KEY (VID, cname),
	CONSTRAINT FK_VendorCategory_Category_came FOREIGN KEY(cname) REFERENCES Category (cname),
	CONSTRAINT FK_VendorCategory_Person_ID FOREIGN KEY(VID) REFERENCES Person (ID)
);

