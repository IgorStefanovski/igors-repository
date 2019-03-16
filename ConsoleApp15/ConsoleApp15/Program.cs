using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {


        static void Main(string[] args)
        {
            PhonePrint();
        }


        public static void PhonePrint()
        {
            Console.WriteLine("Enter a name");
            string name = Console.ReadLine();
            Dictionary<string, int> PhoneBook = new Dictionary<string, int>()


            {  { "John", 070434323 }, {"Jimm", 087323232}, {"Limeni", 070543543} };


            if (PhoneBook.ContainsKey(name) == true) 
            {

                Console.WriteLine(PhoneBook[name]);
                Console.ReadLine();
            }
            

            else 

            {
                Console.WriteLine("error");

            }

            Console.ReadLine();

        }



    }
}
  

    

        
    

    



