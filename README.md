# How to Use
Before starting the application, there are a few things that needs to be configured.
1. Create a local database named **"CircuitCentral"**, or name of your preference, inside Microsoft SQL Server Management Studio (SMSS).
- A .txt file that has all necessary queries to create the database is provided inside the repository or pasted inside here.
- Inside SMSS, just click "New Query" and copy and paste the SQL queries I have provided and click Execute.
2. Connect the database via Server Explorer in Visual Studio.
- If you are facing any connection errors, try to set Encrypt to Optional (False) and disable Trust Server Certificate (this is not recommended but since we are only working on a local database, it is passable.)
3. Copy the connecting string from properties of database
4. Paste the connection string on the public constant variable named **"ConnectionString"**. This is found under **public class Function** inside Program.cs
5. Optional: set admin login details to your preference. This is found right under ConnetionString constant variable inside Program.cs
6. Run the program
7. If logging in with admin priviledges, type "admin" for both email address and password. If first time logging in, register first.

# SQL
```
CREATE DATABASE CircuitCentral;
GO

USE CircuitCentral;
GO

CREATE TABLE Address (
  id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
  street VARCHAR(255) NOT NULL,
  city VARCHAR(255) NOT NULL,
  postal_code VARCHAR(255) NOT NULL,
  country VARCHAR(255) NOT NULL
);
GO

CREATE TABLE Supplier (
  id INT NOT NULL IDENTITY(7000,1) PRIMARY KEY,
  name VARCHAR(255) NOT NULL,
  email_address VARCHAR(255) NOT NULL,
  phone_number VARCHAR(255) NOT NULL,
  address_id INT NOT NULL,
  CONSTRAINT FK_Supplier_Address FOREIGN KEY (address_id) REFERENCES Address (id)
);
GO

CREATE TABLE Customer (
  id INT NOT NULL IDENTITY(1000,1) PRIMARY KEY,
  name VARCHAR(255) NOT NULL,
  email_address VARCHAR(255) NOT NULL,
  [password] VARCHAR(255) NOT NULL,
  phone_number VARCHAR(20) NOT NULL,
  address_id INT NOT NULL,
  CONSTRAINT FK_Customer_Address FOREIGN KEY (address_id) REFERENCES [Address] (id)
);
GO

CREATE TABLE Staff (
  id INT NOT NULL IDENTITY(500,1) PRIMARY KEY,
  name VARCHAR(255) NOT NULL,
  email_address VARCHAR(255) NOT NULL,
  [password] VARCHAR(255) NOT NULL,
  phone_number VARCHAR(20) NOT NULL,
  department VARCHAR(255) NOT NULL,
  address_id INT NOT NULL,
  CONSTRAINT FK_Staff_Address FOREIGN KEY (address_id) REFERENCES [Address] (id)
);
GO

CREATE TABLE Product (
  id INT NOT NULL IDENTITY(3000,1) PRIMARY KEY,
  supplier_id INT NOT NULL,
  name VARCHAR(255) NOT NULL,
  [description] VARCHAR(255) NOT NULL,
  category VARCHAR(255) NOT NULL,
  price DECIMAL(10,2) NOT NULL,
  [stock] INT NOT NULL,
[image_link] VARCHAR(255),
  CONSTRAINT FK_Product_Supplier FOREIGN KEY (supplier_id) REFERENCES Supplier (id)
);
GO

CREATE TABLE [Transaction] (
  id INT NOT NULL IDENTITY(9000,1) PRIMARY KEY,
  total_amount DECIMAL(10,2) NOT NULL,
  payment_method NVARCHAR(20) NOT NULL,
  [date] DATE NOT NULL,
  [status] NVARCHAR(20) NOT NULL
);
GO

CREATE TABLE [Order] (
  id INT NOT NULL IDENTITY(5000,1) PRIMARY KEY,
  customer_id INT NOT NULL,
  transaction_id INT NOT NULL,
  [date] DATE NOT NULL,
  [status] NVARCHAR(20) NOT NULL,
  CONSTRAINT FK_Order_Customer FOREIGN KEY (customer_id) REFERENCES Customer (id),
  CONSTRAINT FK_Order_Transaction FOREIGN KEY (transaction_id) REFERENCES [Transaction] (id)
);
GO

CREATE TABLE OrderDetail (
  id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
order_id INT NOT NULL,
  product_id INT NOT NULL,
  unit_price INT NOT NULL,
  quantity INT NOT NULL,
  CONSTRAINT FK_OrderDetail_Product FOREIGN KEY (product_id) REFERENCES Product (id),
CONSTRAINT FK_OrderDetail_Order FOREIGN KEY (order_id) REFERENCES [Order] (id)
);
```
