CREATE TABLE [dbo].[TableUsers] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Name]     VARCHAR (50)  NOT NULL,
    [IdNumber] NVARCHAR (50) NOT NULL,
    [Age]      INT           NULL,
    [Sex]      VARCHAR (50)  NOT NULL,
    [Phone]    VARCHAR (50)  NOT NULL,
    [Email]    VARCHAR (50)  NULL,
    [Password] VARCHAR (50)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

