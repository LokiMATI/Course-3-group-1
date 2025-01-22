-- 1

SELECT *
FROM order_details od
FULL JOIN orders o ON od.order_id = o.id
FULL JOIN customers c ON o.customer_id = c.id
FULL JOIN products p ON od.product_id = p.id

SELECT c.customer_name, o.order_date, od.product_id, od.quantity
FROM customers c 
FULL JOIN orders o ON c.id = o.customer_id
FULL JOIN order_details od ON o.id = od.order_id

SELECT p.product_name, od.quantity
FROM order_details od
FULL JOIN products p ON od.product_id = p.id

SELECT c.customer_name, p.product_name 
FROM customers c 
FULL JOIN orders o ON c.id = o.customer_id
FULL JOIN order_details od ON o.id = od.order_id
FULL JOIN products p ON od.product_id = p.id

-- 2

SELECT p.product_name, p.price
FROM products p 
INNER JOIN categories c ON p.category_id = c.id
WHERE p.category_id == 3

SELECT c.customer_name, od.quantity * p.price
FROM customers c 
INNER JOIN orders o ON c.id = o.customer_id
INNER JOIN order_details od ON o.id = od.order_id
INNER JOIN products p ON od.product_id = p.id
WHERE od.quantity * p.price > 100

-- 3

SELECT customer_name
FROM customers
WHERE id NOT IN (SELECT customer_id
FROM orders)

SELECT c.customer_name, p.product_name 
FROM customers c 
FULL JOIN orders o ON c.id = o.customer_id
FULL JOIN order_details od ON o.id = od.order_id
FULL JOIN products p ON od.product_id = p.id

SELECT o.*, p.*
FROM orders o
CROSS JOIN products p 
WHERE p.category_id != 1