using System.ComponentModel.DataAnnotations;

namespace GamesService.Models
{
    public class Game
    {
        [Key]
        [Required]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        public string Type { get; set; }
    }
}