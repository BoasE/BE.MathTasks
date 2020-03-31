using Xunit;

namespace Domain.Tests.MultiplicationTaskTests
{
    public class WhenCoreTask : GivenMultiplicationTask
    {
        [Theory]
        [InlineData(1,3),InlineData(2,3),InlineData(5,3),InlineData(10,3)]
        public void RecognizesCoreTask(int a,int b)
        {
            var task = GetSut(a, b);
            
            Assert.True(task.IsCoreTask);
        }
        
    }
}