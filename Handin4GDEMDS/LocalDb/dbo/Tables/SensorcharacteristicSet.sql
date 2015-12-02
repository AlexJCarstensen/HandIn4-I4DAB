CREATE TABLE [dbo].[SensorcharacteristicSet] (
    [SensorID]                              INT            IDENTITY (1, 1) NOT NULL,
    [calibrationDate]                       DATETIME       NOT NULL,
    [description]                           NVARCHAR (MAX) NOT NULL,
    [externalRef]                           NVARCHAR (MAX) NULL,
    [calibrationEquation]                   NVARCHAR (MAX) NULL,
    [calibrationCoeff]                      NVARCHAR (MAX) NULL,
    [unit]                                  NVARCHAR (MAX) NULL,
    [Appartmentcharacteristic_appartmentId] INT            NULL,
    CONSTRAINT [PK_dbo.SensorcharacteristicSet] PRIMARY KEY CLUSTERED ([SensorID] ASC),
    CONSTRAINT [FK_dbo.SensorcharacteristicSet_dbo.AppartmentcharacteristicSet_Appartmentcharacteristic_appartmentId] FOREIGN KEY ([Appartmentcharacteristic_appartmentId]) REFERENCES [dbo].[AppartmentcharacteristicSet] ([appartmentId])
);


GO
CREATE NONCLUSTERED INDEX [IX_Appartmentcharacteristic_appartmentId]
    ON [dbo].[SensorcharacteristicSet]([Appartmentcharacteristic_appartmentId] ASC);

