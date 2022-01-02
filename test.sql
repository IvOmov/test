SELECT ProductName, CategoryName FROM Products
WHERE ProductName = 'Имя_продукта' AND (CategoryName IN 'Имя_Категории' OR CategoryName IS NULL)