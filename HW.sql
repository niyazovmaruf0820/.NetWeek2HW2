create table Customers
(
	Id serial primary key,
	Name varchar,
	Balance decimal
); 

insert into Customers(Name,Balance)values('Maruf',100000),
										 ('Mustafo',1000),
										 ('Davron',10000),
										 ('Mumtoz',10000),
										 ('Samir',100000),
										 ('Ismoil',10000),
										 ('Sunnatulo',10),
										 ('Orzu',1000000),
										 ('Yusuf',100000)
										 
										 drop table Customers
										 
										 select * from Customers order by id
update Customers set Balance = Balance - 1000 where Id = 1
update Customers set Balance = Balance + 1000 where Id = 7
										 
										 
create table Transactions
(
	Id serial primary key,
	SenderId int references Customers(Id),
	RecipientId int references Customers(Id),
	Amount decimal,
	TransactionDate date
);

select * from Transactions



