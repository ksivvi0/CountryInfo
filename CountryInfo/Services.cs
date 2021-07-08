using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryInfo
{
    public interface ILogger
    {
        void WriteLogAsync(string text);
    }

    public interface ISearcher
    {
        string Url { get; set; }
        event Action<CountryInfo[]> OnDataLoad;
        event Action<string> OnError;
        void DoRequest(string data);
    }
}
