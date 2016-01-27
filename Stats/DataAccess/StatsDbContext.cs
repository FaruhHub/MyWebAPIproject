using System.Data.Entity;
using Stats.DataAccess.Entities;

namespace Stats.DataAccess {
    public class StatsDbContext : DbContext {
        public DbSet<Game> Games { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<GameEvent> Events { get; set; }
    }
}