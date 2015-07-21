CREATE TABLE [dbo].[Departament] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (50)  NOT NULL,
    [Description] VARCHAR (MAX) NULL,
    [IdManager]    INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [fk_Manager_user] FOREIGN KEY ([IdManager]) REFERENCES [dbo].[Manager] ([Id])
);