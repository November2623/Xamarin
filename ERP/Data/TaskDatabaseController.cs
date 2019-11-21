using System;
using System.Collections.Generic;
using System.Linq;
using ERP.Model;
using SQLite;
using Xamarin.Forms;

namespace ERP.Data
{
    public class TaskDatabaseController
    {
        protected static object locker = new object();

        SQLiteConnection databaseTask;

        public TaskDatabaseController()
        {
            databaseTask = DependencyService.Get<ISQLite>().GetConnection();
            databaseTask.CreateTable<Task>();
        }

        public void InsertTask(String title, String description)
        {
            lock (locker)
            {
                var task = new Task
                {
                    id = 0,
                    title = title,
                    description = description
                };
                databaseTask.Insert(task);
            }
        }

        public IEnumerable<Task> GetItems()
        {
            lock (locker)
            {
                return (from i in databaseTask.Table<Task>() select i).ToList();
            }
        }
    }
}
