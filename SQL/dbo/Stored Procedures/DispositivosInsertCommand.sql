CREATE PROCEDURE [dbo].DispositivosInsertCommand
(
	@Nombre varchar(200),
	@Hostname varchar(300),
	@MACAddress varchar(17),
	@fechaCreacion datetime
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[Dispositivos] ([Nombre], [Hostname], [MACAddress], [fechaCreacion]) VALUES (@Nombre, @Hostname, @MACAddress, @fechaCreacion);
	
SELECT Id, Nombre, Hostname, MACAddress, fechaCreacion FROM Dispositivos WHERE (Id = SCOPE_IDENTITY())