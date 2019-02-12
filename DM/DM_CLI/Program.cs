using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DM_Lib;

namespace DM_CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            SpecManager manager = new SpecManager();
            
            // Create a spec
            Console.WriteLine("Enter a material number and press enter . . .");
            string material_id = Console.ReadLine();
            var standard_spec = manager.GetSpecification(material_id, true);
            var current_spec = manager.GetSpecification(material_id, false);
            Console.WriteLine(manager.GetPrintableSpecification(standard_spec));
            Console.WriteLine(manager.GetPrintableSpecification(current_spec) + "\nPress any key to exit . . .");
            Console.ReadLine();
        }
    }
}
