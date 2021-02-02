using System;
using System.Collections.Generic;
using System.Diagnostics;
using BE.MathTasks.Artihmetics;
using Jace;

namespace BE.MathTasks
{
    [DebuggerDisplay("{DisplayValue}")]
    public abstract class MathTask : IEquatable<MathTask>
    {
        private static readonly CalculationEngine engine = new CalculationEngine();

        public ArithmeticOperators Operator { get; }

        public string Formula { get; }

        public double Result { get; }

        public Dictionary<string, double> Variables { get; }

        public string DisplayValue { get; }

        public MathTask(string formula, Dictionary<string, double> variables, string displayValue,
            ArithmeticOperators op)
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

        #region equals

        public bool Equals(MathTask? other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return DisplayValue == other.DisplayValue;
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((MathTask) obj);
        }

        public override int GetHashCode()
        {
            return DisplayValue.GetHashCode();
        }

        public static bool operator ==(MathTask? left, MathTask? right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(MathTask? left, MathTask? right)
        {
            return !Equals(left, right);
        }

        #endregion
    }
}