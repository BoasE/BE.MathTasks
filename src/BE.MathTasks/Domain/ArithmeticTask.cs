using System;
using System.Collections.Generic;
using System.Diagnostics;
using BE.MathTasks.Artihmetics;
using BE.MathTasks.Tables;

namespace BE.MathTasks
{
    [DebuggerDisplay("{Expresion}")]
    public sealed class ArithmeticTask : MathTask, IEquatable<ArithmeticTask>
    {
        public int A { get; }

        public int B { get; }

        public int Solution { get; }

        public string Expresion { get; }

        public ArithmeticTaskProperties Meta { get; }

        public ArithmeticTask(int firstArgument, int secondArgument, ArithmeticOperators op)
            : base("a" + op.ToSymbol() + "b",
                new Dictionary<string, double>()
                {
                    {"a", firstArgument},
                    {"b", secondArgument}
                }, "a" + op.ToSymbol() + "b", op)
        {
            A = firstArgument;
            B = secondArgument;
            Expresion = firstArgument + op.ToSymbol() + secondArgument;
            Meta = new ArithmeticTaskProperties(this);
        }

        public MultiplicationTask AsMultiplication()
        {
            return new MultiplicationTask(A, B);
        }

        #region equals

        public bool Equals(ArithmeticTask other)
        {
            if (ReferenceEquals(null, other))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            return A == other.A && B == other.B &&
                   Operator == other.Operator;
        }

        public override bool Equals(object obj)
        {
            return ReferenceEquals(this, obj) || obj is ArithmeticTask other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = A;
                hashCode = (hashCode * 397) ^ B;
                hashCode = (hashCode * 397) ^ (int) Operator;
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