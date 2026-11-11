IF DB_ID('LibraryManagement') IS NULL
	BEGIN
		CREATE DATABASE LibraryManagement;
	END
GO

USE LibraryManagement;
go

create table Members 
(
	MemberId int primary key identity,
	MemberName varchar(50) not null,
	Phone varchar(14),
	Email varchar(30),
	JoinDate datetime not null
)
go

create table Books 
(
	BookId int primary key identity,
	BookName varchar(50) not null,
	ISBN varchar(30),
	AuthorName varchar(50) not null,
	Price money not null,
	TotalCopies int not null
)


go

create table BorrowRecord 
(
	BorrowId int primary key identity,
	BookId int references Books(BookId) not null,
	MemberId int references Members(MemberId) not null,
	IssueDate datetime not null,
	DueDate datetime not null,
	ReturnDate datetime not null,

)



insert into Members (MemberName, Email,Phone,JoinDate) values()