using System.Collections.Generic;
using System.Linq;

namespace BE.MathTasks.TimesTables
{
    public static class MultiplicationTaskFilter
    {
        public static IEnumerable<MultiplicationTask> FilterByRequest(this IEnumerable<MultiplicationTask> tasks,
            MultiplicationTaskRequest request)
        {
            tasks = tasks.Where(x => request.Tables.Contains(x.B));
            if (!request.AllowTimes1)
            {
                tasks = tasks.Where(x => x.B != 1);
            }

            return tasks;
        }
    }
}