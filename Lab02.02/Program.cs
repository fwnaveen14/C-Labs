using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number 1:");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter number 2:");
            double num2 = double.Parse(Console.ReadLine());
            double sum = num1 + num2;
            double sub = num1 - num2;
            double dev = num1 / num2;
            double mul = num1 * num2;
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Subtraction = " + sub);
            Console.WriteLine("Divition = " + dev);
            Console.WriteLine("Mulitiplication = " + mul);
            Console.ReadLine();
        }
    }
}
