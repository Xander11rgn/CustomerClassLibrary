CREATE PROCEDURE sp_get_data_from_address_by_id 
	@id INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM Address WHERE AddressId = @id
END;