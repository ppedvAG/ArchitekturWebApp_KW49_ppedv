using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPageMovieSample.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [MinLength(5)]
        public string Description { get; set; }

        //Geldbeträge in .NET werden mit decimal (double und float)
        [Required, Range(0, 25)]
        public decimal Price { get; set; }
    }
}
