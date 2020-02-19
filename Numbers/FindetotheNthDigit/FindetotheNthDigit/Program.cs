using System;

namespace FindetotheNthDigit
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Enter User Value Here
            Console.WriteLine(FindE(/*Enter Double Here*/, /*Enter Number of Places*/));
        }

        public static string FindE(double number, int numPlaces)
        {
            string e;

            if (number.GetType() == typeof(double) && numPlaces.GetType() == typeof(int))
            {
                e = Math.Round(number, numPlaces).ToString();
            } else
            {
                e = "An error has occured. Make sure you've entered a double and a positive integer";
            }

            return e;
        }
    }
}
