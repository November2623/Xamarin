
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ERP.Data;
using ERP.Droid.Data;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_Android))]
namespace ERP.Droid.Data
{
    [BroadcastReceiver]
    public class SQLite_Android : ISQLite
    {
        public SQLite_Android() { }
        public SQLite.SQLiteConnection GetConnection()
        {
            var sqliteFileName = "ERP.db3";
            string documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentPath, sqliteFileName);
            var conn = new SQLite.SQLiteConnection(path);

            return conn;
        }
    }
}
