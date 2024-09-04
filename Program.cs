

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

9. Add a car
-------
""";
            do
            {
                Console.WriteLine(Prompt);
                Int32? Choice = CLI.GetInteger("Enter your choice: ");
                if (Choice == null) break;

                switch (Choice)
                {
                    case 1:
                        CLI.SearchForCar(logic);
                        break;
                    case 2:
                        CLI.GetAllCars(logic);
                        break;
                    case 3:
                        CLI.GetAllCarsByMake(logic);
                        break;
                    case 4:
                        CLI.GetTotalInventoryValue(logic);
                        break;
                    case 5:
                        CLI.GetAverageCarPrice(logic);
                        break;
                    case 9:
                        CLI.AddCar();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

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
