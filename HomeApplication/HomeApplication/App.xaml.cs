using HomeApplication.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HomeApplication
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());//new BindingPage();  new BindingModePage() new DeviceListPage() new LoginPage() new NavigationPage(new LoginPage()); new NewDevicePage();
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
