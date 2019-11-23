using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {

            Dog myDog = new Dog();

            myDog.Name = "Rex";
            myDog.DoTrick = "A backflip!";
           
            Dog myOtherDog;
            myOtherDog = myDog;
            
            Console.WriteLine("{0} is Barking... {0} is so smart!  {0} is doing a(n) {1}",
                myOtherDog.Name, 
                myOtherDog.DoTrick);
        }
        class Dog
        {
            public string Name { get; set; }
            public string DoTrick { get; set; }
        }
    }
}

/*
 A Scope is double height and double width with anytyhing within the () in a method header.
 A Static vs None-Static, if you static you can access information all across the code.
 If not static then you mst fetcg the information another way. A Return type is double, 
 this means how the program returns information, it can be a void or an int also.
 A method name is a getArea, it tells the code where to get all of the information.
 Parameters are doubles in the example and tells the code the restrictions if the code has any.
 The Public doesn't have restrictions like private does.
 The Method Body is Return height*width in the example and mark the area of code that is going to be executed.
 */
/*
 *User defined method is written by the user and is hidden from the other methods. 
 Methods provided by the framework are able to be reused from different locations on the application.
 When creating a user defind method is in place we take into account to not, "reinvent the wheel."
 */
/* 
A non static method is alowed to access the non static field of the objects.
The static method doesn't have access to the non static objects fields.
*/
