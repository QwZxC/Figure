SELECT Product.NAME, Category.NAME
FROM Product
JOIN Category ON Product.CategoryId = Category.Id