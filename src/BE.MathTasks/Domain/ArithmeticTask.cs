using System;
using System.Collections.Generic;
using System.Diagnostics;
using BE.MathTasks.Artihmetics;

namespace BE.MathTasks
{
    [DebuggerDisplay("{Expresion}")]
    public class ArithmeticTask : MathTask, IEquatable<ArithmeticTask>
    {
        public int A { get; }

        public int B { get; }

        public string Expresion { get; }

        public ArithmeticTaskProperties Meta { get; }

        /// <summary>
        /// Core Task is very important task with can be used to
        /// </summary>
        /// <returns></returns>
        public bool IsCoreTask { get; }

        public ArithmeticTask(int firstArgument, int secondArgument, ArithmeticOperators op)
            : base("a" + op.ToSymbol() + "b",
                new Dictionary<string, double>()
                {
                    {"a", firstArgument},
                    {"b", secondArgument}
                }, firstArgument + op.ToDisplaySymbol() + secondArgument, op)
        {
            A = firstArgument;
            B = secondArgument;
            Expresion = firstArgument + op.ToSymbol() + secondArgument;
            Meta = new ArithmeticTaskProperties(this);

            if (op == ArithmeticOperators.Multiplication)
            {
                IsCoreTask = IsCoreTaskNumber(A);
            }
            else if (op == ArithmeticOperators.Divison)
            {
                IsCoreTask = IsCoreTaskNumber((int) Solution) || IsCoreTaskNumber(B);
            }
        }

        private static bool IsCoreTaskNumber(int number)
        {
            return number == 2 || number == 5 || number == 10;
        }

        public MultiplicationTask AsMultiplication()
        {
            return new(A, B);
        }

        public DivisionTask AsDivision()
        {
            return new(A, B);
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