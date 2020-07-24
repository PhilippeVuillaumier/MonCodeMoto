using MonCodeMoto.Droid.DataBase;
using MonCodeMoto.Helpers;
using SQLite;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(AndroidSQLite))]
namespace MonCodeMoto.Droid.DataBase
{
    public class AndroidSQLite : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            string AndroidDbName = "AndroidLocalDb.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string path = Path.Combine(documentsPath, AndroidDbName);

            return new SQLiteConnection(path); ;
        }
    }
}