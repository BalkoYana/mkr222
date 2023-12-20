SELECT AVG(salary)as avgsalary , number
FROM Zavod
WHERE number = '3'
GROUP BY number