using BE.MathTasks;
using BE.MathTasks.Extensions;
using Xunit;

namespace Domain.Tests.NumberExtensionsTests
{
    public sealed class WhenGettingPlacesFromNumber
    {
        [Fact]
        public static void When0WeGet0Hundred()
        {
            int result = 0.GetHundreds();

            Assert.Equal(0, result);
        }

        [Fact]
        public static void When0WeGet0Ones()
        {
            int result = 0.GetOnes();

            Assert.Equal(0, result);
        }

        [Fact]
        public static void When100WeGet1Hundred()
        {
            int result = 100.GetHundreds();

            Assert.Equal(1, result);
        }

        [Fact]
        public static void When100WeGet0Tens()
        {
            int result = 100.GetTens();

            Assert.Equal(0, result);
        }

        [Fact]
        public static void When100WeGet0Ones()
        {
            int result = 100.GetTens();

            Assert.Equal(0, result);
        }

        [Fact]
        public static void When256WeGet5Tens()
        {
            int result = 256.GetTens();

            Assert.Equal(5, result);
        }

        [Fact]
        public static void When256WeGet6Ones()
        {
            int result = 256.GetOnes();

            Assert.Equal(6, result);
        }
    }
}