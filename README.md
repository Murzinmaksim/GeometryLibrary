Вопрос №2

Для выбора всех пар "Имя продукта - Имя категории", включая продукты, у которых нет категорий, можно использовать соединение таблицы Products с таблицей Categories при помощи оператора LEFT JOIN. Это позволит нам получить все продукты вместе с их категориями, а также продукты без категорий.

SELECT

    P.ProductName AS ProductName, 
    COALESCE(C.CategoryName, 'No Category') AS CategoryName
    
FROM

    Products 
    
LEFT JOIN

    ProductCategories PC ON P.ProductID = PC.ProductID
    
LEFT JOIN

    Categories C ON PC.CategoryID = C.CategoryID
