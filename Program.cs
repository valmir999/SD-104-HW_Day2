//Write a program that asks for two integers.
//Compare the two numbers, display the larger number
//Write a program that asks for three integers
//Compare them and display the largest number and the smallest number

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_HW_Day2
{
    class Program
    {
        // declare variables
        private static int nUserPick;
        private static string answerYN;

        static void Main(string[] args)
        {
            // program header/title info
            Console.WriteLine("This program compares integers");
            Console.WriteLine("");

            while (true)
            {
                try
                {
                    // declare variables
                    int num1;
                    int num2;
                    int num3;

                // user input
                InputNum1:
                    Console.Write("Enter the first integer: ");
                    if (!int.TryParse(Console.ReadLine(), out nUserPick))
                    {
                        Console.WriteLine("Invalid Entry!!! Try again... ");
                        Console.WriteLine("");
                        goto InputNum1;
                    }
                    num1 = Convert.ToInt32(nUserPick);

                InputNum2:
                    Console.Write("Enter the second integer: ");
                    if (!int.TryParse(Console.ReadLine(), out nUserPick))
                    {
                        Console.WriteLine("Invalid Entry!!! Try again... ");
                        Console.WriteLine("");
                        goto InputNum2;
                    }
                    num2 = Convert.ToInt32(nUserPick);

                    // campere two integers and display the larger one

                    if (num1 > num2)
                    {
                        Console.WriteLine(num1 + " is larger than " + num2);
                    }
                    else
                    {
                        Console.WriteLine(num2 + " is larger than " + num1);
                    }

                    Console.WriteLine("");

                InputNum3:
                    Console.Write("Enter the third integer: ");
                    if (!int.TryParse(Console.ReadLine(), out nUserPick))
                    {
                        Console.WriteLine("Invalid Entry!!! Try again... ");
                        Console.WriteLine("");
                        goto InputNum3;
                    }
                    num3 = Convert.ToInt32(nUserPick);


                    // campere two integers and display the larger one
                    //Write a program that asks for three integers
                    //Compare them and display the largest number and the smallest number

                    int numLarger;
                    int numSmaller;
                    numSmaller = num1;
                    numLarger = num1;

                    if (num1 > num2)
                    {
                        numLarger = num1;
                        numSmaller = num2;
                    }
                    else
                    {
                        numLarger = num2;
                        numSmaller = num1;

                    }

                    if (num3 > numLarger)
                    {
                        numLarger = num3;
                    }
                    else if (num3 < numSmaller)
                    {
                        numSmaller = num3;
                    }

                    Console.WriteLine("The First Number is: " + num1);
                    Console.WriteLine("The Second Number is: " + num2);
                    Console.WriteLine("The Third Number is: " + num3);
                    Console.WriteLine("");
                    Console.WriteLine("Out of these three numbers the Larger one is " + numLarger);
                    Console.WriteLine("Out of these three numbers the Smaller one is " + numSmaller);
                    Console.WriteLine("");

                    answerYN = "Y";
                    Console.Write("Do you want to do another run (Y/N)?");
                RunAgain:
                    answerYN = Console.ReadLine();
                    if (answerYN.ToUpper() == "Y" || answerYN.ToUpper() == "N")
                    {
                        if (answerYN.ToUpper() == "N")
                        {
                            System.Environment.Exit(0);
                        }
                    }
                    else
                    {
                        Console.Write("Tray Again -- Please enter (Y/N)?");
                        goto RunAgain;
                    }
                    Console.WriteLine("");
                }
                catch (Exception e) { Console.WriteLine("Please try again !!!"); continue; }
            }
        }
    }
}
