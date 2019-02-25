namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class plan2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Plans", "Surface", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Plans", "Surface");
        }
    }
}
