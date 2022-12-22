DELIMITER // 
CREATE PROCEDURE sp_getstudents()
BEGIN 
	SELECT * FROM tbl_student; 
END //
DELIMITER ;

CALL sp_getstudents();


DELIMITER // 
CREATE PROCEDURE sp_getstudent(id INT)
BEGIN 
	SELECT * FROM tbl_student WHERE stud_id = id;
END //
DELIMITER ;

CALL sp_getstudent(2);


DELIMITER //
CREATE PROCEDURE sp_insertstudent(
	student_fname VARCHAR(20),
	student_lname VARCHAR(30),
	student_dob DATE,
	student_email VARCHAR(50),
	student_gender_id INT,
	student_addr_id INT,
	student_class_id INT
)
BEGIN
INSERT INTO tbl_student(stud_fname, stud_lname, stud_dob, stud_email, gender_id, addr_id, class_id) 
VALUES (student_fname, student_lname, student_dob, student_email, student_gender_id, student_addr_id, student_class_id);
END // 
DELIMITER ;

CALL sp_insertstudent("Victor", "Okon", '2003-04-06', "okonv2@coventry.ac.uk", 2, 2, 2);


DELIMITER //
CREATE PROCEDURE sp_deletestudeharrisdbnt(id INT)
BEGIN
DELETE FROM tbl_student WHERE stud_id = ID;
END //
DELIMITER ;

CALL sp_deletestudent(2);


DELIMITER //
CREATE PROCEDURE sp_updatestudent(
	id INT,
	student_fname VARCHAR(20),
	student_lname VARCHAR(30),
	student_dob DATE,
	student_email VARCHAR(50),
	student_gender_id INT,
	student_addr_id INT,
	student_class_id INT
)
BEGIN
	UPDATE tbl_student
		SET 
			stud_fname = student_fname,
			stud_lname = student_lname,
			stud_dob = student_dob,
			stud_email = student_email,
			gender_id = student_gender_id,
			addr_id = student_addr_id,
			class_id = student_class_id
			WHERE stud_id = id;
END // 
DELIMITER ;

CALL sp_updatestudent(2, "Victor", "Okon", '2003-04-06', "okonv2@coventry.ac.uk", 2, 2, 2);

            







