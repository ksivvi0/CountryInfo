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
        void a();
    }
}
