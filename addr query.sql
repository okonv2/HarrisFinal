SELECT * FROM tbl_address;

SELECT * FROM tbl_address WHERE addr_id = 1;

INSERT INTO tbl_address(addr_1, addr_2, city, postcode) VALUES ("Bishop Gate", "Tower St", "Coventry", "CV11AJ");

UPDATE tbl_address
	SET
		addr_1 = "Bishop Gate",
		addr_2 = "Tower St",
		city = "Coventry",
		postcode = "okonv2@coventry.ac.uk"
	WHERE addr_id = 1;

DELETE FROM tbl_address WHERE addr_id = 1;