using System;
using System.Diagnostics;
using BE.MathTasks.Artihmetics;

namespace BE.MathTasks.TimesTables
{
    [DebuggerDisplay("{Text}")]
    public sealed class MultiplicationTask : MathTask, IEquatable<MultiplicationTask>
    {
        public int A { get; }

        public int B { get; }

        public int Result { get; }

        public string Text => A + " * " + B;

        /// <summary>
        /// Core Task is very important task with can be used to
        /// </summary>
        /// <returns></returns>
        public bool IsCoreTask { get; }


        public MultiplicationTask(int factorA, int factorB)
        {
            A = factorA;
            B = factorB;
            Result = factorA * factorB;
            IsCoreTask = A == 1 || A == 2 || A == 5 || A == 10;
        }

        public override string ToString() => Text;

        #region equals

        public bool Equals(MultiplicationTask? other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return A == other.A && B == other.B;
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is MultiplicationTask other && Equals(other);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(A, B);
        }

        public static bool operator ==(MultiplicationTask? left, MultiplicationTask? right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(MultiplicationTask? left, MultiplicationTask? right)
        {
            return !Equals(left, right);
        }

        #endregion
    }
}