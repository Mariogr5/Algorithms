using AlgorytmsProject1;


//int[] mytab = new int[11];
//for(int i = 0; i < 11; i++)
//{
//    mytab[i] = 11 - i;
//}
//for (int i = 0; i < 11; i++)
//{
//    Console.WriteLine(mytab[i]);
//}
//Sort.Defilementsort(mytab, 0, 10);
//Console.WriteLine("Po przesortowaniu: ");
//for (int i = 0; i < 11; i++)
//{
//    Console.WriteLine(mytab[i]);
//}
//var MylistofMovies =  new Filtrate.filtr("C:\\Users\\mario\\Desktop\\Strukturydanych\\AlgorytmsProject1\\Algorithms\\Datas\\Porjektdane.txt");
var MylistofMovies2 = Filtrate.filtr("C:\\Users\\mario\\Desktop\\Strukturydanych\\AlgorytmsProject1\\Algorithms\\Datas\\Porjektdane.txt");
Console.WriteLine("Numbers: {0}", MylistofMovies2.Count);