CREATE TABLE [dbo].[UserProject] (
    [UserId]       INT      NOT NULL,
    [ProjectId]    INT      NOT NULL,
    [IsActive]     BIT      NOT NULL,
    [AssignedDate] DATETIME NOT NULL,
    CONSTRAINT [FK_UserProject_Project] FOREIGN KEY ([ProjectId]) REFERENCES [dbo].[Project] ([Id]),
    CONSTRAINT [FK_UserProject_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id])
);

