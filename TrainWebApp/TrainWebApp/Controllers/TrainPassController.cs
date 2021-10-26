using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using TrainWebApp.Data;
using System.Data.SqlClient;

namespace TrainWebApp.Controllers
{
    [RoutePrefix("api/Trainpass")]
    public class TrainPassController : ApiController
    {
        private readonly ITrainsPassRepository _repository;
        public TrainPassController()
        {
            _repository = new TrainsPassRepository();
        }
        [Route("Trainspass")]
        [HttpGet]
        public async Task<IEnumerable<ITrainsPass>> Trainspassby(int stationid,string arrivaltime )
        {
            return await _repository.Gettrainspassby(stationid,arrivaltime);
        }

    }
}
