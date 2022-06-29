CREATE DATABASE ProductsAndCategories;

USE ProductsAndCategories;

CREATE TABLE Categories (
	Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	CategoryName NVARCHAR(255) NOT NULL
);

CREATE TABLE Products (
	Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ProductName NVARCHAR(255) NOT NULL
);

CREATE TABLE ProductCategories (
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO Categories VALUES ('Phone');
INSERT INTO Categories VALUES ('Laptop');
INSERT INTO Categories VALUES ('Watches');

INSERT INTO Products VALUES ('Apple iPhone');
INSERT INTO Products VALUES ('Samsung Galaxy S21');
INSERT INTO Products VALUES ('Apple MacBook');
INSERT INTO Products VALUES ('Huawei MateBook');
INSERT INTO Products VALUES ('Apple Watch');
INSERT INTO Products VALUES ('Xiaomi MiBand');

INSERT INTO ProductCategories VALUES (1, 1);
INSERT INTO ProductCategories VALUES (1, 3);
INSERT INTO ProductCategories VALUES (2, 3);
INSERT INTO ProductCategories VALUES (2, 2);
INSERT INTO ProductCategories VALUES (2, 1);
INSERT INTO ProductCategories VALUES (4, 3);
INSERT INTO ProductCategories VALUES (4, 1);

SELECT Products.ProductName, Categories.CategoryName
FROM Products
LEFT JOIN ProductCategories PC
	ON Products.Id = PC.ProductId
LEFT JOIN Categories
	ON PC.CategoryId = Categories.Id;