using OrderFoodAppUI.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OrderFoodAppUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            NavigationPage navigation = new NavigationPage(new MainView());
            MainPage = navigation;
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
