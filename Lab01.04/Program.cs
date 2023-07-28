using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter salary:");
            double salary = double.Parse(Console.ReadLine());
            Console.Write("Enter tax rate:");
            double tax = double.Parse(Console.ReadLine());

            double final = salary - salary * tax / 100;

            Console.WriteLine("Salary after tax = " + final);
            Console.ReadLine();
        }
    }
}
