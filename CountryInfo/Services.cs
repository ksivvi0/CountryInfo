using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CountryInfo
{
    public interface ILogger
    {
        void WriteLogAsync(string text);
    }

    public interface ISearcher
    {
        string Url { get; set; }
        event Action<string> OnError;
        Task<List<CountryInfo>> DoRequest(string data);
    }

    public interface IStore
    {
        string Database { get; set; }
        SqlConnection Connection{ get; set; }

        event Action<Dictionary<string, bool>> SQLResult;
        Task<bool> AddCountry(CountryInfo data);
        Task<List<CountryInfo>> ShowCountriesFromDB();
    }
}
