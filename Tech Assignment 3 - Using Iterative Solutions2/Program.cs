// Cheyenne Van Helden
// February 7th, 2022
// ISM 4300 - Tech Assignment 3

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech_Assignment_3___Using_Iterative_Solutions2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asking the user to input for configuration
            Console.WriteLine("To Convert Currency from USD to CAD, Enter an Integer between 5 and 20:");

            // Utilizing a try - catch block to ensure that the user enters the information correctly
            try
            {
                //Variable for user input
                string userInput = Console.ReadLine();
                // variable for conversion
                decimal convert = 0.792367m;

                int inputValue = int.Parse(userInput);

                if ((inputValue > 0) && (inputValue <= 200))
                {
                    Console.WriteLine("Executing Loop.");
                    Console.WriteLine("The Calculated iterate for" + inputValue.ToString() + " times.");

                    for (decimal dec = 0.792367m; dec < inputValue; dec++)
                    {
                        Console.WriteLine((inputValue * convert).ToString());
                    }
                    Console.WriteLine("This is the conversion for your integer into CAD:" + "\t");
                }
            }
            catch
            {
                Console.WriteLine("Please enter a valid integer and run the program again.");
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
            }
        }
    }
}
