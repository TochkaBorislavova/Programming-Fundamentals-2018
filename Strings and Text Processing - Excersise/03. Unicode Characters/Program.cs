﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var toCharArr = input.ToCharArray();

            StringBuilder sb = new StringBuilder();

            foreach (char c in toCharArr)
            {
                sb.Append("\\u");
                sb.Append(String.Format("{0:x4}", (int)c));
            }

            Console.WriteLine(sb);
        }


    }
}
