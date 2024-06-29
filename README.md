# CIRCUITCENTRAL
![ImageCircuitCentral1](https://github.com/shadowisf/CircuitCentral/assets/97739695/79e29d50-e889-43cf-846f-2726add067a7)

&emsp;

## SETUP
Before starting the application, there are a few things that needs to be configured.
1. Install Visual Studio, with WinForms and .NET 8.0.
2. Install Microsoft SQL Server
3. Clone or download this repository and open the solution file (the CircuitCentral.sln file) in Visual Studio.
4. Create a local database named **"CircuitCentral"**, inside Microsoft SQL Server Management Studio (SMSS).
- A .txt file that has all necessary queries to create the database is provided inside the repository or pasted inside here.
- Inside SMSS, just click "New Query" and copy and paste the SQL queries I have provided and click Execute.
5. Connect the database via Server Explorer in Visual Studio.
- If you are facing any connection errors, try to set Encrypt to Optional (False) and disable Trust Server Certificate (this is not recommended but since we are only working on a local database, it is passable.)
6. Copy the connecting string from properties of database
7. Paste the connection string on the public constant variable named **"ConnectionString"**. This is found under **public class Function** inside Program.cs
8. Optional: set admin login details to your preference. This is found right under ConnetionString constant variable inside Program.cs
9. Run the project
10. If logging in with admin priviledges, type "admin" for both email address and password. If first time logging in, register first.

&emsp;

## SQL
Below is the SQL query provided. I have provided pre-existing records for testing. If you want to start blank copy the query only until OrderDetail table creation.
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
GO



INSERT INTO Address (street, city, postal_code, country)
VALUES
('123 Main St', 'Anytown', '12345', 'USA'),
('456 Elm St', 'Otherville', '67890', 'UK'),
('789 Oak St', 'Sometown', '13579', 'Canada'),
('321 Pine St', 'Anothercity', '24680', 'Australia'),
('555 Maple St', 'Yourtown', '98765', 'Germany');

INSERT INTO Supplier (name, email_address, phone_number, address_id)
VALUES
('TechCorp', 'techcorp@example.com', '123-456-7890', 1),
('ElectroTech', 'electrotech@example.com', '987-654-3210', 2),
('GadgetMasters', 'gadgetmasters@example.com', '555-555-5555', 3),
('CircuitWorld', 'circuitworld@example.com', '111-222-3333', 4),
('FutureElectronics', 'future@example.com', '999-888-7777', 5);

INSERT INTO Customer (name, email_address, [password], phone_number, address_id)
VALUES
('John Doe', 'john.doe@example.com', 'password123', '111-111-1111', 2),
('Jane Smith', 'jane.smith@example.com', 'password456', '222-222-2222', 3),
('Alice Johnson', 'alice.johnson@example.com', 'password789', '333-333-3333', 4),
('Bob Brown', 'bob.brown@example.com', 'passwordabc', '444-444-4444', 5),
('Emily Davis', 'emily.davis@example.com', 'passworddef', '555-555-5555', 1),
('Mark Wilson', 'mark.wilson@example.com', 'passwordghi', '666-666-6666', 3),
('Sarah Lee', 'sarah.lee@example.com', 'passwordjkl', '777-777-7777', 4),
('David Taylor', 'david.taylor@example.com', 'passwordmno', '888-888-8888', 5),
('Emma Clark', 'emma.clark@example.com', 'passwordpqr', '999-999-9999', 1),
('James Martinez', 'james.martinez@example.com', 'passwordstu', '000-000-0000', 2);

INSERT INTO Staff (name, email_address, [password], phone_number, department, address_id)
VALUES
('Michael Johnson', 'michael.johnson@example.com', 'staffpass1', '111-222-3333', 'Sales & Marketing', 1),
('Jennifer Williams', 'jennifer.williams@example.com', 'staffpass2', '222-333-4444', 'Sales & Marketing', 2),
('Christopher Brown', 'christopher.brown@example.com', 'staffpass3', '333-444-5555', 'Technology & IT', 3),
('Amanda Jones', 'amanda.jones@example.com', 'staffpass4', '444-555-6666', 'Operations & Logistics', 4),
('Matthew Garcia', 'matthew.garcia@example.com', 'staffpass5', '555-666-7777', 'Product Management', 5);

INSERT INTO Product (supplier_id, name, [description], category, price, [stock], image_link)
VALUES
(7001, 'iPhone 15 Pro Max', '(256 GB) - Natural Titanium', 'smartphones & mobile devices', 4499.99, 85, 'https://m.media-amazon.com/images/I/81YSmKnlijL._AC_SL1500_.jpg'),
(7004, 'Sony WH-1000XM4', 'Wireless Noise Cancelling Bluetooth Over-Ear Headphones With Speak To Chat Function And Mic For Phone Call, Black, Universal', 'audio & headphones', 799.99, 92, 'https://m.media-amazon.com/images/I/41xvg7mwu3L._AC_SL1000_.jpg'),
(7000, 'Microsoft Xbox Series X', '1TB Game Console - Black', 'gaming & accessories', 1599.99, 63, 'https://m.media-amazon.com/images/I/51ojzJk77qL._AC_SL1500_.jpg'),
(7003, 'Dell XPS 9370-7040', '4K HD Touchscreen Display Laptop, Intel Core i7, 13.3 Inch, 1TB SSD, 16GB RAM, Intel UHD Graphics 620, Windows 10, Eng KB, Silver', 'computers & laptops', 3199.99, 12, 'https://m.media-amazon.com/images/I/71AgLjviG3L._AC_SL1280_.jpg'),
(7002, 'ASUS RT-AX86U Pro', 'Dual Band WiFi 6 Extendable Gaming Router, 2.5G Port, Gaming Port, Mobile Game Mode, Port Forwarding, Subscription-free Network Security, VPN, AiMesh Compatible', 'networking & accessories', 899.99, 87, 'https://m.media-amazon.com/images/I/71SISFYdqDL._AC_SL1500_.jpg');

INSERT INTO [Transaction] (total_amount, payment_method, [date], [status])
VALUES
(4499.99, 'cash', '2024-04-28', 'pending'),
(3999.98, 'card', '2024-04-28', 'failed'),
(2699.97, 'bank', '2024-04-28', 'success');

INSERT INTO [Order] (customer_id, transaction_id, [date], [status])
VALUES
(1004, 9000, '2024-04-28', 'pending'),
(1005, 9001, '2024-04-28', 'cancelled'),
(1009, 9002, '2024-04-28', 'delivered');

INSERT INTO OrderDetail (order_id, product_id, unit_price, quantity)
VALUES
(5000, 3000, 4499, 1),
(5001, 3001, 799, 1),
(5001, 3003, 3199, 1),
(5002, 3004, 899, 3);
```
