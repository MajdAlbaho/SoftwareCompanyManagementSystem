CREATE TABLE [dbo].[ProjectComments] (
    [Id]          UNIQUEIDENTIFIER CONSTRAINT [Default_ProjectComments_Default] DEFAULT (newid()) NOT NULL,
    [ProjectId]   UNIQUEIDENTIFIER NOT NULL,
    [Comment]     NVARCHAR (600)   NOT NULL,
    [UserId]      UNIQUEIDENTIFIER NOT NULL,
    [CreatedDate] DATETIME         DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_ProjectComments_Id] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ProjectComments_Projects_ProjectId] FOREIGN KEY ([ProjectId]) REFERENCES [dbo].[Projects] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_ProjectComments_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id]) ON DELETE CASCADE
);

