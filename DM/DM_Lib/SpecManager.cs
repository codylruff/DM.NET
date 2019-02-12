using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DM_Lib
{
    public class SpecManager
    {
        private SpecsCollection Specs { get; set; }

        public SpecManager()
        {
            Specs = new SpecsCollection();
        }

        public void PrintSpecification(ISpec spec)
        {
            string table_header = spec.IsDefault ? "Standard Specification" : spec.TimeStamp.ToString();
            Console.WriteLine(GetPrintableSpecification(spec) + "\nPress any key to exit . . .");
            Console.ReadLine();
        }
        public ISpec GetSpecification(string material_id, bool is_default)
        {
            string table_name = (is_default ? "standard_specifications" : "modified_specifications");
            var record = DataAccess.GetSpecRecord(material_id, table_name);
            var spec = Factory.CreateSpecFromRecord(record);
            if (is_default)
            {
                Specs.DefaultSpec = spec;
            }else
            {
                Specs.Add(spec);
            }
            spec.IsDefault = is_default;
            return spec;
        }

        public void CommitSpecification(ISpec spec)
        {
            DataAccess.PushSpec(spec);
        }

        public string GetPrintableSpecification(ISpec spec)
        {   
            return spec.ToString();
        }
    }
}
