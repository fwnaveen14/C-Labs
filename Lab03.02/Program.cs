﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();
            int vowelCount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];

                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
                {
                    vowelCount++;
                }
            }
            Console.WriteLine("The number of vowels in this string is {0}.", vowelCount);
            Console.ReadLine();
        }
    }
}
