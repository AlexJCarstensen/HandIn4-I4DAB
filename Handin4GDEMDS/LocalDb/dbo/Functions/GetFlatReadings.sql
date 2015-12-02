CREATE FUNCTION [dbo].[GetFlatReadings]
(
	@flat int,
	@numberOfReadings int
)
RETURNS TABLE

RETURN
	SELECT TOP (@numberOfReadings) [SensorId], [value], [timestamp]
	FROM [dbo].[ReadingSet]
	WHERE appartmentId = @flat