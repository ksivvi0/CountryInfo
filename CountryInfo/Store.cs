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

                var resultParam = new SqlParameter("result", System.Data.SqlDbType.Bit);
                resultParam.Direction = System.Data.ParameterDirection.ReturnValue;

                command.Parameters.Add("cityName", data.Capital);
                command.Parameters.Add("regName", data.Region);
                command.Parameters.Add("name", data.Name);
                command.Parameters.Add("area", data.Area);
                command.Parameters.Add("code", data.NumericCode);
                command.Parameters.Add("population", data.Population);

                command.Parameters.Add(resultParam);

                var reader = await command.ExecuteNonQueryAsync();
                var result = Convert.ToBoolean(command.Parameters["result"].Value);

                Connection.Close();
                return result;
            }
        }

        public async Task<List<CountryInfo>> ShowCountriesFromDB()
        {
            using (SqlCommand command = new SqlCommand("dbo.showAllCountries", Connection))
            {
                command.CommandTimeout = 7;
                command.CommandType = System.Data.CommandType.StoredProcedure;

                await Connection.OpenAsync();

                var reader = await command.ExecuteReaderAsync();
                var countries = new List<CountryInfo>();

                while (await reader.ReadAsync())
                {
                    var id = reader[0];
                    var code = reader.GetString(1);
                    var name = reader.GetString(2);
                    var area = reader.GetDouble(3);
                    var population = reader.GetInt64(4);
                    var region = reader.GetString(5);
                    var capital = reader.GetString(6);

                    countries.Add(
                        new CountryInfo
                        {
                            Area = area,
                            NumericCode = code,
                            Capital = capital,
                            Name = name,
                            Population = population,
                            Region = region
                        }
                    );
                }

                Connection.Close();

                return countries;
            }
        }
    }
}
