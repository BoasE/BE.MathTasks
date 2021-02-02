using Xunit;

namespace Domain.Tests.MultiplicationTaskTests
{
    public sealed class WhenCreated : GivenMultiplicationTask
    {
        [Fact]
        public void ItHasTheFactors()
        {
            var sut = GetSut(2, 3);

            Assert.Equal(2, sut.A);
            Assert.Equal(3, sut.B);
        }

        [Fact]
        public void ItHasCorrectResult()
        {
            var sut = GetSut(2, 3);

            Assert.Equal(6, sut.Solution);
        }

        [Fact]
        public void TextEqualsStringNotationOfTask()
        {
            var sut = GetSut(2, 3);
            string result = "2*3";

            Assert.Equal(result, sut.Expresion);
        }

        [Fact]
        public void ToStringEqualsText()
        {
            var sut = GetSut(2, 3);
            Assert.Equal(sut.DisplayValue, sut.ToString());
        }
    }
}