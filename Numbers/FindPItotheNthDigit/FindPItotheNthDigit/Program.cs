using System;

/*
 * Goal: Enter a number and have the program generate PI up to that many decimal places. Keep a limit to how far the program will go.
 * 
 */

namespace FindPItotheNthDigit
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Enter user value here
            Console.WriteLine(FindPI(/*Enter Value*/));
        }

        
        public static string FindPI(int numPlaces)
        {
            double pi = Math.PI;

            string returnPI;

            if (numPlaces.GetType() == typeof(int) && numPlaces < 15 && numPlaces >= 0)
            {
                returnPI = Math.Round(pi, numPlaces).ToString();
            }
            else
            {
                returnPI = "An error has occured. Please make sure you've entered a positive int and int is less than 15";
            }

            return returnPI;
        }
    }
}
