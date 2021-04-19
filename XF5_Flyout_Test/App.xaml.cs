using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF5_Flyout_Test.Services;
using XF5_Flyout_Test.Views;

namespace XF5_Flyout_Test
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
