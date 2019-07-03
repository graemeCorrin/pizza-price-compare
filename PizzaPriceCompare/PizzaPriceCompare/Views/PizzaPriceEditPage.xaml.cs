using MvvmCross.Forms.Views;
using PizzaPriceCompare.Core.ViewModels;
using System;
using Xamarin.Forms.Xaml;

namespace PizzaPriceCompare.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PizzaPriceEditPage : MvxContentPage<PizzaPriceEditViewModel>
    {
        public PizzaPriceEditPage()
        {
            InitializeComponent();
        }

        private async void DeleteAsync(object sender, EventArgs e)
        {
            await ViewModel.DeleteAsync();
        }

        private async void CancelAsync(object sender, EventArgs e)
        {
            await ViewModel.CancelAsync();
        }

        private async void SaveAsync(object sender, EventArgs e)
        {
            await ViewModel.SaveAsync();
        }
    }
}