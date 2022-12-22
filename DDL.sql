CREATE TABLE tbl_address (
	addr_id INT AUTO_INCREMENT,
	addr_1 VARCHAR(30) NOT NULL,
	addr_2 VARCHAR(30) NOT NULL,
	city VARCHAR(30) NOT NULL,
	postcode VARCHAR(8) NOT NULL,
	CONSTRAINT pk_address PRIMARY KEY (addr_id)
);

CREATE TABLE tbl_gender (
	gender_id INT AUTO_INCREMENT,
	gender VARCHAR(15) NOT NULL,
	CONSTRAINT pk_gender PRIMARY KEY (gender_id)
);

CREATE TABLE tbl_class (
	class_id INT AUTO_INCREMENT,
	class_name VARCHAR(20) NOT NULL,
	CONSTRAINT pk_class PRIMARY KEY (class_id)
);

CREATE TABLE tbl_student (
	stud_id INT AUTO_INCREMENT,
	stud_fname VARCHAR(20) NOT NULL,
	stud_lname VARCHAR(30) NOT NULL,
	stud_dob DATE NOT NULL,
	stud_email VARCHAR(50) NOT NULL,
	gender_id INT NOT NULL,
	addr_id INT NOT NULL,
	class_id INT NOT NULL,
	CONSTRAINT pk_student PRIMARY KEY (stud_id),
	CONSTRAINT fk_studentGender FOREIGN KEY (gender_id) REFERENCES tbl_gender(gender_id),
	CONSTRAINT fk_studentAddress FOREIGN KEY (addr_id) REFERENCES tbl_address(addr_id),
	CONSTRAINT fk_studentClass FOREIGN KEY (class_id) REFERENCES tbl_class(class_id)
);

CREATE TABLE tbl_enrolment (
	enrol_id INT AUTO_INCREMENT,
	enrol_date DATE NOT NULL,
	class_id INT NOT NULL,
	stud_id INT NOT NULL,
	CONSTRAINT pk_enrolment PRIMARY KEY (enrol_id),
	CONSTRAINT fk_enrolmentclass FOREIGN KEY (class_id) REFERENCES tbl_class(class_id),
	CONSTRAINT fk_enrolmentStudent FOREIGN KEY (stud_id) REFERENCES tbl_student(stud_id)
);

CREATE TABLE tbl_teaching_materials (
	material_id INT AUTO_INCREMENT,
	material_name INT NOT NULL,
	file_type INT NOT NULL,
	class_id INT NOT NULL,
	CONSTRAINT pk_teaching_materials PRIMARY KEY (material_id),
	CONSTRAINT fk_materialclass FOREIGN KEY (class_id) REFERENCES tbl_class(class_id)
);

