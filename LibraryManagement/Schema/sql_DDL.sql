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
	JoinDate datetime not null,
	Photo varbinary(max)
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
	DueDate datetime,
	ReturnDate datetime not null,

)     





INSERT INTO Members (MemberName, Phone, Email, JoinDate, Photo)
VALUES
('Ahsanul Islam', '01710000001', 'ahsan01@gmail.com', '2025-01-05', NULL),
('Rahim Ahmed', '01710000002', 'rahim02@gmail.com', '2025-01-08', NULL),
('Karim Hasan', '01710000003', 'karim03@gmail.com', '2025-01-10', NULL),
('Sakib Hossain', '01710000004', 'sakib04@gmail.com', '2025-01-12', NULL),
('Nusrat Jahan', '01710000005', 'nusrat05@gmail.com', '2025-01-15', NULL),
('Sadia Akter', '01710000006', 'sadia06@gmail.com', '2025-01-17', NULL),
('Mehedi Hasan', '01710000007', 'mehedi07@gmail.com', '2025-01-20', NULL),
('Tanvir Ahmed', '01710000008', 'tanvir08@gmail.com', '2025-01-22', NULL),
('Jannatul Ferdous', '01710000009', 'jannat09@gmail.com', '2025-01-25', NULL),
('Imran Hossain', '01710000010', 'imran10@gmail.com', '2025-01-27', NULL),
('Fahim Rahman', '01710000011', 'fahim11@gmail.com', '2025-02-01', NULL),
('Shamim Islam', '01710000012', 'shamim12@gmail.com', '2025-02-03', NULL),
('Rafiul Islam', '01710000013', 'rafiul13@gmail.com', '2025-02-05', NULL),
('Mitu Akter', '01710000014', 'mitu14@gmail.com', '2025-02-07', NULL),
('Shuvo Roy', '01710000015', 'shuvo15@gmail.com', '2025-02-10', NULL),
('Arif Hossain', '01710000016', 'arif16@gmail.com', '2025-02-12', NULL),
('Sumaiya Islam', '01710000017', 'sumaiya17@gmail.com', '2025-02-15', NULL),
('Rakib Hasan', '01710000018', 'rakib18@gmail.com', '2025-02-18', NULL),
('Tanjim Ahmed', '01710000019', 'tanjim19@gmail.com', '2025-02-20', NULL),
('Farzana Akter', '01710000020', 'farzana20@gmail.com', '2025-02-22', NULL),
('Mahmudul Hasan', '01710000021', 'mahmud21@gmail.com', '2025-02-25', NULL),
('Anika Rahman', '01710000022', 'anika22@gmail.com', '2025-02-28', NULL),
('Hasib Khan', '01710000023', 'hasib23@gmail.com', '2025-03-01', NULL),
('Sabbir Hossain', '01710000024', 'sabbir24@gmail.com', '2025-03-03', NULL),
('Ruma Akter', '01710000025', 'ruma25@gmail.com', '2025-03-05', NULL),
('Moinul Islam', '01710000026', 'moinul26@gmail.com', '2025-03-07', NULL),
('Bithi Akter', '01710000027', 'bithi27@gmail.com', '2025-03-10', NULL),
('Al Amin Hossain', '01710000028', 'alamin28@gmail.com', '2025-03-12', NULL),
('Priya Das', '01710000029', 'priya29@gmail.com', '2025-03-15', NULL),
('Saiful Islam', '01710000030', 'saiful30@gmail.com', '2025-03-18', NULL),
('Mushfiq Rahman', '01710000031', 'mushfiq31@gmail.com', '2025-03-20', NULL),
('Tania Sultana', '01710000032', 'tania32@gmail.com', '2025-03-22', NULL),
('Nasir Uddin', '01710000033', 'nasir33@gmail.com', '2025-03-25', NULL),
('Shila Akter', '01710000034', 'shila34@gmail.com', '2025-03-27', NULL),
('Omar Faruk', '01710000035', 'omar35@gmail.com', '2025-03-29', NULL),
('Rashed Ahmed', '01710000036', 'rashed36@gmail.com', '2025-04-01', NULL),
('Lima Rahman', '01710000037', 'lima37@gmail.com', '2025-04-03', NULL),
('Abdullah Hasan', '01710000038', 'abdullah38@gmail.com', '2025-04-05', NULL),
('Nabila Islam', '01710000039', 'nabila39@gmail.com', '2025-04-07', NULL),
('Jahid Hossain', '01710000040', 'jahid40@gmail.com', '2025-04-10', NULL),
('Kamal Uddin', '01710000041', 'kamal41@gmail.com', '2025-04-12', NULL),
('Mariam Akter', '01710000042', 'mariam42@gmail.com', '2025-04-15', NULL),
('Elias Hossain', '01710000043', 'elias43@gmail.com', '2025-04-17', NULL),
('Sonia Rahman', '01710000044', 'sonia44@gmail.com', '2025-04-20', NULL),
('Bashir Ahmed', '01710000045', 'bashir45@gmail.com', '2025-04-22', NULL),
('Tamim Iqbal', '01710000046', 'tamim46@gmail.com', '2025-04-25', NULL),
('Mahiya Islam', '01710000047', 'mahiya47@gmail.com', '2025-04-27', NULL),
('Nayeem Hasan', '01710000048', 'nayeem48@gmail.com', '2025-04-29', NULL),
('Pavel Hossain', '01710000049', 'pavel49@gmail.com', '2025-05-01', NULL),
('Zarin Tasnim', '01710000050', 'zarin50@gmail.com', '2025-05-03', NULL);




