using System;
using ERP.Model;
using SQLite;
using Xamarin.Forms;

namespace ERP.Data
{
    public class EmployeeDatabaseController
    {
        protected static object locker = new object();

        SQLiteConnection database;

        public EmployeeDatabaseController()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<Employee>();
        }

        public void InsertEmployee(String firstName, String lastName,
                                   DateTime dateOfBird, String position,
                                   int accountId)
        {
            lock (locker)
            {
                var item = new Employee { Id = 0, firstName = firstName,
                                                  lastName = lastName,
                                                  dateOfBirth = dateOfBird,
                                                  position = position,
                                                  accountId = accountId };
                database.Insert(item);
            }
        }
    }
}

