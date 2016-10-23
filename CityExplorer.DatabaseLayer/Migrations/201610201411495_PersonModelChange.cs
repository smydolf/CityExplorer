namespace CityExplorer.DatabaseLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PersonModelChange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Email", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.People", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.People", "LastName", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.People", "DateOfBirth", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.People", "Gender", c => c.Int(nullable: false));
            DropColumn("dbo.People", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "Name", c => c.String(nullable: false));
            DropColumn("dbo.People", "Gender");
            DropColumn("dbo.People", "DateOfBirth");
            DropColumn("dbo.People", "LastName");
            DropColumn("dbo.People", "FirstName");
            DropColumn("dbo.People", "Email");
        }
    }
}
