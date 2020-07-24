using MonCodeMoto.Helpers;
using MonCodeMoto.UWP.DataBase;
using SQLite;
using System.IO;
using Windows.Storage;

[assembly: Xamarin.Forms.Dependency(typeof(WindowsSQLite))]
namespace MonCodeMoto.UWP.DataBase
{
    class WindowsSQLite : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var windowsDbName = "WindowsLocalDb.db3";
            var path = Path.Combine(ApplicationData.Current.LocalFolder.Path, windowsDbName);

            return new SQLiteConnection(path);
        }
    }
}