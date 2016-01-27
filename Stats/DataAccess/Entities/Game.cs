using System;
using System.Collections.Generic;

namespace Stats.DataAccess.Entities {
    public class Game : EntityBase {
        public virtual Team HomeTeam { get; set; }
        public virtual Team AwayTeam { get; set; }
        public DateTime StarTime { get; set; }

        public virtual ICollection<GameEvent> Events { get; set; } 
    }
}