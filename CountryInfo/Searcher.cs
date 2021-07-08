using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;

namespace CountryInfo
{
    public class CountryInfo
    {
        public string Name { get; set; }
        public string NumericCode { get; set; }
        public string Capital { get; set; }

        public double? Area { get; set; }
        public long? Population { get; set; }
        public string Region { get; set; }
    }

    public class Searcher : ISearcher
    {
        public string Url { get; set; }

        private JsonSerializerOptions JsonOptions;

        public event Action<string> OnError;

        public Searcher(string url)
        {
            if (string.IsNullOrEmpty(url) || string.IsNullOrWhiteSpace(url))
                throw new Exception("некорректный URL для поиска");

            Url = url;
            JsonOptions = new JsonSerializerOptions { IgnoreNullValues = true, PropertyNameCaseInsensitive = true, WriteIndented = true };
        }

        public async Task<CountryInfo[]> DoRequest(string countryName)
        {
            using (HttpClient client = new HttpClient())
            {
                string response = null;

                if (countryName == "ALL")
                    response = await client.GetStringAsync($"{Url}/all");
                else
                    response = await client.GetStringAsync($"{Url}/name/{countryName}");

                var countries = JsonSerializer.Deserialize<CountryInfo[]>(response, JsonOptions);

                return countries;
            }
        }
    }
}
