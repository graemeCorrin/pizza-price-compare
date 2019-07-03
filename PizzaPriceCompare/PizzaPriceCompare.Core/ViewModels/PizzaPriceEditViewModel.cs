using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using PizzaPriceCompare.Core.Models;
using PizzaPriceCompare.Core.Services;
using System.Threading.Tasks;

namespace PizzaPriceCompare.Core.ViewModels
{
    public class PizzaPriceEditViewModel : MvxViewModel<PizzaPrice>
    {

        private readonly IMvxNavigationService _navigationService;
        private readonly IPizzaPriceDatabase _pizzaPriceDatabase;

        public PizzaPrice PizzaPrice { get; private set; }

        public PizzaPriceEditViewModel(IMvxNavigationService navigationService, IPizzaPriceDatabase pizzaPriceDatabase)
        {
            _navigationService = navigationService;
            _pizzaPriceDatabase = pizzaPriceDatabase;
        }

        public override void Prepare(PizzaPrice parameter)
        {
            PizzaPrice = parameter;
        }     

        public async Task DeleteAsync()
        {
            await _pizzaPriceDatabase.DeletePizzaPriceAsync(PizzaPrice);
            await _navigationService.Close(this);
        }

        public async Task CancelAsync()
        {
            await _navigationService.Close(this);
        }

        public async Task SaveAsync()
        {
            await _pizzaPriceDatabase.SavePizzaPriceAsync(PizzaPrice);
            await _navigationService.Close(this);
        }
    }
}
