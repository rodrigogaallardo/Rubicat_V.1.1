namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CodCliente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cliente", "CodCliente", c => c.String(maxLength: 50, unicode: false));
            CreateIndex("dbo.Cliente", "CodCliente", unique: true, name: "Index");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Cliente", "Index");
            DropColumn("dbo.Cliente", "CodCliente");
        }
    }
}
