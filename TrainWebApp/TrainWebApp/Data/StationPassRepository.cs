using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace TrainWebApp.Data
{
    public class StationPassRepository : IStationPassRepository
    {
        private readonly string _connectionString;
        public StationPassRepository()
        {
            _connectionString = "Data Source=SAILS-DM161;Initial Catalog=trainstation;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=True";
        }
        public async Task<IEnumerable<IStationPass>> GetStationPassby(int trainid,string arrivaltime)
        {
            var sqlquery = "select Station.station_id,Station.station_name from Station LEFT JOIN Schedule on Schedule.station_id=Station.station_id where train_id=@train_id AND arrival_time=@arrival_time;";
            using (var connection = new SqlConnection(_connectionString))
            {
                return await connection.QueryAsync<IStationPass>(sqlquery,new { train_id=trainid,arrival_time = arrivaltime });
            }
        }
    }
}