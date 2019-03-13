using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.Entities;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            User[] userArray = new User[5];

            userArray[0] = new User(17, "jimm", "333");
            userArray[1] = new User(18, "limeni", "444");
            userArray[2] = new User(20, "john", "123");
            userArray[3] = new User(21, "jimmy", "255");
            userArray[4] = new User(22, "luke", "723");

            Console.WriteLine("Enter user name");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();

           for( int i = 0; i < userArray.Length; i++)
            {
                if(userName == userArray[i].Username)
                {
                    if(password == userArray[i].Password)
                    {
                        Console.WriteLine("You are logged in!");
                        Console.ReadLine();
                    }
                }
                

            }
                

              

        
        }
    }
}
