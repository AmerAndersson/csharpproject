# What is SQL?
SQL is the standard language for dealing with Relational Databases.

SQL is used to insert, search, update, and delete database records.

How to Use SQL

## What is MySQL?
MySQL is a relational database management system (RDBMS)
MySQL is open-source
MySQL is free
MySQL is ideal for both small and large applications
MySQL is very fast, reliable, scalable, and easy to use
MySQL is cross-platform
MySQL is compliant with the ANSI SQL standard
MySQL was first released in 1995
MySQL is developed, distributed, and supported by Oracle Corporation
MySQL is named after co-founder Monty Widenius's daughter: My

## Show Data On Your Web Site
To build a web site that shows data from a database, you will need:
An RDBMS database program (like MySQL)
A server-side scripting language, like PHP
To use SQL to get the data you want
To use HTML / CSS to style the page

## MySQL SELECT
The SELECT statement is used to select data from a database.
The data returned is stored in a result table, called the result-set.

SELECT column1, column2, ...are the field names of the table you want to select data from.
FROM table_name;
`
SELECT * FROM Customers;
SELECT CustomerName, City, Country FROM Customers;
SELECT DISTINCT Country FROM Customers;
SELECT COUNT(DISTINCT Country) FROM Customers;
`

## 
-------------------------------------------------------------------------------------------------
| CustomerID | CustomerName	      | ContactName     | Address    | City   | PostalCode | Country
-------------------------------------------------------------------------------------------------
|   1  	      Alfreds Futterkiste	Maria Anders	Obere Str. 57	Berlin	 12209	      Germany
-------------------------------------------------------------------------------------------------

