CREATE TABLE [dbo].[Transaction] (
    [TransactionId] INT           IDENTITY (1, 1) NOT NULL,
    [BankAccountId] INT           NULL,
    [Description]   VARCHAR (250) NULL,
    [DateOperation] DATETIME      NULL,
    [Quantity]      MONEY         NULL,
    [Type]          VARCHAR (100) NULL,
    [Verified]      BIT           NULL,
    CONSTRAINT [PK_Transactions] PRIMARY KEY CLUSTERED ([TransactionId] ASC)
);

