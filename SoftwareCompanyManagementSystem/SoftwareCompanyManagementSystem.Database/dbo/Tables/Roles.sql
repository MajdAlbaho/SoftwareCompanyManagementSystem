﻿CREATE TABLE [dbo].[Roles] (
    [Id]     INT            IDENTITY (0, 1) NOT NULL,
    [EnName] NVARCHAR (200) NOT NULL,
    [ArName] NVARCHAR (200) NOT NULL,
    CONSTRAINT [PK_PositionTypes_Id] PRIMARY KEY CLUSTERED ([Id] ASC)
);

