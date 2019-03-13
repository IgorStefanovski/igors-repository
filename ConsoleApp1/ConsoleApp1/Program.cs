using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string user = "y";
            do
            {


                Console.WriteLine("Enter a number");
                string sometstring = (Console.ReadLine());
                int number;

                if(int.TryParse(sometstring, out number))
                {
                    Console.WriteLine(NumberOrNot(number));
                    Console.WriteLine($"Stats for number {number}");
                    Console.WriteLine(PostiveOrNegative(number));
                    Console.WriteLine(OddOrEven(number));
                }
                else
                {
                    Console.WriteLine("This is not a number");
                }


                Console.WriteLine("Do you want to input another number");
                user =Console.ReadLine();
          
            
            } while (user =="y");
            Console.ReadLine();

        }

        public static string NumberOrNot(int number)
        {
            if (number.GetType() != typeof(int))
            {
                return "This is not a number";


            }
          

                return "This is a number";



        }

        public static string PostiveOrNegative(int number)
        {
            if (number < 0)
            {
                return $"Negative";

            }
            if (number > 0)
            {
                return $"Positive";

            }

            return "The number is zero";
        }

        public static string OddOrEven(int number)
        {

            if (number % 2 == 0)
            {
                return $"Even";

            }

            return $"Odd";

        }


        

 }
    }

