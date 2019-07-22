CREATE TABLE [dbo].[Employees] (
    [Id]                UNIQUEIDENTIFIER CONSTRAINT [Default_Employees_Id] DEFAULT (newid()) NOT NULL,
    [FirstName]         NVARCHAR (200)   NOT NULL,
    [LastName]          NVARCHAR (200)   NOT NULL,
    [FatherName]        NVARCHAR (200)   NOT NULL,
    [MotherName]        NVARCHAR (200)   NOT NULL,
    [BirthDate]         DATE             NOT NULL,
    [Gender]            BIT              NOT NULL,
    [PhoneNumber]       NVARCHAR (10)    NULL,
    [EmailAddress]      NVARCHAR (100)   NULL,
    [PersonalPhoto]     IMAGE            NULL,
    [ExperinceYears]    INT              NOT NULL,
    [UserId]            UNIQUEIDENTIFIER NOT NULL,
    [EducationDegreeId] INT              NOT NULL,
    CONSTRAINT [PK_Employees_Id] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Employees_EducationLevel_EducationLevelId] FOREIGN KEY ([EducationDegreeId]) REFERENCES [dbo].[EducationDegrees] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Employees_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [Unique_Employees_UserId] UNIQUE NONCLUSTERED ([UserId] ASC)
);

