CREATE PROCEDURE [dbo].[PuestosInsertar]
	@Nombre VARCHAR(250),
	@Salario INT,
	@Estado BIT
AS
 BEGIN
   SET NOCOUNT ON
   BEGIN TRANSACTION TRASA

   BEGIN TRY 

   INSERT INTO Puestos
   (
      Nombre,
	  Salario,
	 Estado)
   VALUES
   (
	 @Nombre,
     @Salario,
	@Estado
   )

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
