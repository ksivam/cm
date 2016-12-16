--Create a new rollup table BigOrders(where columns are CustomerID, TotalOrderValue), and insert into that table
--customers whose total Amount across all orders is greater than 1000

-- insert the customers whose total order value is greater than 100
select t1.CustomerID, t1.TotalOrderValue into BigOrders from
(
--aggregate the order value for each customer
select CustomerID, SUM(CostOfUnit) as TotalOrderValue 
from Orders 
group by CustomerID
) as t1
where t1.TotalOrderValue > 1000