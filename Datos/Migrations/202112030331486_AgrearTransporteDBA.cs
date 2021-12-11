namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgrearTransporteDBA : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Transportes",
                c => new
                    {
                        IdTransporte = c.Int(nullable: false, identity: true),
                        NombreTransporte = c.String(nullable: false, maxLength: 50, unicode: false),
                        DireccionTransporte = c.String(nullable: false, maxLength: 50, unicode: false),
                        CaracterTransporte = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.IdTransporte);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Transportes");
        }
    }
}
