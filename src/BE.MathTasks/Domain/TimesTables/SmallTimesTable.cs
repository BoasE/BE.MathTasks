using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BE.MathTasks.TimesTables
{
    public sealed class SmallTimesTable : ISmallTimesTable
    {
        private readonly List<MultiplicationTask> tasks = new List<MultiplicationTask>();

        public SmallTimesTable()
        {
            for (int i = 1; i <= 10; i++)
            {
                tasks.AddRange(AllTasksOfTable(i));
            }
        }

        private static IEnumerable<MultiplicationTask> AllTasksOfTable(int table)
        {
            for (int i = 0; i <= 10; i++)
            {
                yield return new MultiplicationTask(table, i);
            }
        }

        public List<MultiplicationTask> AllForTable(int table)
        {
            return tasks.Where(x => x.B.Equals(table)).ToList();
        }

        public Task<MultiplicationTask> RandomTask(MultiplicationTaskRequest request)
        {
            MultiplicationTask item = tasks.Where(x => request.Tables.Contains(x.B)).ToList().RandomItem();

            return Task.FromResult(item);
        }

        public Task<List<MultiplicationTask>> RandomTasks(MultiplicationTaskRequest request, int count)
        {
            List<MultiplicationTask> item = tasks.Where(x => request.Tables.Contains(x.B)).Shuffle().Take(count).ToList();

            return Task.FromResult(item);
        }
    }
}