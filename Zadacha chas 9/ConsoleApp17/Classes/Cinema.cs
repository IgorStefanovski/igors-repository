using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17.Classes
{
    public class Cinema
    {

        string Name { get; set; }
        int Halls { get; set; }
        public List<Movie> ListOfMovies { get; set; }




        public Cinema(string name,int halls, List<Movie> listofmovies)
        {

            Name = name;
            Halls = halls;
            ListOfMovies = listofmovies;


        }

        public static void MoviePlaying (Movie name)
        {

            Console.WriteLine($"Watching {name.Title}");

        }









    }


}
