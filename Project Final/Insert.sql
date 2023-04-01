INSERT INTO 
LogIn Values('AWES312','anything','Accountant')

INSERT INTO 
LogIn Values('WHMNEH723','hello','WareHouseManager')

INSERT INTO 
LogIn Values('ICMOA1231','how','InventoryControlManager')

INSERT INTO 
LogIn Values('ADAB529','are','Admin')

INSERT INTO 
LogIn Values('SL620','you','Staff')

INSERT INTO 
LogIn Values('CS620','Are','Staff')

INSERT INTO 
LogIn Values('AM620','My','Staff')

INSERT INTO 
LogIn Values('AD620','My','Staff')

INSERT INTO Accountant
VALUES (4444,'AWES312','Wally Elsayed',20,1,'2022-03-12','elsayedwa@students.rhu.edu.lb');

INSERT INTO WareHouseManager
VALUES (1234,'WHMNEH723','Nour ElHariri',20,1,'2020-07-23','elharirinm@students.rhu.edu.lb');

INSERT INTO InventoryControlManager
VALUES (0666,'ICMOA1231','Omar Arabi',20,1,'2021-12-31','arabiom@students.rhu.edu.lb');

INSERT INTO
Admin Values (6372,'ADAB529','Abou Bakr',20,1,'2021-05-29','Bakrah@students.rhu.edu.lb');

INSERT INTO
Staff Values (223,6372,1234,'SL620','lara',71432234,'From 8 till 12 then from 2 to 6');

INSERT INTO
Staff Values (278,6372,1234,'CS620','Carla elsaade',03234567,'From 8 till 12 then from 14 to 18');

INSERT INTO
Staff Values (293,6372,1234,'AM620','Adam mkaram',71438569,'From 18 till 24 then from 2 to 6');

INSERT INTO
Staff Values (968,6372,1234,'AD620','ashren dyski',76826419,'From 18 till 24 then from 2 to 6');

INSERT INTO
Customer VALUES (96101248610,'Beruit-alhamra-mainstreet');

INSERT INTO
Customer VALUES (61401234987,'netherlands-nameofarea-street');

INSERT INTO 
Ordered VALUES (0000001,278,96101248610,4444,'50 redshirts',NULL,75.25);

INSERT INTO 
Ordered VALUES (0000002,223,96101248610,4444,'100 greenshirts + 50 pairs if jeans',10,400);

INSERT INTO 
Ordered VALUES (0000003,223,61401234987,4444,'90 sportsware + 30 gloves + 60 hoodies',22,1400);

INSERT INTO
Ordered VALUES (0000004,968,61401234987,4444,'300 hoodies + 70 Pink Shirts',12,700)

INSERT INTO 
Product VALUES (001,0666,45,10.0,'red','silk',NULL)

INSERT INTO 
Product VALUES (002,0666,555,15.0,'pink','cotton',NULL)

INSERT INTO 
Product VALUES (003,0666,52,0,'gloves','plastic',NULL)

INSERT INTO 
Product VALUES (004,0666,5,0,'purple','furr',NULL)

INSERT INTO 
SelectedItems VALUES (0000001, 001)
INSERT INTO 
SelectedItems VALUES (0000002, 002)
INSERT INTO 
SelectedItems VALUES (0000003, 003)
INSERT INTO 
SelectedItems VALUES (0000004, 004)

INSERT INTO 
DailyRecords VALUES ('2023-03-10', 4444, 453.56)

INSERT INTO 
DailyRecords VALUES ('2023-03-09', 4444, 42342.56)

INSERT INTO 
DailyExpenses VALUES (34343, '2023-03-09', 79354.32, 23453.456, 13432.542, 32421.432)

INSERT INTO 
DailyExpenses VALUES (34363, '2023-03-10', 45324.59, 23153.324, 45332.76, 74321.769)

INSERT INTO
DailyIncome VALUES (14684, '2023-03-10', 13452.43)

INSERT INTO
DailyIncome VALUES (34584, '2023-03-09', 35322.78)