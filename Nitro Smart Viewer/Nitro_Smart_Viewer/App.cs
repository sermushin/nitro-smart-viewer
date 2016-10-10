using Xamarin.Forms;

namespace Nitro_Smart_Viewer
{
    public class App : Application
    {
        public App(ITextFileReader textFileReader)
        {
            // The root page of your application
            //var content = new ContentPage
            //{
            //    Title = "Nitro_Smart_Viewer",
            //    Content = new StackLayout
            //    {
            //        VerticalOptions = LayoutOptions.Center,
            //        Children = {
            //            new Label {
            //                HorizontalTextAlignment = TextAlignment.Center,
            //                Text = "Welcome to Xamarin Forms!"
            //            }
            //        }
            //    }
            //};

            //MainPage = new NavigationPage(content);
            MainPage = new MainPage(textFileReader);
        }

        public static string Description { get; set; }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}