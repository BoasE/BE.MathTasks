using System.Collections.Generic;
using System.Diagnostics;
using Jace;

namespace BE.MathTasks
{
    [DebuggerDisplay("{DisplayValue}")]
    public abstract class MathTask
    {
        private static readonly CalculationEngine engine = new CalculationEngine();

        public string Formula { get; }

        public double Result { get; }

        public Dictionary<string, double> Variables { get; }

        public string DisplayValue { get; }

        protected MathTask(string formula, Dictionary<string, double> variables, string displayValue)
        {
            Variables = variables;
            Formula = formula;
            Result = engine.Calculate(formula, variables);
            DisplayValue = displayValue;
        }

        public override string ToString()
        {
            return DisplayValue;
        }
    }
}