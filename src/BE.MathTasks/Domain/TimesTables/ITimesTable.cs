using System.Collections.Generic;
using System.Threading.Tasks;

namespace BE.MathTasks.TimesTables
{
    public interface ITimesTable
    {
        MultiplicationTask RandomTask(MultiplicationTaskRequest request);

        List<MultiplicationTask> RandomTasks(MultiplicationTaskRequest request, int count);

        List<MultiplicationTask> AllForTable(int table);

        List<MultiplicationTask> AllForTable(MultiplicationTaskRequest request);
    }
}