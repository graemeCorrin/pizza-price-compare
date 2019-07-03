using Acr.UserDialogs;
using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Forms.Platforms.Android.Core;
using MvvmCross.Forms.Platforms.Android.Views;

namespace PizzaPriceCompare.Droid
{
    [Activity(Label = "PizzaPriceCompare", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = false,
     ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.Portrait)]
    public class RootActivity : MvxFormsAppCompatActivity<MvxFormsAndroidSetup<PizzaPriceCompare.Core.App, App>, PizzaPriceCompare.Core.App, App>
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            Window.SetStatusBarColor(Android.Graphics.Color.Argb(255, 205, 69, 69));

            UserDialogs.Init(this);
        }

    }
}