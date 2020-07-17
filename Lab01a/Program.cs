using System;
using System.Linq;
using System.Security.Cryptography;

namespace Lab01a
{
    class Program
    {
        static void Main(string[] args)
        {//below we have a try and catch to manage any errors that might arise
            try
            {
                Console.WriteLine("Welcome to my game! Let's do some math!");
                //below calls the StartSequence method
                StartSequence();
            }
            catch (Exception)
            {
                Console.WriteLine("Caught all");
            }
            //below ends this program with a console line to confirm
            finally
            {
                Console.WriteLine("Program is complete");
            }
        }

        static void StartSequence()
        {//this method calls all subsequent methods as well as provides additional strings for the user to see in the terminal
            try
            {//below allos a user to enter a number that creates how many spaces in an array exist
                Console.WriteLine("Please enter a number greater than 0");
                //below grabs the user input and converts it from a string to an integer
                int answer = Convert.ToInt32(Console.ReadLine());
                //below creates a variable out of the user input
                int[] intArray = new int[answer];
                //below is where the Populate method is called
                Populate(intArray);
                //below converts the GetSum method call into a variable, also calls the method
                int sum = GetSum(intArray);
                //below converts the GetProduct method call into a variable, also calls the method
                int product = GetProduct(intArray, sum);
                //below converts the GetQuotient method call into a variable, also calls the method
                decimal quotient = GetQuotient(product);
                Console.WriteLine($"Your array size is: {intArray.Length}");
                //below is a for loop that shows dynamically what exists within the numbers array (based on user input)
                Console.WriteLine($"The numbers in the array are: ");
                for (int i = 0; i < intArray.Length - 1; i++)
                {
                    Console.Write($"{intArray[i]},");
                }
                Console.WriteLine($"{intArray[intArray.Length - 1]}");
                Console.WriteLine($"\nThe sum of the array is: {sum}");
                Console.WriteLine($"{sum} * {product / sum} = {product}");
                Console.WriteLine($"{product} / {product / quotient} = {quotient}");
            }
            //below is the error handler for this method
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //below is a method that lets a user generate numbers in an array
        static int[] Populate(int[] populateArray)
        {//below iterates over the length of the array (user generated) and lets a user create that many numbers
            for (int i = 0; i < populateArray.Length; i++)
            {
                Console.WriteLine($"Please enter a number {i + 1} of {populateArray.Length}");
                string userAnswer = Console.ReadLine();
                int userNumber = Convert.ToInt32(userAnswer);
                populateArray[i] = userNumber;
            }
            return populateArray;
        }
        //below is a method that adds all of the numbers in the array together and returns a sum or, if the number is or below 20, an error message
        static int GetSum(int[] intArray)
        {
            int sum = intArray.Sum();
            if (sum <= 20)
                {
                    throw (new Exception($"Value of {sum} is too low"));
                }
                else
                {
                    return sum;
                }   
        }
        //below is a method that allows a user to multiply the length of their array by a number they choose that does not exceed the length of the array
        static int GetProduct(int[] intArray, int sum)
        { 
            try
            {
                Console.WriteLine($"Select a random number between 1 and {intArray.Length}");
                string userAnswer = Console.ReadLine();
                int index = Convert.ToInt32(userAnswer);
                int product = sum * index;
                return product;
            }
            catch (IndexOutOfRangeException)
            {//below is a throw error handler that is caught by the Main method
                throw (new Exception($"Size of array is too big"));
            }
        }
        //below is a method that allows a user to select a number to divide their eariler crafted product
        static decimal GetQuotient(int product)
        {
            try
            {
                Console.WriteLine($"Please enter a random number to divide your product {product} by ");
                string userAnswer = Console.ReadLine();
                int userNumber = Convert.ToInt32(userAnswer);
                //below is the specific code that allows us to divide the product by the user's number
                decimal quotient = decimal.Divide(product, userNumber);
                return quotient;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Caught f");
                //below is the return value if an error is caught to ensure that this method works
                return 0;
            }
        }
    }
}
