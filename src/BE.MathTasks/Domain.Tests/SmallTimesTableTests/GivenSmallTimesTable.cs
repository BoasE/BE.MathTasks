using System.Linq;
using System.Threading.Tasks;
using BE.MathTasks.TimesTables;
using Xunit;

namespace Domain.Tests.SmallTimesTableTests
{
    public class GivenSmallTimesTable
    {
        protected SmallTimesTable GetSut()
        {
            return new SmallTimesTable();
        }

        [Theory]
        [InlineData(1), InlineData(2), InlineData(3), InlineData(4), InlineData(5),
         InlineData(6), InlineData(7), InlineData(8), InlineData(9), InlineData(10)]
        public void SecondFactorEqualsTable(int table)
        {
            var task = GetSut().RandomTask(MultiplicationTaskRequest.ForTable(2));

            Assert.Equal(2, task.B);
        }

        [Theory]
        [InlineData(1), InlineData(2), InlineData(3), InlineData(4), InlineData(5),
         InlineData(6), InlineData(7), InlineData(8), InlineData(9), InlineData(10)]
        public void GetMultipleRequests(int table)
        {
            var task =  GetSut().RandomTasks(MultiplicationTaskRequest.ForTable(table), 4);

            Assert.Equal(4, task.Count);
        }

        [Fact]
        public void TableHas10Tasks()
        {
            var tasks = GetSut().AllForTable(3);
            
            Assert.Equal(10,tasks.Count);
        }
        
        [Fact]
        public void ItHas4CoreTasks()
        {
            var tasks = GetSut().AllForTable(3);
            Assert.Equal(4,tasks.Count(x => x.IsCoreTask));
        }
    }
}