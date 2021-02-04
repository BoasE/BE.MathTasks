using BE.MathTasks.Artihmetics;

namespace BE.MathTasks
{
    public sealed class DivisionTask : ArithmeticTask
    {
        public DivisionTask(int firstArgument, int secondArgument) : base(firstArgument, secondArgument,
            ArithmeticOperators.Divison)
        {
        }
    }
}