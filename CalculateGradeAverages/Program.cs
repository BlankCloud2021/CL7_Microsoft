using System;

namespace CalculateAverages
{
    class Program
    {
       
        static void Main(string[] args)
        {
           DaStart:
            Console.WriteLine("Enter a Number between 1-4 to execute:" +
                "\n 1.Sum of numbers\n 2.Average of 10 scores\n 3.Average of specific number of scores \n 4.Average of a Non-Specific number of scores");
            int User = int.Parse(Console.ReadLine());
            switch (User)
            {
                case 1:
                    //Sum of numbers
                    //Collect ten numbers a user input
                    Console.WriteLine("Input your 10 numbers to find the Sum.");
                    Console.WriteLine("---------------------------------------------------------------------------------------------------");
                    double[] newArray = Mathamatics.grabInput10();

                    //Use the Sum method to find the sum and output the results.
                    double ans = Mathamatics.findSum(newArray, newArray.Length);
                    Console.WriteLine($"The sum is :{ans}");
                    break;

                case 2:
                    //Average of 10 Scores 
                    Console.WriteLine("Input 10 scores to find out your grade average");
                    double[] averageArray = Mathamatics.grabInput10();
                    string Average = Mathamatics.findAvg(averageArray, averageArray.Length);

                    Console.WriteLine(Average);
                    break;
                case 3:
                    // Average of a specific number of scores 
                    Console.WriteLine("Input As many Scores as you want to find out your grade average");
                    double[] averageArraysspec = Mathamatics.grabInput();
                    string specAverage = Mathamatics.findAvg(averageArraysspec, averageArraysspec.Length);

                    Console.WriteLine(specAverage);
                    break;
                case 4:
                    //Average of non specific number of scores

                    Console.WriteLine("Now your going to Find the Average of what ever scores you input with first letting us know how many there are.");
                    String eScore = Mathamatics.nSpecAverage();
                    Console.WriteLine(eScore);
                    break;

            }
            Console.WriteLine("Do you want more y/n");
            string Input = Console.ReadLine().ToLower();
            if(Input=="y")
            {
                goto DaStart;
            }


            Console.ReadKey();
        }

        class Mathamatics
        {
            static public double[] grabInput()
            {
                //Find out the amount of numbers need for a Calulation
                Console.WriteLine("First enter the total amount of numbers you intend to use: ");
                //create array to hold user input  
                double max = double.Parse(Console.ReadLine());
                Console.WriteLine("Now enter your integers:");

                double[] uInput = new double[(int)max];
                for(double i= 0; i< uInput.Length; i++)
                {
                    double input =double.Parse(Console.ReadLine());
                    while (!(input >= 0 && input <= 100))
                    {
                        Console.WriteLine("Invalid input try again. Numbers must be between 0 and 100");
                        input = double.Parse(Console.ReadLine());
                    }
                    uInput[(int)i] = input;
                }
               // return the resulting array to be assign as the value of a new array in that instance
                return uInput;
            }
            static public double[] grabInput10()
            {
                //create array to hold user input  
                
                double[] uInput = new double[10];
                for (double i = 0; i < uInput.Length; i++)
                {
                    double input = double.Parse(Console.ReadLine());
                    while (!(input >= 0 && input <= 100))
                    {
                        Console.WriteLine("Invalid input try again. Numbers must be between 0 and 100");
                        input = double.Parse(Console.ReadLine());
                    }
                    uInput[(int)i] = input;
                }
                // return the resulting array to be assign as the value of a new array in that instance
                return uInput;
            }

            static public String nSpecAverage()
            {
                //Needs to be assigned to a Variable and printed to screen
                // Collects all input and finds Average
                double nInput = 0;
                double sum = 0;
                double tNum = 0;
                double Average = 0;

                Console.WriteLine("Input The scores you wish to grade. \n When Complete simply type 'done'.");

                //Collect user input if they dont input some varient of "done" the code with go back to the label TheStart and collect data until done is input.
                //Takes Arbitrary Number of Grade Scores

            TheStart: String uInput = Console.ReadLine().ToLower();
                if (!( uInput == "done"))
                {
                    //Convert input to a double and then add it to the current value of sum, inrement tNum to know the denomenator for the Average equeation
                    //if the input is a number it will check if its in range if not it will ask again
                    nInput = double.Parse(uInput);
                    while (!(nInput >= 0 && nInput <= 100))
                    {
                        Console.WriteLine("Invalid input try again. Numbers must be between 0 and 100");
                        nInput = double.Parse(Console.ReadLine());
                    }
                    sum += nInput;
                    tNum++;
                    goto TheStart;
                }
                // If done is entered find the average and exit the loop.
                else if( uInput == "done")
                {
                   Average = sum / tNum;
                }
                //if no conditions are met display the error and return to TheStart
                else
                {
                    Console.WriteLine("Invalid input");
                    goto TheStart;
                }

                Console.WriteLine($"Total number of scores entered is {tNum}.");
                
                //Then find the results using and if statment
               
                //Find average and assign to a variable that is a string 
                if (Average >= 90)
                {
                    return ($" Your average score is {(int)Average}, and your Grade for the class is A ");
                }
                else if (Average >= 80 && Average < 90)
                {
                    return ($" Your average score is {(int)Average}, and your Grade for the class is B");
                }
                else if (Average >= 70 && Average < 80)
                {
                    return ($" Your average score is {(int)Average}, and your Grade for the class is C");
                }
                else if (Average >= 60 && Average < 70)
                {
                    return ($" Your average score is {(int)Average}, and your Grade for the class is D");
                }
                else
                {
                    return ($" Your average score is {(int)Average}, and your Grade for the class is F");
                }

                
               

            }

            //---------------------------------------------------------------------------------------------------------
            //Find the sum of any given array
            //the inputs should be (The Array of NUm, Array.length)
            static public double findSum(double[] inputArray, double length)
            {
                double Sum = 0;
                for (double i = 0; i < length; i++)
                {
                    Sum += inputArray[(int)i];
                }
                return Sum;
            }
            static public String findAvg(double[] inputArray, double length)
            {
                double Sum = 0;
                for (double i = 0; i < length; i++)
                {
                    Sum += inputArray[(int)i];
                }
                double Average = Sum / length;
                //Find average and assign to a variable that is a string 
                if (Average>=90)
                {
                    return ($" Your average score is {(int)Average}, and your Grade for the class is A ");
                }
                else if(Average>=80 && Average<90)
                {
                    return ($" Your average score is {(int)Average}, and your Grade for the class is B");
                }
                else if (Average>= 70 && Average< 80)
                {
                    return ($" Your average score is {(int)Average}, and your Grade for the class is C");
                }
                else if (Average>= 60 && Average< 70)
                {
                    return ($" Your average score is {(int)Average}, and your Grade for the class is D");
                }
                else 
                {
                    return ($" Your average score is {(int)Average}, and your Grade for the class is F");
                }
            }


        }
        class Error
        
       
        {
            static public void CarryOn()
            {
                string ans;
                
                Console.Write($"Would you like to continue Y/N: ");

                ans = Console.ReadLine().ToLower();
                if (ans == "y"|| ans == "yes")
                {
                    Console.WriteLine("Then lets continue");
                }
                else
                {
                    
                }

                Console.WriteLine("----------------------------------");
            }
        }

    }

}
