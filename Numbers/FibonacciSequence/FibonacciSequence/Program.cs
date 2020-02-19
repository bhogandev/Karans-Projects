using System;

namespace FibonacciSequence
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(/*Enter Value Here*/));
        }

        public static string Fibonacci(int numFib)
        {
            string fibSeq = "0 1";

            int temp1 = 0, temp2 = 1, temp3;

            for(int i = 2; i < numFib; i++)
            {
                temp3 = temp1 + temp2;
                temp1 = temp2;
                temp2 = temp3;

                fibSeq += $" {temp3}";
            }

            return fibSeq;
        }
    }
}
