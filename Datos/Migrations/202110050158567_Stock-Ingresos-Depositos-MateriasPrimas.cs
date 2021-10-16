namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StockIngresosDepositosMateriasPrimas : DbMigration
    {
        public override void Up()
        {
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
                        NombreMateriaPrima = c.String(nullable: false, maxLength: 50, unicode: false),
                        CostoMateriaPrima = c.Decimal(nullable: false, storeType: "money"),
                        IngresoStock_IdIngreso = c.Int(),
                    })
                .PrimaryKey(t => t.IdMateriaPrima)
                .ForeignKey("dbo.IngresosStock", t => t.IngresoStock_IdIngreso)
                .Index(t => t.IngresoStock_IdIngreso);
            
            CreateTable(
                "dbo.Stock",
                c => new
                    {
                        DepositoID = c.Int(nullable: false),
                        MateriaPrimaID = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        MateriaPrima_IdMateriaPrima = c.Int(),
                        Deposito_IdDeposito = c.Int(),
                    })
                .PrimaryKey(t => new { t.DepositoID, t.MateriaPrimaID })
                .ForeignKey("dbo.Depositos", t => t.DepositoID, cascadeDelete: true)
                .ForeignKey("dbo.MateriasPrimas", t => t.MateriaPrimaID, cascadeDelete: true)
                .ForeignKey("dbo.MateriasPrimas", t => t.MateriaPrima_IdMateriaPrima)
                .ForeignKey("dbo.Depositos", t => t.Deposito_IdDeposito)
                .Index(t => t.DepositoID)
                .Index(t => t.MateriaPrimaID)
                .Index(t => t.MateriaPrima_IdMateriaPrima)
                .Index(t => t.Deposito_IdDeposito);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stock", "Deposito_IdDeposito", "dbo.Depositos");
            DropForeignKey("dbo.IngresosStock", "DepositoId", "dbo.Depositos");
            DropForeignKey("dbo.MateriasPrimas", "IngresoStock_IdIngreso", "dbo.IngresosStock");
            DropForeignKey("dbo.Stock", "MateriaPrima_IdMateriaPrima", "dbo.MateriasPrimas");
            DropForeignKey("dbo.Stock", "MateriaPrimaID", "dbo.MateriasPrimas");
            DropForeignKey("dbo.Stock", "DepositoID", "dbo.Depositos");
            DropForeignKey("dbo.IngresosStock", "MateriaPrimaId", "dbo.MateriasPrimas");
            DropForeignKey("dbo.Depositos", "IngresoStock_IdIngreso", "dbo.IngresosStock");
            DropIndex("dbo.Stock", new[] { "Deposito_IdDeposito" });
            DropIndex("dbo.Stock", new[] { "MateriaPrima_IdMateriaPrima" });
            DropIndex("dbo.Stock", new[] { "MateriaPrimaID" });
            DropIndex("dbo.Stock", new[] { "DepositoID" });
            DropIndex("dbo.MateriasPrimas", new[] { "IngresoStock_IdIngreso" });
            DropIndex("dbo.IngresosStock", new[] { "DepositoId" });
            DropIndex("dbo.IngresosStock", new[] { "MateriaPrimaId" });
            DropIndex("dbo.Depositos", new[] { "IngresoStock_IdIngreso" });
            DropTable("dbo.Stock");
            DropTable("dbo.MateriasPrimas");
            DropTable("dbo.IngresosStock");
            DropTable("dbo.Depositos");
        }
    }
}
