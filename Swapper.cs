using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmsProject1
{
    public static class Swapper
    {
        public static void Swap(ref int lhs, ref int phs)
        {
            int temp = lhs; ;
            lhs = phs;
            phs = temp;
        }
    }
}
