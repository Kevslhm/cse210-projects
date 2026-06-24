using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int user_numbs = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        while (user_numbs != 0)
        {
            Console.Write("Enter a number: ");
            user_numbs = int.Parse(Console.ReadLine());

            if (user_numbs != 0)
            {
                numbers.Add(user_numbs);
            }
            
        }

        int sum = 0;
        float average = 0;
        int largest_number = 0;

        foreach (int number in numbers)
        {
            sum += number;
           // Console.WriteLine(number);
           if (number > largest_number)
            {
                largest_number = number;
            }
        }
    
        average = ((float)sum) / numbers.Count;
        Console.WriteLine("-----------------------------");
        Console.WriteLine("total items " + numbers.Count);
        Console.WriteLine("Total sum: " + sum);
        Console.WriteLine("Total average: " + average);
        Console.WriteLine("The largest number is: " + largest_number);
    }
} 