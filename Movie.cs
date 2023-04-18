using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmsProject1.Algorithms
{
    public class Movie
    {
        public Movie(int iD, string title, double rating)
        {
            this.ID = iD;
            this.Title = title;
            this.Rating = rating;
        }
        public int ID { get; set; }
        public string Title { get; set; }
        public double Rating { get; set; }
    }
}
