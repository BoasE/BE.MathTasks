using System.Collections.Generic;
using System.Threading.Tasks;

namespace BE.MathTasks.TimesTables
{
    public interface ITimesTable
    {
        Task<MultiplicationTask> RandomTask(MultiplicationTaskRequest request);

        Task<List<MultiplicationTask>> RandomTasks(MultiplicationTaskRequest request, int count);

        List<MultiplicationTask> AllForTable(int table);
    }
}