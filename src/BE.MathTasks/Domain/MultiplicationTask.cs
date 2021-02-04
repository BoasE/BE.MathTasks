using System.Collections.Generic;
using System.Diagnostics;
using BE.MathTasks.Artihmetics;

namespace BE.MathTasks
{
    [DebuggerDisplay("{DisplayValue}")]
    public sealed class MultiplicationTask : ArithmeticTask
    {
   
        public MultiplicationTask(int firstArgument, int secondArgument) : base(firstArgument, secondArgument,
            ArithmeticOperators.Multiplication)
        {
        }
    }
}