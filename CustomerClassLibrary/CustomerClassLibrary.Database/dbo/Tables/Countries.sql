CREATE TABLE [dbo].[Countries] (
    [CountryId]   INT           IDENTITY (1, 1) NOT NULL,
    [CountryName] NVARCHAR (13) NOT NULL,
    CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED ([CountryId] ASC),
    CONSTRAINT [CK_Countries_CountryName] CHECK ([CountryName] like 'United States' OR [CountryName] like 'Canada'),
    CONSTRAINT [IX_Countries_CountryName] UNIQUE NONCLUSTERED ([CountryName] ASC)
);

