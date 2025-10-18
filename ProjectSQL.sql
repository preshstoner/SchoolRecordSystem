CREATE DATABASE StudentsDB; 

USE  StudentsDB; 
CREATE TABLE Students(
StudentId INT PRIMARY KEY AUTO_INCREMENT,
Name VARCHAR(100),
Age INT,
Gender VARCHAR(10),
DateOfBirth DATE,
Address VARCHAR(255),
FathersName VARCHAR(100),
MothersName VARCHAR(100),
FathersOccupation VARCHAR(100),
IsSpanishCitizen BOOLEAN,
Grade VARCHAR(10),
Division VARCHAR(10),
MajorSubject VARCHAR(50)
);