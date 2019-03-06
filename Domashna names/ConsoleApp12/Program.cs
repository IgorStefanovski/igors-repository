using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Bob", "Jill", "Greg" };

            for (int y = 0; y < 5; y++)
            {
                Console.WriteLine("Input Name");
                Console.ReadLine();

            }
            foreach (string name in names)
            {

                Console.WriteLine(name);

                Console.WriteLine("Do you want to continue? Input Y/N");
                char temp = char.Parse(Console.ReadLine());




                if (temp.Equals('y'))
                    continue;
                else if (temp.Equals('n'))
                    break;

            }

        }


    }
}
    