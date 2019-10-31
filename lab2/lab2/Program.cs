using System;

namespace lab2
{      
    class Multiplication
    {
    static void Main()
        {
            int number1;
            int number2;
            int sum;
          
            Console.WriteLine("Hello World! From Adam"); // computer prints hello world from adam
            Console.WriteLine("Hello\nWorld!\nFrom\nAdam\n"); // computer prints hellp world from adam with new lines on each word

            Console.WriteLine("Enter first integer:"); // asked for first integer
            number1 = int.Parse(Console.ReadLine());  //
            Console.WriteLine("Enter second integer:"); // compute asked user for number
            number2 = int.Parse(Console.ReadLine());  // computer saves users number

            sum = number1 * number2;  // sum of both numbers

            Console.WriteLine($"Sum is {sum}"); // gives out sum

        } // end Main
    } // end muliplication
}