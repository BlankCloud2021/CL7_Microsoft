using System;

namespace String_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
              string fName, lName;

              Console.WriteLine("Enter your Firstname");
              fName= Console.ReadLine();

              Console.WriteLine("Enter your Last name");
              lName = Console.ReadLine();

              string fullName = fName + lName;
              Console.WriteLine("Your Name is: ");
              Console.WriteLine(fullName);

              Console.WriteLine();
              Console.ReadKey();

            double price, discount, nPrice;

            Console.WriteLine("Enter the price of the Item: ");
            price = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the discount applied: ");
            discount = double.Parse(Console.ReadLine());

            //Console.WriteLine("Press 'y' to Contine if not press 'n'");
            //string input = Convert.ToString(Console.ReadKey());



            nPrice = price - (price * discount);

            Console.WriteLine($"The price is now {nPrice:c}");

            double num1, num2, dAns;
            int wAns;
            Console.WriteLine("Enter the first number");
            num1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            num2 = Double.Parse(Console.ReadLine());

            wAns = (int)(num1 / num2);
            dAns = num1 % num2;

            Console.WriteLine($"The Quotient of {num1} and {num2} is: {wAns} ");

            Console.WriteLine($"The Remainder is: {dAns}");
            Console.ReadKey();


        }


    }

}
