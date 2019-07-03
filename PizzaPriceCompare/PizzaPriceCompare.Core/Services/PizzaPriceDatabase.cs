using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PizzaPriceCompare.Core.Models;
using SQLite;

namespace PizzaPriceCompare.Core.Services
{
    public class PizzaPriceDatabase : IPizzaPriceDatabase
    {

        readonly SQLiteAsyncConnection database;

        public PizzaPriceDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<PizzaComparison>().Wait();
            database.CreateTableAsync<PizzaPrice>().Wait();
        }

        public Task<List<PizzaComparison>> GetPizzaComparisonsAsync()
        {
            return database.Table<PizzaComparison>().ToListAsync();
        }

        public Task<List<PizzaPrice>> GetPizzaPricesAsync(PizzaComparison pizzaComparison)
        {
            return database.Table<PizzaPrice>().Where(i => i.PizzaComparisonId == pizzaComparison.Id).ToListAsync();
        }

        public Task<PizzaPrice> GetPizzaPriceAsync(int id)
        {
            return database.Table<PizzaPrice>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public Task<int> SavePizzaPriceAsync(PizzaPrice pizzaPrice)
        {
            pizzaPrice.PricePerSquareInch = pizzaPrice.Price / (Math.PI * Math.Pow(pizzaPrice.Diameter / 2, 2));

            if (pizzaPrice.Id != 0)
            {
                return database.UpdateAsync(pizzaPrice);
            }
            else
            {
                return database.InsertAsync(pizzaPrice);
            }
        }

        public Task<int> SavePizzaComparisonAsync(PizzaComparison pizzaComparison)
        {
            if (pizzaComparison.Id != 0)
            {
                return database.UpdateAsync(pizzaComparison);
            }
            else
            {
                return database.InsertAsync(pizzaComparison);
            }
        }

        public Task<int> DeletePizzaPriceAsync(PizzaPrice pizzaPrice)
        {
            return database.DeleteAsync(pizzaPrice);
        }

        public Task<int> DeletePizzaComparisonAsync(PizzaComparison pizzaComparison)
        {
            return database.DeleteAsync(pizzaComparison);
        }

    }
}
