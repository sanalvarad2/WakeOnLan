CREATE PROCEDURE [dbo].DispositivosDeleteCommand
(
	@Original_Id int,
	@IsNull_Nombre Int,
	@Original_Nombre varchar(200),
	@IsNull_Hostname Int,
	@Original_Hostname varchar(300),
	@Original_MACAddress varchar(17),
	@IsNull_fechaCreacion Int,
	@Original_fechaCreacion datetime
)
AS
	SET NOCOUNT OFF;
DELETE FROM [dbo].[Dispositivos] WHERE (([Id] = @Original_Id) AND ((@IsNull_Nombre = 1 AND [Nombre] IS NULL) OR ([Nombre] = @Original_Nombre)) AND ((@IsNull_Hostname = 1 AND [Hostname] IS NULL) OR ([Hostname] = @Original_Hostname)) AND ([MACAddress] = @Original_MACAddress) AND ((@IsNull_fechaCreacion = 1 AND [fechaCreacion] IS NULL) OR ([fechaCreacion] = @Original_fechaCreacion)))