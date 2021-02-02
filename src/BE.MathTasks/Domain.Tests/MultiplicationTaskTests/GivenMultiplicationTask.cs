using BE.MathTasks;

namespace Domain.Tests.MultiplicationTaskTests
{
    public class GivenMultiplicationTask
    {
        protected MultiplicationTask GetSut(int a = 2, int b = 3)
        {
            return new MultiplicationTask(a, b);
        }
    }
}