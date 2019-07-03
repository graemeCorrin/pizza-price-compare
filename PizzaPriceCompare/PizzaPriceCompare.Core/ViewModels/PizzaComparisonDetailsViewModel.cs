using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using PizzaPriceCompare.Core.Models;
using PizzaPriceCompare.Core.Services;
using System.Threading.Tasks;

namespace PizzaPriceCompare.Core.ViewModels
{
    public class PizzaComparisonDetailsViewModel : MvxViewModel<PizzaComparison>
    {

        private readonly IMvxNavigationService _navigationService;
        private readonly IPizzaPriceDatabase _pizzaPriceDatabase;

        public PizzaComparison PizzaComparison { get; private set; }

        public MvxObservableCollection<PizzaPrice> PizzaPrices { get; } = new MvxObservableCollection<PizzaPrice>();


        public PizzaComparisonDetailsViewModel(IMvxNavigationService navigationService, IPizzaPriceDatabase pizzaPriceDatabase)
        {
            _navigationService = navigationService;
            _pizzaPriceDatabase = pizzaPriceDatabase;
        }

        public override void Prepare(PizzaComparison parameter)
        {
            PizzaComparison = parameter;
        }

        public override async void ViewAppeared()
        {
            base.ViewAppeared();
            var pizzaPrices = await _pizzaPriceDatabase.GetPizzaPricesAsync(PizzaComparison);

            PizzaPrices.Clear();
            foreach (PizzaPrice pizzaPrice in pizzaPrices) PizzaPrices.Add(pizzaPrice);
        }

        public async Task NewPizzaPriceAsync()
        {
            _ = await _navigationService.Navigate<PizzaPriceEditViewModel, PizzaPrice>(new PizzaPrice() { PizzaComparisonId = PizzaComparison.Id });
        }

        public async Task EditPizzaPriceAsync(PizzaPrice pizzaPrice)
        {
            _ = await _navigationService.Navigate<PizzaPriceEditViewModel, PizzaPrice>(pizzaPrice);
        }

        public async Task DeletePizzaComparisonAsync()
        {
            await _pizzaPriceDatabase.DeletePizzaComparisonAsync(PizzaComparison);
            await _navigationService.Close(this);
        }
    }
}
