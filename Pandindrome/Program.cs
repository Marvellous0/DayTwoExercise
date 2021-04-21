using System;

namespace Pandindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer to reverse:");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Reverse of number is " + Reverse(num));
            Console.WriteLine(isPalindrome(num));
        }
        private static int Reverse(int num)
        {
            {
                int reversedNumber = 0;
                while (num > 0)
                {
                    reversedNumber = reversedNumber * 10 + num % 10;
                    num = num / 10;
                }
                return reversedNumber;
            }
        }

        public static bool isPalindrome(int num)
        {

            return (num == Reverse(num));

        }
    }
}
