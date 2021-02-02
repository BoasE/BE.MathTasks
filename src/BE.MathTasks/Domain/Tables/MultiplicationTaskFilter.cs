using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using BE.MathTasks.Artihmetics;

namespace BE.MathTasks.Tables
{
    public static class MultiplicationTaskFilter
    {
        public static IEnumerable<ArithmeticTask> FilterByRequest(this IEnumerable<ArithmeticTask> tasks,
            ArithmeticTaskRequest request)
        {
            tasks = tasks.Where(x =>
            {
                bool match = true;
                if (!request.AllowTimes1)
                {
                    match = match && x.A != 1;
                }

                if (!request.AllowTimes0)
                {
                    match = match && x.A != 0;
                }

                match = match && request.Tables.Contains(x.B);

                return match;
            });


            return tasks;
        }
    }
}