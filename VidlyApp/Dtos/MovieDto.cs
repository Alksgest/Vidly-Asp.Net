using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidlyApp.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "Please enter movie`s title.")]
        public string Name { get; set; }

        public int? Price { get; set; }

        [Required(ErrorMessage = "Please enter movie`s genre.")]
        public int GenreId { get; set; }
        public GenreDto Genre { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public byte NumberInStock { get; set; }
    }
}