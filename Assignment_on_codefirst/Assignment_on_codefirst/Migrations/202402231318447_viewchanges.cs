namespace Assignment_on_codefirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class viewchanges : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.table_city1",
                c => new
                    {
                        cityid = c.Long(nullable: false, identity: true),
                        cityname = c.String(),
                    })
                .PrimaryKey(t => t.cityid);
            
            CreateTable(
                "dbo.table_emp1",
                c => new
                    {
                        empid = c.Long(nullable: false, identity: true),
                        empname = c.String(),
                        address = c.String(),
                        mobileno = c.String(),
                        salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        deptid = c.Long(nullable: false),
                        cityid = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.empid)
                .ForeignKey("dbo.table_city1", t => t.cityid, cascadeDelete: true)
                .ForeignKey("dbo.table_dept1", t => t.deptid, cascadeDelete: true)
                .Index(t => t.deptid)
                .Index(t => t.cityid);
            
            CreateTable(
                "dbo.table_dept1",
                c => new
                    {
                        deptid = c.Long(nullable: false, identity: true),
                        deptName = c.String(),
                    })
                .PrimaryKey(t => t.deptid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.table_emp1", "deptid", "dbo.table_dept1");
            DropForeignKey("dbo.table_emp1", "cityid", "dbo.table_city1");
            DropIndex("dbo.table_emp1", new[] { "cityid" });
            DropIndex("dbo.table_emp1", new[] { "deptid" });
            DropTable("dbo.table_dept1");
            DropTable("dbo.table_emp1");
            DropTable("dbo.table_city1");
        }
    }
}
