using SQLite;

namespace MonCodeMoto.Helpers
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();

    }
}
