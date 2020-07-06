using System;
using System.Security.Cryptography;

namespace Lab01a
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StartSequence();
                Console.WriteLine("Hello World!");
            }
            catch (Exception a)
            {
                Console.WriteLine("Caught a");
            }
            finally
            {
                Console.WriteLine("App Complete");
            }
        }

        static void StartSequence()
        {
            try
            {
                Console.WriteLine("Write a number, please let it be 6");
                int answer = Convert.ToInt32(Console.ReadLine());
                int[] intArray = new int[answer];
                Populate(intArray);
                GetSum(intArray);
                GetProduct(int[] int sum);
                GetQuotient(int product);
            }
            catch (Exception b)
            {
                Console.WriteLine("Caught b");
            }
        }

        static int[] Populate(int[] populateArray)
        {
            try
            {
                for (i = 0; i < populateArray.length; i++)
                {
                    Console.WriteLine("Please enter a number 1/6");
                    string userAnswer = Console.ReadLine();
                    int userNumber = Convert.ToInt32(userAnswer);
                    populateArray[i] = userNumber;
                }
            }
            catch (Exception c)
            {
                Console.WriteLine("Caught c");
            }
        }

        static int GetSum(intArray)
        {
            try
            {
                int sum =
                intArray.Sum()
            }
            catch (Exception d)
            throw (new Exception(d.message));
            {
                Console.WriteLine("Caught d");
            }
        }

        static int GetProduct(intArray, intSum)
        { 
            try
            {
             
            }
            catch(Exception e)
            {
                Console.WriteLine("Caught e");
            }
        }

        static dec GetQuotient(intProduct)
        {
            try
            {

            }
            catch (Exception f)
            {
                Console.WriteLine("Caught f");
            }
        }
    }
}
