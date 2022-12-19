Create database GoodManage
use GoodManage

Create Table UserAcc(
	UserID nvarchar(250),
	UserPassword nvarchar(250),
	Role nvarchar(250),
	Primary key (UserID)
)
Create Table Orders(
	OrderID int identity(1,1),
	PaymentTypeID nvarchar(50),
	AgentID int,
	OrderDate date,
	Primary key (OrderID)
)
Create Table OrderDetail(
	OrderID int,
	ProductID nvarchar(50),
	Quantity int,
	Status nvarchar(50),
	Price int,
	primary key (OrderID,ProductID),
)
Create Table Product(
	ProductID nvarchar(50),
	ProductName nvarchar(50),
	CategoryID nvarchar(50),
	Price int, 
	CurQuantity int, 
	image nvarchar(50),
	Primary key (ProductID)
)
Create Table Category(
	CategoryID nvarchar(50),
	CategoryName nvarchar(50),
	Primary key (CategoryID)
)
Create Table Import(
	IID nvarchar(50),
	ImportDate date,
	Quantity int,
	TotalImportPrice int,
	Primary key (IID)
)
Create Table ImportDetail(
	ID int,
	IID nvarchar(50),
	AccountantID nvarchar(50),
	ProductID nvarchar(50),
	ImportPrice int,
	Quantity int,
	TotalPrice int,
	Primary key (ID,IID,AccountantID,ProductID)
)
Create Table Agent(
	AgentID int identity(1,1),
	AgentName nvarchar(250),
	AgentPhone nvarchar(50),
	AgentAddress nvarchar(250),
	Primary key (AgentID)
)
Create Table PaymentType(
	PaymentTypeID nvarchar(50),
	Type nvarchar(50),
	Primary key (PaymentTypeID)
)
Create Table Accountant(
	AccountantID nvarchar(50) primary key,
	AccountantName nvarchar(250)
)
Drop Table Import,ImportDetail

ALTER TABLE Orders ADD FOREIGN KEY (AgentID) REFERENCES Agent(AgentID);
go
ALTER TABLE Orders ADD FOREIGN KEY (PaymentTypeID) REFERENCES PaymentType(PaymentTypeID);
go
ALTER TABLE OrderDetail ADD FOREIGN KEY (OrderID) REFERENCES Orders(OrderID);
go
ALTER TABLE OrderDetail ADD FOREIGN KEY (ProductID) REFERENCES Product(ProductID);
go
ALTER TABLE Product ADD FOREIGN KEY (CategoryID) REFERENCES Category(CategoryID);
go
ALTER TABLE Import ADD FOREIGN KEY (ProductID) REFERENCES Product(ProductID);
go
ALTER TABLE ImportDetail ADD FOREIGN KEY (IID) REFERENCES Import(IID);
go
ALTER TABLE ImportDetail ADD FOREIGN KEY (AccountantID) REFERENCES Accountant(AccountantID);
go
ALTER TABLE ImportDetail ADD FOREIGN KEY (ProductID) REFERENCES Product(ProductID);


