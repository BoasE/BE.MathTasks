using System.Collections.Generic;

namespace BE.MathTasks.Tables
{
    public interface IArithmeticTable
    {
        ArithmeticTask RandomTask(ArithmeticTaskRequest request);

        List<ArithmeticTask> RandomTasks(ArithmeticTaskRequest request, int count);

        List<ArithmeticTask> AllForTable(int table);

        List<ArithmeticTask> AllForTable(ArithmeticTaskRequest request);
    }
}