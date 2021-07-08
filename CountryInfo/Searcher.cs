using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

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

        public event Action<CountryInfo[]> OnDataLoad;
        public event Action<string> OnError;

        public Searcher(string url)
        {
            if (string.IsNullOrEmpty(url) || string.IsNullOrWhiteSpace(url))
                throw new Exception("некорректный URL для поиска");

            Url = url;
            JsonOptions = new JsonSerializerOptions { IgnoreNullValues = true, PropertyNameCaseInsensitive = true, WriteIndented = true };
        }

        public async void DoRequest(string countryName)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string resp = null;

                    if (countryName == "ALL")
                        resp = await client.GetStringAsync($"{Url}/all");
                    else
                        resp = await client.GetStringAsync($"{Url}/name/{countryName}");

                    var countries = JsonSerializer.Deserialize<CountryInfo[]>(resp, JsonOptions);

                    OnDataLoad?.Invoke(countries);
                }
            }
            catch (Exception ex)
            {
                OnError?.Invoke($"не удалось загрузить данные \n{ex.Message}");
            }

        }
    }
}
