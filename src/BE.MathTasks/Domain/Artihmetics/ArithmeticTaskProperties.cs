using System;
using System.Diagnostics;
using BE.MathTasks.Extensions;

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
            CrossingTenBoundery =
                !(task.A.GetTens() == task.B.GetTens() && task.B.GetTens() == task.Solution.GetTens());
            MaxValue = Math.Max(Math.Max(task.A, task.B), (int) task.Solution);
            MinValue = Math.Min(Math.Min(task.A, task.B), (int) task.Solution);
        }
    }
}