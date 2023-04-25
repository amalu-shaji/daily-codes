create table Client_Master

(

 ClientNo varchar(6) check(ClientNo like 'C%') primary key not null,

 Name varchar(20) not null,

 Address1 varchar(30),

 Address2 varchar(30),

 City varchar(15),

 Pincode numeric(8),

 State varchar(15),

 BalDue numeric(10,2)

 );

create table Product_Master

 (

 ProductNo varchar(6) check(ProductNo like 'P%') primary key not null,

 Description varchar(15) not null,

 ProfitPerc numeric(4,2) not null,

 UnitMeasure varchar(10) not null,

 QtyonHand numeric(8) not null,

 ReorderLvl numeric(8) not null ,

 SellPrice numeric(8,2) check(SellPrice !=0),

 CostPrice numeric(8,2) check(CostPrice !=0)

);

create table Salesman_Master

(

 SalesManno varchar(6) check(SalesManno like 'S%') primary key,

 SalesManname varchar(20) not null,

 Address1 varchar(30) not null,

 Address2 varchar(30) not null,

 City varchar(20),

 Pincode numeric(8),

 State varchar(20),

 Salamt numeric(8,2) check(salamt!=0) not null,

 Tgttoget numeric(6,2) not null,

 Ytdsales numeric(6,2) not null,

 Remarks varchar(60)

);

create table Sales_Order

(

 OrderNo varchar(6) check(OrderNo like 'O%') primary key,

 ClientNo varchar(6) foreign key(ClientNo) references Client_Master(ClientNo),

 OrderDate date,

 DelyAddr varchar(25),

 SalesManNo varchar(6) foreign key(SalesManNo) references Salesman_Master(SalesmanNo),

 DelyType char(1) check(DelyType='P' or DelyType='F'),

 BilledYn char(1) check(BilledYn='Y' or BilledYn='N'),

 DelyDate date,

 OrderStatus varchar(10) check(OrderStatus='In Process' or OrderStatus='Fullfilled' or OrderStatus='Backorder' or OrderStatus='Cancelled')

);

create table Sales_Order_Details

(

 OrderNo varchar(6) foreign key(OrderNo) references Sales_Order(OrderNo),

 ProductNo varchar(6) foreign key(ProductNo) references Product_Master(ProductNo),

 QtyOrdered numeric(8),

 QtyDisp numeric(8),

 ProductRate numeric(10,2),

 primary key(OrderNo,ProductNo)

);

--Client_Master

INSERT INTO Client_Master (ClientNo, Name, City, PinCode, State, BalDue) VALUES ('C00001', 'Ivan Bayross', 'Mumbai', 400054, 'Maharashtra', 15000);

INSERT INTO Client_Master (ClientNo, Name, City, PinCode, State, BalDue) VALUES ('C00002', 'Aswini Sai', 'Banglore', 560001, 'Karnataka',5000);

INSERT INTO Client_Master (ClientNo, Name, City, PinCode, State, BalDue) VALUES ('C00003', 'Dhyan', 'Mumbai', 400054, 'Maharashtra',0);

INSERT INTO Client_Master (ClientNo, Name, City, PinCode, State, BalDue) VALUES ('C00004', 'Deepu', 'Madras', 780001, 'Tamilnadu', 2000);

INSERT INTO Client_Master (ClientNo, Name, City, PinCode, State, BalDue) VALUES ('C00005', 'Ananya', 'Thissur', 690558, 'Kerala', 0);

--Product_Master

INSERT INTO Product_Master VALUES ('P00001', 'T-Shirts', 5, 'Piece', 200, 50, 350, 250);

INSERT INTO Product_Master VALUES ('P00002', 'Shirts', 6, 'Piece', 150, 50, 600, 350);

INSERT INTO Product_Master VALUES ('P00003', 'Jeans', 4, 'Piece', 100, 20, 750,500);

INSERT INTO Product_Master VALUES ('P00004', 'Skirts', 5, 'Piece', 70, 30, 850, 250);

INSERT INTO Product_Master VALUES ('P00005', 'Tops', 5, 'Piece', 75, 40, 300, 300);

