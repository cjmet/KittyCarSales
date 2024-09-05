using KittyCarSales.Interfaces;

namespace KittyCarSales
{
    internal class Duck : Car, ICar
    {
        public String Make { get; set; } = "Duck";

       
    }
}
