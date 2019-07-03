using Xamarin.Forms.Xaml;
using MvvmCross.Forms.Views;
using MvvmCross.Forms.Presenters.Attributes;
using PizzaPriceCompare.Core.ViewModels;
using System;
using Xamarin.Forms;
using PizzaPriceCompare.Core.Models;

namespace PizzaPriceCompare.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PizzaComparisonDetailsPage : MvxContentPage<PizzaComparisonDetailsViewModel>
    {
        public PizzaComparisonDetailsPage()
        {
            InitializeComponent();
        }

        private async void NewPizzaPriceAsync(object sender, EventArgs args)
        {
            await ViewModel.NewPizzaPriceAsync();
        }

        private async void EditPizzaPriceAsync(object sender, SelectedItemChangedEventArgs args)
        {
            await ViewModel.EditPizzaPriceAsync(args.SelectedItem as PizzaPrice);
        }

        private async void DeletePizzaComparisonAsync(object sender, EventArgs args)
        {
            await ViewModel.DeletePizzaComparisonAsync();
        }
    }
}