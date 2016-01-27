using System;
using System.Collections.Generic;
using System.Linq;
using Stats.DataAccess.Entities;

namespace Stats.Models {
    public interface IModelFactory {
        PlayerModel Create( Player player );
        Player Create( PlayerModel playerModel );
        TeamModel Create( Team team );
        Team Create( TeamModel teamModel );

        GameModel Create( Game game );
        GameEventModel Create( GameEvent gameEvent );

        GameEvent Create(Game gameEntity, Player playerEntity, int pointValue);
    }

    public class ModelFactory : IModelFactory {
        public PlayerModel Create( Player player ) {
            return new PlayerModel {
                FirstName = player.FirstName,
                LastName = player.LastName,
                PlayerId = player.ID,
                TeamId = player.Team != null ? player.Team.ID : 0,
                TeamName = player.Team != null ? player.Team.Name : null
            };
        }

        public Player Create( PlayerModel playerModel ) {
            if ( playerModel.PlayerId == 0 ) {
                return new Player {
                    FirstName = playerModel.FirstName,
                    LastName = playerModel.LastName,
                    UpdatedDate = DateTime.Now
                };
            }

            return new Player {
                ID = playerModel.PlayerId,
                FirstName = playerModel.FirstName,
                LastName = playerModel.LastName,
                UpdatedDate = DateTime.Now
            };
        }

        public TeamModel Create( Team team ) {
            return new TeamModel {
                TeamId = team.ID,
                TeamName = team.Name,
                Players = new List<PlayerModel>( team.Players.Select( Create ) )
            };
        }

        public Team Create( TeamModel teamModel ) {
            if ( teamModel.TeamId == 0 ) {
                return new Team {
                    Name = teamModel.TeamName,
                    Players = new List<Player>( teamModel.Players.Select( Create ) ),
                    UpdatedDate = DateTime.Now
                };
            }

            return new Team {
                ID = teamModel.TeamId,
                Name = teamModel.TeamName,
                Players = new List<Player>( teamModel.Players.Select( Create ) ),
                UpdatedDate = DateTime.Now
            };
        }

        public GameModel Create( Game game ) {
            return new GameModel {
                AwayTeam = Create( game.AwayTeam ),
                HomeTeam = Create( game.HomeTeam ),
                Events = game.Events.Select( Create ).ToList(),
                GameID = game.ID,
                StartTime = game.StarTime
            };
        }

        public GameEventModel Create(GameEvent gameEvent) {
            return new GameEventModel {
                GameId = gameEvent.Game.ID,
                PlayerId = gameEvent.Player.ID,
                PointValue = gameEvent.PointValue
            };
        }

        public GameEvent Create( Game gameEntity, Player playerEntity, int pointValue ) {
            return new GameEvent {Game = gameEntity, Player = playerEntity, PointValue = pointValue, UpdatedDate = DateTime.Now};
        }
    }
}