using BE.MathTasks.Artihmetics;

namespace BE.MathTasks
{
    public sealed class DivisionTask : ArithmeticTask
    {
        /// <summary>
        /// Core Task is very important task with can be used to
        /// </summary>
        /// <returns></returns>
        public bool IsCoreTask => A == 1 || A == 2 || A == 5 || A == 10;

        public DivisionTask(int firstArgument, int secondArgument) : base(firstArgument, secondArgument,
            ArithmeticOperators.Multiplication)
        {
        }
    }
}