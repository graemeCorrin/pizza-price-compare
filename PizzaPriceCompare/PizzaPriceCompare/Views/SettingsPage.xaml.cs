using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using PizzaPriceCompare.Core.ViewModels;
using Xamarin.Forms.Xaml;

namespace PizzaPriceCompare.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxMasterDetailPagePresentation(Position = MasterDetailPosition.Detail, NoHistory = true, Title = "Settings")]
    public partial class SettingsPage : MvxContentPage<SettingsViewModel>
    {
        public SettingsPage()
        {
            InitializeComponent();
        }
    }
}