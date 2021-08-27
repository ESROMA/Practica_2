using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica_2
{
    public partial class App : Application
    {
        internal static object current;
        
        public App()
        {
            InitializeComponent();

            MainPage = new tabbed();
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
