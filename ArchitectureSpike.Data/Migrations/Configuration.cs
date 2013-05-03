using System;
using ArchitectureSpike.Domain.Models;

namespace ArchitectureSpike.Data.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Context.AssociateContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Context.AssociateContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Associates.AddOrUpdate(
                a => a.FirstName,
                new Associate {FirstName = "Rafael", LastName = "Miceli", Title = "123456", Birth = DateTime.Parse("07/12/1989")});
        }
    }
}
