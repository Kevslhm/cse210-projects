using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome ()
        {
            Console.WriteLine("Welcome to the program!");
        } 

        static  string PromptUserName ()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber ()
        {
            Console.Write("Please enter your favorite number: ");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }

        static int SquareNumber ( int number)
        {
            int squareNumber = number * number;
            return squareNumber;
        }

        static void DisplayResult (string userName, int squareNumber)
        {
            Console.WriteLine($"{userName}, the square of your number is: {squareNumber}");
        }

        DisplayWelcome();
        DisplayResult(PromptUserName(), SquareNumber(PromptUserNumber()));

    }
}