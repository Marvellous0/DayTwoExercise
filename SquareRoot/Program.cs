using System;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            long number = Convert.ToInt64(Console.ReadLine());

            // Display the square root
            Console.WriteLine("The approximated square root of " + number + " is: " + sqrt(number));
        }

        /** Method squrt approximates the square root of n */
        public static double sqrt(long num)
        {
            long lastGuess = 1;	// Initial guess to positive value
            long nextGuess = (lastGuess + num / lastGuess) / 2;

            // If the difference between nextGuess and lastGuess is less than 0.0001,
            // return nextGuess as the approximated square root of n.
            while (nextGuess - lastGuess > 0.0001)
            {
                lastGuess = nextGuess;
                nextGuess = (lastGuess + num / lastGuess) / 2;
            }
            lastGuess = nextGuess;
            return nextGuess = (lastGuess + num / lastGuess) / 2;
        }
    }
}
