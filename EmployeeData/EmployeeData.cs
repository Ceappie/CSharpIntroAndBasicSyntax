﻿using System;


namespace EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int id = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Employee ID: {id:d8}");
            Console.WriteLine($"Salary: {salary:f2}");
        }
    }
}
