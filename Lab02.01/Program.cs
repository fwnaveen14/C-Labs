using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02._01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1:");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2:");
            double num2 = double.Parse(Console.ReadLine());
            double sum = num1 + num2;
            Console.WriteLine("Sum = " + sum);
            Console.ReadLine();
        }
    }
}
