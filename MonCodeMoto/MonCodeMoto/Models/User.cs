using SQLite;
using System;

namespace MonCodeMoto.Models
{
    [Table("User")]
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }
        public bool isAdmin { get; set; }
    }
}
