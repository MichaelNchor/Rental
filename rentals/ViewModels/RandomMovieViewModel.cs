using System.Collections.Generic;
using rentals.Models;

namespace rentals.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customer { get; set; }
    }
}