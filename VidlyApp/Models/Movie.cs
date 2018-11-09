using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidlyApp.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "Please enter movie`s title.")]
        public string Name { get; set; }
 
        public int? Price { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        [Required(ErrorMessage = "Please enter movie`s genre.")]
        public int GenreId { get; set; }

        [Required][Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        [Required][NumberInStockValidation]
        public byte NumberInStock { get; set; }
    }
    //movies/random
}