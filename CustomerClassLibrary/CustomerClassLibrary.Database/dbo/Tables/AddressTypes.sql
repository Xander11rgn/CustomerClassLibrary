CREATE TABLE [dbo].[AddressTypes] (
    [AddressTypeId] INT          IDENTITY (1, 1) NOT NULL,
    [AddressType]   NVARCHAR (8) NOT NULL,
    CONSTRAINT [PK_AddressTypes] PRIMARY KEY CLUSTERED ([AddressTypeId] ASC),
    CONSTRAINT [CK_AddressTypes_AddressType] CHECK ([AddressType] like 'Shipping' OR [AddressType] like 'Billing'),
    CONSTRAINT [IX_AddressTypes_AddressType] UNIQUE NONCLUSTERED ([AddressType] ASC)
);

