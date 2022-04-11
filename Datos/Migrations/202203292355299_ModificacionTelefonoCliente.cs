namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModificacionTelefonoCliente : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cliente", "Telefono", c => c.Decimal(nullable: false, precision: 18, scale: 0));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cliente", "Telefono", c => c.Int(nullable: false));
        }
    }
}
