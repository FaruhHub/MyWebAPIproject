using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Http;
using Stats.DataAccess;
using Stats.Filters;
using Stats.Models;

namespace Stats.Controllers
{
    public class GameController : BaseApiController
    {
        public GameController( ) : base( new ModelFactory(), new StatsService() ) {}

        public IHttpActionResult Get( ) {
            try {
                var gameEntities = StatsService.Games.Get( );
                var models = gameEntities.Select( ModelFactory.Create );

                return Ok( models );

            } catch ( Exception ex ) {
                return InternalServerError( ex );
            }
        }

        public IHttpActionResult Get(int id)
        {
            try
            {
                var gameEntity = StatsService.Games.Get(id);
                var model = ModelFactory.Create( gameEntity );

                return Ok(model);

            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [ModelValidator]
        public IHttpActionResult CreateEvent( [FromBody] GameEventModel gameEventModel ) {
            try {
                var gameEntity = StatsService.Games.Get( gameEventModel.GameId );
                var playerEntity = StatsService.Players.Get( gameEventModel.PlayerId );
                var pointValue = gameEventModel.PointValue;

                var gameEventEntity = ModelFactory.Create( gameEntity, playerEntity, pointValue );
                StatsService.Events.Insert( gameEventEntity );

                return Created( string.Format( "http://localhost:13362/api/game/{0}", gameEntity.ID ), gameEventModel );
            } catch ( Exception ex ) {
                return InternalServerError( ex );
            }
        }
    }
}