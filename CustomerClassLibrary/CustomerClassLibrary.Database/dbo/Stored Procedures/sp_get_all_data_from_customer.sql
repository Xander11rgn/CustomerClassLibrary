CREATE PROCEDURE sp_get_all_data_from_customer AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM Customer
END;