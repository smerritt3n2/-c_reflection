using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace CarInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Car details = new Car(); // Generates new Object to use

            questions(details); // Calls Method to execute with object
            Console.WriteLine("<==============================>");
            Console.WriteLine("Car Details:");
            Console.WriteLine(details); // Calls Object Class to display data user has inputted
            Console.WriteLine("<==============================>");
            test(); // Generates an automatic result if program already has data avaliable
            Console.WriteLine("<==============================>");
            Console.ReadLine();
        }

        public static Car questions(Car details)
        {
            bool Valid = false;
            int number;

            Console.WriteLine("Car Make:"); // Request details for "Car Make"
            details.make = Console.ReadLine(); // Stores variable into "Car" Object section called "make"

            Console.WriteLine("Car Model:"); // Request details for "Car Model"
            details.model = Console.ReadLine(); // Stores variable into "Car" Object section called "model"

            Console.WriteLine("Car Registration:"); // Request details for "Car Registration"
            details.reg = Console.ReadLine(); // // Stores variable into "Car" Object section called "reg"

            Console.WriteLine("Year of make:"); // Request details for "Car Year"
            while(Valid == false) // Keeps looping till Valid = true
            {
                string input = Console.ReadLine();
                if(int.TryParse(input, out number)) // Checks that data is numbers only not other characters
                {
                    Valid = true;
                    details.year = int.Parse(input); // Stores variable into "Car" Object section called "year"
                }
                else
                {
                    Console.WriteLine("Invalid Data, please try again");
                }
            }
            Valid = false;


            Console.WriteLine("Car Current Value:");// Request details for "Current Value"
            while (Valid == false) // Keeps looping till Valid = true
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out number)) // Checks that data is numbers only not other characters
                {
                    Valid = true;
                    details.value = int.Parse(input); // Stores variable into "Car" Object section called "value"
                }
                else
                {
                    Console.WriteLine("Invalid Data, please try again");
                }
            }

            return details;
        }

        
    }
}
