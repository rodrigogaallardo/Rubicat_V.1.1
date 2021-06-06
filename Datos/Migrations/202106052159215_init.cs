namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
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
                    })
                .PrimaryKey(t => t.IdCliente)
                .ForeignKey("dbo.Vendedor", t => t.VendedorId, cascadeDelete: true)
                .ForeignKey("dbo.Zona", t => t.ZonaId, cascadeDelete: true)
                .Index(t => t.VendedorId)
                .Index(t => t.ZonaId);
            
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
                    })
                .PrimaryKey(t => t.IdVenta)
                .ForeignKey("dbo.Cliente", t => t.ClienteId, cascadeDelete: false)
                .ForeignKey("dbo.Vendedor", t => t.VendedorId, cascadeDelete: false)
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
                        Nombre = c.String(maxLength: 50, unicode: false),
                        Peso = c.Double(nullable: false),
                        Costo = c.Decimal(nullable: false, storeType: "money"),
                        Precio = c.Decimal(nullable: false, storeType: "money"),
                        Ean = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdProducto);
            
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
                .ForeignKey("dbo.Zona", t => t.ZonaId, cascadeDelete: false)
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
            DropForeignKey("dbo.Venta", "ClienteId", "dbo.Cliente");
            DropForeignKey("dbo.DetalleVenta", "VentaId", "dbo.Venta");
            DropForeignKey("dbo.ProductoVentas", "Venta_IdVenta", "dbo.Venta");
            DropForeignKey("dbo.ProductoVentas", "Producto_IdProducto", "dbo.Producto");
            DropForeignKey("dbo.DetalleVenta", "ProductoId", "dbo.Producto");
            DropIndex("dbo.ProductoVentas", new[] { "Venta_IdVenta" });
            DropIndex("dbo.ProductoVentas", new[] { "Producto_IdProducto" });
            DropIndex("dbo.Vendedor", new[] { "ZonaId" });
            DropIndex("dbo.DetalleVenta", new[] { "ProductoId" });
            DropIndex("dbo.DetalleVenta", new[] { "VentaId" });
            DropIndex("dbo.Venta", new[] { "VendedorId" });
            DropIndex("dbo.Venta", new[] { "ClienteId" });
            DropIndex("dbo.Cliente", new[] { "ZonaId" });
            DropIndex("dbo.Cliente", new[] { "VendedorId" });
            DropTable("dbo.ProductoVentas");
            DropTable("dbo.Zona");
            DropTable("dbo.Vendedor");
            DropTable("dbo.Producto");
            DropTable("dbo.DetalleVenta");
            DropTable("dbo.Venta");
            DropTable("dbo.Cliente");
        }
    }
}
