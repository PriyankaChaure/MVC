namespace code_first_exam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stringchange : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblauthor",
                c => new
                    {
                        authorid = c.Long(nullable: false, identity: true),
                        authorname = c.String(),
                    })
                .PrimaryKey(t => t.authorid);
            
            CreateTable(
                "dbo.tblbook",
                c => new
                    {
                        bookid = c.Long(nullable: false, identity: true),
                        bookname = c.String(),
                        bookdescription = c.String(),
                        bookcatid = c.Long(nullable: false),
                        authorid = c.Long(nullable: false),
                        publisherid = c.Long(nullable: false),
                        price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.bookid)
                .ForeignKey("dbo.tblauthor", t => t.authorid, cascadeDelete: true)
                .ForeignKey("dbo.tblbookcategory", t => t.bookcatid, cascadeDelete: true)
                .ForeignKey("dbo.tblpublisher", t => t.publisherid, cascadeDelete: true)
                .Index(t => t.bookcatid)
                .Index(t => t.authorid)
                .Index(t => t.publisherid);
            
            CreateTable(
                "dbo.tblbookcategory",
                c => new
                    {
                        bookcatid = c.Long(nullable: false, identity: true),
                        bookcatname = c.String(),
                    })
                .PrimaryKey(t => t.bookcatid);
            
            CreateTable(
                "dbo.tblpublisher",
                c => new
                    {
                        publisherid = c.Long(nullable: false, identity: true),
                        publishername = c.String(),
                        address = c.String(),
                        emailid = c.String(),
                        mobileno = c.String(),
                    })
                .PrimaryKey(t => t.publisherid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblbook", "publisherid", "dbo.tblpublisher");
            DropForeignKey("dbo.tblbook", "bookcatid", "dbo.tblbookcategory");
            DropForeignKey("dbo.tblbook", "authorid", "dbo.tblauthor");
            DropIndex("dbo.tblbook", new[] { "publisherid" });
            DropIndex("dbo.tblbook", new[] { "authorid" });
            DropIndex("dbo.tblbook", new[] { "bookcatid" });
            DropTable("dbo.tblpublisher");
            DropTable("dbo.tblbookcategory");
            DropTable("dbo.tblbook");
            DropTable("dbo.tblauthor");
        }
    }
}
