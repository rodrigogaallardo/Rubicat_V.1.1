namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregarTranspote : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Venta", "Transporte", c => c.String());
            AddColumn("dbo.Venta", "FechaDeEntrega", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Venta", "FechaDeEntrega");
            DropColumn("dbo.Venta", "Transporte");
        }
    }
}
