namespace Euler17
{
    public class NumberConverter
    {
        private const string Million = "Million";
        private const string Thousand = "Thousand";
        private const string Hundred = "Hundred";
        private const string And = "And";
        private const string Zero = "Zero";


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

            if (number < 100)
            {
                var ten = (number / 10) * 10;
                var remainder = number % 10;
                return TensString(ten) + this.HandleRemainder(string.Empty, remainder);
            }

            if (number < 1000)
            {
                var hundred = (number / 100);
                var remainder = number % 100;
                return this.OnesAndTeensString(hundred) + Hundred + this.HandleRemainder(And, remainder);
            }

            if (number < 1000000)
            {
                var thousand = number / 1000;
                var remainder = number % 1000;
                return this.Convert(thousand) + Thousand + this.HandleRemainder(string.Empty, remainder);
            }

            if (number < 1000000000)
            {
                var million = number / 1000000;
                var remainder = number % 1000000;
                return this.Convert(million) + Million + this.HandleRemainder(string.Empty, remainder);
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