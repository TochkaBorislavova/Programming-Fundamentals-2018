﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if(type == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine($"{GetMax(a, b)}");
            }

            if(type == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());

                Console.WriteLine($"{GetMax(a, b)}");
            }

            if(type == "string")
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();

                Console.WriteLine($"{GetMax(a, b)}");
            }
        }

        static int GetMax(int a, int b)
        {
            if(a >= b)
            {
                return a;
            }

            return b;
        }

        static char GetMax(char a, char b)
        {
            if(a > b)
            {
                return a;
            }

            return b;
        }

        static string GetMax(string a, string b)
        {
            if(a.CompareTo(b) >= 0)
            {
                return a;
            }

            return b;
        }
    }
}
