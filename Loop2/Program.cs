using System;
using System.Collections;

namespace Loop2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            int m = 3;
            int n = 3;
            int sum = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sum = sum + arr[i, j];
                    Console.WriteLine($"Sum of row: {sum}");
                }
            }

        }
    }
}
