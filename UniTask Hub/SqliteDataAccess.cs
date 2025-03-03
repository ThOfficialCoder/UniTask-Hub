using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniTask_Hub.Model;

namespace UniTask_Hub
{
    public class SqliteDataAccess
    {
        public static List<PageModel> AddTasks()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PageModel>("select * from Tasks", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveTask(PageModel task)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Tasks (title, description) values (@title, @description)", task);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
