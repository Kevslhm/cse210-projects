using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is the magic number? ");
        string magicNum = Console.ReadLine();
        int number = int.Parse(magicNum);
        int guess = 0;

        while (number != guess)
        {

            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            guess = int.Parse(userGuess);

            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess == number)
            {
                Console.WriteLine("That is the number!!");
            }
        }


    }
}