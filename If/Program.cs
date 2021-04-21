using System;

namespace If
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 7;
            int z = 5;

            Console.WriteLine("Enter first digit number: ");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second digit number: ");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third digit number: ");
            int x3 = Convert.ToInt32(Console.ReadLine());

            
            // if ((x == x1 && y == x2) || (z == x3 && y == x2) || (x == x1 && z == x3) || (x == x2 && y == x3))
            // {
            //     Console.WriteLine($"You have earned an award of $3,000.");
            // }

            if ((x == x1) || (y == x2) || (z == x3))
            {
                Console.WriteLine($"You have earned an award of $1,000. ");
            }
            else if (x == x1 && y == x2 || z == x3 && y == x2 || x == x1 && z == x3 || x == x2 && y == x3)
            {
                Console.WriteLine($"You have earned an award of $3,000.");
            }

            else if((x == x1) && (y == x2) && (z == x3))
            {
                Console.WriteLine($"You have earned an award of $10,000.");
            }

            else
            {
                Console.WriteLine("You do not earn any award. ");
            }

        }
    }
}
