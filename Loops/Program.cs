using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
                int[] arr = { 1, 2, 3, 4, 5, 6 };
                int odd = 0;

                // Loop to find odd sum
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i % 2 == 1)
                    {
                        odd += arr[i];
                    }
                }

                Console.WriteLine("Odd index positions " + "sum: " + odd);
        }
    }
}
