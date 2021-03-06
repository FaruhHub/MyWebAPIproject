﻿using System;
using System.Linq;
using System.Web.Http;
using Stats.DataAccess;
using Stats.Filters;
using Stats.Models;

namespace Stats.Controllers {
    public class PlayerController : BaseApiController {
        public PlayerController( ) : base(new ModelFactory(), new StatsService()) {
        }

        public IHttpActionResult Get( ) {
            try {
                var players = StatsService.Players.Get( );
                var models = players.Select( ModelFactory.Create );

                return Ok( models );
            } catch ( Exception ex ) {
                return InternalServerError( ex );
            }
        }

        public IHttpActionResult Get( int id ) {
            try {
                var player = StatsService.Players.Get(id);
                var model = ModelFactory.Create(player);

                return Ok( model );
            } catch ( Exception ex ) {
                return InternalServerError( ex );
            }
        }

        [ModelValidator]
        public IHttpActionResult Post( [FromBody] PlayerModel playerModel ) {
            try {
                var playerEntity = ModelFactory.Create(playerModel);
                var player = StatsService.Players.Insert(playerEntity);

                var model = ModelFactory.Create(player);
                return Created( string.Format( "http://localhost:13362/api/player/{0}", model.PlayerId ), model );
            } catch ( Exception ex ) {
                return InternalServerError( ex );
            }
        }

        [ModelValidator]
        public IHttpActionResult Put( [FromBody] PlayerModel playerModel ) {
            try {
                var playerEntity = ModelFactory.Create(playerModel);
                var player = StatsService.Players.Update(playerEntity);

                var model = ModelFactory.Create(player);

                return Ok( model );

            } catch ( Exception ex ) {
                return InternalServerError( ex );
            }
        }

        public IHttpActionResult Delete( int id ) {
            try {
                var playerEntity = StatsService.Players.Get(id);
                if ( playerEntity != null )
                    StatsService.Players.Delete(playerEntity);
                else
                    return NotFound( );

                return Ok( );
            } catch ( Exception ex ) {
                return InternalServerError( ex );
            }
        }
    }
}