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



            int istrue = 10;

            if (istrue <= 60)
                Console.WriteLine("It is True");

            else
                Console.WriteLine("It is False");


            Console.WriteLine("Input temperature in Fahrenheit: ");
            
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            double Celsius = (fahrenheit - 32d) * 5d / 9d;
            Console.WriteLine("input any number");
            Console.WriteLine("Temperature in Celsius is {0}: ", Celsius);
            
            Console.ReadLine();
            
            if (fahrenheit >= 90)
            {
                Console.WriteLine("It is hot");
            }

            
            else _ = (fahrenheit <= 40);
            {
                
                Console.WriteLine("It is cold");
            }
            
           
            int a = 1;
            
            while (a < 11)
            {
                
                Console.Write("Value: ");
                 
                Console.WriteLine(a);

                a++;
            }

            int b=60;


            while (b >= 20)
            { 
                

                Console.Write("Value: ");
               
                Console.WriteLine(b);

                b -= 5;
            }
            int c=10;


            while (c <= 20)
            {
                Console.Write("Value: ");

                Console.WriteLine(c);

                c += 2;
            }
        }

    }
}

/* The if single-selection statement and the while repetition statement both perform
an action when the condition is true or false. 
If the condition is true, the if single-selection statement performs the action once,
where instead the while repetition statement repeatedly performs the action until the
while statement becomes false. */ 
