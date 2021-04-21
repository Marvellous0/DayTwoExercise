using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of length: ");
            double l = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Enter the value of breadth: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Area x = new Area(l, b);
            x.getArea();
        }
    }
}
