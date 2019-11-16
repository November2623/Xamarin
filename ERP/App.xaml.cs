using System;
using ERP.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ERP
{
    public partial class App : Application
    {
        static UserDatabaseController database;
        public static UserDatabaseController Database
        {
            get
            {
                if(database == null)
                {
                    database = new UserDatabaseController();
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new Login();
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
