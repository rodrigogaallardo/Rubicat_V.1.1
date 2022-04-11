namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModificacionCuitCliente : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cliente", "Cuit", c => c.Decimal(nullable: false, precision: 18, scale: 0));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cliente", "Cuit", c => c.Int(nullable: false));
        }
    }
}
