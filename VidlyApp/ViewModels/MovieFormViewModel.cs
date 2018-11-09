using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VidlyApp.Models;


namespace VidlyApp.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public int? Id { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "Please enter movie`s title.")]
        public string Name { get; set; }

        public int Price { get; set; }

        [Display(Name = "Genre")]
        [Required(ErrorMessage = "Please enter movie`s genre.")]
        public int? GenreId { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        [NumberInStockValidation]
        public byte? NumberInStock { get; set; }

        public MovieFormViewModel()
        {
            Id = 0;
        }
        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }

        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Movie" : "New Movie";
            }
        }
    }
}