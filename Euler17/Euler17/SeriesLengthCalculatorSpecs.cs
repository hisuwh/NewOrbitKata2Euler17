namespace Euler17
{
    using Machine.Fakes;
    using Machine.Specifications;

    public class Series_length_calculator_specs_base : WithSubject<SeriesLengthCalculator>
    {
        protected static int Length;
        protected static int From;
        protected static int To;

        private Because of = () => Length = Subject.SeriesLength(From, To);
    }

    public class When_series_is_1_to_1 : Series_length_calculator_specs_base
    {
        private Establish context = () =>
        {
            From = 1;
            To = 1;
        };

        public It Should_return_3 = () => Length.ShouldEqual(3);
    }

    public class When_series_is_1_to_5 : Series_length_calculator_specs_base
    {
        private Establish context = () =>
        {
            From = 1;
            To = 5;
        };

        public It Should_return_19 = () => Length.ShouldEqual(19);
    }

    public class When_series_is_18_to_23 : Series_length_calculator_specs_base
    {
        private Establish context = () =>
        {
            From = 18;
            To = 23;
        };

        public It Should_return_51 = () => Length.ShouldEqual(51);
    }
}