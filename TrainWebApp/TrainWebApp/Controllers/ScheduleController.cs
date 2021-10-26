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
    [RoutePrefix("api/Schedule")]
    public class ScheduleController : ApiController
    {
        private readonly IScheduleRepository _repository;
        public ScheduleController()
        {
            _repository = new TrainPassRepository();
        }
        [Route("Retrieve")]
        [HttpGet]
        public async Task<IEnumerable<Schedule>> GetSchedule()
        {
            return await _repository.Get();
        }
        [Route("Save")]
        [HttpPost]
        public async Task<Schedule> PostSchedule(Schedule schedule)
        {
            var newSchedule = await _repository.Create(schedule);
            return null;
        }
       

    }
}
