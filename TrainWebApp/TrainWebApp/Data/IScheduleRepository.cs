using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace TrainWebApp.Data
{
    public interface IScheduleRepository
    {
        Task<Schedule> Create(Schedule schedule);
        Task<IEnumerable<Schedule>> Get();
        
    }
}