--Salesman_Master

INSERT INTO Salesman_Master VALUES ('S00001', 'Aman', 'A/14', 'Worli', 'Mumbai', 400002, 'Maharashtra', 3000, 100, 50, 'Good');

INSERT INTO Salesman_Master VALUES ('S00002', 'Ashish', '65', 'Badra', 'Mumbai', 400001, 'Maharashtra', 2000, 200, 40, 'Good');

INSERT INTO Salesman_Master VALUES ('S00003', 'Rahul', 'B/7', 'Jani', 'Mumbai', 400004, 'Maharashtra', 3000, 100, 20, 'Good');

INSERT INTO Salesman_Master VALUES ('S00004', 'Raj', 'A/5', 'Vemam', 'Mumbai', 400005, 'Maharashtra', 1000, 200, 30, 'Good');

INSERT INTO Salesman_Master VALUES ('S00005', 'Abin', 'A/13', 'Keerthika', 'Mumbai', 400007, 'Maharashtra', 4000, 300, 10, 'Good');

--Sales_Order

 INSERT INTO Sales_Order (OrderNo, OrderDate, ClientNo, DelyType, BilledYn, SalesmanNo, DelyDate, OrderStatus)

 VALUES('O19001', '12-june-02', 'C00001', 'F', 'N', 'S00001', '20-july-02', 'In Process');

 INSERT INTO Sales_Order (OrderNo, OrderDate, ClientNo, DelyType, BilledYn, SalesmanNo, DelyDate, OrderStatus)

 VALUES('O19002', '10-june-04', 'C00002', 'P', 'Y', 'S00002', '27-june-06', 'Cancelled');

 INSERT INTO Sales_Order (OrderNo, OrderDate, ClientNo, DelyType, BilledYn, SalesmanNo, DelyDate, OrderStatus)

 VALUES('O19003', '03-april-04', 'C00003', 'F', 'N', 'S00003', '07-Apr-12', 'Fullfilled');

 INSERT INTO Sales_Order (OrderNo, OrderDate, ClientNo, DelyType, BilledYn, SalesmanNo, DelyDate, OrderStatus)

 VALUES('O19004', '24-may-03', 'C00004', 'P', 'N', 'S00004', '26-may-05', 'Backorder');

 INSERT INTO Sales_Order (OrderNo, OrderDate, ClientNo, DelyType, BilledYn, SalesmanNo, DelyDate, OrderStatus)

 VALUES('O19005', '20-feb-01', 'C00005', 'F', 'Y', 'S00005', '20-june-08', 'In Process');

 --Sales_Order_Details

INSERT INTO Sales_Order_Details (OrderNo, ProductNo, Qtyordered, QtyDisp, ProductRate) VALUES('O19001', 'P00001', 4, 4, 525);

INSERT INTO Sales_Order_Details (OrderNo, ProductNo, QtyOrdered, QtyDisp, ProductRate) VALUES('O19002', 'P00002', 2, 1, 5250);

INSERT INTO Sales_Order_Details (OrderNo, ProductNo, QtyOrdered, QtyDisp, ProductRate) VALUES('O19003', 'P00003', 1, 0, 3150);

INSERT INTO Sales_Order_Details (OrderNo, ProductNo, QtyOrdered, QtyDisp, ProductRate) VALUES('O19004', 'P00004', 4, 5, 8400);

INSERT INTO Sales_Order_Details (OrderNo, ProductNo, QtyOrdered, QtyDisp, ProductRate) VALUES('O19005', 'P00005', 0, 6, 1500);
--answer following queries with the help of above schema :
--1. Display the names of all the clients.

select Name from Client_Master;

--2. Display all the clients who are located in Mumbai.

select * from Client_Master where City='Mumbai';

--3. Display all the products whose selling price is > 2000 and < 5000.

select * from Product_Master where SellPrice>2000 and SellPrice<5000 ;

--4. Display Name, City and State of Clients not in the state of

--Maharashtra.

select Name,City,State from Client_Master where State!='Maharashtra';

--5. Display all the information of client_no C0001 and C0002.

select * from Client_Master where ClientNo in('C00001','C00002');

