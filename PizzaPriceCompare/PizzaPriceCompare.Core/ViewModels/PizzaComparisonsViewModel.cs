using System.Threading.Tasks;
using Acr.UserDialogs;
using MvvmCross;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using PizzaPriceCompare.Core.Models;
using PizzaPriceCompare.Core.Services;

namespace PizzaPriceCompare.Core.ViewModels
{
    public class PizzaComparisonsViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;
        private readonly IPizzaPriceDatabase _pizzaPriceDatabase;

        public MvxObservableCollection<PizzaComparison> PizzaComparisons { get; } = new MvxObservableCollection<PizzaComparison>();


        public PizzaComparisonsViewModel(IMvxNavigationService navigationService, IPizzaPriceDatabase pizzaPriceDatabase)
        {
            _navigationService = navigationService;
            _pizzaPriceDatabase = pizzaPriceDatabase;
        }

        public override async void ViewAppeared()
        {
            base.ViewAppeared();
            var pizzaComparisons = await _pizzaPriceDatabase.GetPizzaComparisonsAsync();

            PizzaComparisons.Clear();
            foreach (PizzaComparison comparison in pizzaComparisons) PizzaComparisons.Add(comparison);
        }

        public async Task NewPizzaComparisonAsync()
        {
            var result = await Mvx.IoCProvider.Resolve<IUserDialogs>().PromptAsync("Pizza Comparison Name");

            if (result.Ok && !string.IsNullOrWhiteSpace(result.Text))
            {
                var newPizzaComparison = new PizzaComparison() { Name = result.Text };
                await _pizzaPriceDatabase.SavePizzaComparisonAsync(newPizzaComparison);
                _ = await _navigationService.Navigate<PizzaComparisonDetailsViewModel, PizzaComparison>(newPizzaComparison);
            }
        }

        public async Task ViewPizzaComparisonAsync(PizzaComparison comparison)
        {
            _ = await _navigationService.Navigate<PizzaComparisonDetailsViewModel, PizzaComparison>(comparison);
        }

    }
}
