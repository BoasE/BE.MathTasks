using System;
using BE.MathTasks.Artihmetics;
using Xunit;

namespace Domain.Tests.ArithmeticTaskPoolTests
{
    public sealed class WhenCreatingTaskPool
    {
        public AThousandPool GetSut()
        {
            return new AThousandPool();
        }

        [Fact]
        public void ItAppliesTheRanage()
        {
            AThousandPool sut = GetSut();

            Assert.Equal(new Range(0, 1000), sut.NumberRange);
        }

        [Fact]
        public void ItHasTasks()
        {
            AThousandPool sut = GetSut();

            Assert.True(sut.TotalTasks > 8);
        }
    }
}