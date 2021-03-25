--Select
--ANSII
--Select ContactName Name, CompanyName, City from Customers order by ContactName

--Select * from Customers where City = 'London'

--Select * from Products where UnitsInStock != 0

--Select * from Products where CategoryID = 3 or CategoryID = 4 order by CategoryID

--Select * from Products where CategoryID = 1 and UnitPrice >= 10 

--select * from Products order by CategoryID,ProductName

--select * from Products where CategoryID = 1 order by UnitPrice desc

--select count(Products.ProductName) from Products

--select count(*) Adet from Products where CategoryID = 3

--select categoryId, count(*) CategoryProductAmount from Products group by CategoryID --> Group By CategoryId --> Hangi kategoride kaç ürün var

--select categoryId, count(*) CategoryProductAmount from Products group by CategoryID having count(*) < 10 --> Group By CategoryId --> Hangi kategoride kaç ürün var ve ürün sayısı 10 dan az olan kategorileri getir

select categoryId, count(*) CategoryProductAmount from Products where UnitPrice > 20 group by CategoryID having count(*) < 10


