using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16.Class_Folder
{
    public class Person
    {

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre FavouriteMusicType { get; set; }
        public List<Song> FavouriteSongs { get; set; }


        public Person (string firstname, string lastname, int age, Genre fav)
        {

            FirstName = firstname;
            LastName = lastname;
            Age = age;
            FavouriteMusicType = fav;


        }



            
    public void GetFavSong()
        {

            if(FavouriteSongs.Count == 0)
            {
                Console.WriteLine("This person hates music");


            }

                foreach(Song song in FavouriteSongs)
            {
                Console.WriteLine(Song.Title);


            }

        }



    }

}



