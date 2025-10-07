using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userPercentage = Console.ReadLine();
        int numPercentage = int.Parse(userPercentage);

        string letter = "";

        if (numPercentage >= 90)
        {
            letter = "A";
        }
        else if (numPercentage >= 80)
        {
            letter = "B";
        }
        else if (numPercentage >= 70)
        {
            letter = "C";
        }
        else if (numPercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine(letter);
    }
}