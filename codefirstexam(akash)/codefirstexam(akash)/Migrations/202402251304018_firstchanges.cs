namespace codefirstexam_akash_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstchanges : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_batch",
                c => new
                    {
                        batchid = c.Long(nullable: false, identity: true),
                        batchtitle = c.String(),
                        trainerid = c.Long(nullable: false),
                        courseid = c.Long(nullable: false),
                        startdate = c.DateTime(nullable: false),
                        noofstudent = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.batchid)
                .ForeignKey("dbo.tbl_course", t => t.courseid, cascadeDelete: true)
                .ForeignKey("dbo.tbl_trainer", t => t.trainerid, cascadeDelete: true)
                .Index(t => t.trainerid)
                .Index(t => t.courseid);
            
            CreateTable(
                "dbo.tbl_course",
                c => new
                    {
                        courseid = c.Long(nullable: false, identity: true),
                        coursename = c.String(),
                        duration = c.Decimal(nullable: false, precision: 18, scale: 2),
                        fees = c.Decimal(nullable: false, precision: 18, scale: 2),
                        coursecatid = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.courseid)
                .ForeignKey("dbo.tbl_coursecategory", t => t.coursecatid, cascadeDelete: true)
                .Index(t => t.coursecatid);
            
            CreateTable(
                "dbo.tbl_coursecategory",
                c => new
                    {
                        coursecatid = c.Long(nullable: false, identity: true),
                        coursecatname = c.String(),
                    })
                .PrimaryKey(t => t.coursecatid);
            
            CreateTable(
                "dbo.tbl_trainer",
                c => new
                    {
                        trainerid = c.Long(nullable: false, identity: true),
                        trainername = c.String(),
                    })
                .PrimaryKey(t => t.trainerid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tbl_batch", "trainerid", "dbo.tbl_trainer");
            DropForeignKey("dbo.tbl_batch", "courseid", "dbo.tbl_course");
            DropForeignKey("dbo.tbl_course", "coursecatid", "dbo.tbl_coursecategory");
            DropIndex("dbo.tbl_course", new[] { "coursecatid" });
            DropIndex("dbo.tbl_batch", new[] { "courseid" });
            DropIndex("dbo.tbl_batch", new[] { "trainerid" });
            DropTable("dbo.tbl_trainer");
            DropTable("dbo.tbl_coursecategory");
            DropTable("dbo.tbl_course");
            DropTable("dbo.tbl_batch");
        }
    }
}
