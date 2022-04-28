namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambioCostoProducto : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Producto", "Costo", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Producto", "Costo", c => c.Decimal(nullable: false, precision: 14, scale: 2));
        }
    }
}
