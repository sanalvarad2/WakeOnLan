CREATE PROCEDURE [dbo].DispositivoGetCommand
AS
	SET NOCOUNT ON;
SELECT Id, Nombre, Hostname, MACAddress, fechaCreacion FROM dbo.Dispositivos