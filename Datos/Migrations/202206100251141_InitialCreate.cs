namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Pedidos", "ProductoId", "dbo.Producto");
            DropForeignKey("dbo.Depositos", "IngresoStock_IdIngreso", "dbo.IngresosStock");
            DropForeignKey("dbo.IngresosStock", "MateriaPrimaId", "dbo.MateriasPrimas");
            DropForeignKey("dbo.Stock", "DepositoID", "dbo.Depositos");
            DropForeignKey("dbo.Stock", "MateriaPrimaID", "dbo.MateriasPrimas");
            DropForeignKey("dbo.Stock", "MateriaPrima_IdMateriaPrima", "dbo.MateriasPrimas");
            DropForeignKey("dbo.MateriasPrimas", "IngresoStock_IdIngreso", "dbo.IngresosStock");
            DropForeignKey("dbo.Stock", "Deposito_IdDeposito", "dbo.Depositos");
            DropIndex("dbo.Depositos", new[] { "IngresoStock_IdIngreso" });
            DropIndex("dbo.IngresosStock", new[] { "MateriaPrimaId" });
            DropIndex("dbo.MateriasPrimas", new[] { "IngresoStock_IdIngreso" });
            DropIndex("dbo.Stock", new[] { "MateriaPrimaID" });
            DropIndex("dbo.Stock", new[] { "DepositoID" });
            DropIndex("dbo.Stock", new[] { "MateriaPrima_IdMateriaPrima" });
            DropIndex("dbo.Stock", new[] { "Deposito_IdDeposito" });
            AddColumn("dbo.Producto", "CodProducto", c => c.String(maxLength: 50, unicode: false));
            AddColumn("dbo.Producto", "uniDeMedida", c => c.String(maxLength: 50, unicode: false));
            AddColumn("dbo.IngresosStock", "CantidadMinima", c => c.Int(nullable: false));
            AddColumn("dbo.IngresosStock", "ProductoId", c => c.Int(nullable: false));
            AddColumn("dbo.IngresosStock", "SumaUnidadesIngresados", c => c.Int(nullable: false));
            AddColumn("dbo.IngresosStock", "SumaUnidadesUsadas", c => c.Int(nullable: false));
            AddColumn("dbo.IngresosStock", "StockFinal", c => c.Int(nullable: false));
            AddColumn("dbo.IngresosStock", "Status", c => c.Int(nullable: false));
            CreateIndex("dbo.Producto", "CodProducto", unique: true, name: "Index");
            CreateIndex("dbo.IngresosStock", "ProductoId");
            AddForeignKey("dbo.Pedidos", "ProductoId", "dbo.IngresosStock", "IdIngreso", cascadeDelete: true);
            AddForeignKey("dbo.IngresosStock", "ProductoId", "dbo.Producto", "IdProducto", cascadeDelete: true);
            DropColumn("dbo.Producto", "Cantidad");
            DropColumn("dbo.Depositos", "IngresoStock_IdIngreso");
            DropColumn("dbo.IngresosStock", "NumeroRemito");
            DropColumn("dbo.IngresosStock", "MateriaPrimaId");
            DropColumn("dbo.MateriasPrimas", "IngresoStock_IdIngreso");
            DropTable("dbo.Stock");
        }
        
        public override void Down()
        {
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
                .PrimaryKey(t => t.IdStockTotal);
            
            AddColumn("dbo.MateriasPrimas", "IngresoStock_IdIngreso", c => c.Int());
            AddColumn("dbo.IngresosStock", "MateriaPrimaId", c => c.Int(nullable: false));
            AddColumn("dbo.IngresosStock", "NumeroRemito", c => c.Int(nullable: false));
            AddColumn("dbo.Depositos", "IngresoStock_IdIngreso", c => c.Int());
            AddColumn("dbo.Producto", "Cantidad", c => c.Int(nullable: false));
            DropForeignKey("dbo.IngresosStock", "ProductoId", "dbo.Producto");
            DropForeignKey("dbo.Pedidos", "ProductoId", "dbo.IngresosStock");
            DropIndex("dbo.IngresosStock", new[] { "ProductoId" });
            DropIndex("dbo.Producto", "Index");
            DropColumn("dbo.IngresosStock", "Status");
            DropColumn("dbo.IngresosStock", "StockFinal");
            DropColumn("dbo.IngresosStock", "SumaUnidadesUsadas");
            DropColumn("dbo.IngresosStock", "SumaUnidadesIngresados");
            DropColumn("dbo.IngresosStock", "ProductoId");
            DropColumn("dbo.IngresosStock", "CantidadMinima");
            DropColumn("dbo.Producto", "uniDeMedida");
            DropColumn("dbo.Producto", "CodProducto");
            CreateIndex("dbo.Stock", "Deposito_IdDeposito");
            CreateIndex("dbo.Stock", "MateriaPrima_IdMateriaPrima");
            CreateIndex("dbo.Stock", "DepositoID");
            CreateIndex("dbo.Stock", "MateriaPrimaID");
            CreateIndex("dbo.MateriasPrimas", "IngresoStock_IdIngreso");
            CreateIndex("dbo.IngresosStock", "MateriaPrimaId");
            CreateIndex("dbo.Depositos", "IngresoStock_IdIngreso");
            AddForeignKey("dbo.Stock", "Deposito_IdDeposito", "dbo.Depositos", "IdDeposito");
            AddForeignKey("dbo.MateriasPrimas", "IngresoStock_IdIngreso", "dbo.IngresosStock", "IdIngreso");
            AddForeignKey("dbo.Stock", "MateriaPrima_IdMateriaPrima", "dbo.MateriasPrimas", "IdMateriaPrima");
            AddForeignKey("dbo.Stock", "MateriaPrimaID", "dbo.MateriasPrimas", "IdMateriaPrima", cascadeDelete: true);
            AddForeignKey("dbo.Stock", "DepositoID", "dbo.Depositos", "IdDeposito", cascadeDelete: true);
            AddForeignKey("dbo.IngresosStock", "MateriaPrimaId", "dbo.MateriasPrimas", "IdMateriaPrima", cascadeDelete: true);
            AddForeignKey("dbo.Depositos", "IngresoStock_IdIngreso", "dbo.IngresosStock", "IdIngreso");
            AddForeignKey("dbo.Pedidos", "ProductoId", "dbo.Producto", "IdProducto", cascadeDelete: true);
        }
    }
}
