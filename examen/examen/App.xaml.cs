using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using examen.Views.Forms;

namespace examen
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SimpleLoginPage();
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
