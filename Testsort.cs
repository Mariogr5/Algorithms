using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmsProject1.Algorithms
{
    public static class Testsort
    {
        public static void IfIsGoodSorted(List<Movie> mylist)
        {
            double inter = 0;
            foreach (var movie in mylist)
            {
                if (inter > movie.Rating)
                {
                    Console.WriteLine("Lista nie jest dobrze posortowana!!!");
                    return;
                }
                inter = movie.Rating;
            }
            Console.WriteLine("Jest dobrze posortowana!!!");
        }
    }
}
