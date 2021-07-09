using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryInfo
{
    class Config
    {
        public string Username { get; set; }
        public string Passwd { get; set; }
        public string ServerName { get; set; }
        public string Database { get; set; }

        //TODO: добавить лучше хэш пароля... 
    }
}
