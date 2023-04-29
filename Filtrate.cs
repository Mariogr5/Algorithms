using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Data;
using System.Linq.Expressions;
using AlgorytmsProject1.Algorithms;
using System.Globalization;

namespace AlgorytmsProject1
{
    public static class Filtrate
    {
        public static List<Movie> filtr(string path)
        {
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";
            List<Movie> listofmovies = new List<Movie>();
            var ratingregex = new Regex(@"[0-9]\.0", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            var idregex = new Regex(@"[0-9]+", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            foreach (var line in File.ReadLines(path))
            {
                String[] lines = line.Split(",");
                if (lines.Length <= 2)
                    continue;
                Match rates = ratingregex.Match(lines[lines.Length - 1]);
                if (rates.Value == "")
                    continue;
                Match ID = idregex.Match(lines[0]);
                if (ID.Value == "")
                    continue;
                int id = int.Parse(ID.Value);
                double rate = Convert.ToDouble(rates.Value, provider);
                for (int i = 2; i < lines.Length-1; i++)
                {
                    lines[1] += ("," + lines[i]);
                }
                string Title = lines[1];
                Movie movie = new Movie(id, Title, rate);
                listofmovies.Add(movie);
            }
            Console.WriteLine("Filtracja przebiegła pomyślnie!");
            return listofmovies;
        }
        public static void Numberoflines(string path)
        {
            int o = 0;
            foreach(var line in File.ReadLines(path))
            {
                o++;
            }
            Console.WriteLine("Ilość lini: {0}", o);
        }
    }
}
