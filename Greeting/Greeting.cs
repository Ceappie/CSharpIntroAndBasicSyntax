﻿using System;


namespace CSharpIntroAndBasicSyntax
{
    class Greeting
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}!");
        }
    }
}
