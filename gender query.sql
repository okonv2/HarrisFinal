SELECT * FROM tbl_gender;

SELECT * FROM tbl_gender WHERE gender_id = 1;

INSERT INTO tbl_gender(gender) VALUES ("Male");

UPDATE tbl_gender
	SET
		gender = "Male"
	WHERE gender_id = 1;

DELETE FROM tbl_gender WHERE gender_id = 1;