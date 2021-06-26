CREATE PROCEDURE [dbo].[DepartamentosObtener]
	@Id_Departamento INT= NULL
AS
	BEGIN 
	SET NOCOUNT ON

	SELECT
		@Id_Departamento
	  , Descripcion
	  , Ubicacion
	    Estado
	FROM Departamentos
	WHERE (@Id_Departamento IS NULL OR @Id_Departamento=@Id_Departamento)

	END