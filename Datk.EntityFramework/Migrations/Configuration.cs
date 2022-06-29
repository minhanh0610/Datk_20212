using Datk.People;
using System.Data.Entity.Migrations;

namespace Datk.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Datk.EntityFramework.DatkDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Datk";
        }

        protected override void Seed(Datk.EntityFramework.DatkDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
            context.People.AddOrUpdate(
            p => p.Name,
            new Person { Name = "Isaac Asimov" },
            new Person { Name = "Thomas More" },
            new Person { Name = "George Orwell" },
            new Person { Name = "Douglas Adams" }
            );
        }
    }
}
