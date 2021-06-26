CREATE PROCEDURE [dbo].[DepartamentosActualizar]
	@Id_Departamento INT,
	@Descripcion VARCHAR(250),
	@Ubicacion VARCHAR(250),
	@Estado BIT

AS
 BEGIN
   SET NOCOUNT ON
   BEGIN TRANSACTION TRASA

   BEGIN TRY 
   --MÉTODO

   UPDATE Departamentos
   SET 
   Id_Departamento=@Id_Departamento,
   Descripcion=@Descripcion,
   Ubicacion=@Ubicacion,
   Estado=@Estado
   WHERE 
      Id_Departamento=@Id_Departamento

   COMMIT TRANSACTION TRASA

     SELECT 0 AS CodeError, '' AS MsgError

   END TRY

   BEGIN CATCH
     SELECT 
	     ERROR_NUMBER() AS CodeError
	   , ERROR_MESSAGE() AS MsgError

	   ROLLBACK TRANSACTION TRASA
   END CATCH

 END