namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mod2CP : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Producto", "Peso", c => c.Decimal(nullable: false, precision: 30, scale: 2));
            AlterColumn("dbo.Producto", "Costo", c => c.Decimal(nullable: false, precision: 30, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Producto", "Costo", c => c.Decimal(nullable: false, precision: 10, scale: 2));
            AlterColumn("dbo.Producto", "Peso", c => c.Decimal(nullable: false, precision: 10, scale: 2));
        }
    }
}
