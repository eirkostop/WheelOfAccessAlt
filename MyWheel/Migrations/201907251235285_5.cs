namespace MyWheel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Places", "score", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Places", "score");
        }
    }
}
