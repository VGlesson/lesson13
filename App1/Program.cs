using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Тула, 20, 40, 60");
            Console.WriteLine(building.Print());
            MultiBuilding multiBuilding = new MultiBuilding("Тула, 20, 40, 60, 20");
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }
    }
}
