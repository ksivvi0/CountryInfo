using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryInfo
{
    public class Store : IStore
    {
        public string Database { get; set; }
        public SqlConnection Connection { get; set; }
        public event Action<Dictionary<string, bool>> SQLResult;

        public Store(string connectionString)
        {
            Connection = new SqlConnection(connectionString);
        }

        public async Task<bool> AddCountry(CountryInfo data)
        {
            using (SqlCommand command = new SqlCommand("dbo.addCountry", Connection))
            {
                command.CommandTimeout = 7;
                command.CommandType = System.Data.CommandType.StoredProcedure;

                await Connection.OpenAsync();

                var result = new SqlParameter("result", System.Data.SqlDbType.Bit);
                result.Direction = System.Data.ParameterDirection.ReturnValue;

                command.Parameters.Add("cityName", data.Capital);
                command.Parameters.Add("regName", data.Region);
                command.Parameters.Add("name", data.Name);
                command.Parameters.Add("area", data.Area);
                command.Parameters.Add("code", data.NumericCode);

                command.Parameters.Add(result);

                var reader = await command.ExecuteNonQueryAsync();

                return (bool)command.Parameters["result"].Value;
            }
        }
    }
}
