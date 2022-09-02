using AutoMapper;
using GamesService.DTOs;
using GamesService.Models;

namespace GamesService.Profiles
{
    public class GameProfile: Profile
    {
        public GameProfile()
        {
            // source --> Target
            CreateMap<Game, GameReadDto>();
            CreateMap<GameCreateDto, Game>();
        }
    }
}