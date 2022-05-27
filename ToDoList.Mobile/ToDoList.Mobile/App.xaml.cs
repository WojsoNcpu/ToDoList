using System;
using ToDoList.Core;
using ToDoList.Database;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToDoList.Mobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var database = new ToDoListDbContext();

            database.Database.EnsureCreated();

            DatabaseLocator.Database = database;

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
