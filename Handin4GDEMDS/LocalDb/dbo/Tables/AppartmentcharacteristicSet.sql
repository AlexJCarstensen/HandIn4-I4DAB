CREATE TABLE [dbo].[AppartmentcharacteristicSet] (
    [appartmentId] INT        IDENTITY (1, 1) NOT NULL,
    [No]           INT        NOT NULL,
    [Size]         FLOAT (53) NOT NULL,
    [Floor]        INT        NOT NULL,
    CONSTRAINT [PK_dbo.AppartmentcharacteristicSet] PRIMARY KEY CLUSTERED ([appartmentId] ASC)
);

