namespace Euler17
{
    public class SeriesLengthCalculator
    {
        private readonly NumberConverter numberConverter;

        public SeriesLengthCalculator()
        {
            this.numberConverter = new NumberConverter();
        }

        public int SeriesLength(int from, int to)
        {
            var total = 0;

            for (var i = from; i <= to; i++)
            {
                total += this.numberConverter.Convert(i).Length;
            }

            return total;
        }
    }
}