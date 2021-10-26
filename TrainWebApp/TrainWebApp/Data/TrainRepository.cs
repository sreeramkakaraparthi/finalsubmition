using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace TrainWebApp.Data
{
    public class TrainRepository : ITrainRepository
    {


        private readonly string _connectionString;

        public TrainRepository()
        {
            _connectionString = "Data Source=SAILS-DM161;Initial Catalog=trainstation;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=True";
        }




        public async Task<Train> Create(Train train)
        {
            // var sqlQuery = "INSERT INTO Train(train_id, train_name,source,destination) VALUES (@train_id, @train_name,@source,@destination)";
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.ExecuteAsync("INSERT INTO Train(train_id, train_name,soource,destination) VALUES (@train_id, @train_name,@soource,@destination)", new
                {
                    train.train_id,
                    train.train_name,
                    train.soource,
                    train.destination

                });

                return train;

            }

        }
        public async Task<IEnumerable<Train>> Get()
        {
            var sqlQuery = "SELECT * FROM Train";

            using (var connection = new SqlConnection(_connectionString))
            {
                return await connection.QueryAsync<Train>(sqlQuery);
            }
        }

        public async Task<Train> Get(int id)
        {
            var sqlQuery = "SELECT * FROM Train WHERE train_Id=@train_Id";

            using (var connection = new SqlConnection(_connectionString))
            {
                return await connection.QueryFirstOrDefaultAsync<Train>(sqlQuery, new { train_id = id });
            }
        }

       
    }
}