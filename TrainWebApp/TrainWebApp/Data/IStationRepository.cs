using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace TrainWebApp.Data
{
    public interface IStationRepository
    {
        Task<Station> Create(Station station);
        Task<IEnumerable<Station>> Get();
        Task<Station> Getbyid(int id);
       
    }
}