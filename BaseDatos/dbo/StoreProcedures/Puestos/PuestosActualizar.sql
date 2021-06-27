CREATE PROCEDURE [dbo].[PuestosActualizar]
	@Id_Puesto INT,
	@Nombre VARCHAR(250),
	@Salario INT,
	@Estado BIT

AS
 BEGIN
   SET NOCOUNT ON
   BEGIN TRANSACTION TRASA

   BEGIN TRY 
   --MÉTODO

   UPDATE Puestos
   SET 
   
   Nombre=@Nombre,
   Salario=@Salario,
   Estado=@Estado
   WHERE 
      Id_Puesto=@Id_Puesto

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
