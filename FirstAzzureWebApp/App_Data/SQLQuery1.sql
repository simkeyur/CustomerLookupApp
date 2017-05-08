CREATE TABLE dbo.Users (
    userID int IDENTITY(1,1) PRIMARY KEY,
    LastName varchar(255),
    FirstName varchar(255),
    userName varchar(255),
    password varchar(255)
);

CREATE TABLE dbo.Customers (
    customerID int IDENTITY(1,1) PRIMARY KEY,
    LastName varchar(255),
    FirstName varchar(255),
    phoneNumber varchar(255),
    email varchar(255)
);

