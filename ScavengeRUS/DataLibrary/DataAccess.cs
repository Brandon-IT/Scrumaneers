using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class DataAccess : IDataAccess
    {
        // to get data dfrom data base
        // sql string will be select statement
        // u is var paramater to passs makes it easier to be able to pass different types of data 
        // connection string string to connect to connect to database
        public async Task<List<T>> LoadData<T, U>(string sql, U parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                var rows =await connection.QueryAsync<T>(sql, parameters);
                return rows.ToList();
            }
        }
        public Task SaveData<T>(string sql, T parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
               return connection.ExecuteAsync(sql, parameters);

            }
        }
    }
}
