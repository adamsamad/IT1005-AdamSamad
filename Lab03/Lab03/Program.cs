using System;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            int speedLimit = 35;
            int speed = 42;

            if (speed > speedLimit)
            {
                Console.WriteLine("SLOW NOW");
            }

            else
            { }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int istrue = 10;

            if (istrue <= 60)
                Console.WriteLine("It is True");

            else
                Console.WriteLine("It is False");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input temperature in Fahrenheit: ");

            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            double Celsius = (fahrenheit - 32d) * 5d / 9d;

            Console.WriteLine("Temperature in Celsius is {0}: ", Celsius);

            Console.ReadLine();

            if (fahrenheit >= 90) Console.WriteLine("It is hot");

            if (fahrenheit <= 40)
                Console.WriteLine("It is cold");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;

            while (a < 11)

                Console.Write("Value: ");

            Console.WriteLine(a);

            a++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int b = 60;

            while (b >= 20)

                Console.Write("Value: ");

            Console.WriteLine(b);

            b--;
        }
    }
}