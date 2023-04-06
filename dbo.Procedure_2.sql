CREATE PROCEDURE AddStaff
@SID INT,
@ADID INT,
@WMID INT,
@UserName NVARCHAR(25),
@Name NVARCHAR(30),
@Phone BIGINT,
@DailySchedule TEXT
AS
INSERT INTO Staff VALUES (1, @SID, @ADID, WMID, @UserName, @Name, @Phone, @DailySchedule)
