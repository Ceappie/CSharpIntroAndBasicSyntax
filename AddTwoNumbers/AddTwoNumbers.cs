using System;

namespace AddTwoNumbers
{
    class AddTwoNumbers
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            int result = firstNum + secondNum;

            Console.WriteLine($"{firstNum} + {secondNum} = {result}");
        }
    }
}
