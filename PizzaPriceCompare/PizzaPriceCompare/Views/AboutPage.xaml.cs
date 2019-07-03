using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using PizzaPriceCompare.Core.ViewModels;
using Xamarin.Forms.Xaml;

namespace PizzaPriceCompare.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxMasterDetailPagePresentation(Position = MasterDetailPosition.Detail, NoHistory = true, Title = "About")]
    public partial class AboutPage : MvxContentPage<AboutViewModel>
    {
        public AboutPage()
        {
            InitializeComponent();
        }
    }
}