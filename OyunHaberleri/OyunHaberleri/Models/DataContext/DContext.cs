using System.Data.SQLite;
namespace OyunHaberleri.Models.DataContext
{
    public static class DContext
    {
        private static SQLiteConnection sqlite = new SQLiteConnection(@"Data Source=C:\Users\celil31\source\repos\OyunHaberleri\OyunHaberleri\Models\dbsqlite\oyunhaberleri.db;Version=3;");
        public static SQLiteConnection sqliteconn{ get => sqlite; }
    }
}