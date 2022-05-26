using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToDoList.Mobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new WorkTaskPage();
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
