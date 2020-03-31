using System;

namespace BE.MathTasks.Artihmetics
{
    public interface IArithmeticTaskPool : ITaskPool
    {
        Range NumberRange { get; }
    }
}