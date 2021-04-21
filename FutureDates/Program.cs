using System;

namespace FutureDates
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Enter todays date: ");
            int date = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of days elapsed since today: ");
            int futuredate = Convert.ToInt32(Console.ReadLine());

            int future_date = (date + futuredate) % 7;
            string day_of_week = "";

            switch (date)
            {
                case 0:
                    day_of_week = "Sunday";
                    break;
                case 1:
                    day_of_week = "Monday";
                    break;
                case 2:
                    day_of_week = "Tuesday";
                    break;
                case 3:
                    day_of_week = "Wednesday";
                    break;
                case 4:
                    day_of_week = "Thursday";
                    break;
                case 5:
                    day_of_week = "Friday";
                    break;
                case 6:
                    day_of_week = "Saturday";
                    break;
            }

            if (future_date == 0)
            {
                Console.WriteLine($"Todays is Sunday and the future day is Sunday ", day_of_week);
            }
            else if (future_date == 1)
            {
                Console.WriteLine($"Todays is Monday and the future day is Monday ", day_of_week);
            }
            else if (future_date == 2)
            {
                Console.WriteLine($"Todays is Tuesday and the future day is Tuesday", day_of_week);
            }
            else if (future_date == 3)
            {
                Console.WriteLine($"Todays is Wednesday and the future day is Wednesday", day_of_week);
            }
            else if (future_date == 4)
            {
                Console.WriteLine($"Todays is Thursday and the future day is Thursday", day_of_week);
            }
            else if (future_date == 5)
            {
                Console.WriteLine($"Todays is Friday and the future day is Friday", day_of_week);
            }
            else if (future_date == 6)
            {
                Console.WriteLine($"Todays is Saturday and the future day is Saturday", day_of_week);
            }
        }

    }
}
