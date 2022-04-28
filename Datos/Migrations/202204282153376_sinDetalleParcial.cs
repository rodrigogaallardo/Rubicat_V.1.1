namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sinDetalleParcial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DetallesParciales", "ClienteId", "dbo.Cliente");
            DropForeignKey("dbo.DetallesParciales", "ProductoId", "dbo.Producto");
            DropForeignKey("dbo.DetallesParciales", "TransporteId", "dbo.Transportes");
            DropIndex("dbo.DetallesParciales", new[] { "ClienteId" });
            DropIndex("dbo.DetallesParciales", new[] { "ProductoId" });
            DropIndex("dbo.DetallesParciales", new[] { "TransporteId" });
            DropTable("dbo.DetallesParciales");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.DetallesParciales",
                c => new
                    {
                        IdDetalleParcial = c.Int(nullable: false, identity: true),
                        NumeroDeRemito = c.Int(nullable: false),
                        FechaDePedido = c.DateTime(nullable: false),
                        FechaDeEntrega = c.DateTime(nullable: false),
                        ClienteId = c.Int(nullable: false),
                        ProductoId = c.Int(nullable: false),
                        TransporteId = c.Int(nullable: false),
                        ValorFinal = c.Decimal(nullable: false, precision: 14, scale: 2),
                    })
                .PrimaryKey(t => t.IdDetalleParcial);
            
            CreateIndex("dbo.DetallesParciales", "TransporteId");
            CreateIndex("dbo.DetallesParciales", "ProductoId");
            CreateIndex("dbo.DetallesParciales", "ClienteId");
            AddForeignKey("dbo.DetallesParciales", "TransporteId", "dbo.Transportes", "IdTransporte");
            AddForeignKey("dbo.DetallesParciales", "ProductoId", "dbo.Producto", "IdProducto", cascadeDelete: true);
            AddForeignKey("dbo.DetallesParciales", "ClienteId", "dbo.Cliente", "IdCliente", cascadeDelete: true);
        }
    }
}
