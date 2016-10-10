using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Util;

namespace Nitro_Smart_Viewer.Droid
{
    //[Activity(Label = "NitroSmartViewer")]//, Icon = "@drawable/icon", Theme = "@style/MainTheme.Splash", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    [Activity(Label = "NitroSmartViewer", Theme = "@style/MyTheme.Splash", Icon = "@drawable/icon", MainLauncher = true)]
    public class SplashActivity : AppCompatActivity
    //public class SplashActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        //static readonly string TAG = "X:" + typeof (SplashActivity).Name;

        public override void OnCreate(Bundle savedInstanceState, PersistableBundle persistentState)
        {
            base.OnCreate(savedInstanceState, persistentState);
            //Log.Debug(TAG, "SplashActivity.OnCreate");
        }

        protected override void OnResume()
        {
            base.OnResume();

            Task startupWork = new Task(() =>
                                        {
                                            //Log.Debug(TAG, "Performing some startup work that takes a bit of time.");
                                            Task.Delay(5000); // Simulate a bit of startup work.
                                            //Log.Debug(TAG, "Working in the background - important stuff.");
                                        });

            startupWork.ContinueWith(t =>
                                     {
                                         //Log.Debug(TAG, "Work is finished - start Activity1.");
                                         StartActivity(new Intent(Application.Context, typeof (MainActivity)));
                                     }, TaskScheduler.FromCurrentSynchronizationContext());

            startupWork.Start();
        }
    }
}