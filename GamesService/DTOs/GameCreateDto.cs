using System.ComponentModel.DataAnnotations;

namespace GamesService.DTOs
{
    public class GameCreateDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Type { get; set; }
    }
}