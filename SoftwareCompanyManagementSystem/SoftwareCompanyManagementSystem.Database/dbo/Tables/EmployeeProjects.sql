CREATE TABLE [dbo].[EmployeeProjects] (
    [EmployeeId] UNIQUEIDENTIFIER NOT NULL,
    [ProjectId]  UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [FK_EmployeeProjects_Employees_EmployeeId] FOREIGN KEY ([EmployeeId]) REFERENCES [dbo].[Employees] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_EmployeeProjects_Projects_ProjectId] FOREIGN KEY ([ProjectId]) REFERENCES [dbo].[Projects] ([Id]) ON DELETE CASCADE
);

