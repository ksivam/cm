--Return the names of salespeople that have 2 or more orders.
select t2.Name as 'sales people that have 2 or more orders' from
(
--aggregate sales person id to get the number of orders per sales person.
select SalespersonID, COUNT(*) as NumOfOrders
from Orders 
group by SalespersonID
) as t1

inner join

(
--get the sales person name who have more than 1 order (ie. 2 or more orders)
select Name, SalespersonID 
from Salesperson
group by Name, SalespersonID
) as t2
on t1.SalespersonID=t2.SalespersonID and t1.NumOfOrders > 1