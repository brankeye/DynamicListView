using Xamarin.Forms;

namespace Playground
{
    public class App : Application
    {
        public App()
        {
            MainPage = new Views.Pages.Main();
        }

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
