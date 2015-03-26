namespace Euler17
{
    using Machine.Fakes;
    using Machine.Specifications;

    public class Number_string_formatter_specs_base : WithSubject<NumberStringFormatter>
    {
        protected static string Test;

        protected static string Result;

        private Because of = () => Result = Subject.Format(Test);
    }

    public class When_formatting_ninetytwo : Number_string_formatter_specs_base
    {
        private Establish context = () => Test = "NinetyTwo";

        public It Should_format_string_properly = () => Result.ShouldEqual("Ninety two");
    }

    public class When_formatting_thirteen : Number_string_formatter_specs_base
    {
        private Establish context = () => Test = "Thirteen";

        public It Should_format_string_properly = () => Result.ShouldEqual("Thirteen");
    }

    public class When_formatting_onehundredandtwentyone : Number_string_formatter_specs_base
    {
        private Establish context = () => Test = "OneHundredAndTwentyOne";

        public It Should_format_string_properly = () => Result.ShouldEqual("One hundred and twenty one");
    }
}