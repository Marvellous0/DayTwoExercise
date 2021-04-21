using System;

namespace Area
{
    public class Area
    {
        private double length; 
        private double breadth;
        public Area(double l, double b)
        {
            length = l;
            breadth = b;
        }
        public double Division()
        {
            double results = length * breadth;
            return results;
        }
        public void getArea()
        {
            Console.WriteLine("Area = " + Division());
        }
    }
}