/* add books */

INSERT INTO Books (BookName, ISBN, AuthorName, Price, TotalCopies)
VALUES
('Clean Code', '9780132350884', 'Robert C. Martin', 850, 10),
('The Pragmatic Programmer', '9780135957059', 'David Thomas', 950, 8),
('Introduction to Algorithms', '9780262046305', 'Thomas H. Cormen', 1800, 5),
('Design Patterns', '9780201633610', 'Erich Gamma', 1200, 6),
('Refactoring', '9780134757599', 'Martin Fowler', 1100, 7),
('C Programming Language', '9780131103627', 'Brian Kernighan', 650, 10),
('Head First Java', '9780596009205', 'Kathy Sierra', 950, 8),
('Effective Java', '9780134685991', 'Joshua Bloch', 1050, 6),
('JavaScript: The Good Parts', '9780596517748', 'Douglas Crockford', 550, 8),
('Eloquent JavaScript', '9781593279509', 'Marijn Haverbeke', 750, 10),
('Learning Python', '9780135409814', 'Mark Lutz', 1300, 6),
('Python Crash Course', '9781718502703', 'Eric Matthes', 900, 10),
('Fluent Python', '9781491946008', 'Luciano Ramalho', 1500, 5),
('Programming in C#', '9780132612315', 'Andrew Troelsen', 1000, 8),
('Pro C#', '9781484202202', 'Andrew Troelsen', 1400, 5),
('ASP.NET Core in Action', '9781617294617', 'Andrew Lock', 1200, 7),
('SQL Server Internals', '9780133976118', 'Kalen Delaney', 1600, 4),
('Learning SQL', '9781492057611', 'Alan Beaulieu', 700, 10),
('Database System Concepts', '9780078022159', 'Abraham Silberschatz', 1400, 6),
('Fundamentals of Database Systems', '9780133970777', 'Ramez Elmasri', 1500, 5),
('Computer Networking', '9780132126953', 'James Kurose', 1250, 8),
('Network Security Essentials', '9780134451418', 'William Stallings', 1100, 6),
('Operating System Concepts', '9781118063330', 'Abraham Silberschatz', 1350, 7),
('Modern Operating Systems', '9780137618873', 'Andrew Tanenbaum', 1450, 5),
('Computer Organization', '9780133617998', 'David Patterson', 1200, 8),
('Artificial Intelligence', '9780136042594', 'Stuart Russell', 1800, 4),
('Machine Learning', '9780262035613', 'Tom Mitchell', 1300, 6),
('Deep Learning', '9780262035613', 'Ian Goodfellow', 2000, 3),
('Data Structures and Algorithms', '9780133073604', 'Michael T. Goodrich', 950, 10),
('Algorithms', '9780321573513', 'Robert Sedgewick', 1500, 5),
('The Hobbit', '9780547928227', 'J. R. R. Tolkien', 650, 10),
('Harry Potter and the Sorcerers Stone', '9780590353427', 'J. K. Rowling', 700, 12),
('The Lord of the Rings', '9780544003415', 'J. R. R. Tolkien', 1200, 8),
('1984', '9780451524935', 'George Orwell', 450, 15),
('Animal Farm', '9780451526342', 'George Orwell', 350, 12),
('The Alchemist', '9780062315007', 'Paulo Coelho', 500, 10),
('Rich Dad Poor Dad', '9781612680194', 'Robert Kiyosaki', 550, 10),
('Think and Grow Rich', '9781585424337', 'Napoleon Hill', 450, 8),
('Atomic Habits', '9780735211292', 'James Clear', 750, 12),
('The Power of Habit', '9780812981605', 'Charles Duhigg', 700, 8),
('Sapiens', '9780062316097', 'Yuval Noah Harari', 900, 7),
('Homo Deus', '9780062464316', 'Yuval Noah Harari', 950, 6),
('A Brief History of Time', '9780553380163', 'Stephen Hawking', 650, 8),
('The Theory of Everything', '9780553380163', 'Stephen Hawking', 550, 6),
('The Great Gatsby', '9780743273565', 'F. Scott Fitzgerald', 400, 10),
('To Kill a Mockingbird', '9780061120084', 'Harper Lee', 600, 8),
('Pride and Prejudice', '9780141439518', 'Jane Austen', 500, 10),
('The Kite Runner', '9781594631931', 'Khaled Hosseini', 700, 7),
('The Book Thief', '9780375842207', 'Markus Zusak', 800, 6),
('The Fault in Our Stars', '9780525478812', 'John Green', 650, 8);



