USE sets;
GO

CREATE SCHEMA hr;
GO

CREATE TABLE hr.candidates(
    id INT PRIMARY KEY IDENTITY,
    fullname VARCHAR(100) NOT NULL
);

CREATE TABLE hr.employees(
    id INT PRIMARY KEY IDENTITY,
    fullname VARCHAR(100) NOT NULL
);
GO

INSERT INTO 
    hr.candidates(fullname)
VALUES
    ('John Doe'),
    ('Lily Bush'),
    ('Peter Drucker'),
    ('Jane Doe');


INSERT INTO 
    hr.employees(fullname)
VALUES
    ('John Doe'),
    ('Jane Doe'),
    ('Michael Scott'),
    ('Jack Sparrow');

-- SQL Server Inner Join
-- Inner join produces a data set that includes rows from the left table which have matching rows from the right table.

-- The following example uses the inner join clause to get the rows from the candidates 
-- table that have the corresponding rows with the same values in the fullname column of the employees table:
SELECT  
    c.id candidate_id,
    c.fullname candidate_name,
    e.id employee_id,
    e.fullname employee_name
FROM 
    hr.candidates c
    INNER JOIN hr.employees e 
        ON e.fullname = c.fullname;

-- SQL Server Left Join
-- Left join selects data starting from the left table and matching rows in the right table. 
-- The left join returns all rows from the left table and the matching rows from the right table. 
-- If a row in the left table does not have a matching row in the right table, the columns of the right table will have nulls.

-- The following statement joins the candidates table with the employees table using left join:
SELECT  
	c.id candidate_id,
	c.fullname candidate_name,
	e.id employee_id,
	e.fullname employee_name
FROM 
	hr.candidates c
	LEFT JOIN hr.employees e 
		ON e.fullname = c.fullname;

-- To get the rows that available only in the left table but not in the right table, you add a WHERE clause to the above query:

SELECT  
    c.id candidate_id,
    c.fullname candidate_name,
    e.id employee_id,
    e.fullname employee_name
FROM 
    hr.candidates c
    LEFT JOIN hr.employees e 
        ON e.fullname = c.fullname
WHERE 
    e.id IS NULL;

-- SQL Server Right Join
-- The right join or right outer join selects data starting from the right table. It is a reversed version of the left join.
-- The right join returns a result set that contains all rows from the right table and the matching rows in the left table. 
-- If a row in the right table that does not have a matching row in the left table, all columns in the left table will contain nulls.

-- The following example uses the right join to query rows from candidates and employees tables:

SELECT  
    c.id candidate_id,
    c.fullname candidate_name,
    e.id employee_id,
    e.fullname employee_name
FROM 
    hr.candidates c
    RIGHT JOIN hr.employees e 
        ON e.fullname = c.fullname;

-- Similarly, you can get rows that are available only in the right table by adding a WHERE clause to the above query as follows:

SELECT  
    c.id candidate_id,
    c.fullname candidate_name,
    e.id employee_id,
    e.fullname employee_name
FROM 
    hr.candidates c
    RIGHT JOIN hr.employees e 
        ON e.fullname = c.fullname
WHERE
    c.id IS NULL;

-- SQL Server full join
-- The full outer join or full join returns a result set that contains all rows from both left and right tables, with the matching rows from both sides where available. 
-- In case there is no match, the missing side will have NULL values.

-- The following example shows how to perform a full join between the candidates and employees tables:

SELECT  
    c.id candidate_id,
    c.fullname candidate_name,
    e.id employee_id,
    e.fullname employee_name
FROM 
    hr.candidates c
    FULL JOIN hr.employees e 
        ON e.fullname = c.fullname;

-- To select rows that exist either left or right table, you exclude rows that are common to both tables by adding a WHERE clause as shown in the following query:

SELECT  
    c.id candidate_id,
    c.fullname candidate_name,
    e.id employee_id,
    e.fullname employee_name
FROM 
    hr.candidates c
    FULL JOIN hr.employees e 
        ON e.fullname = c.fullname
WHERE
    c.id IS NULL OR
    e.id IS NULL;