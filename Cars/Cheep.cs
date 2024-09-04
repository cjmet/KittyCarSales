using KittyCarSales.Interfaces;

namespace KittyCarSales
{
    internal class Cheep : ICar
    {
        public String Make { get; set; } = "Cheep";

        public String Model { get; set; } = "Generic Model";
        public Int32 Year { get; set; } = -1;
        public String Color { get; set; } = "Generic Color";
        public String Description { get; set; } = "Generic Description";
        public Decimal Price { get; set; } = -1;
        public Int32 Quantity { get; set; } = -1;

        public Boolean AddCarFromConsole()
        {
            String? model = CLI.GetString("Model: ");
            if (model == null) return false;
            Int32? year = CLI.GetInteger("Year: ");
            if (year == null) return false;

            String? color = CLI.GetString("Color: ");
            if (color == null) return false;
            String? description = CLI.GetString("Description: ");
            if (description == null) return false;

            Decimal? price = CLI.GetDecimal("Price: ");
            if (price == null) return false;


            { Make = this.Make; Model = model; Year = (Int32)year; Color = color; Description = description; Price = (Decimal)price;  }
            return true;

        }
        public override String ToString()
        {
            return $"{Make,-8} {Model,-5} ({Year,-4}) - {Color,-10} - {Description,-40}\n {" ",61} {Price,8:C0} - {Quantity,2} in stock";
        }
    }
}
