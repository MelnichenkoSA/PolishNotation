﻿using System;

namespace PolishNotation
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите выражение: ");
                Console.WriteLine(RPN.Calculate(Console.ReadLine()));
            }
        }
    }
}
