CREATE DATABASE CollegeDB;

USE CollegeDB;

CREATE TABLE Students
(
    Id INT PRIMARY KEY,
    Name VARCHAR(50),
    Department VARCHAR(50),
    Mark INT
);

INSERT INTO Students VALUES
(1, 'Mohan', 'Information Technology', 85),
(2, 'Arun', 'Computer Science', 90),
(3, 'Iniya', 'Information Technology', 88),
(4, 'Kumar', 'Computer Science', 78);