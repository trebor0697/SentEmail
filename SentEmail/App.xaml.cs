using SentEmail.Services;
using SentEmail.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SentEmail
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new EmailPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
