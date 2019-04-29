namespace PeerTutor.Migrations.ContextB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using PeerTutor.Models;

    internal sealed class ConfigurationB : DbMigrationsConfiguration<PeerTutor.Models.DBOModel>
    {
        public ConfigurationB()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations\ContextB";
        }

        protected override void Seed(PeerTutor.Models.DBOModel context)
        {
            context.Tutors.AddOrUpdate(x => x.Id,
                new Tutor() {Id = "1", FirstName = "Best", LastName = "Tutor", Email = "Best.Tutor@yahoo.com", Major = "CIT", Year = "Senior" },
                new Tutor() { Id = "2", FirstName = "Killua", LastName = "Tutor", Email = "killua.Tutor@yahoo.com", Major = "CIT", Year = "Sophomore" },
                new Tutor() { Id = "3", FirstName = "Matthew", LastName = "Abbot", Email = "mattabb.Tutor@yahoo.com", Major = "CIT", Year = "Senior" },
                new Tutor() { Id = "4", FirstName = "Jeffry", LastName = "Doe", Email = "djeff.Tutor@yahoo.com", Major = "CIS", Year = "Senior" },
                new Tutor() { Id = "5", FirstName = "Johnimus", LastName = "Doeximus", Email = "doeximus.Tutor@yahoo.com", Major = "MIS", Year = "Junior" });
        }
    }
}
