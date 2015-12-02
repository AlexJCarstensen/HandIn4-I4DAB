CREATE TABLE [dbo].[TriggerLog] (
    [LogId]     INT        IDENTITY (1, 1) NOT NULL,
    [Value]     FLOAT (53) NULL,
    [Timestamp] DATETIME   NULL,
    [SensorId]  INT        NOT NULL,
    CONSTRAINT [PK_TriggerLog] PRIMARY KEY CLUSTERED ([LogId] ASC),
    CONSTRAINT [FK_TriggerLog_SensorcharacteristicSet] FOREIGN KEY ([SensorId]) REFERENCES [dbo].[SensorcharacteristicSet] ([SensorID])
);

