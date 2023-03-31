CREATE TABLE Accountant (
AID INT,
UserName NVARCHAR(25),--fk from Login
Name NVARCHAR(30),
Age INT,
Gender BIT,
YOE DATE,
Email NVARCHAR(100),
PRIMARY KEY (AID));

CREATE TABLE WareHouseManager(
WMID INT,
UserName NVARCHAR(25),--fk from Login
Name NVARCHAR(30),
Age INT,
Gender BIT,
YOE DATE,
Email NVARCHAR(100),
PRIMARY KEY (WMID));

CREATE TABLE InventoryControlManager (
ICMID INT,
UserName NVARCHAR(25), --fk from login
Name NVARCHAR(30),
Age INT,
Gender BIT,
YOE DATE,
Email NVARCHAR(100),
PRIMARY KEY (ICMID));
 
CREATE TABLE LogIn(
UserName NVARCHAR(25),
Password NVARCHAR(30),
PRIMARY KEY (UserName));

CREATE TABLE Staff(
SID INT,
ADID INT, --fk FROM ADMIN
WMID INT, --fk from warehousemanage
UserName NVARCHAR(25),--fk from login
Name NVARCHAR(30),
Phone INT,
DailySchedule TEXT,
PRIMARY KEY (SID));

CREATE TABLE Customer(
PhoneNumber BIGINT,
Address NVARCHAR(150),
PRIMARY KEY (PhoneNumber));

CREATE TABLE Ordered (
OID INT,
SID INT, --fk from Staff
PhoneNumber BIGINT,--fk from customer
AID INT,--from accountant
PurchaseHistory TEXT,
Discount REAL,
AmmountSpent REAL,
PRIMARY KEY (OID));

CREATE TABLE SelectedItems(
OID INT,
PID INT,
PRIMARY KEY (OID,PID));

CREATE TABLE Product(
PID INT,
ICMID INT,--fk from inventorycontrol Manager
Size INT,
Price REAL,
COLOR NVARCHAR(25),
Quality NVARCHAR(25),
IMG VARBINARY(MAX),
PRIMARY KEY (PID));

CREATE TABLE DailyRecords (
Date DATE,
AID INT, --fk from accountant
Revenue REAL,
PRIMARY KEY (Date));

CREATE TABLE DailyExpenses (
ECODE INT,
Date DATE, --fk dailyrecords
Bought REAL,
PayDay REAL,
Maintenance REAL,
Taxes REAl,
PRIMARY KEY (ECODE));

CREATE TABLE DailyIncome (
ICODE INT,
Date DATE, --fk dailyrecords 
Returns REAL,
PRIMARY KEY (ICODE));

CREATE TABLE Admin(
ADID INT,
UserName NVARCHAR(25),--fk from Login
Name NVARCHAR(30),
Age INT,
Gender BIT,
YOE DATE,
Email NVARCHAR(100),
PRIMARY KEY (ADID));

ALTER TABLE SelectedItems
ADD CONSTRAINT Ordered_SelectedItems_OID
FOREIGN KEY (OID) REFERENCES Ordered (OID)

ALTER TABLE SelectedItems
ADD CONSTRAINT Product_SelectedItems_PID
FOREIGN KEY (PID) REFERENCES Product (PID)

ALTER TABLE Accountant
ADD CONSTRAINT LogIn_Accountant_UserName
FOREIGN KEY (UserName) REFERENCES LogIn (UserName);

ALTER TABLE WareHouseManager
ADD CONSTRAINT LogIn_WareHouseManager_UserName
FOREIGN KEY (UserName) REFERENCES LogIn (UserName);

ALTER TABLE InventoryControlManager
ADD CONSTRAINT LogIn_InventoryControlManager_UserName
FOREIGN KEY (UserName) REFERENCES LogIn (UserName);

ALTER TABLE Admin
ADD CONSTRAINT LogIn_Admin_UserName
FOREIGN KEY (UserName) REFERENCES LogIn (UserName);

ALTER TABLE Staff
ADD CONSTRAINT LogIn_Staff_UserName
FOREIGN KEY (UserName) REFERENCES LogIn (UserName);

ALTER TABLE Staff
ADD CONSTRAINT Admin_Staff_ADID
FOREIGN KEY (ADID) REFERENCES Admin (ADID);

ALTER TABLE Staff
ADD CONSTRAINT WareHouseManager_Staff_WMID
FOREIGN KEY (WMID) REFERENCES WareHouseManager(WMID);

ALTER TABLE Ordered
ADD CONSTRAINT Staff_Ordered_SID
FOREIGN KEY (SID) REFERENCES Staff (SID);

ALTER TABLE Ordered
ADD CONSTRAINT Customer_Ordered_PhoneNumber
FOREIGN KEY (PhoneNumber) REFERENCES Customer (PhoneNumber);

ALTER TABLE Ordered
ADD CONSTRAINT Accountant_Ordered_AID
FOREIGN KEY (AID) REFERENCES Accountant (AID);

ALTER TABLE Product
ADD CONSTRAINT InventoryControlManager_Product_ICMID
FOREIGN KEY (ICMID) REFERENCES InventoryControlManager (ICMID);

ALTER TABLE DailyRecords
ADD CONSTRAINT Accountant_DailyRecords_AID
FOREIGN KEY (AID) REFERENCES Accountant (AID);

ALTER TABLE DailyExpenses
ADD CONSTRAINT DailyRecords_DailyExpenses_Date
FOREIGN KEY (Date) REFERENCES DailyRecords (Date);

ALTER TABLE DailyIncome
ADD CONSTRAINT DailyRecords_DailyIncome_Date
FOREIGN KEY (Date) REFERENCES DailyRecords (Date);