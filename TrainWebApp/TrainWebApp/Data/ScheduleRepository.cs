using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace TrainWebApp.Data
{
    public class TrainPassRepository : IScheduleRepository
    {
        private readonly string _connectionString;
        public TrainPassRepository()
        {
            _connectionString = "Data Source=SAILS-DM161;Initial Catalog=trainstation;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=True";
        }
        public async Task<Schedule> Create(Schedule schedule)
        {
           using(var connection=new SqlConnection(_connectionString))
            {
                await connection.ExecuteAsync("INSERT INTO Schedule(train_id,station_id,arrival_time,departure_time) VALUES (@train_id,@station_id,@arrival_time,@departure_time)", new
                {
                    schedule.train_id,
                    schedule.station_id,
                    schedule.arrival_time,
                    schedule.departure_time
                });
                return schedule;
                

            }
        }

        public async Task<IEnumerable<Schedule>> Get()
        {
            var sqlquery = "SELECT * FROM Schedule";
            using (var connection = new SqlConnection(_connectionString))
            {
               return await connection.QueryAsync<Schedule>(sqlquery);
            }
        }

        
    }
}