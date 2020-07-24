    using SQLite;
using SQLiteNetExtensions.Attributes;

namespace MonCodeMoto.Models
{
    [Table("Questions")]

    public class Question
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Question1 { get; set; }
        public string Question2 { get; set; }
        public string Question3 { get; set; }
        public string Question4 { get; set; }

        [ForeignKey(typeof(Video))]
        public int VideoId { get; set; }



    }
}
