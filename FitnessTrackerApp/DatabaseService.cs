using SQLite;
using FitnessTrackerApp.Models;

namespace FitnessTrackerApp.Services
{
    public class DatabaseService
    {
        private SQLiteConnection _database;

        public DatabaseService(string dbPath)
        {
            _database = new SQLiteConnection(dbPath);
            _database.CreateTable<Workout>();
        }

    }
}
