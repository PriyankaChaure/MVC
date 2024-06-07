namespace codefirstex2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class area : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.table_area",
                c => new
                    {
                        areaid = c.Long(nullable: false, identity: true),
                        areaname = c.String(),
                    })
                .PrimaryKey(t => t.areaid);
            
            AddColumn("dbo.table_department", "areaid", c => c.Long(nullable: false));
            CreateIndex("dbo.table_department", "areaid");
            AddForeignKey("dbo.table_department", "areaid", "dbo.table_area", "areaid", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.table_department", "areaid", "dbo.table_area");
            DropIndex("dbo.table_department", new[] { "areaid" });
            DropColumn("dbo.table_department", "areaid");
            DropTable("dbo.table_area");
        }
    }
}
