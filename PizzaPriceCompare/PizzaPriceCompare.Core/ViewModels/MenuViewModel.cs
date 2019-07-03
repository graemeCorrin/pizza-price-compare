using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace PizzaPriceCompare.Core.ViewModels
{
    public class MenuViewModel : MvxViewModel
    {

        #region services

        private readonly IMvxNavigationService _navigationService;

        #endregion

        #region propterties

        private ObservableCollection<Tuple<string, string>> _primaryMenuList;
        public ObservableCollection<Tuple<string, string>> PrimaryMenuList
        {
            get => _primaryMenuList;
            set => SetProperty(ref _primaryMenuList, value);
        }

        private ObservableCollection<Tuple<string, string>> _secondaryMenuList;
        public ObservableCollection<Tuple<string, string>> SecondaryMenuList
        {
            get => _secondaryMenuList;
            set => SetProperty(ref _secondaryMenuList, value);
        }

        private readonly IMvxAsyncCommand<string> _showDetailPageAsyncCommand;
        public IMvxAsyncCommand<string> ShowDetailPageAsyncCommand
        {
            get => _showDetailPageAsyncCommand ?? new MvxAsyncCommand<string>(ShowDetailPageAsync);
        }

        #endregion

        #region constructor

        public MenuViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;

            PrimaryMenuList = new MvxObservableCollection<Tuple<string, string>>()
            {
                new Tuple<string, string>("Quick Compare", "i_balance"),
                new Tuple<string, string>("Saved Comparisons", "i_save"),
                new Tuple<string, string>("Icon Creator", "i_create")
            };

            SecondaryMenuList = new MvxObservableCollection<Tuple<string, string>>()
            {
                new Tuple<string, string>("Settings", "i_gear"),
                new Tuple<string, string>("About", "i_question")
            };
        }

        #endregion


        #region private methods

        private async Task ShowDetailPageAsync(string param)
        {
            switch (param)
            {
                case "Quick Compare":
                    await _navigationService.Navigate<PizzaComparisonsViewModel>();
                    break;
                case "Saved Comparisons":
                    await _navigationService.Navigate<PizzaComparisonsViewModel>();
                    break;
                case "Icon Creator":
                    await _navigationService.Navigate<IconCreatorViewModel>();
                    break;
                case "Settings":
                    await _navigationService.Navigate<SettingsViewModel>();
                    break;
                case "About":
                    await _navigationService.Navigate<AboutViewModel>();
                    break;
                default:
                    break;
            }

            if (Application.Current.MainPage is MasterDetailPage masterDetailPage)
            {
                masterDetailPage.IsPresented = false;
            }
            else if (Application.Current.MainPage is NavigationPage navigationPage
                     && navigationPage.CurrentPage is MasterDetailPage nestedMasterDetail)
            {
                nestedMasterDetail.IsPresented = false;
            }
        }

        #endregion
    }
}