using Net.Maui.Maths.Game.Models;
using SQLite;

namespace Net.Maui.Maths.Game.Data
{
    public class GameRepository 
    {
        string _dbPath;
        private SQLiteConnection conn;

        public GameRepository(string dbPath)
        {
            _dbPath = dbPath;
        }
        public void Init()
        {
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<Games>();
        }

        public List<Games> GetAllGames()
        {
            Init();
            return conn.Table<Games>().ToList();
        }

        public void Add(Games game)
        {
            conn = new SQLiteConnection(_dbPath);
            conn.Insert(game);
        }

        public void Delete(int id)
        {
            conn = new SQLiteConnection(_dbPath);
            conn.Delete(new Games {Id = id });
        }
    }
}
