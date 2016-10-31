namespace CityExplorer.DatabaseLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nullableGender : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "Gender", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "Gender", c => c.Int(nullable: false));
        }
    }
}
