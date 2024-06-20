SELECT Product.NAME, Category.NAME
FROM Product
LEFT JOIN Category ON Product.CategoryId = Category.Id
