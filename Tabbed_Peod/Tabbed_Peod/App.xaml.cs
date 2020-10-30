using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Tabbed_Peod.Services;
using Tabbed_Peod.Views;

namespace Tabbed_Peod
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
