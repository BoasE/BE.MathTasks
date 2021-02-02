using System.Collections.Generic;
using System.Linq;
using BE.MathTasks.Artihmetics;

namespace BE.MathTasks.Tables
{
    public static class MultiplicationTaskFilter
    {
        public static IEnumerable<ArithmeticTask> FilterByRequest(this IEnumerable<ArithmeticTask> tasks,
            ArithmeticTaskRequest request)
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