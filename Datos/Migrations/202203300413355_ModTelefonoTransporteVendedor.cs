namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModTelefonoTransporteVendedor : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Transportes", "TelefonoTransporte", c => c.Decimal(nullable: false, precision: 18, scale: 0));
            AlterColumn("dbo.Vendedor", "Telefono", c => c.Decimal(nullable: false, precision: 18, scale: 0));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vendedor", "Telefono", c => c.Int(nullable: false));
            AlterColumn("dbo.Transportes", "TelefonoTransporte", c => c.Int(nullable: false));
        }
    }
}
