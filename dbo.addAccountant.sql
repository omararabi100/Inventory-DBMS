﻿CREATE PROCEDURE addAccountant
	@AID int,
	@UserName NVARCHAR(25),
	@Name NVARCHAR(30),
	@Age INT,
	@GENDER BIT,
	@YOE DATE,
	@EMAIL NVARCHAR(100)

AS
INSERT INTO Accountant VALUES (1,@AID,@UserName,@Name,@Age,@GENDER,@YOE,@EMAIL)