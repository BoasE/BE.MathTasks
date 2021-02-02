using System.Security.Cryptography;
using BE.MathTasks;
using BE.MathTasks.Extensions;
using Xunit;

namespace Domain.Tests.RandomNumberTests
{
    public sealed class GivenRandomNumber
    {
        protected RandomNumbers Numbers { get; } = new RandomNumbers();

        [Theory]
        [InlineData(1), InlineData(2), InlineData(5), InlineData(99), InlineData(1213),]
        public void NumberIsInBelowUpperBound(int upperBound)
        {
            for (int i = 0; i < 100; i++)
            {
                var val = Numbers.Next(upperBound);
                Assert.True(val <= upperBound);
            }
        }

        [Theory]
        [InlineData(1, 9), InlineData(2, 29), InlineData(5, 35), InlineData(1, 4), InlineData(55, 69),]
        public void NumberIsInRange(int lowerBound, int upperBound)
        {
            for (int i = 0; i < 100; i++)
            {
                var val = Numbers.Next(lowerBound, upperBound);
                Assert.True(val <= upperBound && val >= lowerBound);
            }
        }
    }
}