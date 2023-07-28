using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius:");
            double radius = double.Parse(Console.ReadLine());
            FindValue cal = new FindValue();          
            double x = cal.findArea(radius);
            Console.WriteLine("Area = "+ x);

            double y = cal.findCircumference(radius);
            Console.WriteLine("Circumference = "+  y);
            Console.ReadLine();
        }
    }
}
