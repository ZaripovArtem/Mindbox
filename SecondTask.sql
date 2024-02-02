SELECT 
	p.Name AS 'Имя продукта'
	, ISNULL(c.Name, 'Без категории') AS 'Имя категории'
FROM Product p
LEFT JOIN ProductCategory pc ON 
	p.ProductId = pc.ProductId
LEFT JOIN Categories c ON 
	pc.CategoryId = c.CategoryId