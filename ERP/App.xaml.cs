using System;
using ERP.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ERP
{
    public partial class App : Application
    {
        static UserDatabaseController database;
        static TaskDatabaseController databasetask;
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
        public static TaskDatabaseController databaseTask
        {
            get
            {
                if (databasetask == null)
                {
                    databasetask = new TaskDatabaseController();
                }
                return databasetask;
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
