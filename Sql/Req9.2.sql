-- Return the names of all salespeople that do not have any order with George

select Name as 'Name of sales people that donot have any order with George' 
from Salesperson
where SalespersonID 
-- get the sales person name that dont have any order with Gorge.
NOT IN
(
-- get the sales person id that have an order with George.
select SalespersonID 
from Orders 
where CustomerID 
IN (
-- get the customer id of George.
select CustomerID 
from Customer 
where UPPER(Name)=UPPER('George')
)
)