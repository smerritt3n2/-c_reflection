using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInformation
{
    static class test
    {
        public static void testClass()
        {
            string[] testCar = { "Fiat", "Scario", "HLP 09L", "2009", "350" };
            Console.WriteLine("Test Details Class");
            Console.WriteLine("Make: " + testCar[0] + " Model: " + testCar[1] + " Car Registration: " + testCar[2] + " Year: " + testCar[3] + " Current Value: £" + testCar[4]);
        }
    }
}
