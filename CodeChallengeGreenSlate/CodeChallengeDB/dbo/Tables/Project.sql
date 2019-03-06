CREATE TABLE [dbo].[Project] (
    [Id]        INT      NOT NULL,
    [StartDate] DATETIME NOT NULL,
    [EndDate]   DATETIME NOT NULL,
    [Credits]   INT      NOT NULL,
    CONSTRAINT [PK_Project] PRIMARY KEY CLUSTERED ([Id] ASC)
);

