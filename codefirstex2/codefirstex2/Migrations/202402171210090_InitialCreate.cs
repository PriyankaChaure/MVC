namespace codefirstex2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.table_department",
                c => new
                    {
                        deptid = c.Long(nullable: false, identity: true),
                        deptname = c.String(),
                    })
                .PrimaryKey(t => t.deptid);
            
            CreateTable(
                "dbo.table_employee",
                c => new
                    {
                        empid = c.Long(nullable: false, identity: true),
                        empname = c.String(),
                        address = c.String(),
                        mobileno = c.String(),
                        salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        deptid = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.empid)
                .ForeignKey("dbo.table_department", t => t.deptid, cascadeDelete: true)
                .Index(t => t.deptid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.table_employee", "deptid", "dbo.table_department");
            DropIndex("dbo.table_employee", new[] { "deptid" });
            DropTable("dbo.table_employee");
            DropTable("dbo.table_department");
        }
    }
}
