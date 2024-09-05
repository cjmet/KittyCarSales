using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KittyCarSales.Interfaces
{
    public interface ICar
    {
        public String Make { get; set; }
        public String Model { get; set; }
        public Int32 Year { get; set; }
        public String Color { get; set; }
        public String Description { get; set; }
        public Decimal Price { get; set; }
        public Int32 Quantity { get; set; }

        public abstract String ToString();
        public Boolean AddCarFromConsole();

    }
}
