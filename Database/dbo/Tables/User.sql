CREATE TABLE [dbo].[User] (
    [UserId]      INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]   VARCHAR (100) NULL,
    [LastName]    VARCHAR (100) NULL,
    [DateOfBirth] DATETIME      NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([UserId] ASC)
);

