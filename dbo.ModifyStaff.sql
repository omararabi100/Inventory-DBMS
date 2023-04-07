CREATE PROCEDURE ModifyStaff
@ActivityStatus bit,
@SID INT,
@ADID INT,
@WMID INT,
@UserName NVARCHAR(25),
@Name NVARCHAR(30),
@Phone BIGINT,
@DailySchedule NVARCHAR(100)
AS
BEGIN TRY 
BEGIN TRANSACTION

UPDATE Staff
SET ActivityStatus = @ActivityStatus, @ADID = ADID, WMID = @WMID, UserName = @UserName, Name = @Name, Phone = @Phone, DailySchedule = @DailySchedule
WHERE SID = @SID

COMMIT TRANSACTION
END TRY 
BEGIN CATCH
ROLLBACK TRANSACTION;
THROW;  
END CATCH