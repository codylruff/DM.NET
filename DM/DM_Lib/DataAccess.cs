using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_Lib
{
    public static class DataAccess
    {
        public static string GetSpecJson(string material_id)
        {
            return "{'MaterialNumber':'GKE0101T90E', 'Style':'101',}";
        }

        public static void PushSpec(string material_id, string json_text, string spec_type)
        {
            throw new NotImplementedException();
        }
    }
}
