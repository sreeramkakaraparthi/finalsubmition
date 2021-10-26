using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainWebApp.Data
{
   public  interface ITrainRepository
    {
        Task<Train>  Create(Train train);
        Task<IEnumerable<Train>> Get();
        Task<Train> Get(int id);
    }
}
