using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmsProject1
{
    public static class Sort
    {
        public static void Quicksort(ref int[] tab, int left, int right)
        {
            //Przy pierwszym wywołaniu sortowania podajemy zerowy indeks i indeks maksymalny(rozmiar tablicy)
            int i = left;
            int j = right;
            int srodek = tab[(left + right) / 2];
            do
            {
                while (tab[i] < srodek)
                    i++;

                while (tab[j] > srodek)
                    j--;

                if (i <= j)
                {
                    Swapper.Swap(ref tab[i], ref tab[j]);
                    i++;
                    j--;
                }
            } while (i <= j);

            if (left < j) 
                Quicksort(ref tab, left, j);

            if (right > i) 
                Quicksort(ref tab, i, right);
        }
        //-----------------Defilementsort-------------
        public static void Defilementsort(int[] tab, int left, int right)
        {
            int[] temptab = new int[right + 1];
            DivideElements(temptab, tab, left, right);

        }
        private static void DivideElements(int[] temptab, int[] tab, int left, int right)
        {
            if (right <= left) return;
            int srodek = (right + left) / 2;
            DivideElements(temptab, tab, left, srodek);
            DivideElements(temptab, tab, srodek + 1, right);
            Together(temptab, tab, left, srodek, right);
        }
        private static void Together(int[] temptab, int[] tab, int left, int Middle, int right)
        {
            int i, j;
            for (i = Middle + 1; i > left; i--)
                temptab[i - 1] = tab[i - 1];
            for (j = Middle; j < right; j++)
                temptab[right + Middle - j] = tab[j + 1];
            for(int z = left; z <= right; z ++)
                if(temptab[j] < temptab[i])
                    tab[z] = temptab[j--];
                else
                    tab[z] = temptab[i++];
        }
        //-------------------Bagssort-----------------
        public static void Kubeleksort(int[] tab)
        {

        }
    }
}
