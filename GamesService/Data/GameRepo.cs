using GamesService.Models;

namespace GamesService.Data
{
    public class GameRepo : IGameRepo
    {
        private readonly AppDbContext _context;

        public GameRepo(AppDbContext context)
        {
            _context = context;
        }

        public void CreateGame(Game game)
        {
            _context.Games.Add(game);
        }

        public IEnumerable<Game> GetAllGames()
        {
            return _context.Games;
        }

        public Game GetGameById(int id)
        {
            return _context.Games.FirstOrDefault(g => g.Id == id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}