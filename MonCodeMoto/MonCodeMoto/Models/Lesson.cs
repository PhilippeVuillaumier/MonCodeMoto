using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

namespace MonCodeMoto.Models
{
    [Table("Lessons")]
    public class Lesson
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        [ForeignKey(typeof(Chapter))] 
        public int ChapterId { get; set; }

        [OneToMany]
        public List<Video> Videos { get; set; }

    }
}
