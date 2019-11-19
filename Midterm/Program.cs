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
            */
            
            int c = 2;
            while (c <= 128)
            {
                
                c *= 2;
                Console.WriteLine("[ "+ c + "]");
               
                
            }
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

