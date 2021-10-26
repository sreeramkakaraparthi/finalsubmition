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
    [RoutePrefix("api/Station")]

    public class StationController : ApiController
    {
        private readonly IStationRepository __repository;
        public StationController()
            {
                __repository = new StationRepository();
            }
        [Route("Retrieve")]
        [HttpGet]
        public async Task<IEnumerable<Station>> GetStation()
        {
            return await __repository.Get();
        }
        public async Task<Station> GetStation(int id)
        {
            return await __repository.Getbyid(id);
        }

        [Route("Save")]
        [HttpPost]
        public async Task<Station> PostStation(Station station)
        {
            var newStation = await __repository.Create(station);
            return null;
        }
        


    }
}
