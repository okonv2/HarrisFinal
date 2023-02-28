SELECT * FROM tbl_student;

SELECT * FROM tbl_student WHERE stud_id = 1;

INSERT INTO tbl_student(stud_fname, stud_lname, stud_dob, stud_email, gender_id, addr_id, class_id) VALUES ("Victor", "Okon", '2003-04-06', "okonv2@coventry.ac.uk", 2, 2, 2);

UPDATE tbl_student
	SET
		stud_fname = "Victor",
		stud_lname = "Okon",
		stud_dob = '2003-04-06',
		stud_email = "okonv2@coventry.ac.uk",
		gender_id = 2,
		addr_id = 2,
		class_id = 2,
	WHERE stud_id = 1;

DELETE FROM tbl_student WHERE stud_id = 1;

