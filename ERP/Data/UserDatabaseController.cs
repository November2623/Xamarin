using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ERP.Model;
using SQLite;
using Xamarin.Forms;

namespace ERP.Data
{
    public class UserDatabaseController
    {
        protected static object locker = new object();

        SQLiteConnection database;

        public UserDatabaseController()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<Account>();
        }

        public Boolean Login(String username, String password)
        {
            lock(locker)
            {
               var user = database.Table<Account>().FirstOrDefault(x => x.username == username && x.password == password);
               return (user == null) ? false : true;
            }
            
        }

        public void InsertAccount(String username, String password)
        {
            lock (locker)
            {
               var item = new Account { id = 0, username = username, password = password };
               database.Insert(item);
            }
        }

        public IEnumerable<Account> GetItems()
        {
            lock (locker)
            {
                return (from i in database.Table<Account>() select i).ToList();
            }
        }
    }
}
