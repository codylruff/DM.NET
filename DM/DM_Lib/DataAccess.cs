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
        public static SpecRecord GetSpecRecord(string material_id, string table_name)
        {
            var sql = new StringBuilder();
            sql.AppendFormat("SELECT * FROM {0} WHERE Material_Id = '{1}'", table_name, material_id);
            var record = Factory.CreateSpecRecordFromReader(ExecuteSqlSelect(sql.ToString()));
            return record;
        }

        public static void PushSpec(ISpec spec)
        {
            var record = Factory.CreateRecordFromSpec(spec);
        }

        public static SQLiteDataReader ExecuteSqlSelect(string sql)
        {
            var dbConnection = new SQLiteConnection(
                @"Data Source=C:\Users\codyl\Source\Repos\DM.NET\DM\SAATI_Spec_Manager.db3;Version=3;");
            dbConnection.Open();        
            SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
            return command.ExecuteReader();
        }

        public static void CreateSqliteDatabase(string db_name)
        {
            SQLiteConnection.CreateFile(db_name + ".sqlite");
        }

    }
}
