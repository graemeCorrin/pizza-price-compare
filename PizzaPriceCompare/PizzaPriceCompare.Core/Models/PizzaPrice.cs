using SQLite;

namespace PizzaPriceCompare.Core.Models
{
    public class PizzaPrice
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Diameter { get; set; }
        public double Price { get; set; }
        public double PricePerSquareInch { get; set; }
        public int PizzaComparisonId { get; set; }
    }
}
