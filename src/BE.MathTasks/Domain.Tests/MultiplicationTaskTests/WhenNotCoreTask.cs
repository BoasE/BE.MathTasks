using Xunit;

namespace Domain.Tests.MultiplicationTaskTests
{
    public class WhenNotCoreTask : GivenMultiplicationTask
    {
        [Theory]
        [InlineData(3, 3), InlineData(4, 3), InlineData(6, 3), InlineData(7, 3), InlineData(8, 3), InlineData(9, 3)]
        [InlineData(3, 5), InlineData(4, 5), InlineData(6, 5), InlineData(7, 5), InlineData(8, 5), InlineData(9, 5)]
        public void RecognizesCoreTask(int a, int b)
        {
            var task = GetSut(a, b);

            Assert.False(task.IsCoreTask);
        }
    }
}