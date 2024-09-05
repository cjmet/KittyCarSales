using KittyCarSales.Interfaces;

namespace KittyCarSales
{
    public class Logic
    {
        List<ICar> _cars = new List<ICar>();
        public Logic()
        {
            _cars = new List<ICar> {
                new Cattilap {Model = "Racer", Color = "Red", Description = "Fast and Luxurious", Price = 103542, Quantity = 1, Year = 2024 },
                new Cheep {Model = "Sedan", Color = "Blue", Description = "Cheap and Affordable", Price = 12345, Quantity = 2, Year = 2003 },
                new Duck {Model = "Truck", Color = "Green", Description = "Durable and Reliable", Price = 54321, Quantity = 3, Year = 2022 },
                new Fjorde {Model = "SUV", Color = "Yellow", Description = "Off-road and Adventurous", Price = 98765, Quantity = 4, Year = 2021 },
                new Quick {Model = "Coupe", Color = "Black", Description = "Sporty and Fun", Price = 67890, Quantity = 5, Year = 2020 },
                new Voltaic {Model = "Zapper", Color = "Electric Blue", Description = "Fun and Sporty Electric Two Seater", Price = 77396, Quantity = 1, Year = 2024 }
            };
        }

        public List<ICar> SearchForCar(String search)
        {
            search = search.ToLower();
            return _cars.Where(c => c.Make.ToLower().Contains(search) || c.Model.ToLower().Contains(search)
            || c.Color.ToLower().Contains(search) || c.Description.ToLower().Contains(search)).ToList();
        }

        public List<ICar> GetAllCars()
        {
            return _cars;
        }

        public List<ICar> GetAllCarsByMake(String make)
        {
            make = make.ToLower();
            return _cars.Where(c => c.Make.ToLower().Contains(make)).ToList();
        }

        public Decimal? GetTotalInventoryValue()
        {
            return _cars.Sum(c => c.Price * c.Quantity);
        }

        public Decimal? GetAverageCarPrice()
        {
            return _cars.Average(c => c.Price);
        }

        public void AddCar(ICar car)
        {
            _cars.Add(car);
        }

    }
}
