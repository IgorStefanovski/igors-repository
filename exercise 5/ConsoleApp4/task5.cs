using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[5];

            for (int y = 0; y < 5; y++)
            {
                Console.WriteLine("Input Number");
                nums[y] = int.Parse(Console.ReadLine());


            }
            Console.WriteLine("Sum of the array :");

            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            {

                Console.WriteLine(sum);

            }


            Console.ReadLine();


        }


    }
}

        
    

