use DBRubicat
GO
create procedure SP_NuevaVenta
(
	@Cantidad int,
	@Peso float,
	@Importe money,
	@RentBruta money,
	@Cvm money,
	@ClienteId int,
	@VendedorId int,
	@Fecha datetime,
	@Detalle TDetalle readOnly
)
as
BEGIN TRY
	BEGIN TRANSACTION
	declare @Venta table(VentaId int)
	/*Insert Venta*/
	insert Venta (Cantidad,Peso,Importe,RentBruta,Cvm,ClienteId,VendedorId,Fecha)
	output inserted.IdVenta into @Venta
	values(@Cantidad,@Peso,@Importe,@RentBruta,@Cvm,@ClienteId,@VendedorId,@Fecha)
	/*Insert DetalleVenta*/
	insert DetalleVenta
	select * from @Venta, @Detalle
	COMMIT TRANSACTION
END TRY

BEGIN CATCH
	RAISERROR('Error, no se pudo dar de alta la venta',16,1)
	ROLLBACK TRANSACTION
END CATCH