CREATE TABLE [dbo].[ReadingSet] (
    [Id]           INT        IDENTITY (1, 1) NOT NULL,
    [value]        FLOAT (53) NOT NULL,
    [timestamp]    DATETIME   NOT NULL,
    [SensorID]     INT        NOT NULL,
    [appartmentId] INT        NOT NULL,
    CONSTRAINT [PK_dbo.ReadingSet] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.ReadingSet_dbo.AppartmentcharacteristicSet_appartmentId] FOREIGN KEY ([appartmentId]) REFERENCES [dbo].[AppartmentcharacteristicSet] ([appartmentId]),
    CONSTRAINT [FK_dbo.ReadingSet_dbo.SensorcharacteristicSet_SensorID] FOREIGN KEY ([SensorID]) REFERENCES [dbo].[SensorcharacteristicSet] ([SensorID])
);


GO
CREATE NONCLUSTERED INDEX [IX_SensorID]
    ON [dbo].[ReadingSet]([SensorID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_appartmentId]
    ON [dbo].[ReadingSet]([appartmentId] ASC);


GO
CREATE TRIGGER [Trigger]
	ON [dbo].[ReadingSet]
	FOR DELETE, INSERT, UPDATE
	AS
	BEGIN
		SET NOCOUNT ON
	END
GO
CREATE TRIGGER [dbo].[InsertTrigger]
ON [dbo].[ReadingSet]
AFTER DELETE
AS
DECLARE @value float
DECLARE @time datetime
DECLARE @SensorId int
SELECT @value =(SELECT value FROM deleted)
SELECT @time = (SELECT [Timestamp] FROM deleted)
SELECT @SensorId = (SELECT SensorID FROM deleted)
INSERT INTO [dbo].[TriggerLog] (value, [Timestamp], SensorID)VALUES (@value, @time, @SensorId)