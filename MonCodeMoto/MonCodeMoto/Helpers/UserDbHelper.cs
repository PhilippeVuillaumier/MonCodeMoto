using MonCodeMoto.Models;
using SQLite;
using Xamarin.Forms;

namespace MonCodeMoto.Helpers
{
    public class UserDbHelper
    {
        static SQLiteConnection sqliteconnection;
        public const string DbFileName = "Users.db3";

        public UserDbHelper()
        {
            sqliteconnection = DependencyService.Get<ISQLite>().GetConnection();
            sqliteconnection.CreateTable<User>();
        }

    }
}
