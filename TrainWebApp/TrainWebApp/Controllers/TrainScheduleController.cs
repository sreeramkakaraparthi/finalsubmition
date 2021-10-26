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
    [RoutePrefix("api/TrainSchedule")]
    public class TrainScheduleController : ApiController
    {
        private readonly ITrainScheduleRepository _repository;
        public TrainScheduleController()
        {
            _repository = new TrainScheduleRepository();
        }
        [Route("Retrieve1")]
        [HttpGet]
        public async Task<IEnumerable<ITrainSchedule>> GetTrainSchedule(string arrivaltime)
        {
            return await _repository.ScheduledTrains(arrivaltime);
        }

    }
}
