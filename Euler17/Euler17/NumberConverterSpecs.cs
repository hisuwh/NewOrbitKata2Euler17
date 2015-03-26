namespace Euler17
{
    using Machine.Fakes;
    using Machine.Specifications;

    public class Number_converter_specs_base : WithSubject<NumberConverter>
    {
        protected static int Test;
        protected static string Result;

        private Because of = () => Result = Subject.Convert(Test);
    }

    public class When_converting_1 : Number_converter_specs_base
    {
        private Establish context = () => Test = 1;
        public It Should_return_one = () => Result.ShouldEqual("One");
    }

    public class When_converting_5 : Number_converter_specs_base
    {
        private Establish context = () => Test = 5;
        public It Should_return_five = () => Result.ShouldEqual("Five");
    }

    public class When_converting_14 : Number_converter_specs_base
    {
        private Establish context = () => Test = 14;
        public It Should_return_fourteen = () => Result.ShouldEqual("Fourteen");
    }

    public class When_converting_32 : Number_converter_specs_base
    {
        private Establish context = () => Test = 32;
        public It Should_return_thirty_two = () => Result.ShouldEqual("ThirtyTwo");
    }

    public class When_converting_47 : Number_converter_specs_base
    {
        private Establish context = () => Test = 47;
        public It Should_return_forty_seven = () => Result.ShouldEqual("FortySeven");
    }

    public class When_converting_89 : Number_converter_specs_base
    {
        private Establish context = () => Test = 89;
        public It Should_return_eighty_nine = () => Result.ShouldEqual("EightyNine");
    }

    public class When_converting_90 : Number_converter_specs_base
    {
        private Establish context = () => Test = 90;
        public It Should_return_ninety = () => Result.ShouldEqual("Ninety");
    }

    public class When_converting_100 : Number_converter_specs_base
    {
        private Establish context = () => Test = 100;
        public It Should_return_one_hundred = () => Result.ShouldEqual("OneHundred");
    }

    public class When_converting_101 : Number_converter_specs_base
    {
        private Establish context = () => Test = 101;
        public It Should_return_one_hundred_and_one = () => Result.ShouldEqual("OneHundredAndOne");
    }

    public class When_converting_116 : Number_converter_specs_base
    {
        private Establish context = () => Test = 116;
        public It Should_return_one_hundred_and_sixteen = () => Result.ShouldEqual("OneHundredAndSixteen");
    }

    public class When_converting_144 : Number_converter_specs_base
    {
        private Establish context = () => Test = 144;
        public It Should_return_one_hundred_and_forty_four = () => Result.ShouldEqual("OneHundredAndFortyFour");
    }

    public class When_converting_678 : Number_converter_specs_base
    {
        private Establish context = () => Test = 678;
        public It Should_return_six_hundred_and_seventy_eight = () => Result.ShouldEqual("SixHundredAndSeventyEight");
    }

    public class When_converting_1000 : Number_converter_specs_base
    {
        private Establish context = () => Test = 1000;
        public It Should_return_one_thousand = () => Result.ShouldEqual("OneThousand");
    }

    public class When_converting_1230 : Number_converter_specs_base
    {
        private Establish context = () => Test = 1230;
        public It Should_return_one_thousand_two_hundred_and_thirty = () => Result.ShouldEqual("OneThousandTwoHundredAndThirty");
    }

    public class When_converting_13456 : Number_converter_specs_base
    {
        private Establish context = () => Test = 13456;
        public It Should_return_thirteen_thousand_four_hundred_and_fifty_six = () => Result.ShouldEqual("ThirteenThousandFourHundredAndFiftySix");
    }

    public class When_converting_650231 : Number_converter_specs_base
    {
        private Establish context = () => Test = 650231;
        public It Should_return_six_hundred_and_fifty_thousand_two_hundred_and_thirty_one = () => Result.ShouldEqual("SixHundredAndFiftyThousandTwoHundredAndThirtyOne");
    }

    public class When_converting_1000000 : Number_converter_specs_base
    {
        private Establish context = () => Test = 1000000;
        public It Should_return_one_million = () => Result.ShouldEqual("OneMillion");
    }
}