﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03._01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number :");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("ODD Number");
            }
            Console.ReadLine();
        }
    }
}
