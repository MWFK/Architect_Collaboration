namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nbproj : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Architectes", "NombreProjetsEncours", c => c.Int(nullable: false));
            AddColumn("dbo.Architectes", "NombresProjetsParAnnée", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Architectes", "NombresProjetsParAnnée");
            DropColumn("dbo.Architectes", "NombreProjetsEncours");
        }
    }
}
