using System;
using System.Globalization;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<float> numbers = new List<float>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int num = 1;
        while (num != 0)
        {
            Console.Write("Enter a number:");
            num = int.Parse(Console.ReadLine());
            if (num != 0)
            {
                numbers.Add(num);
            }
        }
        if (num == 0)
        {
            float sum = 0;
            int bigNum = 0;
            foreach (int number in numbers)
            {
                sum = sum + number;
                if (number > bigNum)
                {
                    bigNum = number;
                }
            }

            float average = sum/numbers.Count;
             
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The biggest number is: {bigNum}");
        }

    }
}