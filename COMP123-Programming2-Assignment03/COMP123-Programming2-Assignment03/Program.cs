/*
 * studentName:Bin Liang | studentNumber:300788322
 * Date last Modified:Feb 24th,2015
 * Program description:COMP123_Assignment03,Abstract Planets Class.
 * Revision	History:
 * 1.Finished Abstract Class Planet.
 * 2.Finished subClass GiantPlanet.
 * 3.Add TerrestrialPlanet class and three Interfaces
 * 4.Debugging successfully and completing check with "ClassDiagram".
 * 5.Improve interface method codes and comments
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Programming2_Assignment03
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet myGiantPlanet = new GiantPlanet("Fire", 100.0, 200.0, "Gas");
            Console.WriteLine(myGiantPlanet.ToString());

            TerrestrialPlanet myTerrestrialPlanet = new TerrestrialPlanet("Sun", 1000000.0, 2000000.0, true);
            Console.WriteLine(myTerrestrialPlanet.ToString());

            waitForAnyKey();
        }

        private static void waitForAnyKey()
        {
            Console.Write("\n");
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("Please hit any key to exit....");
            Console.ReadKey();
        }
    }
}
