namespace MyWheel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dsdas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String());
            AddColumn("dbo.AspNetUsers", "Dateofbirth", c => c.DateTime());
            AddColumn("dbo.AspNetUsers", "ProfilePic", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "ProfilePic");
            DropColumn("dbo.AspNetUsers", "Dateofbirth");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirstName");
        }
    }
}
