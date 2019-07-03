using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using PizzaPriceCompare.Core.ViewModels;
using Xamarin.Forms.Xaml;

namespace PizzaPriceCompare.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxMasterDetailPagePresentation(Position = MasterDetailPosition.Detail, NoHistory = true, Title = "Pizza Price Compare")]
    public partial class MainPage : MvxContentPage<MainViewModel>
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }
}