using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace TrainWebApp.Data
{
    public class Train
    {
        public int train_id { get; set; }
        public string train_name { get; set; }
        public string soource { get; set; }
        public string destination { get; set; }

    }
}