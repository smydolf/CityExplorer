namespace CityExplorer.DatabaseLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nullabledateTime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "DateOfBirth", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "DateOfBirth", c => c.DateTime(nullable: false));
        }
    }
}
