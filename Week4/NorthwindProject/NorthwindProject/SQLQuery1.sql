USE engineering_134_students;

DROP TABLE IF EXISTS Students;
DROP TABLE IF EXISTS Courses;

CREATE TABLE Courses(
	course_id INT PRIMARY KEY IDENTITY(1,1),
	course_name VARCHAR(40) UNIQUE
);

CREATE TABLE Students(
	student_id INT PRIMARY KEY IDENTITY(1,1),
	title VARCHAR(4),
	first_name VARCHAR(20),
	last_name VARCHAR(20),
	course_id INT FOREIGN KEY REFERENCES Courses (course_id),
	mark_achieved VARCHAR(4)
);

ALTER TABLE Courses
ADD student_id INT FOREIGN KEY REFERENCES Students (student_id);


INSERT INTO Courses
	(course_name)
VALUES
	('Interactive Media'),
	('Physics'),
	('Chemical Engineering'),
	('Natural Sciences');

INSERT INTO Students
	(title, first_name, last_name, course_id) 
VALUES
	('Mr', 'Scot', 'Morrison', 1),
	('Mr', 'Caner', 'Dursun', 2),
	('Mr', 'Maajid', 'Ali', 3),
	('Mr', 'Jasser', 'Bawi', 3),
	('Mr', 'Mehdi', 'Hamdi', 3),
	('Mr', 'Faisal', 'Khalaf', 3),
	('Ms', 'Ikra', 'Dahir', NULL),
	('Mr', 'Alex', 'Blunt', 4)
;