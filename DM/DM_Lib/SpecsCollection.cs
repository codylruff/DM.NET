using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_Lib
{
    public class SpecsCollection
    {
        private List<ISpec> specs_collection;
        public ISpec DefaultSpec { get; set; }
        public string SpecType { get; set; }

        public SpecsCollection()
        {
            specs_collection = new List<ISpec>();

        }

        public void Add(ISpec spec)
        {
            specs_collection.Add(spec);
        }

        public ISpec SpecByMaterialId(string material_id)
        {
            foreach (ISpec spec in specs_collection)
            {
                if (spec.MaterialId == material_id)
                    return spec;
            }
            // returns null if no spec is found.
            Debug.Print("No spec found with this id");
            return null;
        }
    }
}
