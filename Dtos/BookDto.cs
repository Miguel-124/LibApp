using LibApp.Models;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LibApp.Dtos
{
    public class BookDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Tittle { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public byte GenreId { get; set; }
        [Required]
        public DateTime? DateAdded { get; set; }
        [Required]
        public DateTime? ReleaseDate { get; set; }
        [Required]
        [Range(1, 20)]
        public byte NumberInStock { get; set; }
      

    }
}
