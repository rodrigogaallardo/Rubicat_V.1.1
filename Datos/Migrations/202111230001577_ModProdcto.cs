namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModProdcto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Producto", "Familia", c => c.String(maxLength: 50, unicode: false));
            AddColumn("dbo.Producto", "Arquetipo", c => c.String(maxLength: 50, unicode: false));
            AddColumn("dbo.Producto", "Descripcion", c => c.String(maxLength: 50, unicode: false));
            AddColumn("dbo.Producto", "Cantidad", c => c.Int(nullable: false));
            DropColumn("dbo.Producto", "Nombre");
            DropColumn("dbo.Producto", "Precio");
            DropColumn("dbo.Producto", "Ean");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Producto", "Ean", c => c.Int(nullable: false));
            AddColumn("dbo.Producto", "Precio", c => c.Decimal(nullable: false, storeType: "money"));
            AddColumn("dbo.Producto", "Nombre", c => c.String(maxLength: 50, unicode: false));
            DropColumn("dbo.Producto", "Cantidad");
            DropColumn("dbo.Producto", "Descripcion");
            DropColumn("dbo.Producto", "Arquetipo");
            DropColumn("dbo.Producto", "Familia");
        }
    }
}
