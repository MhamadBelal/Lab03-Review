﻿using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System;
using System.ComponentModel;

namespace Lab03Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Challenge01();

            //Challenge02();

            //Challenge03();

            /*
             int[] input = { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 };
             Console.WriteLine(Challenge04(input)); 
            */

            /*
            int[] input = { 22, 18, 99, 102, 1, 2 };
             Console.WriteLine(Challenge05(input));
            */

            /*
            string path = "../../../words.txt";
            Challenge06(path);
            */

            /*
            string path = "../../../words.txt";
            Challenge07(path);
            */


            /*
            string path = "../../../words.txt";
             Challenge08(path, "file");
            */


            /*
            string sentence = "This is a sentence about important things";
            string[] wordLengths = Challenge09(sentence);
            Console.WriteLine(string.Join(", ", wordLengths));
            */

            Console.ReadKey();
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


        /*
        Challenge 4:Write a method that brings in an integer array and returns the number that appears the most times. 
        If there are no duplicates, return the first number in the array. 
        If more than one number show up the same amount of time, return the first found.
        */
        public static int Challenge04(int[] numbers)
        {
            Dictionary<int, int> countMap = new Dictionary<int, int>();

            foreach (int number in numbers)
            {
                if (countMap.ContainsKey(number))
                {
                    countMap[number]++;
                }
                else
                {
                    countMap[number] = 1;
                }
            }

            int maxCount = 0;
            int mostFrequentNumber = numbers[0];

            foreach (var entry in countMap)
            {
                if (entry.Value > maxCount)
                {
                    maxCount = entry.Value;
                    mostFrequentNumber = entry.Key;
                }
            }

            return mostFrequentNumber;
        }


        /*
        Challenge 5: Write a method in that finds the maximum value in the array. 
        The array is not sorted. You may not use .Sort() 
        */
        public static int Challenge05(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("Input array is null or empty.");
            }

            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            return max;
        }


        /*
        Challenge 6: Write a method that asks the user to input a word,
        and then saves that word into an external file named words.txt
        Hint: Have a file already saved in the root of your directory with a couple of words already present in the file.
        */
        public static void Challenge06( string path)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(path, true))
            {
                // Write the word to the file
                writer.WriteLine(word);
            }
            Console.WriteLine("Word appended to the file successfully.");
        }

        /*
        Challenge 7: Write a method that reads the file in from Challenge 6, and outputs the contents to the console.
        */
        public static void Challenge07(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);

                if (lines.Length > 0)
                {
                    Console.WriteLine("File contents:");

                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                }
                else
                {
                    Console.WriteLine("The file is empty.");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file does not exist.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }


        /*
        Challenge 8: Write a method that reads in the file from Challenge 6. 
        Removes one of the words, and rewrites it back to the file.
        */
        public static void Challenge08(string filePath, string wordToRemove)
        {
            // Read all lines from the file
            string[] lines = File.ReadAllLines(filePath);

            bool wordFound = false;

            // Iterate through each line and remove the word if found
            for (int i = 0; i < lines.Length; i++)
            {
                string[] words = lines[i].Split(' ');

                for (int j = 0; j < words.Length; j++)
                {
                    if (words[j] == wordToRemove)
                    {
                        // Remove the word from the line
                        words[j] = string.Empty;
                        wordFound = true;
                        break;
                    }
                }

                // Update the line with the modified words
                lines[i] = string.Join(" ", words);
            }

            if (!wordFound)
            {
                Console.WriteLine("Word not found in the file.");
                return;
            }

            // Append the word to the end of the lines
            string[] updatedLines = new string[lines.Length + 1];
            Array.Copy(lines, updatedLines, lines.Length);
            updatedLines[updatedLines.Length - 1] = wordToRemove;

            // Write the updated lines back to the file
            File.WriteAllLines(filePath, updatedLines);

            Console.WriteLine("Word removed and appended back to the file successfully.");
        }


        public static string[] Challenge09(string sentence)
        {
            string[] words = sentence.Split(' ');

            string[] wordLengths = new string[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                int length = word.Length;

                wordLengths[i] = $"{word}: {length}";
            }

            return wordLengths;
        }

    }
}