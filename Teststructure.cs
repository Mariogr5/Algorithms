using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AlgorytmsProject1.Algorithms
{
    public static class Teststructure
    {
        public static List<Movie> Testlist(string path, int numberofelements)
        {
            int thiselement = 0;
            bool restart = true;
            int countofdates = File.ReadLines(path).Count();
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";
            List<Movie> listofmovies = new List<Movie>();
            var ratingregex = new Regex(@"[0-9]\.0", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            var idregex = new Regex(@"[0-9]+", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            do
            {
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
                    for (int i = 2; i < lines.Length - 1; i++)
                    {
                        lines[1] += ("," + lines[i]);
                    }
                    string Title = lines[1];
                    Movie movie = new Movie(id, Title, rate);
                    listofmovies.Add(movie);
                    thiselement++;
                    if (thiselement == numberofelements)
                    {
                        restart = false;
                        break;
                    }
                    if (thiselement > countofdates)
                    {
                        numberofelements -= thiselement;
                        thiselement = 0;
                    }
                }
            } while (restart);
            return listofmovies;
        }
    }
}
