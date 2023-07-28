using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int a = 1;

            for (int i = 0; i <= 9; i++)
            {
                Console.Write("Enter number " + a + " :");
                a++;
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] % 2 == 0)
                {
                    Console.WriteLine("It is an even number");
                }
                else
                {
                    Console.WriteLine("It a odd number");
                }

            }
            Console.ReadLine();
        }
    }
}
