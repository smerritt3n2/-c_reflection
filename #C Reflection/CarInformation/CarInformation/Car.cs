using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInformation
{
    class Car // Creates Object Array to store mutiple values from user input
    { 
        public string make { get; internal set; } // Stores value of car make
        public string model { get; internal set; } // Stores value of car model
        public string reg { get; internal set; } // Stores value of car reg
        public int year { get; internal set; } // Stores value of car year
        public int value { get; internal set; } // Stores value of car value

        public override string ToString() // Overrides the data and converts to string
        {
            return "Make: " + make + " Model: " + model + " Car Registration: " + reg + " Year: " + year + " Current Value: £" + value;
        }
    }
}
