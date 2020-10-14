using System;

namespace Converter2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the temperature in celsius?");
            string temp = Console.ReadLine();
            int y = Int32.Parse(temp);
            int x = y - 32;
            double z = y * 2.5;
            Console.WriteLine("It is about " + z + " degrees fahrenheit!");
            if (z > 86)
            {
                Console.WriteLine("That's hot!");
            }

            else if (z <= 41)
            {
                Console.WriteLine("That's cold!");
            }
            else if (z > 50 || z <= 77)
            {
                Console.WriteLine("Such a nice day!");
            }
            Console.ReadKey();
        }
    }
}
