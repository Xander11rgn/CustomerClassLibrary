CREATE PROCEDURE sp_get_all_data_from_address AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM Address
END;