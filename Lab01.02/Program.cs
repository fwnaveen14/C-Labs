using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius:");
            double radius = double.Parse(Console.ReadLine());
            double area = 3.14 * radius * radius;
            Console.WriteLine("Area of the circle: " + area);
            Console.ReadLine();
        }
    }
}
