using System.ComponentModel.DataAnnotations;

namespace LibApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required")]]
        [StringLength(100)]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime ReleaseDate { get; set; }
        [Range(1, 20, ErrorMessage = "Number in stock must be between 1 and 20")]
        public byte NumberInStock { get; set; }

    }
}
