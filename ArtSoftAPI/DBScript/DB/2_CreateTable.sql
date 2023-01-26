USE OSKITest

CREATE TABLE Users(
Id int IDENTITY(1,1) primary key not null,
Name varchar(50),
SurName varchar(50),
Age int,
Gender varchar(10),
Email varchar(100),
Password varchar(100),
Created datetime,
Changed datetime
)

CREATE TABLE Test(
Id int IDENTITY(1,1) primary key not null,
Name varchar(500),
ShortDesc varchar(1500),
)

CREATE TABLE Question(
Id int IDENTITY(1,1) primary key not null,
TestId int,
Text varchar(500)
)

CREATE TABLE Answer(
Id int IDENTITY(1,1) primary key not null,
QuestionId int,
Text varchar(250),
IsTrue bit
)

CREATE TABLE Logs(
Id int IDENTITY(1,1) primary key not null,
OperationId varchar(100),
ErrorMessage varchar(1000),
StackTrace varchar(2000),
Created datetime
)