using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileHelper
{

    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Menu();
            //break fucking app
            //MainPage = new NavigationPage(new Menu());
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
