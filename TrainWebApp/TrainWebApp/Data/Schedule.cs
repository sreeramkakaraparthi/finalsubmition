using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrainWebApp.Data
{
    public class Schedule
    {
        public int train_id { get; set; }
        public int station_id { get; set; }
        public string arrival_time { get; set; }
        public string departure_time { get; set; }

    }
}