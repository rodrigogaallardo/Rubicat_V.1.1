namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModificacionEnMAteriaPrimasSinNombre : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MateriasPrimas", "NombreMateriaPrima", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MateriasPrimas", "NombreMateriaPrima", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }
    }
}
