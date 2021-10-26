using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainWebApp.Data
{
    public interface IStationPassRepository
    {
        Task<IEnumerable<IStationPass>> GetStationPassby(int trainid,string arrivaltime);
    }
}
