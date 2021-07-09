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

        public async void DoQuery(CountryInfo[] data)
        {
            using (SqlCommand command = new SqlCommand("cmd", Connection))
            {
                command.CommandTimeout = 7;
                await Connection.OpenAsync();

                foreach (var country in data)
                {
                    command.Parameters.Add("cityName", country.Capital);
                    command.Parameters.Add("regName", country.Region);
                    command.Parameters.Add("name", country.Name);
                    command.Parameters.Add("area", country.Area);
                    command.Parameters.Add("code", country.NumericCode);

                    var reader = await command.ExecuteReaderAsync();
                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
                        {
                            var result = reader.GetBoolean(0);
                            var response = new Dictionary<string, bool>(1);
                            response.Add(country.Name, result);

                            SQLResult?.Invoke(response);
                        }
                    }
                }
            }
        }
    }
}
