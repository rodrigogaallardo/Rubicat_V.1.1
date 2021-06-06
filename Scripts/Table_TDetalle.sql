USE DBRubicat
GO

-- Create the data type
CREATE TYPE TDetalle AS TABLE 
(	
	ProductoId int,
	Cantidad int,
	Precio money,
	Costo money,
	Peso float
)
GO