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
        
         
         public static List<weatherForecast> LoadData()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<weatherForecast>("select * from Data", new DynamicParameters());
                return output.ToList();
                
            }
        }
        public static void SaveData(weatherForecast wforcast)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO Data (`Date`, `Country`, `City`, `Conditions`, `MinTemperature`, `MaxTemperature`, `Wind`) values" +
                    " (@date, @country, @ccity, @cond, @minTemp, @maxTemp, @wind)", wforcast);
                Console.WriteLine("Successful");
            }
        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
