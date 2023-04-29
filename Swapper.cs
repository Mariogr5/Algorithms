using AlgorytmsProject1.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmsProject1
{
    public static class Swapper
    {
        public static void Swap(Movie lhs,Movie phs)
        {
            double temp = lhs.Rating;
            string temptitle = lhs.Title;
            int tempid = lhs.ID; ;
            lhs.Rating = phs.Rating;
            phs.Rating = temp;
            lhs.Title = phs.Title;
            phs.Title = temptitle;
            lhs.ID = phs.ID;
            phs.ID = tempid;
        }
        public static void Set(Movie lhs, Movie phs)
        {
            lhs.Title=phs.Title;
            lhs.Rating = phs.Rating;
            lhs.ID=phs.ID;
            //lhs = phs;
        }
    }
}