--6. Change the selling price of '1.44 drive' to Rs. 1150.50.

update Product_Master set SellPrice=1.44 where SellPrice=1150.50

--7. Delete the record of client_no C0005.

delete Client_Master where ClientNo='C0005';

--8. Display the clients who stay in a city whose second letter is 'a'.

select * from Client_Master where city like '_a%';

--9. Count the number of products having price greater than or equal to

--1500.

select count(ProductNo) as NUMBER_OF_PRODUCTS from Product_Master where SellPrice>=1500;

--10. Display qtyordered, qtydisp and balancedqty (not in table)

select QtyOrdered,QtyDisp as Balancedqty from Sales_Order_Details;
--Write Commands to do following [10] Define in 1 or 2 lines and give one example also [10] 

--1. Make Client_no as primary key in client_master.

alter table Client_Master add primary key(ClientNo);

--2. Add a new column phone_no in the client_master table.

alter table Client_Master add phone_no int;

--3. Add the not null constraint in the product_master table with the

--column description, profit percent, sell price and cost price.

alter table Product_Master alter column Description varchar(15) not null;

alter table Product_Master alter column ProfitPerc numeric(4,2) not null;

alter table Product_Master alter column SellPrice numeric(8,2) not null;

alter table Product_Master alter column CostPrice numeric(8,2) not null;

--4. Change size of name column to 60 in client_master table.

alter table Client_Master alter column Name varchar(60);

--5. Remove pincode column from table

alter table Client_Master drop column Pincode;

--Write queries for following descriptions: (Joins ) 


--Find out the products, which have been sold to 'Ivan Bayross'.



select * from product_master join

sales_order_details on product_master.productno=sales_order_details.productno

join sales_order on sales_order.orderno=sales_order_details.orderno

join client_master on client_master.clientno=sales_order.clientno

where client_master.name='Ivan Bayross';

-- Finding out the products and their quantities that will have to be delivered in the current month.

select product_master.productno,product_master.qtyonhand from product_master join

sales_order_details on product_master.productno=sales_order_details.productno

join sales_order on sales_order.orderno=sales_order_details.orderno

where month(sales_order.delydate)='04';

--Listing the ProductNo and description of constantly sold (i.e. rapidly moving) products.

select product_master.productno,product_master.description from product_master join sales_order_details on

product_master.productno=sales_order_details.productno

where sales_order_details.qtyordered>5;

--Finding the names of clients who have purchased 'Trousers'.

select client_master.name from client_master join sales_order on

client_master.clientno=sales_order.clientno join

sales_order_details on sales_order.orderno=sales_order_details.orderno

join product_master on sales_order_details.productno=product_master.productno

where product_master.description='Trousers';

--Listing the products and orders from customers who have ordered less than 5 units of 'Pull Overs'

select * from client_master join sales_order on

client_master.clientno=sales_order.clientno join

sales_order_details on sales_order.orderno=sales_order_details.orderno

join product_master on sales_order_details.productno=product_master.productno

where sales_order_details.qtyordered<5 ;



--subquery
-- Finding the non-moving products i.e. products not being sold.

select * from product_master where productno not in(select productno from sales_order_details);

--Finding the name and complete address for the customer who has placed Order number 'O19001'.

select name,city from client_master where clientno in (select clientno from sales_order where orderno='O19001');

-- Finding the clients who have placed orders before the month of May'02.

SELECT clientno, NAME FROM client_master WHERE clientno IN(SELECT clientno FROM SALES_ORDER WHERE TO_CHAR(orderdate, 'MON,YY') < 'MAY,02');



--Write Commands to do following 
--Display system date as Saturday, February 11, 2012

select concat(datename(weekday,getdate()),', ',datename(month,getdate()),' ',day(current_timestamp),' ',year(current_timestamp));

--Display Balance Due from Client master as $99,999.99

select format(baldue,'C', 'en-US') from client_master ;

-- Display message as 'Salesman Aman sold goods of 50 while given target was 100.

select concat(salesmanname,' sold goods of ',salamt,' while given target was ',tgttoget) from salesman_master;




