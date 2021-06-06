using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFShellDemo.pages;

namespace XFShellDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShellPage();
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
