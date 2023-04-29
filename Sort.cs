using AlgorytmsProject1.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmsProject1
{
    public static class Sort
    {
        public static void Quicksort(List<Movie> tab, int left, int right)
        {
            //Przy pierwszym wywołaniu sortowania podajemy zerowy indeks i indeks maksymalny(rozmiar tablicy - 1)
            int i = left;
            int j = right;
            double srodek = tab[right].Rating;
            do
            {
                while (tab[i].Rating < srodek)
                    i++;

                while (tab[j].Rating > srodek)
                    j--;

                if (i <= j)
                {
                    Swapper.Swap(tab[i], tab[j]);
                    i++;
                    j--;
                }
            } while (i <= j);

            if (right > i)
                Quicksort(tab, i, right);
            if (left < j) 
                Quicksort(tab, left, j);

        }
        //-----------------Mergesort-------------

        public static void Mergesort(List<Movie> mylist, int  l, int  r)
        {
            if (l < r && (r - l) >= 1)
            {
                int mid = (r + l) / 2;
                Mergesort(mylist, l, mid);
                Mergesort(mylist, mid + 1, r);
                Merge(mylist, l, mid, r);
            }
        }
        public static void Merge(List<Movie> mylist, int l, int  mid, int  r)
        {
            List<Movie> tempArray = new List<Movie>();
            int getLeftIndex = l;
            int getRightIndex = mid + 1;
            while(getLeftIndex <= mid && getRightIndex <= r)
            {
                if(mylist[getLeftIndex].Rating <= mylist[getRightIndex].Rating)
                {
                    tempArray.Add(mylist[getLeftIndex]);
                    getLeftIndex++;
                }
                else
                {
                    tempArray.Add(mylist[getRightIndex]);
                    getRightIndex++;
                }
            }

            while(getLeftIndex <= mid)
            {
                tempArray.Add(mylist[getLeftIndex]);
                getLeftIndex++;
            }

            while(getRightIndex <= r)
            {
                tempArray.Add(mylist[getRightIndex]);
                getRightIndex++;
            }

            for (int i = 0; i < tempArray.Count(); l++)
            {
                mylist[l] = tempArray[i++];
            }
        }
        //-------------------Bucketsort-----------------
        public static void Bucketsort(List<Movie> mylist)
        {
            double numberofbuckets = 5;
            double p = 10.0 / numberofbuckets;
            List<List<Movie>> Buckets = new List<List<Movie>>();

            for(int i = 0; i < numberofbuckets; i++)
            {
                Buckets.Add(new List<Movie>());
            }
            foreach(var mymovie in mylist)
            {
                Buckets[(int)(mymovie.Rating / p)].Add(mymovie);
            }
            for (int i = 0; i < numberofbuckets; i++)
            {
                if (Buckets[i].Count > 1)
                {
                    Quicksort(Buckets[i], 0, Buckets[i].Count - 1);
                }
            }
            mylist.Clear();
            for (int j = 0; j < numberofbuckets; j++)
            {
                mylist.AddRange(Buckets[j]);
            }
        }
    }
}
