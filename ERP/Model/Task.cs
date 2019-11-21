using System;
using SQLite;

namespace ERP.Model
{
    public class Task
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        [MaxLength(20)]
        public String title { get; set; }
      
        public String description { get; set; }
    }
}
