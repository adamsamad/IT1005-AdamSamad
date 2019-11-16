using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)// even
                {
                    Console.WriteLine(i);

                }
            }

            Console.WriteLine("Please enter a temperature");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            if (fahrenheit < 10)
                Console.WriteLine("Polar Bear");
            if (fahrenheit < 20)
                Console.WriteLine("Penguin");
            if (fahrenheit < 40)
                Console.WriteLine("Moose");
            if (fahrenheit < 50)
                Console.WriteLine("Reindeer");
            if (fahrenheit < 60)
                Console.WriteLine("Deer");
            if (fahrenheit < 70)
                Console.WriteLine("Turtle");
            if (fahrenheit < 80)
                Console.WriteLine("Lion");
            if (fahrenheit < 90)
                Console.WriteLine("fish");
            else
            {
                Console.WriteLine("Bug");
            }


            int p = 0;
            while (p < 21)
            {
                if (p % 2 == 0)
                    Console.WriteLine(p);
                p++;
            }


            for (int r = 0; r < 101; r++)
            {
                
                Console.WriteLine("*******");

                Console.WriteLine("{0}", (r + 1));

            }
        }
    }
}

/* Counter-controlled repetition requires a control variable, an initial
value of the control variable, also an increment which the control variable is modified by each time 
through the loop, and finally a loop-continuation condition that determines whether looping should continue.
*/

/* The for and while repetition statements repeatedly execute a set of
statements as long as a loop condition remains true. The for repetition statement
specifies the counter controlled repetition in its header, where instead the control variable in a
while statement normally is initialized before the loop and incremented in the loop's body.
*/

/* If you want some statement or set of statements to execute at least once, then repeat
based on a condition, a do…while is more appropriate than a while. A
do…while statement tests the loop-continuation condition after executing the loop’s
body. A while tests the loop-continuation condition before executing the loop’s body, so the program would need to
include the statement required to execute at least once both before the loop and in
the body of the loop.  Suppose a program needs to obtain an integer value from the user, and the integer value entered
is positive for the program to be true. In this specific situation, a do…while body could
contain the statements required to obtain the user input, and the loop-continuation
condition could determine the value. The loop would then repeat and prompt the user for input again. 
This would continue until the user entered a value greater than or equal to zero. Once this criterion was met,
the loop continuation condition would become false, and the loop would terminate, allowing
the program to continue past the loop. This process is often called validating input.
*/
