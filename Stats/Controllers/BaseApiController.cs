using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Stats.DataAccess;
using Stats.Models;

namespace Stats.Controllers
{
    public abstract class BaseApiController : ApiController
    {
        private readonly IModelFactory _modelFactory;
        private readonly IStatsService _service;

        protected BaseApiController( IModelFactory modelFactory, IStatsService statsService ) {
            _modelFactory = modelFactory;
            _service = statsService;
        }

        protected IModelFactory ModelFactory {
            get { return _modelFactory; }
        }

        protected IStatsService StatsService
        {
            get { return _service; }
        }
    }
}