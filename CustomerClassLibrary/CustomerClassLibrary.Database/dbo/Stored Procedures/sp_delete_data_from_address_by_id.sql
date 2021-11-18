CREATE PROCEDURE sp_delete_data_from_address_by_id
	@AddressId INT
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM Address
	WHERE AddressId = @AddressId
END;