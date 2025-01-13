--Практика A

--SELECT * 
--FROM employees
--WHERE salary > 70000

--SELECT *
--FROM employees
--WHERE position == "Разработчик"

--SELECT *
--FROM employees
--WHERE position == "Разработчик"
--ORDER BY name

-- Практика B

--SELECT *
--FROM employees
--WHERE salary >  72000
--ORDER BY name DESC

--SELECT *
--FROM employees
--WHERE salary >  60000 AND salary < 80000

--SELECT *
--FROM employees
--WHERE department_id == 1
--ORDER BY salary

-- Практика C

--SELECT "position", COUNT("position")
--FROM employees
--WHERE department_id == 4
--GROUP BY "position"

SELECT position, SUM("salary")
FROM employees
WHERE department_id == 2
GROUP BY "position"

--SELECT "position", MAX(salary) as max
--FROM employees
--WHERE department_id == 2

--SELECT "position", MIN(salary) as min
--FROM employees
--WHERE department_id == 2


--SELECT *
--FROM employees
--WHERE department_id == 1 OR department_id == 2
--ORDER By salary DESC, "position"
