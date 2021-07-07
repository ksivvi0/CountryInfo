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

        public double Area { get; set; }
        public long Population { get; set; }
        public string Region { get; set; }
    }

    public class Searcher : ISearcher
    {
        public string Url { get; set; }

        private JsonSerializerOptions JsonOptions;

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
                    if (countryName == "ALL")
                    {
                        Console.WriteLine($"{Url}/all");
                        var resp = await client.GetStringAsync($"{Url}/all");

                        var countries = JsonSerializer.Deserialize<CountryInfo[]>(resp, JsonOptions);
                        foreach (var c in countries)
                        {
                            Console.WriteLine(c.Name);
                        }
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
