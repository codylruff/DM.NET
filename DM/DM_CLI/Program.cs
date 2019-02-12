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
            // Create a spec
            Console.WriteLine("Enter a material number and press enter . . .");
            string material_id = Console.ReadLine();
            var spec = SpecManager.GetSpecification(material_id);
            Console.WriteLine(spec.ToString() + "\nPress any key to exit . . .");
            Console.ReadLine();
        }
    }
}
