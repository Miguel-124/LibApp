using System.ComponentModel.DataAnnotations;

namespace LibApp.Models
{
    public class Book
    {
        [Required(ErrorMessage = "Id is required")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required")]
        [StringLength(100)]
        public string Title { get; set; }
        [Required(ErrorMessage = "Author is required")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Genre is required")]
        public Genre Genre { get; set; }
        [Required(ErrorMessage = "GenreId is required")]
        public int GenreId { get; set; }
        [Required(ErrorMessage = "DateAdded is required")]
        public DateTime DateAdded { get; set; }
        [Required(ErrorMessage = "Release date is required")]
        public DateTime ReleaseDate { get; set; }
        [Required(ErrorMessage = "Number in stock is required")]
        [Range(1, 20, ErrorMessage = "Number in stock must be between 1 and 20")]
        public byte NumberInStock { get; set; }

    }
}
