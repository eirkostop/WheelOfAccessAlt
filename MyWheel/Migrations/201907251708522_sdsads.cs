namespace MyWheel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sdsads : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "FirstName");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "Dateofbirth");
            DropColumn("dbo.AspNetUsers", "ProfilePic");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "ProfilePic", c => c.Binary());
            AddColumn("dbo.AspNetUsers", "Dateofbirth", c => c.DateTime());
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String());
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
        }
    }
}
