using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Rentlix.Models;

namespace Rentlix.ViewModels
{
    public class RandomMovieViewModel
    {
        public  Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }   
    }
}