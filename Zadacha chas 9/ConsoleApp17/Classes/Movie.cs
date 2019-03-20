using ConsoleApp17.Ennums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17.Classes
{
    public class Movie
    {

        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Rating { get; set; }
        public int TicketPrice { get; set; }


        public Movie(string title, Genre genre , int rating)
        {


            Title = title;
            Genre = genre;
            Rating = rating;
            try
            {
                if (rating < 0 && rating > 5)
                {
                    throw new Exception("Rating must be between 1 and 5");

                }


            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            TicketPrice = rating * 5 ;
            




        }




    }
}

  

