SELECT * 
FROM LogIn

SELECT * 
FROM Accountant

SELECT * 
FROM Admin

SELECT * 
FROM InventoryControlManager

SELECT * 
FROM WareHouseManager

SELECT * 
FROM Staff

SELECT * 
FROM Customer

SELECT * 
FROM Product

SELECT * 
FROM DailyExpenses

SELECT *
FROM Ordered

SELECT *
FROM DailyIncome

SELECT *
FROM DailyRecords

SELECT *
FROM SelectedItems


SELECT * 
from Staff
Where UserName IN (SELECT UserName 
From LogIn 
Where Password like 'Are') 

SELECT * 
from Staff 
Where UserName IN (SELECT UserName 
From LogIn 
Where Password like 'MY') 

SELECT *
from Staff 
Where UserName IN (SELECT UserName 
From LogIn 
Where Password like 'Fire') 
SELECT *
from Staff 
Where UserName IN (SELECT UserName 
From LogIn 
Where Password like 'you') 

SELECT * 
FROM Ordered 
Where AID IN (SELECT AID 
FROM Accountant)

SELECT SID 
FROM Ordered 
Where AID IN (SELECT AID 
FROM Accountant)

SELECT * 
FROM Customer
WHERE PhoneNumber in (SELECT PhoneNumber 
FROM Ordered 
WHERE PhoneNumber LIKE 61401234987)

SELECT *
FROM SelectedItems 
WHERE OID IN (SELECT OID 
FROM Ordered 
WHERE PID IN ( SELECT PID 
FROM PRODUCT 
WHERE PID = 1))

SELECT * 
FROM Accountant 
WHERE AID IN (SELECT AID
FROM Ordered 
WHERE PhoneNumber IN (SELECT PhoneNumber 
FROM Customer 
WHERE PhoneNumber like 96101248610))

SELECT SID
FROM Staff WHERE SID IN (SELECT SID 
FROM Ordered WHERE OID IN
(SELECT OID 
FROM SelectedItems 
WHERE PID IN (SELECT PID 
FROM Product)))

SELECT ADID 
FROM Admin 
WHERE ADID IN (SELECT ADID 
FROM Staff 
WHERE SID = 223)

SELECT * 
FROM DailyExpenses 
WHERE Date IN (SELECT Date 
FROM DailyRecords 
WHERE Date LIKE '2023-03-10')

SELECT * 
FROM DailyIncome
WHERE Date IN (SELECT Date 
FROM DailyRecords 
WHERE Date LIKE '2023-03-09')

SELECT * 
FROM product
WHERE ICMID IN (SELECT ICMID 
FROM InventoryControlManager)

SELECT * 
FROM Accountant 
WHERE AID in (SELECT AID 
FROM DailyRecords)

SELECT * FROM Staff WHERE WMID IN (SELECT WMID FROM Staff WHERE SID = 278)

SELECT * FROM Staff WHERE SID = 278
