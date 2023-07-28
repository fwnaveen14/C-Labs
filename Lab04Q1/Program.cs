using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value(km): ");
            double x = double.Parse(Console.ReadLine());

            ConvertValues objkilo = new ConvertValues();

            double z = objkilo.KilometerTOmeter(x);

            Console.WriteLine("Answer: " + z);
        }
    }
}
