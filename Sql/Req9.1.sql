--Return the names of all salespeople that have an order with George

select t3.Name as 'Name of sales people that have an order with George' from
(
-- get the customer id of George.
select CustomerID 
from Customer 
where UPPER(Name)=UPPER('George') 
) as t1

inner join

(
-- get the sales person id that have an order with George.
select SalespersonID, CustomerID 
from Orders 
group by SalespersonID, CustomerID 
) as t2
on t1.CustomerID=t2.CustomerID

inner join

(
-- get the sales person name that have an order with George.
select Name, SalespersonID 
from Salesperson 
group by Name, SalespersonID
) as t3
on t2.SalespersonID=t3.SalespersonID