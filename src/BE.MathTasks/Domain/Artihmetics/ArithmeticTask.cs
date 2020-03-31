using System;
using System.Diagnostics;

namespace BE.MathTasks.Artihmetics
{
    [DebuggerDisplay("{Expresion}")]
    public sealed class ArithmeticTask : MathTask, IEquatable<ArithmeticTask>
    {
        public int FirstArgument { get; }

        public int SecondArgument { get; }

        public ArithmeticOperators Operator { get; }

        public int Solution { get; }

        public string Expresion { get; }

        public ArithmeticTaskProperties Meta { get; }

        public ArithmeticTask(int firstArgument, int secondArgument, ArithmeticOperators op, int solution)
        {
            FirstArgument = firstArgument;
            SecondArgument = secondArgument;
            Operator = op;
            Solution = solution;
            Expresion = firstArgument + op.ToSymbol() + secondArgument;
            Meta = new ArithmeticTaskProperties(this);
        }

        #region equals

        public bool Equals(ArithmeticTask other)
        {
            if (ReferenceEquals(null, other))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            return FirstArgument == other.FirstArgument && SecondArgument == other.SecondArgument && Operator == other.Operator;
        }

        public override bool Equals(object obj)
        {
            return ReferenceEquals(this, obj) || obj is ArithmeticTask other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = FirstArgument;
                hashCode = (hashCode * 397) ^ SecondArgument;
                hashCode = (hashCode * 397) ^ (int)Operator;
                return hashCode;
            }
        }

        public static bool operator ==(ArithmeticTask left, ArithmeticTask right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ArithmeticTask left, ArithmeticTask right)
        {
            return !Equals(left, right);
        }

        #endregion
    }
}