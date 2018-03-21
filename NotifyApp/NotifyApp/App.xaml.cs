using System;
using Microsoft.WindowsAzure.MobileServices;
using NotifyApp.Views;
using Xamarin.Forms;

namespace NotifyApp
{
    public partial class App : Application
    {
        public static MobileServiceClient MobileService = new MobileServiceClient("https://notifyappservice.azurewebsites.net");

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
