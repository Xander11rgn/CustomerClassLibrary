CREATE PROCEDURE sp_get_data_from_customer_by_id 
	@id INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM Customer WHERE CustomerId = @id
END;