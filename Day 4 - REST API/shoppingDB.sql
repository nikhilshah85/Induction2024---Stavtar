create database shoppingDB_2

use ShoppingDB_2

create table products
(
	pid int primary key,
	pName varchar(20),
	pCategory varchar(20),
	pPrice int,
	pIsInstock bit
)
insert into products values(501,'Pepsi','Cold-Drink',50,1)
insert into products values(502,'Nike','Shoes',5000,1)
insert into products values(503,'IPhone','Electronics',150000,0)
insert into products values(504,'Samsung Galaxy','Electronics',99000,1)
insert into products values(505,'Macbook','Electronics',250000,0)
insert into products values(506,'Appy','Cold-Drink',90,1)

insert into products values
		(506,'Appy','Cold-Drink',90,1),
		(506,'Appy','Cold-Drink',90,1),
		(506,'Appy','Cold-Drink',90,1)
		