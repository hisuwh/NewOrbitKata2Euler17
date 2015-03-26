namespace Euler17
{
    public class NumberConverter
    {
        private const string Billion = "Billion";
        private const string Million = "Million";
        private const string Thousand = "Thousand";
        private const string Hundred = "Hundred";
        private const string And = "And";
        private const string Zero = "Zero";

        private const int Ten = 10;
        private const int AHundred = 100;
        private const int AThousand = 1000;
        private const int AMillion = 1000000;
        private const int ABillion = 1000000000;
        private const int Max = int.MaxValue;

        public string Convert(int number)
        {
            if (number == 0)
            {
                return Zero;
            }

            if (number < 20)
            {
                return this.OnesAndTeensString(number);
            }

            if (number < AHundred)
            {
                var ten = (number / Ten) * Ten;
                var remainder = number % Ten;
                return TensString(ten) + this.HandleRemainder(string.Empty, remainder);
            }

            if (number < AThousand)
            {
                var hundred = (number / AHundred);
                var remainder = number % AHundred;
                return this.OnesAndTeensString(hundred) + Hundred + this.HandleRemainder(And, remainder);
            }

            if (number < AMillion)
            {
                var thousand = number / AThousand;
                var remainder = number % AThousand;
                return this.Convert(thousand) + Thousand + this.HandleRemainder(string.Empty, remainder);
            }

            if (number < ABillion)
            {
                var million = number / AMillion;
                var remainder = number % AMillion;
                return this.Convert(million) + Million + this.HandleRemainder(string.Empty, remainder);
            }

            if (number < Max)
            {
                var billion = number / ABillion;
                var remainder = number % ABillion;
                return this.Convert(billion) + Billion + this.HandleRemainder(string.Empty, remainder);
            }

            return "";
        }

        private static string TensString(int ten)
        {
            return ((Tens)ten).ToString();
        }

        private string OnesAndTeensString(int number)
        {
            return ((OnesAndTeens)number).ToString();
        }

        private string HandleRemainder(string prefix, int remainder)
        {
            if (remainder == 0)
            {
                return string.Empty;
            }

            return prefix + this.Convert(remainder);
        }

    }
}