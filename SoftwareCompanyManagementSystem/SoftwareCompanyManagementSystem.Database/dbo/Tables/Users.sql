CREATE TABLE [dbo].[Users] (
    [Id]       UNIQUEIDENTIFIER CONSTRAINT [Default_Users_Id] DEFAULT (newid()) NOT NULL,
    [UserName] NVARCHAR (200)   NOT NULL,
    [Password] NVARCHAR (200)   NOT NULL,
    [RoleId]   INT              NOT NULL,
    CONSTRAINT [PK_Users_Id] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Users_Roles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[Roles] ([Id]) ON DELETE CASCADE
);

