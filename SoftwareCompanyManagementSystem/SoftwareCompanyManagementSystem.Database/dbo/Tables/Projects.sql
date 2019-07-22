CREATE TABLE [dbo].[Projects] (
    [Id]                    UNIQUEIDENTIFIER CONSTRAINT [Default_Projects_Id] DEFAULT (newid()) NOT NULL,
    [ProjectName]           NVARCHAR (200)   NOT NULL,
    [ProgrammingLanguageId] INT              NOT NULL,
    [ProjectTypeId]         INT              NOT NULL,
    [CustomerName]          NVARCHAR (200)   NULL,
    [StartDate]             DATE             NOT NULL,
    [DeliverDate]           DATE             NOT NULL,
    CONSTRAINT [PK_Projects_Id] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Projects_ProgrammingLanguages_ProgrammingLanguageId] FOREIGN KEY ([ProgrammingLanguageId]) REFERENCES [dbo].[ProgrammingLanguages] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Projects_ProjectTypes_ProjectTypeId] FOREIGN KEY ([ProjectTypeId]) REFERENCES [dbo].[ProjectTypes] ([Id]) ON DELETE CASCADE
);

