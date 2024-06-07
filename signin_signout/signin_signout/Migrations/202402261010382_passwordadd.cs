namespace signin_signout.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class passwordadd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tbl_patient", "password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tbl_patient", "password");
        }
    }
}
