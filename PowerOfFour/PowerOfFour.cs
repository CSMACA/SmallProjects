using System;
using System.Diagnostics;

namespace PowerOfFour
{
    class PowerOfFour
    {
        /// <summary>
        /// Given a 32-bit positive integer N, determine whether it is a power of four in faster than O(log N) time.
        /// </summary>

        static void Main(string[] args)
        {
            Stopwatch mySW = new Stopwatch();
            mySW.Start();

            int n;
            n = 1048576;
            // log base 4 of N = valid int
            double f = Math.Log(n, 4);
            bool answer = f == Math.Floor(f);

            mySW.Stop();
            string elapsedTime = mySW.Elapsed.ToString();

            Console.WriteLine(answer);
            Console.WriteLine("The elapsed time of the program is: " + elapsedTime);
            Console.ReadKey();
        }
    }
}
