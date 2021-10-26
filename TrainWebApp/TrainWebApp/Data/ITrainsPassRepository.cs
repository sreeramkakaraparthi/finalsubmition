using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace TrainWebApp.Data
{
    public interface ITrainsPassRepository
    {
        Task<IEnumerable<ITrainsPass>> Gettrainspassby(int stationid,string arrivaltime);
    }
}