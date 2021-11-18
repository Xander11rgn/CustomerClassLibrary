CREATE PROCEDURE sp_update_data_in_customer_by_id
	@CustomerId INT,
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@CustomerPhoneNumber nvarchar(16),
	@CustomerEmail nvarchar(100),
	@Notes ntext,
	@TotalPurchasesAmount smallmoney
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE Customer
	SET FirstName = @FirstName, LastName = @LastName, @CustomerPhoneNumber = @CustomerPhoneNumber, CustomerEmail = @CustomerEmail, Notes = @Notes, TotalPurchasesAmount = @TotalPurchasesAmount
	WHERE CustomerId = @CustomerId;
END;