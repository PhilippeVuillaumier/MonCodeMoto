using SQLite;
using SQLiteNetExtensions.Attributes;

namespace MonCodeMoto.Models
{
    [Table("Videos")]
    public class Video
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }

        [ForeignKey(typeof(Lesson))]
        public int LessonId { get; set; }

    }
}
