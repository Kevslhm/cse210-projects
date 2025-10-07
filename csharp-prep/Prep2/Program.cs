using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userPercentage = Console.ReadLine();
        int numPercentage = int.Parse(userPercentage);

        if (numPercentage >= 90)
        {
            Console.WriteLine($"you've got an A with grade of {numPercentage}");
        }
        else if (numPercentage >= 80 && numPercentage < 90)
        {
            Console.WriteLine($"you've got a b with a grade of {numPercentage}");
        }
        else if (numPercentage >= 70 && numPercentage < 80)
        {
            Console.WriteLine($"you've got a c with a grade of {numPercentage}");
        }
        else if (numPercentage >= 60 && numPercentage < 70)
        {
            Console.WriteLine($"you've got a d with a grade of {numPercentage}");
        }
        else
        {
            Console.WriteLine($"you've got a f with a grade of {numPercentage}");
        }
    }
}