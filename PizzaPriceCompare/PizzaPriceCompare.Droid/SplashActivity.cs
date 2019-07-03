using Android.App;
using Android.Content.PM;
using Android.OS;
using PizzaPriceCompare.Droid;

namespace XF_SplashScreen.Droid
{
    [Activity(Label = "PizzaPriceCompare", Icon = "@mipmap/icon", Theme = "@style/Theme.Splash", MainLauncher = true, NoHistory = true,
    ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            System.Threading.Thread.Sleep(1500);
            StartActivity(typeof(RootActivity));
        }
    }
}