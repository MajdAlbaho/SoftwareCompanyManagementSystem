CREATE TABLE [dbo].[ProjectTypes] (
    [Id]   INT            IDENTITY (0, 1) NOT NULL,
    [Type] NVARCHAR (200) NOT NULL,
    CONSTRAINT [PK_ProjectTypes_Id] PRIMARY KEY CLUSTERED ([Id] ASC)
);

