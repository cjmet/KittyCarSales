using System;
using System.Reflection;

namespace KittyCarSales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logo();

            Logic logic = new Logic();

            String Prompt =
"""

Welcome to Kitty Car Sales!
-------
1. Search for a car
2. Get all cars
3. Get all cars by make
4. Get Total Inventory Value
5. Get Average Car Price

8. System.Reflection
9. Add a car
-------
""";
            do
            {
                Console.WriteLine(Prompt);
                Int32? Choice = CLI.GetInteger("Enter your choice: ");
                if (Choice == null) break;

                if (Choice == 1) 
                    CLI.SearchForCar(logic);
                if (Choice == 2); 
                    CLI.GetAllCars(logic);
                if (Choice == 3) 
                    CLI.GetAllCarsByMake(logic);
                if (Choice == 4) 
                    CLI.GetTotalInventoryValue(logic);
                if (Choice == 5) 
                    CLI.GetAverageCarPrice(logic);
                if (Choice == 8) 
                    CLI.Reflection();
                if (Choice == 9) 
                    CLI.AddCar(logic);
                if (Choice <= 0 || Choice > 9)  Console.WriteLine("Invalid choice. Please try again.");

            } while (true);

        }

        public static void Logo()
        {
            String logo =
"""
        ,_     _,
        |\\___//|
        |=6   6=|
        \=._Y_.=/
         )  `  (    ,
        /       \  ((
        |       |   ))
       /| |   | |\_//
  jgs  \| |._.| |/-`
        '"'   '"'                                             Art by Joan Stark
""";
            Console.WriteLine(logo);
        }
    }
}
