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

/* 1. The C# program applies the execution at the class when you first open it p and then continues to say “hello world”

2. An integer is a number without a decimal point.A float is a floating-point number, which is a number with a decimal place and 
    used more when a code needs to be more accurate.

3. An example of a block of code method is the ‘GetName’ Method.It is a set code that can give information depending on what you enter, 
    for example in this GetName method you can return a particular account object name to the caller.

4. ⦁	Like we have types double and int, we can create our own custom types using Classes.  Each class has variables called instance variables or class members.
To read the value of an instance variable, we create method called a ____ accessor.To assign a value ton instance variable, 
    we use a method called a ____ accessor.

Get; set 

5. An object is a collection of data and behaviors that represent some entity.A class defines the structure and behaviors of all entities of a given type.
    The objects are the data that we enter in the code.The classes are the holding places of those objects that keep it together. 

    */
      