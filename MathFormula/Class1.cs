using System;
using System.Collections.Generic;
using System.Text;

namespace MathFormula
{
    class SecondClass
    {

        //Method for Finding Circumference
        //Input Pass Radius
        public double circ(double i)
        {
            double ans = 2 * Math.PI * i;
            i = ans;
            return i;

        }

        //Method for Finding Area of Circle
        public double AreaC(double i)
        {
            double ans = Math.PI * (i * i);
            i = ans;
            return i;

        }
        //Method for Finding Volume of hemisphere
        public double Vol(double i)
        {
            double ans = ((4 / 3) * Math.PI * (i * i * i)) / 2;
            i = ans;
            return i;
        }
        //Method for Finding area of Triangle 
        public double AreaT(double a, double b, double c)
        {
            //*Try and create an IF (a,b,c) greater than zero
            double p = (a + b + c) / 2;
            Double ans = Math.Sqrt((p * (p - a)) * (p - b) * (p - c));
            double i = ans;
            return i;


        }
        //Method for Solving Quadatic equation
        //make sure values are valid (b^2 > 4ac)
        public double Quad1(double a, double b, double c)
        {
            //double ans = (-b) + Math.Sqrt((b * b) - (4 * (a * c))) / (2 * a);

            double sqrtpart = (b * b) - (4 * a * c);
            double ans = ((-1) * b + Math.Sqrt(sqrtpart)) / (2 * a);
            double i = ans;
            return i;
        }
        //Quadratic Equation
        public double Quad2(double a, double b, double c)
        {
            //double ans = (-b) + Math.Sqrt((b * b) - (4 * (a * c))) / (2 * a);

            double sqrtpart = (b * b) - (4 * a * c);
            double ans = ((-1) * b - Math.Sqrt(sqrtpart)) / (2 * a);
            double i = ans;
            return i;
        }
        //tuple example

        //Quadratic Equation As a tuple 
        /*
         public(double, double) Quad2(double a, double b, double c)
           {
               //double ans = (-b) + Math.Sqrt((b * b) - (4 * (a * c))) / (2 * a);

               double sqrtpart = (b * b) - (4 * a * c);
               double ans = ((-1) * b - Math.Sqrt(sqrtpart)) / (2 * a);
               double ans2= ((-1) * b + Math.Sqrt(sqrtpart)) / (2 * a);
               return (ans, ans2);
           }
        */
    }

}


