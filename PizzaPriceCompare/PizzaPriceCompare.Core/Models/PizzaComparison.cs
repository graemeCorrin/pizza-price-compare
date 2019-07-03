using SQLite;

namespace PizzaPriceCompare.Core.Models
{
    public class PizzaComparison
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
