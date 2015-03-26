namespace Euler17
{
    using System.Text.RegularExpressions;

    public class NumberStringFormatter
    {
        public string Format(string numberString)
        {
            return this.DeCapitalise(this.InsertSpaces(numberString));
        }

        private string DeCapitalise(string value)
        {
            return value.Substring(0, 1) + value.Substring(1).ToLower();
        }

        private string InsertSpaces(string numberString)
        {
            return Regex.Replace(numberString, "(\\B[A-Z])", " $1");
        }
    }
}