using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        string play_again = "yes";
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,100);
        int guess;
        int attemps = 0;

        while (play_again != "no")
        {

            Console.WriteLine();
            Console.WriteLine("Attemps: " + attemps);
            Console.WriteLine();
            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            guess = int.Parse(userGuess);

            if (guess > number)
            {
                Console.WriteLine("Lower");
                attemps++;
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
                attemps++;
            }
            else if (guess == number)
            {
                Console.WriteLine("That is the number!!");
                attemps = 0;
                Console.Write("Do you wanna play again? (yes/no)  ");
                play_again = Console.ReadLine();
                number = randomGenerator.Next(1,100);
            }
        }


    }
}