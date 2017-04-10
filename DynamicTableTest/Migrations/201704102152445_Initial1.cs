namespace DynamicTableTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Student", "FirstName", c => c.String());
            DropColumn("dbo.Student", "FirstMidName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Student", "FirstMidName", c => c.String());
            DropColumn("dbo.Student", "FirstName");
        }
    }
}
