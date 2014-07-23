using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicPlayer_1._0.classes
{
    class Config
    {
        public static readonly string APP_NAME = "Music Player 1.0";
        public static readonly string DB_CON_STR = "User Id=system;Password=1234;Data Source=localhost:1521/xe";
        public static Int16 USER_ID_NO = 0;
        public static String USER_NAME = "";

        public static string getAppNameAppended(string prefix)
        {
            return prefix + " : " + APP_NAME;
        }
    }
}
