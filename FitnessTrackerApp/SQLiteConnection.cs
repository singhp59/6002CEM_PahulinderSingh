
namespace FitnessTrackerApp.Services
{
    internal class SQLiteConnection
    {
        public SQLiteConnection(string dbPath)
        {
            DbPath = dbPath;
        }

        public string DbPath { get; }

        internal void CreateTable<T>()
        {
            throw new NotImplementedException();
        }

        internal object Table<T>()
        {
            throw new NotImplementedException();
        }
    }
}