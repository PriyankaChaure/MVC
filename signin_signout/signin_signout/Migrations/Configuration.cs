namespace signin_signout.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<signin_signout.Models.patientcontext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "signin_signout.Models.patientcontext";
        }

        protected override void Seed(signin_signout.Models.patientcontext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
