CREATE PROCEDURE [dbo].[InsertIntoFlat]
	@flat int,
	@sensor int,
	@value float
AS
	INSERT INTO [dbo].ReadingSet([appartmentId], [SensorID], [timestamp], [value])
	VALUES (@flat, @sensor, SYSDATETIME(), @value )