using System;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int i = 12;
            Boolean keepLooping = true;
            while (keepLooping)
            {
                if (i <= 11)
                    keepLooping = false;
                i++;
                Console.WriteLine(i);
            }
            
            
            int c = 2;
            while (c <= 128)
            {
                
                c *= 2;
                Console.WriteLine("[ "+ c + "]");    
            } 


            string j = ",";
            int i;
            for (i = 49; i >= 1; --i)
            {
                Console.Write(i);
                if (i>=2)
                {
                    Console.Write(j);
                }
            }
           


            int i = 1;
            while (i<=21)
            {
                {
                    if ((i%2)==0)
                    {
                        Console.Write(" ");
                    }
                    else if ((i%2)!=0)
                    {
                        Console.Write(i);
                    }
                    i++;
                }
            }

            







            {
                bool icyRain = !false; bool tornadoWarning = !false;

                if (icyRain && tornadoWarning)
                {
                    Console.WriteLine("Let's Go Outside!");

                }
            }
            

            int numberoflayer = 5, Space, Number;
            Console.WriteLine("Print pyramid");
            for (int i = 1; i<=numberoflayer;i++)
            {
                for (Space = 1; Space <= (numberoflayer - i); Space++)
                    Console.Write(" ");
                for (Number = 1; Number <= i; Number++)
                    Console.Write(Number);
                for (Number = (i - 1); Number >= 1; Number--)
                    Console.Write(Number);
                    Console.WriteLine();
                    Console.WriteLine();
            }
            */


            int n = 8;
            int i = 10; // initialize
            do
            {
                Console.Write("*");
                i++; // update!
               
            } while (i < n) ; // test condition

        }
    }

}   












/* Control statements: the sequence statement, selection statements (three types—if, if...else and switch) 
and repetition statements (three types—while, for and do...while). The while and for statements perform the action
in their bodies zero or more times if the loop-continuation condition is initially false, the action
will not execute. The do...while statement performs the action in its body at least once.
The if selection statement either performs an action if a condition is true or skips the action if the condition is false.
The if...else selection statement performs an action if a condition is true or performs a different action if the condition is false.
The switch selection statement performs one of many different actions, depending on the value of an integer expression.
The sequence structure is built into C++. Unless directed otherwise, C++ statements execute one after the other in the order in which they are written—that is, in sequence.
 */

