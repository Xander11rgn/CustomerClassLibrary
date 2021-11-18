CREATE TABLE [dbo].[Addresses] (
    [AddressId]     INT            IDENTITY (1, 1) NOT NULL,
    [CustomerId]    INT            NOT NULL,
    [AddressLine]   NVARCHAR (100) NOT NULL,
    [AddressLine2]  NVARCHAR (100) NULL,
    [AddressTypeId] INT            NOT NULL,
    [City]          NVARCHAR (50)  NOT NULL,
    [PostalCode]    NVARCHAR (6)   NOT NULL,
    [State]         NVARCHAR (20)  NOT NULL,
    [CountryId]     INT            NOT NULL,
    CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED ([AddressId] ASC),
    CONSTRAINT [CK_Address_AddressLine] CHECK (len([AddressLine])<=(100)),
    CONSTRAINT [CK_Address_AddressLine2] CHECK (len([AddressLine2])<=(100)),
    CONSTRAINT [CK_Address_City] CHECK (len([City])<=(50)),
    CONSTRAINT [CK_Address_PostalCode] CHECK (len([PostalCode])<=(6)),
    CONSTRAINT [CK_Address_State] CHECK (len([State])<=(20)),
    CONSTRAINT [FK_Address_AddressTypes] FOREIGN KEY ([AddressTypeId]) REFERENCES [dbo].[AddressTypes] ([AddressTypeId]),
    CONSTRAINT [FK_Address_Countries] FOREIGN KEY ([CountryId]) REFERENCES [dbo].[Countries] ([CountryId]),
    CONSTRAINT [FK_Address_Customer] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customers] ([CustomerId])
);

