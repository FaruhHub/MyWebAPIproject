using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using Stats.DataAccess;
using Stats.DataAccess.Entities;

namespace Stats.Migrations {
    internal sealed class Configuration : DbMigrationsConfiguration<StatsDbContext> {
        public Configuration( ) {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed( StatsDbContext context ) {
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

            //var p1 = new Player {FirstName = "John", LastName = "Doe", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now};
            //var p2 = new Player {FirstName = "Frank", LastName = "Doe", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now};
            //var p3 = new Player {FirstName = "Robbie", LastName = "Johnson", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now};
            //var p4 = new Player {FirstName = "Billy", LastName = "Bob", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now};

            //var t1 = new Team {Name = "Rhinos", CreatedDate = DateTime.Now, Players = new List<Player> {p1, p2}, UpdatedDate = DateTime.Now};
            //var t2 = new Team {Name = "Eagles", CreatedDate = DateTime.Now, Players = new List<Player> {p3, p4}, UpdatedDate = DateTime.Now};

            //p1.Team = t1;
            //p2.Team = t1;
            //p3.Team = t2;
            //p4.Team = t2;

            //var game = new Game {AwayTeam = t1, HomeTeam = t2, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, StarTime = DateTime.Now};

            //context.Players.Add( p1 );
            //context.Players.Add( p2 );
            //context.Players.Add( p3 );
            //context.Players.Add( p4 );
            //context.Teams.Add( t1 );
            //context.Teams.Add( t2 );
            //context.Games.Add( game );
        }
    }
}