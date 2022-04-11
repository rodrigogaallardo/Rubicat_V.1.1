namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;


    //tuve que cambiar el willcascade a false en zona porque tenia problemas con IdZona en vendedores
    //tuve que cambiar el willcascade a false en vendedores porque tenia problemas con Idvendedoress en ventas
    public partial class InicioNuevo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aprobados",
                c => new
                    {
                        IdAprobados = c.Int(nullable: false, identity: true),
                        NumeroDeRemito = c.Int(nullable: false),
                        FechaDePedido = c.DateTime(nullable: false),
                        FechaDeEntrega = c.DateTime(nullable: false),
                        ClienteId = c.Int(nullable: false),
                        ProductoId = c.Int(nullable: false),
                        TransporteId = c.Int(nullable: false),
                        ValorFinal = c.Decimal(nullable: false, precision: 14, scale: 2),
                    })
                .PrimaryKey(t => t.IdAprobados);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        IdCliente = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 50, unicode: false),
                        RazonSocial = c.String(maxLength: 50, unicode: false),
                        Cuit = c.Int(nullable: false),
                        IngBrutos = c.Int(nullable: false),
                        TipoIngBrutos = c.String(maxLength: 50, unicode: false),
                        DomicilioFiscal = c.String(maxLength: 50, unicode: false),
                        Telefono = c.Int(nullable: false),
                        VendedorId = c.Int(nullable: false),
                        ZonaId = c.Int(nullable: false),
                        TransporteId = c.Int(nullable: false),
                        Mail = c.String(maxLength: 8000, unicode: false),
                        Localidad = c.String(maxLength: 8000, unicode: false),
                        CondicionVenta = c.String(maxLength: 8000, unicode: false),
                        HorarioAtencion = c.String(maxLength: 8000, unicode: false),
                    })
                .PrimaryKey(t => t.IdCliente)
                .ForeignKey("dbo.Transportes", t => t.TransporteId, cascadeDelete: true)
                .ForeignKey("dbo.Vendedor", t => t.VendedorId, cascadeDelete: true)
                .ForeignKey("dbo.Zona", t => t.ZonaId, cascadeDelete: true)
                .Index(t => t.VendedorId)
                .Index(t => t.ZonaId)
                .Index(t => t.TransporteId);
            
            CreateTable(
                "dbo.Pedidos",
                c => new
                    {
                        IdPedido = c.Int(nullable: false, identity: true),
                        NumeroDeRemito = c.Int(nullable: false),
                        FechaDePedido = c.DateTime(nullable: false),
                        FechaDeEntrega = c.DateTime(nullable: false),
                        ClienteId = c.Int(nullable: false),
                        ProductoId = c.Int(nullable: false),
                        TransporteId = c.Int(nullable: false),
                        ValorFinal = c.Decimal(nullable: false, precision: 14, scale: 2),
                    })
                .PrimaryKey(t => t.IdPedido)
                .ForeignKey("dbo.Cliente", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.Producto", t => t.ProductoId, cascadeDelete: true)
                .ForeignKey("dbo.Transportes", t => t.TransporteId)
                .Index(t => t.ClienteId)
                .Index(t => t.ProductoId)
                .Index(t => t.TransporteId);
            
            CreateTable(
                "dbo.Venta",
                c => new
                    {
                        IdVenta = c.Int(nullable: false, identity: true),
                        Cantidad = c.Int(nullable: false),
                        Peso = c.Double(nullable: false),
                        Importe = c.Decimal(nullable: false, storeType: "money"),
                        Cvm = c.Decimal(nullable: false, storeType: "money"),
                        RentBruta = c.Decimal(nullable: false, storeType: "money"),
                        ClienteId = c.Int(nullable: false),
                        VendedorId = c.Int(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                        Transporte = c.String(),
                        FechaDeEntrega = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdVenta)
                .ForeignKey("dbo.Cliente", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.Vendedor", t => t.VendedorId)
                .Index(t => t.ClienteId)
                .Index(t => t.VendedorId);
            
            CreateTable(
                "dbo.DetalleVenta",
                c => new
                    {
                        VentaId = c.Int(nullable: false),
                        ProductoId = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        Precio = c.Decimal(nullable: false, storeType: "money"),
                        Costo = c.Decimal(nullable: false, storeType: "money"),
                        Peso = c.Double(nullable: false),
                    })
                .PrimaryKey(t => new { t.VentaId, t.ProductoId })
                .ForeignKey("dbo.Producto", t => t.ProductoId, cascadeDelete: true)
                .ForeignKey("dbo.Venta", t => t.VentaId, cascadeDelete: true)
                .Index(t => t.VentaId)
                .Index(t => t.ProductoId);
            
            CreateTable(
                "dbo.Producto",
                c => new
                    {
                        IdProducto = c.Int(nullable: false, identity: true),
                        Familia = c.String(maxLength: 50, unicode: false),
                        Arquetipo = c.String(maxLength: 50, unicode: false),
                        Descripcion = c.String(maxLength: 50, unicode: false),
                        Peso = c.Double(nullable: false),
                        Costo = c.Decimal(nullable: false, precision: 14, scale: 2),
                        Cantidad = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdProducto);
            
            CreateTable(
                "dbo.Depositos",
                c => new
                    {
                        IdDeposito = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Descripcion = c.String(nullable: false, maxLength: 50, unicode: false),
                        Espacio = c.String(nullable: false, maxLength: 50, unicode: false),
                        IngresoStock_IdIngreso = c.Int(),
                    })
                .PrimaryKey(t => t.IdDeposito)
                .ForeignKey("dbo.IngresosStock", t => t.IngresoStock_IdIngreso)
                .Index(t => t.IngresoStock_IdIngreso);
            
            CreateTable(
                "dbo.IngresosStock",
                c => new
                    {
                        IdIngreso = c.Int(nullable: false, identity: true),
                        FechaIngreso = c.DateTime(nullable: false, storeType: "date"),
                        Cantidad = c.Int(nullable: false),
                        NumeroRemito = c.Int(nullable: false),
                        Responsable = c.String(nullable: false, maxLength: 50, unicode: false),
                        MateriaPrimaId = c.Int(nullable: false),
                        DepositoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdIngreso)
                .ForeignKey("dbo.MateriasPrimas", t => t.MateriaPrimaId, cascadeDelete: true)
                .ForeignKey("dbo.Depositos", t => t.DepositoId, cascadeDelete: true)
                .Index(t => t.MateriaPrimaId)
                .Index(t => t.DepositoId);
            
            CreateTable(
                "dbo.MateriasPrimas",
                c => new
                    {
                        IdMateriaPrima = c.Int(nullable: false, identity: true),
                        NombreMateriaPrima = c.String(),
                        CostoMateriaPrima = c.Decimal(nullable: false, storeType: "money"),
                        FamiliaMateriaPrima = c.String(nullable: false, maxLength: 50, unicode: false),
                        ArquetipoMateriaPrima = c.String(nullable: false, maxLength: 50, unicode: false),
                        DescripcionMateriaPrima = c.String(nullable: false, maxLength: 50, unicode: false),
                        CantidadMateriaPrima = c.Int(nullable: false),
                        PesoMateriaPrima = c.Double(nullable: false),
                        IngresoStock_IdIngreso = c.Int(),
                    })
                .PrimaryKey(t => t.IdMateriaPrima)
                .ForeignKey("dbo.IngresosStock", t => t.IngresoStock_IdIngreso)
                .Index(t => t.IngresoStock_IdIngreso);
            
            CreateTable(
                "dbo.Stock",
                c => new
                    {
                        IdStockTotal = c.Int(nullable: false, identity: true),
                        Cantidad = c.Int(nullable: false),
                        MateriaPrimaID = c.Int(nullable: false),
                        DepositoID = c.Int(nullable: false),
                        MateriaPrima_IdMateriaPrima = c.Int(),
                        Deposito_IdDeposito = c.Int(),
                    })
                .PrimaryKey(t => t.IdStockTotal)
                .ForeignKey("dbo.Depositos", t => t.DepositoID, cascadeDelete: true)
                .ForeignKey("dbo.MateriasPrimas", t => t.MateriaPrimaID, cascadeDelete: true)
                .ForeignKey("dbo.MateriasPrimas", t => t.MateriaPrima_IdMateriaPrima)
                .ForeignKey("dbo.Depositos", t => t.Deposito_IdDeposito)
                .Index(t => t.MateriaPrimaID)
                .Index(t => t.DepositoID)
                .Index(t => t.MateriaPrima_IdMateriaPrima)
                .Index(t => t.Deposito_IdDeposito);
            
            CreateTable(
                "dbo.Transportes",
                c => new
                    {
                        IdTransporte = c.Int(nullable: false, identity: true),
                        NombreTransporte = c.String(nullable: false, maxLength: 50, unicode: false),
                        DireccionTransporte = c.String(nullable: false, maxLength: 50, unicode: false),
                        CaracterTransporte = c.String(nullable: false, maxLength: 50, unicode: false),
                        TelefonoTransporte = c.Int(nullable: false),
                        HorarioDeTransporte = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.IdTransporte);
            
            CreateTable(
                "dbo.Vendedor",
                c => new
                    {
                        IdVendedor = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 50, unicode: false),
                        Telefono = c.Int(nullable: false),
                        ZonaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdVendedor)
                .ForeignKey("dbo.Zona", t => t.ZonaId)
                .Index(t => t.ZonaId);
            
            CreateTable(
                "dbo.Zona",
                c => new
                    {
                        IdZona = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.IdZona);
            
            CreateTable(
                "dbo.ProductoVentas",
                c => new
                    {
                        Producto_IdProducto = c.Int(nullable: false),
                        Venta_IdVenta = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Producto_IdProducto, t.Venta_IdVenta })
                .ForeignKey("dbo.Producto", t => t.Producto_IdProducto, cascadeDelete: true)
                .ForeignKey("dbo.Venta", t => t.Venta_IdVenta, cascadeDelete: true)
                .Index(t => t.Producto_IdProducto)
                .Index(t => t.Venta_IdVenta);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vendedor", "ZonaId", "dbo.Zona");
            DropForeignKey("dbo.Cliente", "ZonaId", "dbo.Zona");
            DropForeignKey("dbo.Venta", "VendedorId", "dbo.Vendedor");
            DropForeignKey("dbo.Cliente", "VendedorId", "dbo.Vendedor");
            DropForeignKey("dbo.Pedidos", "TransporteId", "dbo.Transportes");
            DropForeignKey("dbo.Cliente", "TransporteId", "dbo.Transportes");
            DropForeignKey("dbo.Stock", "Deposito_IdDeposito", "dbo.Depositos");
            DropForeignKey("dbo.IngresosStock", "DepositoId", "dbo.Depositos");
            DropForeignKey("dbo.MateriasPrimas", "IngresoStock_IdIngreso", "dbo.IngresosStock");
            DropForeignKey("dbo.Stock", "MateriaPrima_IdMateriaPrima", "dbo.MateriasPrimas");
            DropForeignKey("dbo.Stock", "MateriaPrimaID", "dbo.MateriasPrimas");
            DropForeignKey("dbo.Stock", "DepositoID", "dbo.Depositos");
            DropForeignKey("dbo.IngresosStock", "MateriaPrimaId", "dbo.MateriasPrimas");
            DropForeignKey("dbo.Depositos", "IngresoStock_IdIngreso", "dbo.IngresosStock");
            DropForeignKey("dbo.Venta", "ClienteId", "dbo.Cliente");
            DropForeignKey("dbo.DetalleVenta", "VentaId", "dbo.Venta");
            DropForeignKey("dbo.ProductoVentas", "Venta_IdVenta", "dbo.Venta");
            DropForeignKey("dbo.ProductoVentas", "Producto_IdProducto", "dbo.Producto");
            DropForeignKey("dbo.Pedidos", "ProductoId", "dbo.Producto");
            DropForeignKey("dbo.DetalleVenta", "ProductoId", "dbo.Producto");
            DropForeignKey("dbo.Pedidos", "ClienteId", "dbo.Cliente");
            DropIndex("dbo.ProductoVentas", new[] { "Venta_IdVenta" });
            DropIndex("dbo.ProductoVentas", new[] { "Producto_IdProducto" });
            DropIndex("dbo.Vendedor", new[] { "ZonaId" });
            DropIndex("dbo.Stock", new[] { "Deposito_IdDeposito" });
            DropIndex("dbo.Stock", new[] { "MateriaPrima_IdMateriaPrima" });
            DropIndex("dbo.Stock", new[] { "DepositoID" });
            DropIndex("dbo.Stock", new[] { "MateriaPrimaID" });
            DropIndex("dbo.MateriasPrimas", new[] { "IngresoStock_IdIngreso" });
            DropIndex("dbo.IngresosStock", new[] { "DepositoId" });
            DropIndex("dbo.IngresosStock", new[] { "MateriaPrimaId" });
            DropIndex("dbo.Depositos", new[] { "IngresoStock_IdIngreso" });
            DropIndex("dbo.DetalleVenta", new[] { "ProductoId" });
            DropIndex("dbo.DetalleVenta", new[] { "VentaId" });
            DropIndex("dbo.Venta", new[] { "VendedorId" });
            DropIndex("dbo.Venta", new[] { "ClienteId" });
            DropIndex("dbo.Pedidos", new[] { "TransporteId" });
            DropIndex("dbo.Pedidos", new[] { "ProductoId" });
            DropIndex("dbo.Pedidos", new[] { "ClienteId" });
            DropIndex("dbo.Cliente", new[] { "TransporteId" });
            DropIndex("dbo.Cliente", new[] { "ZonaId" });
            DropIndex("dbo.Cliente", new[] { "VendedorId" });
            DropTable("dbo.ProductoVentas");
            DropTable("dbo.Zona");
            DropTable("dbo.Vendedor");
            DropTable("dbo.Transportes");
            DropTable("dbo.Stock");
            DropTable("dbo.MateriasPrimas");
            DropTable("dbo.IngresosStock");
            DropTable("dbo.Depositos");
            DropTable("dbo.Producto");
            DropTable("dbo.DetalleVenta");
            DropTable("dbo.Venta");
            DropTable("dbo.Pedidos");
            DropTable("dbo.Cliente");
            DropTable("dbo.Aprobados");
        }
    }
}
