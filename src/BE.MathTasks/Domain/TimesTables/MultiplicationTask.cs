using System;
using System.Collections.Generic;
using System.Diagnostics;
using BE.MathTasks.Artihmetics;

namespace BE.MathTasks.TimesTables
{
    [DebuggerDisplay("{DisplayValue}")]
    public sealed class MultiplicationTask : MathTask
    {
        public int A => (int) Variables["a"];

        public int B => (int) Variables["b"];
        
        /// <summary>
        /// Core Task is very important task with can be used to
        /// </summary>
        /// <returns></returns>
        public bool IsCoreTask => A == 1 || A == 2 || A == 5 || A == 10;

        public MultiplicationTask(int factorA, int factorB) : base("a*b",
            new Dictionary<string, double>()
            {
                {"a", factorA},
                {"b", factorB}
            }, factorA + "*" + factorB,ArithmeticOperators.Multiplication)
        {
            
        }
    }
}