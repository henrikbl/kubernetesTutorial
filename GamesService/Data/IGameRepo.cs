using GamesService.Models;

namespace GamesService.Data
{
    public interface IGameRepo
    {
        void SaveChanges();

        IEnumerable<Game> GetAllGames();

        Game GetGameById(int id);

        void CreateGame(Game game);
    }
}