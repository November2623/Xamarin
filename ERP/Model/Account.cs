using System;
using SQLite;

using Xamarin.Forms;

namespace ERP.Model
{
    public class Account
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        [MaxLength(20)]
        public String username { get; set; }
        [MaxLength(30)]
        public String password { get; set; }
    }
}

