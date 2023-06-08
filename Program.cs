using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 100);
        int remainingTries = 6;

        Console.WriteLine("Guess the number between 1 and 99.");

        while (remainingTries > 0)
        {
            Console.Write("Enter your guess: ");
            int guess = Convert.ToInt32(Console.ReadLine());

            if (guess == randomNumber)
            {
                Console.WriteLine("guess is correct.");
                return;
            }
            else if (guess < randomNumber)
            {
                Console.WriteLine("The number is higher than your guess.");
            }
            else
            {
                Console.WriteLine("The number is lower than your guess.");
            }

            remainingTries--;
        }

        Console.WriteLine("ran out of tries. The correct number was: " + randomNumber);
    }
}
