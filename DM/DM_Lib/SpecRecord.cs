using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Globalization;

namespace DM_Lib
{
    public class SpecRecord
    {
        public string JsonText { get; private set; }
        public string SpecType { get; private set; }
        public string TimeStamp { get; private set; }
        public string MaterialId { get; private set; }
        public int Id { get; private set; }

        public SpecRecord(SQLiteDataReader reader)
        {
            while (reader.Read())
            {
                JsonText = (string)reader["Json_Text"];
                SpecType = (string)reader["Spec_Type"];
                MaterialId = (string)reader["Material_Id"];
                Id = reader.GetInt32(0);
            }
        }

        public SpecRecord(ISpec spec, string json_text)
        {
            JsonText = json_text;
            SpecType = spec.SpecType;
            TimeStamp = Convert.ToString(DateTime.Now);
            MaterialId = spec.MaterialId;
        }
    }
}
