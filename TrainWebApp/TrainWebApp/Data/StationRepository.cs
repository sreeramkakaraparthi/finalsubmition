using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace TrainWebApp.Data
{
    public class StationRepository : IStationRepository
    {
        private readonly string _connectionString;

        public StationRepository()
        {
            _connectionString = "Data Source=SAILS-DM161;Initial Catalog=trainstation;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=True";
        }

        public async Task<Station> Create(Station station)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.ExecuteAsync("INSERT INTO Station(station_id,station_name) VALUES (@station_id,@station_name)", new
                {
                    station.station_id,
                    station.station_name
                });

                return station;
               
            }

        }
        public async Task<IEnumerable<Station>> Get()
        {
            var sqlQuery = "SELECT * FROM Station";

            using (var connection = new SqlConnection(_connectionString))
            {
                return await connection.QueryAsync<Station>(sqlQuery);
            }
        }

        public async Task<Station> Getbyid(int id)
        {
            var sqlQuery = "SELECT * FROM Train WHERE station_id=@station_Id";

            using (var connection = new SqlConnection(_connectionString))
            {
                return await connection.QueryFirstOrDefaultAsync<Station>(sqlQuery, new { station_id = id });
            }
        }
       
    }

       
 }
