namespace signin_signout.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_doctor",
                c => new
                    {
                        doctorid = c.Long(nullable: false, identity: true),
                        doctorname = c.String(),
                        qualification = c.String(),
                        specialist = c.String(),
                        emilid = c.String(),
                        phoneno = c.String(),
                        password = c.String(),
                    })
                .PrimaryKey(t => t.doctorid);
            
            CreateTable(
                "dbo.tbl_patient",
                c => new
                    {
                        patientid = c.Long(nullable: false, identity: true),
                        patientname = c.String(),
                        age = c.Long(nullable: false),
                        appoinmentdate = c.DateTime(nullable: false),
                        emailid = c.String(),
                        phoneno = c.String(),
                        disease = c.String(),
                        address = c.String(),
                    })
                .PrimaryKey(t => t.patientid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tbl_patient");
            DropTable("dbo.tbl_doctor");
        }
    }
}
