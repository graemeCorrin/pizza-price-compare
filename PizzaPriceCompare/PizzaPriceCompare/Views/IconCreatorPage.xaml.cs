using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using PizzaPriceCompare.Core.ViewModels;
using Xamarin.Forms.Xaml;

namespace PizzaPriceCompare.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxMasterDetailPagePresentation(Position = MasterDetailPosition.Detail, NoHistory = true, Title = "Icon Creator")]
    public partial class IconCreatorPage : MvxContentPage<IconCreatorViewModel>
    {
        public IconCreatorPage()
        {
            InitializeComponent();
        }
    }
}