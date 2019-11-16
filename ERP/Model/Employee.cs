using System;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace ERP.Model
{
    public class Employee
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(30)]
        public String firstName { get; set; }
        [MaxLength(30)]

        public String lastName { get; set; }

        [MaxLength(40)]
        public DateTime dateOfBirth { get; set;}

        [MaxLength(30)]
        public String position { get; set; }

        [ForeignKey(typeof(Account))]
        public int accountId { get; set; }
    }

}

