using System;

namespace OptionalPerameter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UserInfo called with no perameters");
            Optional.userInfo();

            Console.WriteLine();

            Console.WriteLine("UserInfo called with both perameters");
            Optional.userInfo("Carl",9);
                

        }



    class Optional
        {
            //Question 1 
            static public void userInfo(string name = "No Name", int age = 0)
            {
                Console.WriteLine($"The Adventure begins with {name}. your character age is {age}");
            }
            //Question 2 
            //Overloaded becuse is now expecting a double for age instead of an int.
            static public void userInfo(string name, double age)
            {
                Console.WriteLine($"The Adventure begins with {name}. your character age is {age}");
            }


        }
    }
}
