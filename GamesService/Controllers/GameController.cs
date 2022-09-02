using AutoMapper;
using GamesService.Data;
using GamesService.DTOs;
using GamesService.Models;
using Microsoft.AspNetCore.Mvc;

namespace GamesService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController: ControllerBase
    {
        private readonly IGameRepo _repository;
        private readonly IMapper _mapper;

        public GameController(IGameRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Game>> GetAllGames()
        {
            var games = _repository.GetAllGames();

            return Ok(_mapper.Map<IEnumerable<GameReadDto>>(games));
        }

        [HttpGet("{id}")]
        public ActionResult<Game> GetGameById(int id)
        {
            var game = _repository.GetGameById(id);

            return Ok(_mapper.Map<GameReadDto>(game));
        }

        [HttpPost]
        public ActionResult<Game> CreateGame(GameCreateDto gameCreateDto)
        {
            var game = _mapper.Map<Game>(gameCreateDto);
            _repository.CreateGame(game);
            _repository.SaveChanges();

            return Ok(_mapper.Map<GameReadDto>(game));
        }
    }
}