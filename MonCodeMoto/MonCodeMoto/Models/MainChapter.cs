using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

namespace MonCodeMoto.Models
{
    [Table("MainChapters")]
    class MainChapter
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Title { get; set; }

        [OneToMany]
        public List<Chapter> Chapters { get; set; }

    }
}

