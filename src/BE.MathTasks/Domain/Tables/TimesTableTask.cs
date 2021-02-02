using System.Collections.Generic;
using System.Diagnostics;
using BE.MathTasks.Artihmetics;

namespace BE.MathTasks.Tables
{
    [DebuggerDisplay("{A}*{B}")]
    public sealed class TimesTableTask : MathTask
    {

        public TimesTableTask(Dictionary<string,double> variables,string displayValue) : base("a*b",variables,displayValue,ArithmeticOperators.Multiplication)
        {
        }

    }
}