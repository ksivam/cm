--Return the name of the salesperson with the 3rd highest salary.

-- get the last sales person in the top 3 highest saleried sales person. 
select top 1 t1.Name as 'sales person with 3rd highest salary' from
(
-- get the top 3 highest saleried sales person.
select top 3 Name, Salary 
from Salesperson 
order by Salary desc
) as t1
order by t1.Salary asc