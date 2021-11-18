CREATE TABLE [dbo].[Customers] (
    [CustomerId]           INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]            NVARCHAR (50)  NULL,
    [LastName]             NVARCHAR (50)  NOT NULL,
    [CustomerPhoneNumber]  NVARCHAR (16)  NULL,
    [CustomerEmail]        NVARCHAR (100) NULL,
    [Notes]                NTEXT          NOT NULL,
    [TotalPurchasesAmount] SMALLMONEY     NULL,
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([CustomerId] ASC),
    CONSTRAINT [CK_Customer_FirstName] CHECK (len([FirstName])<=(50)),
    CONSTRAINT [CK_Customer_LastName] CHECK (len([LastName])<=(50)),
    CONSTRAINT [CK_Customer_Mail] CHECK (len([CustomerEmail])<=(100) AND [CustomerEmail] like '%@%.%'),
    CONSTRAINT [CK_Customer_Phone] CHECK (len([CustomerPhoneNumber])<=(16) AND [CustomerPhoneNumber] like '+%[0-9]%'),
    CONSTRAINT [IX_Customer_Mail] UNIQUE NONCLUSTERED ([CustomerEmail] ASC),
    CONSTRAINT [IX_Customer_Phone] UNIQUE NONCLUSTERED ([CustomerPhoneNumber] ASC)
);

