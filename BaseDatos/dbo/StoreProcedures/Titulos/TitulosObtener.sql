CREATE PROCEDURE [dbo].[TitulosObtener]
	@Id_Titulo INT= NULL
AS
	BEGIN 
	SET NOCOUNT ON

	SELECT 
	    Id_Titulo
	  , Descripcion
	  , Estado
	FROM Titulos
	WHERE (@Id_Titulo IS NULL OR Id_Titulo=@Id_Titulo)

	END