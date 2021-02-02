using System.Collections.Generic;
using System.Linq;
using BE.MathTasks.Artihmetics;
using BE.MathTasks.Extensions;

namespace BE.MathTasks.Tables
{
    public sealed class SmallArithmeticTable : ISmallArithmeticTable
    {
        private readonly List<ArithmeticTask> tasks = new List<ArithmeticTask>();

        public SmallArithmeticTable(ArithmeticOperators @operator)
        {
            for (int i = 1; i <= 10; i++)
            {
                tasks.AddRange(AllTasksOfTable(@operator, i));
            }
        }

        private static IEnumerable<ArithmeticTask> AllTasksOfTable(@ArithmeticOperators @operator, int table)
        {
            for (int i = 0; i <= 10; i++)
            {
                yield return new ArithmeticTask(table, i, @operator);
            }
        }

        public List<ArithmeticTask> AllForTable(int table)
        {
            return tasks.Where(x => x.B.Equals(table)).ToList();
        }

        public List<ArithmeticTask> AllForTable(ArithmeticTaskRequest request)
        {
            return tasks.FilterByRequest(request).ToList();
        }


        public ArithmeticTask RandomTask(ArithmeticTaskRequest request)
        {
            ArithmeticTask item = tasks.FilterByRequest(request).ToList().RandomItem();

            return item;
        }

        public List<ArithmeticTask> RandomTasks(ArithmeticTaskRequest request, int count)
        {
            List<ArithmeticTask> item = tasks.FilterByRequest(request).Shuffle().Take(count)
                .ToList();

            return item;
        }
    }
}