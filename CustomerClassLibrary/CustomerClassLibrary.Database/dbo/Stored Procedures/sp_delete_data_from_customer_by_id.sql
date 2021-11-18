CREATE PROCEDURE sp_delete_data_from_customer_by_id
	@CustomerId INT
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM Customer
	WHERE CustomerId = @CustomerId
END;