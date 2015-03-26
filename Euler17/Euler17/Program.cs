namespace Euler17
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(NaiveImplementation());
            
            Console.ReadLine();
        }

        /*
         * ---- Naive Implementation ----
         * 
         * one              = 9 x 10 + 10 times
         * two-nine         = 9 x 10 + 9 times
         * ten-nineteen     = 10 times
         * 20-90            = 10 times
         * hundred          = 9 times      
         * thousand         = 1 time 
         * and              = 9 times
         */
        private static int NaiveImplementation()
        {
            var total = 0;
            var twoToNine = new [] { "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var teensAndTens = new[] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            total += "one".Length * ((9 * 10) + 10);
            total += twoToNine.Sum(s => s.Length * ((9 * 10) + 9));
            total += teensAndTens.Sum(s => s.Length * 10);
            total += "hundred".Length * 9;
            total += "thousand".Length;
            total += "and".Length * 9;

            return total; // doesn't seem to work....
        }
    }
}
