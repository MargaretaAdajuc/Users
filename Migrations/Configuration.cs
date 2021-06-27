using Users.Models;

namespace Users.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Users.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Users.Data.UsersContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Users.Data.UsersContext context)
        {
            context.Users.AddOrUpdate(x => x.Id,
                new User() { Id = 1, FirstName = "Margareta", LastName = "Diacenco", Email = "margaretadiacenco@gmail.com", Password = "DoNotTellAnyone"},
                new User() { Id = 2, FirstName = "Vladimir", LastName = "Adajuc", Email = "adajucvlad@gmail.com", Password = "TellEveryone" },
                new User() { Id = 3, FirstName = "Ion", LastName = "Cojocaru", Email = "ionc@gmail.com", Password = "NotYourBusiness" },
                new User() { Id = 4, FirstName = "Vasile", LastName = "Lapsa", Email = "vasilelapsa@gmail.com", Password = "Secret101" },
                new User() { Id = 5, FirstName = "Maria", LastName = "Bostan", Email = "mariab@gmail.com", Password = "MySecret666" }
                );
        }
    }
}
