using System.Collections.Generic;
using System.Diagnostics;
using BE.MathTasks.Artihmetics;
using Jace;

namespace BE.MathTasks
{
    [DebuggerDisplay("{DisplayValue}")]
    public abstract class MathTask
    {
        private static readonly CalculationEngine engine = new CalculationEngine();

        public ArithmeticOperators Operator { get;  }
        public string Formula { get; }

        public double Result { get; }

        public Dictionary<string, double> Variables { get; }

        public string DisplayValue { get; }

        public MathTask(string formula, Dictionary<string, double> variables, string displayValue,ArithmeticOperators op)
        {
            Variables = variables;
            Formula = formula;
            Result = engine.Calculate(formula, variables);
            DisplayValue = displayValue;
            Operator = op;
        }

        public override string ToString()
        {
            return DisplayValue;
        }
    }
}