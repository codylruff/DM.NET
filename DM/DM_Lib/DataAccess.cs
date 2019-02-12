using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace DM_Lib
{
    public static class DataAccess
    {
        public static string GetSpecJson(string material_id, string table_name)
        {
            var sql = new StringBuilder();
            sql.AppendFormat("SELECT Json_Text FROM {0} WHERE Material_Id = '{1}'", table_name, material_id);
            var data = ExecuteSqlSelect(sql.ToString());
            return data[0];
        }

        public static void PushSpec(string material_id, string json_text, string spec_type)
        {
            throw new NotImplementedException();
        }

        public static List<string> ExecuteSqlSelect(string sql)
        {
            var data = new List<string>();
            var dbConnection = new SQLiteConnection(
                @"Data Source=C:\Users\codyl\Source\Repos\DM.NET\DM\SAATI_Spec_Manager.db3;Version=3;");
            dbConnection.Open();        
            SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
                data.Add((string)(reader["json_text"]));
            return data;
        }

        public static void CreateSqliteDatabase(string db_name)
        {
            SQLiteConnection.CreateFile(db_name + ".sqlite");
        }

    }
}
