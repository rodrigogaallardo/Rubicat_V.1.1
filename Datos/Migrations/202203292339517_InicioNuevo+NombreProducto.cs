namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InicioNuevoNombreProducto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Producto", "Nombre", c => c.String(maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Producto", "Nombre");
        }
    }
}
