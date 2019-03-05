using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[20];

            for (int y = 0; y < 20; y++)
            {
                Console.WriteLine("Input Number");
                nums[y] = int.Parse(Console.ReadLine());


            }
            Console.WriteLine("The elements of the array :");


            foreach (int z in nums)
            {
                if (z == 0)
                {
                    Console.WriteLine("skipped");
                    continue;

                }
                if (z > 99)
                    break;
                Console.WriteLine(z);
            }

            Console.ReadLine();

        }
    }
}
