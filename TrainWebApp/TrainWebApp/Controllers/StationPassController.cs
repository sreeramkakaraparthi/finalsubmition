using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using TrainWebApp.Data;

namespace TrainWebApp.Controllers
{
    [RoutePrefix("api/Stationpass")]
    public class StationPassController : ApiController
    {
        private readonly IStationPassRepository _repository;
        public StationPassController()
        {
            _repository = new StationPassRepository();
        }
        [Route("Stationspass")]
        [HttpGet]
        public async Task<IEnumerable<IStationPass>> Trainspassby(int trainid,string arrivaltime)
        {
            return await _repository.GetStationPassby(trainid,arrivaltime);
        }

    }
}
