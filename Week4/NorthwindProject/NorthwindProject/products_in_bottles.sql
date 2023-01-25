use Northwind

--SELECT CustomerID, CompanyName, Address, City
--FROM Customers
--WHERE City = 'Paris' OR City = 'London';

--SELECT ProductName, CompanyName, Country
--FROM Products p
--JOIN Suppliers s
--	ON p.SupplierID = s.SupplierID
--WHERE QuantityPerUnit LIKE '%bottle%';

--SELECT CategoryName,
--	SUM(UnitsInStock) AS "Total Stock"
--FROM Products p
--JOIN Categories c
--	ON p.CategoryID = c.CategoryID
--GROUP BY CategoryName
--ORDER BY SUM(UnitsInStock) DESC;

--SELECT TitleOfCourtesy + ' ' + FirstName + ' ' + LastName AS "Full Name", City 
--FROM Employees
--WHERE Country = 'UK';

--SELECT Freight, ShipCountry
--FROM Orders
--WHERE Freight > 100.0 AND ShipCountry IN ('USA','UK');

--SELECT TOP 1 OrderID, MAX(Discount * UnitPrice * Quantity) AS "Discount"
--FROM [Order Details]
--GROUP BY OrderID
--ORDER BY MAX(Discount * UnitPrice * Quantity) DESC;

--SELECT emp.FirstName + ' ' + emp.LastName AS "Full Name", rep.FirstName + ' ' + rep.LastName AS "Reports To"
--FROM Employees emp
--JOIN Employees rep
--	ON emp.ReportsTo = rep.EmployeeID;

--SELECT 
--	s.CompanyName,
--	AVG(p.UnitsOnOrder) AS "Average Items On Order"
--FROM Products p
--INNER JOIN Suppliers s
--	ON p.SupplierID = s.SupplierID
--GROUP BY s.CompanyName
--ORDER BY AVG(p.UnitsOnOrder) DESC;