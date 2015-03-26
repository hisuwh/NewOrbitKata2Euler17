namespace Euler17
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var exit = false;

            while (!exit)
            {

                Console.WriteLine("What would you like to do?");
                Console.WriteLine(" 1 - calculate number series string length");
                Console.WriteLine(" 2 - convert number to string representation");
                Console.WriteLine(" 3 - Exit");
                var option = GetValue();

                switch (option)
                {
                    case 3:
                        exit = true;
                        break;
                    case 2:
                        ConvertNumberToString();
                        break;
                    default:
                        CalculateSeriesLength();
                        break;
                }
                Console.WriteLine();
            }
        }

        private static void ConvertNumberToString()
        {
            Console.WriteLine("Convert number to string representation");
            Console.WriteLine("Enter number:");
            var number = GetValue();

            var numberConverter = new NumberConverter();
            var numberStringFormatter = new NumberStringFormatter();

            var stringValue = numberConverter.Convert(number);
            Console.WriteLine(numberStringFormatter.Format(stringValue));
        }

        private static void CalculateSeriesLength()
        {
            Console.WriteLine("Calculate number series string length.");
            Console.WriteLine("From:");
            var from = GetValue();
            Console.WriteLine("To:");
            var to = GetValue();

            var seriesLengthCalculator = new SeriesLengthCalculator();

            Console.WriteLine("Series string length: {0}", seriesLengthCalculator.SeriesLength(@from, to));
        }

        private static int GetValue()
        {
            int value;
            var valid = false;
            do
            {
                valid = int.TryParse(Console.ReadLine(), out value);
            }
            while (!valid);

            return value;
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
