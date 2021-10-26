using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace TrainWebApp.Data
{
    public class TrainScheduleRepository : ITrainScheduleRepository
    {
        private readonly string _connectionString;
        public TrainScheduleRepository()
        {
            _connectionString = "Data Source=SAILS-DM161;Initial Catalog=trainstation;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=True";

        }
        public async Task<IEnumerable<ITrainSchedule>> ScheduledTrains(string arrivaltime)
        {
            var sqlQuery = "SELECT Train.train_id,train_name FROM Train LEFT JOIN Schedule on Schedule.train_id=Train.train_id WHERE arrival_time=@arrival_time";
            using (var connection = new SqlConnection(_connectionString))
            {
                return await connection.QueryAsync<ITrainSchedule>(sqlQuery, new { Arrival_time = arrivaltime });
            }
        }
    }
}