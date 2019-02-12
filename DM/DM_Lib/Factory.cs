using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_Lib
{
    public static class Factory
    {
        public static WarpingSpecification DefaultWarpingSpecification(string material_id, StyleSpecification style_spec)
        {
            var spec = new WarpingSpecification(material_id, style_spec);
            return spec;
        }

        public static WarpingSpecification WarpingSpecificationFromJson(string json_text)
        {
            var spec = new WarpingSpecification(json_text);
            return spec;
        }
    }
}
