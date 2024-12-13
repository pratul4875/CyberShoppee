namespace CyberShoppeeDataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CyberShoppeeDataAccessLayer.CyberShoppeeContext.CyberShoppeeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CyberShoppeeDataAccessLayer.CyberShoppeeContext.CyberShoppeeContext context)
        {

            
        }
    }
}
