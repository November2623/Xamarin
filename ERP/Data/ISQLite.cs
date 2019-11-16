using System;
using SQLite;
namespace ERP.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