/* Add borrow record */

INSERT INTO BorrowRecord (BookId, MemberId, IssueDate, DueDate, ReturnDate)
VALUES
(1, 1, '2025-01-05', '2025-01-19', '2025-01-17'),
(2, 2, '2025-01-08', '2025-01-22', '2025-01-21'),
(3, 3, '2025-01-10', '2025-01-24', '2025-01-23'),
(4, 4, '2025-01-12', '2025-01-26', '2025-01-25'),
(5, 5, '2025-01-15', '2025-01-29', '2025-01-28'),
(6, 6, '2025-01-17', '2025-01-31', '2025-01-30'),
(7, 7, '2025-01-20', '2025-02-03', '2025-02-01'),
(8, 8, '2025-01-22', '2025-02-05', '2025-02-04'),
(9, 9, '2025-01-25', '2025-02-08', '2025-02-07'),
(10, 10, '2025-01-27', '2025-02-10', '2025-02-09'),
(11, 11, '2025-02-01', '2025-02-15', '2025-02-14'),
(12, 12, '2025-02-03', '2025-02-17', '2025-02-16'),
(13, 13, '2025-02-05', '2025-02-19', '2025-02-18'),
(14, 14, '2025-02-07', '2025-02-21', '2025-02-20'),
(15, 15, '2025-02-10', '2025-02-24', '2025-02-23'),
(16, 16, '2025-02-12', '2025-02-26', '2025-02-25'),
(17, 17, '2025-02-15', '2025-03-01', '2025-02-28'),
(18, 18, '2025-02-18', '2025-03-04', '2025-03-03'),
(19, 19, '2025-02-20', '2025-03-06', '2025-03-05'),
(20, 20, '2025-02-22', '2025-03-08', '2025-03-07'),
(21, 21, '2025-02-25', '2025-03-11', '2025-03-10'),
(22, 22, '2025-02-28', '2025-03-14', '2025-03-13'),
(23, 23, '2025-03-01', '2025-03-15', '2025-03-14'),
(24, 24, '2025-03-03', '2025-03-17', '2025-03-16'),
(25, 25, '2025-03-05', '2025-03-19', '2025-03-18'),
(26, 26, '2025-03-07', '2025-03-21', '2025-03-20'),
(27, 27, '2025-03-10', '2025-03-24', '2025-03-23'),
(28, 28, '2025-03-12', '2025-03-26', '2025-03-25'),
(29, 29, '2025-03-15', '2025-03-29', '2025-03-28'),
(30, 30, '2025-03-18', '2025-04-01', '2025-03-31'),
(31, 31, '2025-03-20', '2025-04-03', '2025-04-02'),
(32, 32, '2025-03-22', '2025-04-05', '2025-04-04'),
(33, 33, '2025-03-25', '2025-04-08', '2025-04-07'),
(34,34, '2025-03-27', '2025-04-10', '2025-04-09'),
(35,35, '2025-03-29', '2025-04-12', '2025-04-11'),
(36,36, '2025-04-01', '2025-04-15', '2025-04-14'),
(37,37, '2025-04-03', '2025-04-17', '2025-04-16'),
(38,38, '2025-04-05', '2025-04-19', '2025-04-18'),
(39,39, '2025-04-07', '2025-04-21', '2025-04-20'),
(40,40, '2025-04-10', '2025-04-24', '2025-04-23'),
(41,41, '2025-04-12', '2025-04-26', '2025-04-25'),
(42,42, '2025-04-15', '2025-04-29', '2025-04-28'),
(43,43, '2025-04-17', '2025-05-01', '2025-04-30'),
(44,44, '2025-04-20', '2025-05-04', '2025-05-03'),
(45,45, '2025-04-22', '2025-05-06', '2025-05-05'),
(46,46, '2025-04-25', '2025-05-09', '2025-05-08'),
(47,47, '2025-04-27', '2025-05-11', '2025-05-10'),
(48,48, '2025-04-29', '2025-05-13', '2025-05-12'),
(49,49, '2025-05-01', '2025-05-15', '2025-05-14'),
(50,50, '2025-05-03', '2025-05-17', '2025-05-16');