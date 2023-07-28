using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter radius:");
            double radius = double.Parse(Console.ReadLine());

            double area = 3.14 * radius * radius;
            double cir = 2 * 3.14 * radius;

            Console.WriteLine("Area of the circle: " + area);
            Console.WriteLine("Circumference of the circle: " + cir);
            Console.ReadLine();
        }
    }
}
