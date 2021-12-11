namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModificacionEnMAteriaPrimas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MateriasPrimas", "FamiliaMateriaPrima", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AddColumn("dbo.MateriasPrimas", "ArquetipoMateriaPrima", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AddColumn("dbo.MateriasPrimas", "DescripcionMateriaPrima", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AddColumn("dbo.MateriasPrimas", "CantidadMateriaPrima", c => c.Int(nullable: false));
            AddColumn("dbo.MateriasPrimas", "PesoMateriaPrima", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MateriasPrimas", "PesoMateriaPrima");
            DropColumn("dbo.MateriasPrimas", "CantidadMateriaPrima");
            DropColumn("dbo.MateriasPrimas", "DescripcionMateriaPrima");
            DropColumn("dbo.MateriasPrimas", "ArquetipoMateriaPrima");
            DropColumn("dbo.MateriasPrimas", "FamiliaMateriaPrima");
        }
    }
}
