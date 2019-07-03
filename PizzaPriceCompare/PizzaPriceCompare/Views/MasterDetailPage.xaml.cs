using MvvmCross.Forms.Presenters.Attributes;

namespace PizzaPriceCompare.Views
{
    [MvxMasterDetailPagePresentation(Position = MasterDetailPosition.Root, WrapInNavigationPage = false, Title = "MasterDetail Page")]
    public partial class MasterDetailPage
    {
        public MasterDetailPage()
        {
            InitializeComponent();
        }
    }
}
