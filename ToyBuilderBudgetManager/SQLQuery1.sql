
CREATE DATABASE BudgetDB
GO

USE BudgetDB
go

CREATE TABLE UserProfile
(
  UserId INT PRIMARY KEY IDENTITY,
  FirstName VARCHAR(50),
  LastName VARCHAR(50),
  Salary DECIMAL(18,2)
);

CREATE TABLE BudgetPlan
(
	ExpenseId INT PRIMARY KEY IDENTITY,
	ExpenseName VARCHAR(50),
	Cost DECIMAL(18,2),
	DueDate DATETIME, 
	UserId INT FOREIGN KEY REFERENCES dbo.UserProfile(UserId)
);

SELECT * FROM dbo.UserProfile
GO

SELECT * FROM dbo.BudgetPlan
go