using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryInfo
{
    public class Logger: ILogger
    {
        public string LogPath{ get; private set; }

        public Logger(string path)
        {
            if (string.IsNullOrEmpty(path) || string.IsNullOrWhiteSpace(path))
                throw new Exception("некорректный путь для журналирования");

            LogPath = path;
        }

        public async void WriteLogAsync(string data)
        {
            using (StreamWriter writer = new StreamWriter(LogPath, true, Encoding.UTF8))
                await writer.WriteLineAsync($"{DateTime.Now}:\t{data}");
        }
    }

}
