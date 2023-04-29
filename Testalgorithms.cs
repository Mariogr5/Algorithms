using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AlgorytmsProject1.Algorithms
{
    public static class Testalgorithms
    {
        private static List<List<Movie>> MakeTestlists(string path)
        {
            List<List<Movie>> lists = new List<List<Movie>>();
            int n = File.ReadLines(path).Count();
            int[] elements = new int[5];
            elements[0] = 10000;
            elements[1] = 100000;
            elements[2] = 500000;
            elements[3] = 1000000;
            elements[4] = n;
            for (int i = 0; i < 5; i++)
            {
                lists.Add(Teststructure.Testlist(path, elements[i]));
            }
            return lists;
        }
        public static void Testfiltrate(string path)
        {
            List<Movie> taboftimes = new List<Movie>();
            Stopwatch stopper = new Stopwatch();
            int n = File.ReadLines(path).Count();
            int[] elements = new int[5];
            double[] times = new double[5];
            elements[0] = 10000;
            elements[1] = 100000;
            elements[2] = 500000;
            elements[3] = 1000000;
            elements[4] = n;
            for (int i = 0; i < 5; i++)
            {
                stopper.Start();
                taboftimes = Teststructure.Testlist(path, elements[i]);
                stopper.Stop();
                times[i] = stopper.Elapsed.TotalMilliseconds;
                stopper.Reset();
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Czas dla {0} elementow wynosi: {1} s", elements[i], times[i]);
            }
        }
        public static void TestQuicksort(string path)
        {
            var thislist = MakeTestlists(path);
            Stopwatch stopper = new Stopwatch();
            double[] times = new double[5];
            for (int i = 0; i < 5; i++)
            {
                stopper.Start();
                Sort.Quicksort(thislist[i], 0, thislist[i].Count - 1);
                stopper.Stop();
                times[i] = stopper.Elapsed.TotalMilliseconds;
                stopper.Reset();
                Console.WriteLine("Czas dla {0} elementow wynosi: {1} ms", thislist[i].Count ,times[i]);
            }
        }
        public static void TestMergesort(string path)
        {
            var thislist = MakeTestlists(path);
            Stopwatch stopper = new Stopwatch();
            double[] times = new double[5];
            for (int i = 0; i < 5; i++)
            {
                stopper.Start();
                Sort.Mergesort(thislist[i], 0, thislist[i].Count - 1);
                stopper.Stop();
                times[i] = stopper.Elapsed.TotalMilliseconds;
                stopper.Reset();
                Console.WriteLine("Czas dla {0} elementow wynosi: {1} ms", thislist[i].Count, times[i]);
            }
        }
        public static void TestBucketsort(string path)
        {
            var thislist = MakeTestlists(path);
            Stopwatch stopper = new Stopwatch();
            double[] times = new double[5];
            for (int i = 0; i < 5; i++)
            {
                stopper.Start();
                Sort.Bucketsort(thislist[i]);
                stopper.Stop();
                times[i] = stopper.Elapsed.TotalMilliseconds;
                stopper.Reset();
                Console.WriteLine("Czas dla {0} elementow wynosi: {1} ms", thislist[i].Count, times[i]);
            }
        }
        public static List<double> ArithmeticTestQuicksort(string path)
        {
            var thislist = MakeTestlists(path);
            List<double> aritmetictimes = new List<double>();
            Stopwatch stopper = new Stopwatch();
            double[] times = new double[5];
            for (int i = 0; i < 5; i++)
            {
                stopper.Start();
                Sort.Quicksort(thislist[i], 0, thislist[i].Count - 1);
                stopper.Stop();
                times[i] = stopper.Elapsed.TotalMilliseconds;
                stopper.Reset();
                aritmetictimes.Add(times[i]);
            }
            return aritmetictimes;
        }
        public static List<double> ArithmeticTestMergesort(string path)
        {
            var thislist = MakeTestlists(path);
            List<double> aritmetictimes = new List<double>();
            Stopwatch stopper = new Stopwatch();
            double[] times = new double[5];
            for (int i = 0; i < 5; i++)
            {
                stopper.Start();
                Sort.Mergesort(thislist[i], 0, thislist[i].Count - 1);
                stopper.Stop();
                times[i] = stopper.Elapsed.TotalMilliseconds;
                stopper.Reset();
                aritmetictimes.Add(times[i]);
            }
            return aritmetictimes;
        }
        public static List<double> ArithmeticTestBuckettsort(string path)
        {
            var thislist = MakeTestlists(path);
            List<double> aritmetictimes = new List<double>();
            Stopwatch stopper = new Stopwatch();
            double[] times = new double[5];
            for (int i = 0; i < 5; i++)
            {
                stopper.Start();
                Sort.Bucketsort(thislist[i]);
                stopper.Stop();
                times[i] = stopper.Elapsed.TotalMilliseconds;
                stopper.Reset();
                aritmetictimes.Add(times[i]);
            }
            return aritmetictimes;
        }
        public static void Aritmetictimesofalgorithms(string path)
        {
            List<List<double>> median = new List<List<double>>();
            int n = File.ReadLines(path).Count();
            int[] elements = new int[5];
            elements[0] = 10000;
            elements[1] = 100000;
            elements[2] = 500000;
            elements[3] = 1000000;
            elements[4] = n;
            List<List<double>> listoftimes = new List<List<double>>();
            double[] sum = new double[5];
            for(int i = 0; i < 5; i++)
            {
                sum[i] = 0;
            }

                for(int j = 0; j < 5; j++)
                {
                //listoftimes.Add(ArithmeticTestQuicksort(path));
                listoftimes.Add(ArithmeticTestBuckettsort(path));
                //listoftimes.Add(ArithmeticTestBuckettsort(path));
                }
            for (int i = 0; i < 5; i++)
           {
               for (int j = 0; j < 5; j++)
               {
                   sum[i] += listoftimes[j][i];
               }
           }
            for (int i = 0; i < 5; i++)
            {
                median.Add(new List<double>());
                for (int j = 0; j < 5; j++)
                {
                    median[i].Add(listoftimes[j][i]);
                    Console.WriteLine(listoftimes[j][i]);
                }
                median[i].Sort();
                Console.WriteLine("Srednie mediana dla {0} elementow: {1}", elements[i], median[i][4 / 2]);
            }
        }

    }
}
