using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            String? input;
            do
            {
                Console.Write(Prompt);
                input = Console.ReadLine();
                bool success = Decimal.TryParse(input, out decimal result);
                if (success) return result;
                if (input != "") Console.WriteLine("Invalid input. Please try again.");
            } while (input != "");
            return null;
        }

        public static void SearchForCar(Logic logic)
        {
            String? search = GetString("Enter the search string: ");
            if (search == null) return;
            Console.WriteLine();
            List<Car> cars = logic.SearchForCar(search); 
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

        public static void GetAllCars(Logic logic)
        {
            Console.WriteLine();
            List<Car> cars = logic.GetAllCars();
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

        public static void GetAllCarsByMake(Logic logic)
        {
            String make = GetString("Enter the make: ");
            if (make == null) return;
            Console.WriteLine();
            List<Car> cars = logic.GetAllCarsByMake(make);
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

        public static void AddCar()
        {
            String make = GetString("Enter the make: ");
            if (make == null) return;
            String model = GetString("Enter the model: ");
            if (model == null) return;
            Decimal? price = GetDecimal("Enter the price: ");
            if (price == null) return;
            Int32? year = GetInteger("Enter the year: ");
            if (year == null) return;
            // Logic.AddCar(make, model, price, year);
            throw new NotImplementedException();
        }
    }
}
