
namespace KittyCarSales
{
    public abstract class Car
    {
        public abstract String Make { get; set; }
        public String Model { get; set; } = "Generic Model";
        public Int32 Year { get; set; } = -1;
        public String Color { get; set; } = "Generic Color";
        public String Description { get; set; } = "Generic Description";
        public Decimal Price { get; set; } = -1;
        public Int32 Quantity { get; set; } = -1;

        public override String ToString()
        {
            return $"{Make,-8} {Model,-5} ({Year,-4}) - {Color,-10} - {Description,-40}\n             {Price,8:C0} - {Quantity,2} in stock";
        }
    }
}
