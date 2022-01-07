using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieApp.Data
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public int Year { get; set; }
        public string Summary { get; set; }
        [MaxLength(3)]
        public List<Actors> Actors { get; set; }
    }

    public class Actors
    {
        public int Id { get; set; }
        public string FullName { get; set; }
    }
}