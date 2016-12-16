--Return the total Amount of orders for each month, ordered by year, then month (both in descending order)

select YEAR(OrderDate) as Year,  MONTH(OrderDate) as Month, SUM(CostOfUnit) as TotalAmountOfOrders 
from Orders 
group by YEAR(OrderDate), MONTH(OrderDate)
order by TotalAmountOfOrders desc