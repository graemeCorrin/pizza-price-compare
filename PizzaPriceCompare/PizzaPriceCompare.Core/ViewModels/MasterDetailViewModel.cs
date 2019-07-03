using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace PizzaPriceCompare.Core.ViewModels
{
    public class MasterDetailViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public MasterDetailViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override async void ViewAppearing()
        {
            base.ViewAppearing();
            await _navigationService.Navigate<MenuViewModel>();
            await _navigationService.Navigate<MainViewModel>();
        }
    }
}