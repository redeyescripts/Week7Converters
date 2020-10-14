using System;

namespace Week7Converters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the temperature in fahrenheit?");
            string temp = Console.ReadLine();
            int x = Int32.Parse(temp);
            int y = x - 32;
            double z = y * 0.5;
                Console.WriteLine("It is about " + z + " degrees Celsius!");
            if (z > 23)
            {
                Console.WriteLine("That's hot!");
            }

            else if (z <= 12)
            {
                Console.WriteLine("That's cold!");
            }
            else if (z > 12 || z <= 23)
            {
                Console.WriteLine("Such a nice day!");
            }
            Console.ReadKey();

        }

    }
}
