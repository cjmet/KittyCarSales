using System.Reflection;
using KittyCarSales.Interfaces;

namespace KittyCarSales
{
    static public class CLI
    {
        public static Int32? GetInteger(String Prompt)
        {
            String? input;
            do
            {
                Console.Write(Prompt);
                input = Console.ReadLine();
                bool success = Int32.TryParse(input, out int result);
                if (success) return result;
                if (input != "") Console.WriteLine("Invalid input. Please try again.");
            } while (input != "");
            return null;
        }

        public static String? GetString(String Prompt)
        {
            String? input;
            do
            {
                Console.Write(Prompt);
                input = Console.ReadLine();
                if (input != "") return input;
            } while (input != "");
            return null;
        }

        public static Decimal? GetDecimal(String Prompt)
        {
            throw new NotImplementedException();
        }

        public static void SearchForCar(Logic logic)
        {
            String? search = GetString("Enter the search string: ");
            if (search == null) return;
            Console.WriteLine();
            List<ICar> cars = logic.SearchForCar(search);
            if (cars.Count == 0)
            {
                Console.WriteLine("No cars found.");
                return;
            }
            foreach (ICar car in cars)
            {
                Console.WriteLine(car);
            }
        }

        public static void GetAllCars(Logic logic)
        {
            Console.WriteLine();
            List<ICar> cars = logic.GetAllCars();
            if (cars.Count == 0)
            {
                Console.WriteLine("No cars found.");
                return;
            }
            foreach (ICar car in cars)
            {
                Console.WriteLine(car);
            }
        }

        public static void GetAllCarsByMake(Logic logic)
        {
            String make = GetString("Enter the make: ");
            if (make == null) return;
            Console.WriteLine();
            List<ICar> cars = logic.GetAllCarsByMake(make);
            if (cars.Count == 0)
            {
                Console.WriteLine("No cars found.");
                return;
            }
            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
        }

        public static void GetTotalInventoryValue(Logic logic)
        {
            Decimal? value = logic.GetTotalInventoryValue();
            if (value == null)
            {
                Console.WriteLine("No cars found.");
                return;
            }
            Console.WriteLine();
            Console.WriteLine($"Total Inventory Value: {value:C0}");
        }

        public static void GetAverageCarPrice(Logic logic)
        {
            Decimal? value = logic.GetAverageCarPrice();
            if (value == null)
            {
                Console.WriteLine("No cars found.");
                return;
            }
            Console.WriteLine();
            Console.WriteLine($"Average Car Price: {value:C0}");
        }

        public static void Reflection()
        {
            Console.WriteLine();
            var parent = Assembly.GetExecutingAssembly().GetName().Name;
            Console.WriteLine($"Parent: {parent}");
            var children = Assembly.GetExecutingAssembly().GetTypes().Where(a => a.BaseType == typeof(Car)).ToList();
            var childNames = children.Select(a => a.Name).ToList();
            Console.WriteLine("Children: ");
            foreach (var child in children)
            {
                Console.WriteLine($"   {child.Name,-8} is a {child.BaseType.Name}");
            }
            return;
        }

        public static void AddCar(Logic logic)
        {
            var makes = Assembly.GetExecutingAssembly().GetTypes().Where(a => a.BaseType == typeof(Car)).ToList();

            String? make;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Available Makes: ");
                Console.WriteLine($"   {String.Join(", ", makes.Select(a => a.Name))}");
                make = CLI.GetString("Make: ");
                if (make == null) return;
            } while (!makes.Select(a => a.Name).Contains(make));

            Type type = makes.Where(a => a.Name == make).First();


            ICar clone = (ICar)Activator.CreateInstance(type);

            // Use Interfaces to FIX this.
            dynamic car = Activator.CreateInstance(type); // dynamic is bad!  Start praying here.
            if (car == null) return; 
            var result = car.AddCarFromConsole(); // Pray harder here ... will this work or go boom!

            if (result)
            {
                logic.AddCar(car);
                Console.WriteLine("Car added successfully.");
            }
            else
            {
                Console.WriteLine("Car not added.");
            }
        }
    }
}
