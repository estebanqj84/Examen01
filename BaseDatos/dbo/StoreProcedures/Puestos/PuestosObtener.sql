CREATE PROCEDURE [dbo].[PuestosObtener]
	@Id_Puesto INT= NULL
AS
	BEGIN 
	SET NOCOUNT ON

	SELECT
		@Id_Puesto
	  , Nombre
	  , Salario
	    Estado
	FROM Puestos
	WHERE (@Id_Puesto IS NULL OR @Id_Puesto=@Id_Puesto)

	END