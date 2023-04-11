Use Northwind



GRANT SELECT ON dbo.Orders TO SalesRole;
GRANT SELECT ON dbo.Employees TO HRRole;
GRANT SELECT ON dbo.Orders TO CEORole;
GRANT SELECT ON dbo.Customers TO CEORole;
GRANT SELECT ON dbo.Employees TO CEORole;


Exec sp_addrolemember 'SalesRole', 'User_Sales';
Exec sp_addrolemember 'HRRole', 'User_HR';
Exec sp_addrolemember 'CEORole', 'User_CEO';
