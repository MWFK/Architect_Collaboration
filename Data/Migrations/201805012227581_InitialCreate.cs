namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Architectes",
                c => new
                    {
                        NumeroArchitecte = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false),
                        Nom = c.String(nullable: false),
                        Prenom = c.String(nullable: false),
                        Telephone = c.Int(nullable: false),
                        NombresAnneesExperiences = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.NumeroArchitecte);
            
            CreateTable(
                "dbo.Plans",
                c => new
                    {
                        DateDebut = c.DateTime(nullable: false),
                        NumeroParcelle = c.Int(nullable: false),
                        NumeroArchitecte = c.Int(nullable: false),
                        DureeRealisation = c.Int(nullable: false),
                        Etat = c.Int(nullable: false),
                        Surface = c.Single(nullable: false),
                        ImageName = c.String(),
                        NombreEtages = c.Int(nullable: false),
                        NombrePieces = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.DateDebut, t.NumeroParcelle, t.NumeroArchitecte })
                .ForeignKey("dbo.Architectes", t => t.NumeroArchitecte, cascadeDelete: true)
                .ForeignKey("dbo.ParcelleTerres", t => t.NumeroParcelle, cascadeDelete: true)
                .Index(t => t.NumeroParcelle)
                .Index(t => t.NumeroArchitecte);
            
            CreateTable(
                "dbo.ParcelleTerres",
                c => new
                    {
                        NumeroParcelle = c.Int(nullable: false, identity: true),
                        Surface = c.Single(nullable: false),
                        Endroit_Num = c.Int(nullable: false),
                        Endroit_Rue = c.String(nullable: false, maxLength: 20),
                        Endroit_Ville = c.String(nullable: false, maxLength: 20),
                        NatureDuSol = c.String(),
                    })
                .PrimaryKey(t => t.NumeroParcelle);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Plans", "NumeroParcelle", "dbo.ParcelleTerres");
            DropForeignKey("dbo.Plans", "NumeroArchitecte", "dbo.Architectes");
            DropIndex("dbo.Plans", new[] { "NumeroArchitecte" });
            DropIndex("dbo.Plans", new[] { "NumeroParcelle" });
            DropTable("dbo.ParcelleTerres");
            DropTable("dbo.Plans");
            DropTable("dbo.Architectes");
        }
    }
}
