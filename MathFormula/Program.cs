using System;
using MathFormula;
namespace MathFormula
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Create a new object of the SecondClass
            //keyword formula creates shortcut to the SecondClass
            //use for loop to take user input
            MathFormula.SecondClass formula = new SecondClass();
            double r,a,b,c,x;
            double[] Num = new double[5];

            Console.WriteLine("Enter your integers For Radius, A,B,C,and X");
            Console.Write("in that Order:");
            for(int i=0;i<Num.Length; i++)
            {
                Console.WriteLine("-----------------------------------------------------------");
                Num[i] = Double.Parse(Console.ReadLine());

            }
            //Assign the array to the Variables
            r = Num[0];
            a = Num[1];
            b = Num[2];
            c = Num[3];
            x = Num[4];
            Console.WriteLine("-------------------------------------------------------------");
            Console.ReadKey();

            //State the action and add the method
            Console.WriteLine("The Circumefrence is:");
            double Ans = formula.circ(r);
            Console.WriteLine(Ans);

            Console.WriteLine("-------------------------------------------------------------");
            Console.ReadKey();

            Console.WriteLine("The Area of the circle is: ");
            double Ans2 = formula.AreaC(r);
            Console.WriteLine(Ans2);

            Console.WriteLine("-------------------------------------------------------------");
            Console.ReadKey();

            Console.WriteLine("The volume of the hemisphere is: ");
            double Ans3 = formula.Vol(r);
            Console.WriteLine(Ans3);

            Console.WriteLine("-------------------------------------------------------------");
            Console.ReadKey();

            Console.WriteLine("The Area of the triangle is: ");
            double Ans4 = formula.AreaT(a, b, c);
            Console.WriteLine(Ans4);

            Console.WriteLine("-------------------------------------------------------------");
            Console.ReadKey();

            //Insert Quadratic Fourmula
            Console.WriteLine("The quadratic formula is: ");
            double Ans5 = formula.Quad1(a, b, c);
            double Ans6 = formula.Quad2(a, b, c);
            Console.WriteLine($"{Ans5} and {Ans6}" );
            
            
            Console.WriteLine("-------------------------------------------------------------");
            Console.ReadKey();

        }



    }
}
