using System.ComponentModel.DataAnnotations;

namespace CodeLabNET6.Models
{
    public class Movie
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "The title is required")]
        [MaxLength(50, ErrorMessage = "Title has a maximum of 50 characteres")]
        public string Title { get; set; }
        [Required(ErrorMessage = "The genre is required")]
        [MaxLength(50, ErrorMessage = "Genre has a maximum of 50 characteres")]
        public string Genre  { get; set; }
        [Required(ErrorMessage = "The duration is required")]
        [Range(30,600,ErrorMessage ="Duration must be between 30 minutes and 600 minutes")]
        public int Duration { get; set; }
    }
}
