create database manager
go
use manager
go
create table tablefood (
id int identity primary key,
names nvarchar(100)Not null,
trangthai nvarchar(100)Not null default N'trong'
)
go
create table account (
id int identity primary key,
fullname nvarchar(100)Not null,
UserName nvarchar(100)Not null,
Passwords nvarchar(100)Not null,
Email nvarchar(100)
)
go
create table loaifood (
id int identity primary key,
names nvarchar(100)Not null

)
go
create table food (
id int identity primary key,
names nvarchar(100)Not null,
idcategory int not null,
gia int not null default 0
foreign key (idcategory) references dbo.loaifood(id)
)
go 
create table bill
(id int identity primary key,
datecheck  date not null default getdate() , 
idtable int not null ,
trangthai int not null default 0
foreign key (idtable) references dbo.tablefood(id)
)

