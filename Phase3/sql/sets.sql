USE sets
GO

CREATE TABLE Students2000(
    Name VARCHAR(15),
    TotalMark INT)

CREATE TABLE Students2005(
    Name VARCHAR(15),
    TotalMark INT)
GO

INSERT INTO Students2000 VALUES('Robert',1063);
INSERT INTO Students2000 VALUES('John',1070);
INSERT INTO Students2000 VALUES('Rose',1032);
INSERT INTO Students2000 VALUES('Abel',1002);
INSERT INTO Students2005 VALUES('Robert',1063);
INSERT INTO Students2005 VALUES('Rose',1032);
INSERT INTO Students2005 VALUES('Boss',1086);
INSERT INTO Students2005 VALUES('Marry',1034);
GO

SELECT * FROM Students2000
SELECT * FROM Students2005
GO

SELECT Name,TotalMark FROM students2000 UNION
SELECT Name,TotalMark FROM students2005
GO

SELECT Name,TotalMark FROM students2000 INTERSECT
SELECT Name,TotalMark FROM students2005
GO

SELECT Name,TotalMark FROM students2000 EXCEPT
SELECT Name,TotalMark FROM students2005
GO

SELECT Name,TotalMark FROM students2005 EXCEPT
SELECT Name,TotalMark FROM students2000
GO

