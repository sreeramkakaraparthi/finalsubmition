using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using TrainWebApp.Data;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;

namespace TrainWebApp.Controllers
{
    [RoutePrefix("api/Train")]
    public class TrainController : ApiController
    {
        private readonly ITrainRepository _repository;
        public TrainController()
        {
            _repository =new TrainRepository();
        }
        [Route("Retrieve")]
        [HttpGet]
        public async Task<IEnumerable<Train>> GetTrain()
        {
            return await _repository.Get();
        }
        
        public async Task<Train> GetTrain(int id)
        {
            return await _repository.Get(id);
        }

        [Route("Save")]
        [HttpPost]
        public async Task<Train> PostTrains(Train train)
        {
            var newTrain = await _repository.Create(train);
            return null;
        }
    }
}