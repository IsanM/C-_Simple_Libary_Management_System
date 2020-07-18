# This is Simple C# Libary Management System
# How to Configure
# Downlod and Install MS Sql Server and Create ODBC Connection
# Database Code bellow  shown

create database DOTNET8043
use DOTNET8043
create table  Administrator
(
AdminID char(10),
FristName char(25),
LastName char(25),
Email    char(40),
UserPassword char(50),
gender char(10),
Adress char(50),
Phone_Number int,
Registerdate date,
constraint AdminID  primary key (AdminID )
)
INSERT INTO Administrator VALUES('USE001','Ishan','Madhawa','ishanmadhawa44@gmail.com','A1234','Male','Matugama',0717613775,'2018-04-16')

create table  Librarian
(
LibrarianID char(10),
FristName char(25),
LastName char(25),
Email    char(40),
LibrarianPassword char(50),
gender char(10),
Adress char(50),
Phone_Number int,
Registerdate date,
constraint LibrarianID primary key (LibrarianID )
)
INSERT INTO Librarian VALUES('LIB001','Oshan','Pamudya','ishanmadhawa44@gmail.com','L1234','Male','Matugama',0717613775,'2018-04-16')

create table  Member
(
 MemberID char(10),
FristName char(25),
LastName char(25),
Email    char(40),
MemberPassword char(50),
gender char(10),
Adress char(50),
Phone_Number int,
Registerdate date,
Registationfee float,
constraint MemberID primary key (MemberID)
)
INSERT INTO Member VALUES('MEM001','Sithum','Sanjana','ishanmadhawa44@gmail.com','M1234','Male','Matugama',0717613775,'2018-04-16',450)

create table Book
(
ISBNNumber char(32),
BookName char(35),
AuthorName char(30),
publishedyear int,
bookprice money,
Bookcategoery char(25),
Quantity int,
Avalableqty int,
publisherName char(35),
constraint ISBNNumber primary key (ISBNNumber)

)
insert into Book values ('ISBN-5678-20','java','Ishan',2000,1234,'IT',5,5,'Samzn')


create table bookissue
(
IssueID int,
BookName char(35),
MemberName char(50),
IssueDate char(50),
ReturnDate char(50),
MemberID char(10),
constraint IssueID primary key (IssueID),
foreign key (MemberID) references Member(MemberID)

)
insert into bookissue   values ('1002','Java','Madu','2018-04-01','2018-04-31','MEM001')
