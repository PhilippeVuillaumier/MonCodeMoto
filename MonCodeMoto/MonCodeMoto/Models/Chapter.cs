using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

namespace MonCodeMoto.Models
{
    [Table("Chapters")]
    public class Chapter
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Title { get; set; }

        [ForeignKey(typeof(MainChapter))]
        public int MainChapterId { get; set; }

        [OneToMany]
        public List<Lesson> Lessons { get; set; }

    }
}
