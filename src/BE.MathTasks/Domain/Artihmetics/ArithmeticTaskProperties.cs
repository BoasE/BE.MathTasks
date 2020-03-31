using System;
using System.Diagnostics;

namespace BE.MathTasks.Artihmetics
{
    [DebuggerDisplay("{MinValue} -> {MaxValue} - {CrossingTenBoundery}")]
    public readonly struct ArithmeticTaskProperties
    {
        public bool CrossingTenBoundery { get; }

        public int MaxValue { get; }

        public int MinValue { get; }

        public ArithmeticTaskProperties(ArithmeticTask task)
        {
            CrossingTenBoundery = !(task.FirstArgument.GetTens() == task.SecondArgument.GetTens() && task.SecondArgument.GetTens() == task.Solution.GetTens());
            MaxValue = Math.Max(Math.Max(task.FirstArgument, task.SecondArgument), task.Solution);
            MinValue = Math.Min(Math.Min(task.FirstArgument, task.SecondArgument), task.Solution);
        }
    }
}