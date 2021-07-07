using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryInfo
{
    public class Logger
    {
        static string LogPath;

        static Logger()
        {
            LogPath = "country_info.log";
        }

        public static async void WriteLogAsync(string data)
        {
            using (StreamWriter writer = new StreamWriter(LogPath, true, Encoding.UTF8))
                await writer.WriteLineAsync($"{DateTime.Now}:\t{data}");
        }
    }

}
