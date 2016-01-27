using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Stats.DataAccess.Entities;

namespace Stats.Models
{
    public class GameModel
    {
        public int GameID { get; set; }
        public TeamModel AwayTeam { get; set; }
        public TeamModel HomeTeam { get; set; }
        public DateTime StartTime { get; set; }

        public List<GameEventModel> Events { get; set; } 
    }
}