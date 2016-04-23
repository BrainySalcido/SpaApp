namespace SpaApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newparameter : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Name", c => c.Int(nullable: false));
        }
    }
}
