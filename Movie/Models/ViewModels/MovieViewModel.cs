using System;
using System.ComponentModel.DataAnnotations;

namespace Movie.Models.ViewModels
{
    public class MovieViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Genre is required")]
        [MaxLength(50)]
        public string Genre { get; set; }
    }
}
