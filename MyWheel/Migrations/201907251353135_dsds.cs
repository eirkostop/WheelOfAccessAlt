namespace MyWheel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dsds : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "Rating", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reviews", "Rating");
        }
    }
}
