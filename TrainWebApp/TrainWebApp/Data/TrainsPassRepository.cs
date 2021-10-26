using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace TrainWebApp.Data
{
    public class TrainsPassRepository : ITrainsPassRepository
    {
        private readonly string _connectionString;
        public TrainsPassRepository()
        {
            _connectionString = "Data Source=SAILS-DM161;Initial Catalog=trainstation;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=True";
        }
        public async Task<IEnumerable<ITrainsPass>> Gettrainspassby(int stationid,string arrivaltime)
        {
            var sqlquery = "select  Train.train_id,train_name from Train LEFT JOIN Schedule on Schedule.train_id=Train.train_id where station_id=@station_id AND arrival_time=arrival_time;";
            using (var connection = new SqlConnection(_connectionString))
            {
                return await connection.QueryAsync<ITrainsPass>(sqlquery,new { station_id = stationid, arrival_time = arrivaltime });
            }
        }
    }
}