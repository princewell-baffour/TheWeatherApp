using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWeather
{
    class SqliteDataAccess
    {
        public static List<WeatherInfo> LoadData()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<WeatherInfo>("select * from Data", new DynamicParameters());
                return output.ToList();
            }
        }
        public static void SaveData(WeatherInfo weatherInfo)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Data (Country, City) values ('BE', 'Gee')", weatherInfo);
            }
        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
