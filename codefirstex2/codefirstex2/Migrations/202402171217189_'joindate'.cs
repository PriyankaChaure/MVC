namespace codefirstex2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class joindate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.table_employee", "joindate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.table_employee", "joindate");
        }
    }
}
