using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using PizzaPriceCompare.Core.Models;
using PizzaPriceCompare.Core.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PizzaPriceCompare.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxMasterDetailPagePresentation(Position = MasterDetailPosition.Detail, NoHistory = true, Title = "Saved Comparisons")]
    public partial class PizzaComparisonsPage : MvxContentPage<PizzaComparisonsViewModel>
    {
        public PizzaComparisonsPage()
        {
            InitializeComponent();
        }

        public async void NewPizzaComparisonAsync(object sender, EventArgs e)
        {
            await ViewModel.NewPizzaComparisonAsync();
        }

        public async void ViewPizzaComparisonAsync(object sender, SelectedItemChangedEventArgs e)
        {
            await ViewModel.ViewPizzaComparisonAsync(e.SelectedItem as PizzaComparison);
        }
    }
}