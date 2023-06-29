using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System;

namespace Lab03Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Challenge01();

            //Challenge02();

            Challenge03();
        }

        /*Challenge01: Write a program that asks the user for 3 numbers.
        //Return the product of these 3 numbers multiplied together.
        //If the user puts in less than 3 numbers, return 0;
        //If the user puts in more than 3 numbers, only multiply the first 3.
        If the number is not a number, default that value to 1.*/
        public static int Challenge01()
        {
            Console.Write("Please enter 3 numbers: ");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            int count = Math.Min(numbers.Length, 3);

            if (count < 3)
            {
                Console.WriteLine("You entered less than 3 numbers. Returning 0.");
                return 0;
            }

            int product = 1;

            for (int i = 0; i < count; i++)
            {
                try
                {
                    if (int.TryParse(numbers[i], out int num))
                    {
                        product *= num;
                    }
                    else
                    {
                        // Default the value to 1 if it's not a number
                        product *= 1;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                    return 0;
                }
            }
            Console.WriteLine("The product of these 3 numbers is: " + product);
            return product;
        }


        /*Challenge02: Create a method that asks the user to enter a number between 2-10. 
        Then, prompt the user that number of times for random numbers.
        After the user has inputted all of the numbers. Find the average of all the numbers inputted.
        Specs: 1. Do not let the user put in negative numbers 2. Confirm each input is a real number*/
        public static int Challenge02()
        {
            int count;
            bool validInput = false;

                Console.Write("Please enter a number between 2-10: ");
                string inputt = Console.ReadLine();

                if (int.TryParse(inputt, out count))
                {
                    if (count >= 2 && count <= 10)
                    {
                        int sum = 0;

                        for (int i = 1; i <= count; i++)
                        {
                            bool validNumber = false;
                            int number;

                            do
                            {
                                Console.Write("{0} of {1} - Enter a number: ", i, count);
                                string input = Console.ReadLine();

                                if (int.TryParse(input, out number))
                                {
                                    if (number >= 0)
                                    {
                                        validNumber = true;
                                        sum += number;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid input. Please enter a non-negative number.");
                                        return -1;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input. Please enter a valid number.");
                                    return -2;
                                }
                            } while (!validNumber);
                        }

                        int average = sum / count;
                        Console.WriteLine("The average of these {0} numbers is: {1}", count, average);

                        return average;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Number must be between 2 and 10.");
                        return 0;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    return 0;
                }
        }

        /*
         * Challenge 3:
        Create a method that will output to the console the following design. Pay attention to spacing.


    *
   ***
  *****
 *******
*********
 *******
  *****
   ***
    *
        */
        public static void Challenge03()
        {
            int n = 5; // Number of rows

            // Upper half of the pattern
            for (int i = 1; i <= n; i++)
            {
                // Print spaces
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                // Print asterisks
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            // Lower half of the pattern
            for (int i = n - 1; i >= 1; i--)
            {
                // Print spaces
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                // Print asterisks
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }


    }
}