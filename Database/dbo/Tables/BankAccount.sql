CREATE TABLE [dbo].[BankAccount] (
    [BankAccountId] INT           IDENTITY (1, 1) NOT NULL,
    [UserId]        INT           NULL,
    [BankAccount]   VARCHAR (100) NULL,
    [BaseCurrency]  VARCHAR (3)   NULL,
    [DateCreation]  DATETIME      NULL,
    [Iban]          VARCHAR (34)  NULL,
    CONSTRAINT [PK_BankAccount] PRIMARY KEY CLUSTERED ([BankAccountId] ASC),
    CONSTRAINT [FK_BankAccount_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([UserId])
);

