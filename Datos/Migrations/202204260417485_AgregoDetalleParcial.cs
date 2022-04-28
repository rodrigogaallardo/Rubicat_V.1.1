namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregoDetalleParcial : DbMigration
    {
        public override void Up()
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
                .PrimaryKey(t => t.IdDetalleParcial)
                .ForeignKey("dbo.Cliente", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.Producto", t => t.ProductoId, cascadeDelete: true)
                .ForeignKey("dbo.Transportes", t => t.TransporteId)
                .Index(t => t.ClienteId)
                .Index(t => t.ProductoId)
                .Index(t => t.TransporteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DetallesParciales", "TransporteId", "dbo.Transportes");
            DropForeignKey("dbo.DetallesParciales", "ProductoId", "dbo.Producto");
            DropForeignKey("dbo.DetallesParciales", "ClienteId", "dbo.Cliente");
            DropIndex("dbo.DetallesParciales", new[] { "TransporteId" });
            DropIndex("dbo.DetallesParciales", new[] { "ProductoId" });
            DropIndex("dbo.DetallesParciales", new[] { "ClienteId" });
            DropTable("dbo.DetallesParciales");
        }
    }
}
