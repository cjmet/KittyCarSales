using KittyCarSales.Interfaces;

namespace KittyCarSales
{
    internal class Quick : Car, ICar
    {
        public String Make { get; set; } = "Quick";

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
            Int32? quantity = CLI.GetInteger("Quantity: ");
            if (quantity == null) return false;

            { Make = this.Make; Model = model; Year = (Int32)year; Color = color; Description = description; Price = (Decimal)price; Quantity = (Int32)quantity; }
            return true;

        }
        public override String ToString()
        {
            return $"{Make,-8} {Model,-5} ({Year,-4}) - {Color,-10} - {Description,-40}\n {" ",11} {Price,8:C0} - {Quantity,2} in stock";
        }
    }
}
