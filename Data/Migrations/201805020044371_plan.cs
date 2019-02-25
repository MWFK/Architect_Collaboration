namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class plan : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Plans", "Surface");
            DropColumn("dbo.Plans", "ImageName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Plans", "ImageName", c => c.String());
            AddColumn("dbo.Plans", "Surface", c => c.Single(nullable: false));
        }
    }
}
