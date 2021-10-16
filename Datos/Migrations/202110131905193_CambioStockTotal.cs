namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambioStockTotal : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Stock");
            AddColumn("dbo.Stock", "IdStockTotal", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Stock", "IdStockTotal");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Stock");
            DropColumn("dbo.Stock", "IdStockTotal");
            AddPrimaryKey("dbo.Stock", new[] { "DepositoID", "MateriaPrimaID" });
        }
    }
}
