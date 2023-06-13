using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_movies.Models
{

    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public int GenreId { get; set; }

        public Genre? Genre { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        public string? Rating { get; set; }

        [Display(Name = "Image URL")]
        public string? imageURL { get; set; }
    }

    public class MovieGenreViewModel
    {
        public List<Movie>? Movies { get; set; }
        public SelectList? Genres { get; set; }
        public int? SortBy { get; set; }
        public string? MovieGenre { get; set; }
        public string? SearchString { get; set; }
    }


    public class Genre
    {
        public int Id { get; set; }

        [Display(Name = "Genre")]
        public string Name { get; set; }
    }


}
