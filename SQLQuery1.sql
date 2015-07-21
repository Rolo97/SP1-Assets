CREATE TABLE [dbo].[Users] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Name]     VARCHAR (50)  NOT NULL,
    [IdNumber] NVARCHAR (50) NOT NULL,
    [Age]      INT           NULL,
    [Sex]      VARCHAR (50)  NOT NULL,
    [Phone]    VARCHAR (50)  NOT NULL,
    [Email]    VARCHAR (50)  NULL,
    [Password] VARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


CREATE TABLE [dbo].[Departament] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (50)  NOT NULL,
    [Description] VARCHAR (MAX) NULL,
    [IdManager]    INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [fk_Manager_user] FOREIGN KEY ([IdManager]) REFERENCES [dbo].[Manager] ([Id])
);