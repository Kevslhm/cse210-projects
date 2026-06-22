using System;

class Program
{
    static void Main(string[] args)
    {
        string play_again = "yes";
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,100);
        int guess = 0;

        while (play_again != "no")
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
                Console.Write("Do you wanna play again? (yes/no)  ");
                play_again = Console.ReadLine();
                number = randomGenerator.Next(1,100);
            }
        }


    }
}