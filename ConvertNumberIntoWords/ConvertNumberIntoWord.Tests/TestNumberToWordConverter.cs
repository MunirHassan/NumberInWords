using NumberToWordConverter;
using Xunit;

namespace ConvertNumberIntoWord.Tests
{
    public class TestNumberToWordConverter
    {
        [Fact]
        public void ONE_HUNDRED_AND_TWENTY_THREE_DOLLARS_AND_FORTY_FIVE_CENTS_Test()
        {
            decimal value = 123.45M;
            var expectedResult = "ONE HUNDRED AND TWENTY-THREE DOLLARS AND FORTY-FIVE CENTS";

            string actualResult = NumberToWordConversion.NumberToCurrencyText(value);
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void TWELVE_THOUSAND_FIVE_HUNDRED_AND_FORTY_DOLLARS_Test()
        {
            decimal value = 12540M;
            var expectedResult = "TWELVE THOUSAND FIVE HUNDRED AND FORTY DOLLARS";
            var actualResult = NumberToWordConversion.NumberToCurrencyText(value);
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void NEGATIVE_FIVE_DOLLARS_Test()
        {
            decimal value = -5.0M;
            var expectedResult = "NEGATIVE FIVE DOLLARS";
            var actualResult = NumberToWordConversion.NumberToCurrencyText(value);
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ONE_MILLION_DOLLARS_AND_ONE_CENT_Test()
        {
            decimal value = 1000000.01M;
            var expectedResult = "ONE MILLION DOLLARS AND ONE CENT";
            var actualResult = NumberToWordConversion.NumberToCurrencyText(value);
            Assert.Equal(expectedResult, actualResult);

        }

        [Fact]
        public void ONE_CENT_Test()
        {
            decimal value = 0.01M;
            var expectedResult = "ONE CENT";
            var actualResult = NumberToWordConversion.NumberToCurrencyText(value);
            Assert.Equal(expectedResult, actualResult);

        }

        [Fact]
        public void ONE_HUNDRED_AND_TWENTY_NINE_MILLION_DOLLARS_Test()
        {
            decimal value = 129000000M;
            var expectedResult = "ONE HUNDRED AND TWENTY-NINE MILLION DOLLARS";
            var actualResult = NumberToWordConversion.NumberToCurrencyText(value);
            Assert.Equal(expectedResult, actualResult);

        }

        [Fact]
        public void ZERO_DOLLAR_Test()
        {
            decimal value = 0M;
            var expectedResult = "ZERO DOLLAR";
            var actualResult = NumberToWordConversion.NumberToCurrencyText(value);
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ONE_HUNDRED_DOLLARS_AND_ONE_CENT_Test()
        {
            decimal value = 100.01M;
            var expectedResult = "ONE HUNDRED DOLLARS AND ONE CENT";
            var actualResult = NumberToWordConversion.NumberToCurrencyText(value);
            Assert.Equal(expectedResult, actualResult);

        }

        [Fact]
        public void ONE_THOUSAND_ONE_HUNDRED_DOLLARS_AND_ONE_CENT_test()
        {
            decimal value = 1100.01M;
            var expectedResult = "ONE THOUSAND ONE HUNDRED DOLLARS AND ONE CENT";
            var actualResult = NumberToWordConversion.NumberToCurrencyText(value);
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ZERO_DOLLAS_AND_ZERO_CENT_test()
        {
            decimal value = 0.0M;
            var expectedResult = "ZERO CENT";
            var actualResult = NumberToWordConversion.NumberToCurrencyText(value);
            Assert.Equal(expectedResult, actualResult);
        }

    }
}
