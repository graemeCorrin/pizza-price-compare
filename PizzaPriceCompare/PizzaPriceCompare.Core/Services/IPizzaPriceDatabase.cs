using PizzaPriceCompare.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzaPriceCompare.Core.Services
{
    public interface IPizzaPriceDatabase
    {

        Task<List<PizzaComparison>> GetPizzaComparisonsAsync();

        Task<List<PizzaPrice>> GetPizzaPricesAsync(PizzaComparison comparison);

        Task<PizzaPrice> GetPizzaPriceAsync(int id);

        Task<int> SavePizzaPriceAsync(PizzaPrice pizzaPrice);

        Task<int> SavePizzaComparisonAsync(PizzaComparison comparison);

        Task<int> DeletePizzaPriceAsync(PizzaPrice pizzaPrice);

        Task<int> DeletePizzaComparisonAsync(PizzaComparison comparison);

    }
}
