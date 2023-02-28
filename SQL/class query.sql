SELECT * FROM tbl_class;

SELECT * FROM tbl_class WHERE class_id = 1;

INSERT INTO tbl_class(class_name) VALUES ("Class 1");

UPDATE tbl_class
	SET
		class_name = "Class 1"
	WHERE class_id = 1;

DELETE FROM tbl_class WHERE class_id = 1;
