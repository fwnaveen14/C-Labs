using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number 01:");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter number 02:");
            double num2 = double.Parse(Console.ReadLine());

            double sum = num1 + num2;
            Console.WriteLine("Summation  = " + sum);
            Console.ReadLine();
        }
    }
}
