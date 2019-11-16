using System;
using System.IO;
using ERP.Data;
using ERP.iOS.Data;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_IOS))]
namespace ERP.iOS.Data
{
    public class SQLite_IOS : ISQLite
    {
        public SQLite_IOS()
        {
        }
        public SQLite.SQLiteConnection GetConnection()
        {
            var sqliteFileName = "ERP.db3";
            string documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine(documentPath, "..", "Library");
            var path = Path.Combine(libraryPath, sqliteFileName);
            var conn = new SQLite.SQLiteConnection(path);

            return conn;
        }
    }
}
