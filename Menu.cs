using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmsProject1.Algorithms
{
    public static class Menu
    {
        public static void Runmenu()
        {
            List<Movie> mylist = new List<Movie>();
            bool a = true;
            string path = "C:\\Users\\mario\\Desktop\\Strukturydanych\\AlgorytmsProject1\\Algorithms\\Datas\\Porjektdane.txt";
            Printoptions();
            while(a)
            {
                Console.WriteLine("Podaj akcję: ");
                var x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        mylist = Filtrate.filtr(path);
                        break;
                    case 2:
                        try
                        {
                            Sort.Quicksort(mylist, 0, mylist.Count - 1);
                        }
                        catch
                        {
                            Console.WriteLine("Najpierw należy przefiltrować listę");
                        }
                        break;
                    case 3:
                        try
                        {
                            Sort.Mergesort(mylist, 0, mylist.Count - 1);
                        }
                        catch
                        {
                            Console.WriteLine("Najpierw należy przefiltrować listę");
                        }
                        break;
                    case 4:
                        try
                        {
                            Sort.Bucketsort(mylist);
                        }
                        catch
                        {
                            Console.WriteLine("Najpierw należy przefiltrować listę");
                        }
                        break;
                    case 5:
                        try
                        {
                            Testalgorithms.TestQuicksort(path);
                        }
                        catch
                        {
                            Console.WriteLine("Najpierw należy przefiltrować listę");
                        }
                        break;
                    case 6:
                        try
                        {
                            Testalgorithms.TestMergesort(path);
                        }
                        catch
                        {
                            Console.WriteLine("Najpierw należy przefiltrować listę");
                        }
                        break;
                    case 7:
                        try
                        {
                            Testalgorithms.TestBucketsort(path);
                        }
                        catch
                        {
                            Console.WriteLine("Najpierw należy przefiltrować listę");
                        }
                        break;
                    case 8:
                        if (mylist.Count == 0)
                            Console.WriteLine("Najpierw należy przefiltrować listę");
                        else
                            Printlist(mylist);
                        break;
                    case 9:
                        ClearConsole();
                        break;
                    case 10:
                        a = false;
                        break;

                }
            }
        }

        public static void Printlist(List<Movie> list)
        {
            foreach(var movie in list)
            {
                Console.WriteLine("{0}  {1}   {2}.0", movie.ID, movie.Title, movie.Rating);
            }
        }
        public static void Printoptions()
        {
            Console.WriteLine("Witaj w programie testującym algorytmy sortowania!!");
            Console.WriteLine("Wybierz akcję: ");
            Console.WriteLine("1: Przefiltruj dane");
            Console.WriteLine("2: Sortowanie szybkie");
            Console.WriteLine("3: Sortowanie przez scalanie");
            Console.WriteLine("4: Sortowanie kubełkowe");
            Console.WriteLine("5: Zmierzenie sortowania szybkiego dla 5 struktur danych");
            Console.WriteLine("6: Zmierzenie sortowania przez scalanie dla 5 struktur danych");
            Console.WriteLine("7: Zmierzenie sortowania kubełkowego dla 5 struktur danych");
            Console.WriteLine("8: Wyświetl listę");
            Console.WriteLine("9: Wyczyść ekran");
            Console.WriteLine("10: Wyjście");
        }

        public static void ClearConsole()
        {
            Console.Clear();
            Printoptions();
        }
    }
}
